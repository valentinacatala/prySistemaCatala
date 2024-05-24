using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaCatala
{
    internal class clsUsuario
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

        string rutaArchivo;
        public string estadoConexion;

        public clsUsuario()
        {
            try
            {
                rutaArchivo = @"../../Archivos/BDusuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
                conexionBD.Open();

                objDS = new DataSet();

                estadoConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }

        public void RegistroLogInicioSesion()
        {
            try
            {
               
                comandoBD = new OleDbCommand("SELECT * FROM Logs", conexionBD);

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];

                DataRow nuevoRegistro = objTabla.NewRow();
                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);
                adaptadorBD.Update(objDS, "Logs");

                estadoConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }

        public bool ValidarUsuario(string nombreUser, string passUser)
        {
            using (OleDbConnection conexionBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo))
            {
                try
                {
                    conexionBD.Open();

                    using (OleDbCommand comandoBD = new OleDbCommand("SELECT * FROM Usuario", conexionBD))
                    using (OleDbDataReader lectorBD = comandoBD.ExecuteReader())
                    {
                        while (lectorBD.Read())
                        {
                            string nombreUsuarioDB = lectorBD.GetString(1);
                            string contraseñaUsuarioDB = lectorBD.GetString(2);

                            if (nombreUsuarioDB == nombreUser && contraseñaUsuarioDB == passUser)
                            {
                                estadoConexion = "Usuario válido";
                                return true;
                            }
                        }
                    }

                    estadoConexion = "Usuario no válido";
                    return false;
                }
                catch (Exception error)
                {
                    estadoConexion = error.Message;
                    return false;
                }
            }
        }

        public void CrearUsuario( string Usuario, string Contraseña, string Perfil)
        {
            try
            {
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;

                comandoBD.CommandType = CommandType.Text;
                comandoBD.CommandText = $"INSERT INTO Usuario (Id, Usuario, Contraseña, Perfil) VALUES {Usuario}{Contraseña}{Perfil} ";

                comandoBD.ExecuteNonQuery();
                conexionBD.Close();

                MessageBox.Show("Se creo el usuario");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hubo un error al intentar guardar los datos.");

                throw ex;
            }
        }
    }

       
    
}
