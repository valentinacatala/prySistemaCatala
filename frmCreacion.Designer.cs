namespace prySistemaCatala
{
    partial class frmCreacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Label();
            this.txtPefil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(91, 63);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(162, 20);
            this.txtContraseña.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(91, 23);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(162, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(44, 135);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(158, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.AutoSize = true;
            this.btnPerfil.Location = new System.Drawing.Point(23, 102);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(30, 13);
            this.btnPerfil.TabIndex = 10;
            this.btnPerfil.Text = "Perfil";
            // 
            // txtPefil
            // 
            this.txtPefil.Location = new System.Drawing.Point(91, 99);
            this.txtPefil.Name = "txtPefil";
            this.txtPefil.Size = new System.Drawing.Size(162, 20);
            this.txtPefil.TabIndex = 11;
            // 
            // frmCreacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 170);
            this.Controls.Add(this.txtPefil);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCreacion";
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.frmCreacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label btnPerfil;
        private System.Windows.Forms.TextBox txtPefil;
    }
}