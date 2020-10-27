namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usuari = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConQuienJuego = new System.Windows.Forms.RadioButton();
            this.Mascorta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.partida = new System.Windows.Forms.TextBox();
            this.MasPuntos = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsuariLogIn = new System.Windows.Forms.TextBox();
            this.contrasenyaLogIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ContrasenyaSignIn = new System.Windows.Forms.TextBox();
            this.UsuariSignIn = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Usuari
            // 
            this.Usuari.AutoSize = true;
            this.Usuari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuari.Location = new System.Drawing.Point(35, 39);
            this.Usuari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuari.Name = "Usuari";
            this.Usuari.Size = new System.Drawing.Size(110, 37);
            this.Usuari.TabIndex = 1;
            this.Usuari.Text = "Usuari";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(174, 48);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(244, 26);
            this.ID.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 241);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.ConQuienJuego);
            this.groupBox1.Controls.Add(this.Mascorta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.partida);
            this.groupBox1.Controls.Add(this.MasPuntos);
            this.groupBox1.Controls.Add(this.Usuari);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(35, 160);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(630, 304);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // ConQuienJuego
            // 
            this.ConQuienJuego.AutoSize = true;
            this.ConQuienJuego.Location = new System.Drawing.Point(174, 108);
            this.ConQuienJuego.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConQuienJuego.Name = "ConQuienJuego";
            this.ConQuienJuego.Size = new System.Drawing.Size(226, 24);
            this.ConQuienJuego.TabIndex = 7;
            this.ConQuienJuego.TabStop = true;
            this.ConQuienJuego.Text = "Dime con quien has jugado";
            this.ConQuienJuego.UseVisualStyleBackColor = true;
            // 
            // Mascorta
            // 
            this.Mascorta.AutoSize = true;
            this.Mascorta.Location = new System.Drawing.Point(174, 144);
            this.Mascorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mascorta.Name = "Mascorta";
            this.Mascorta.Size = new System.Drawing.Size(302, 24);
            this.Mascorta.TabIndex = 7;
            this.Mascorta.TabStop = true;
            this.Mascorta.Text = "Dime cual ha sido la partida más corta";
            this.Mascorta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Partida";
            // 
            // partida
            // 
            this.partida.Location = new System.Drawing.Point(22, 169);
            this.partida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partida.Name = "partida";
            this.partida.Size = new System.Drawing.Size(91, 26);
            this.partida.TabIndex = 9;
            // 
            // MasPuntos
            // 
            this.MasPuntos.AutoSize = true;
            this.MasPuntos.Location = new System.Drawing.Point(174, 180);
            this.MasPuntos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MasPuntos.Name = "MasPuntos";
            this.MasPuntos.Size = new System.Drawing.Size(376, 24);
            this.MasPuntos.TabIndex = 8;
            this.MasPuntos.TabStop = true;
            this.MasPuntos.Text = "Dime que jugador tiene más puntos en la partida";
            this.MasPuntos.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(37, 511);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 81);
            this.button3.TabIndex = 10;
            this.button3.Text = "desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Usuari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contrasenya";
            // 
            // UsuariLogIn
            // 
            this.UsuariLogIn.Location = new System.Drawing.Point(143, 70);
            this.UsuariLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsuariLogIn.Name = "UsuariLogIn";
            this.UsuariLogIn.Size = new System.Drawing.Size(112, 26);
            this.UsuariLogIn.TabIndex = 14;
            // 
            // contrasenyaLogIn
            // 
            this.contrasenyaLogIn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.contrasenyaLogIn.Location = new System.Drawing.Point(143, 105);
            this.contrasenyaLogIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contrasenyaLogIn.Name = "contrasenyaLogIn";
            this.contrasenyaLogIn.Size = new System.Drawing.Size(112, 26);
            this.contrasenyaLogIn.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "SIGN IN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Usuari";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Contrasenya";
            // 
            // ContrasenyaSignIn
            // 
            this.ContrasenyaSignIn.Location = new System.Drawing.Point(143, 278);
            this.ContrasenyaSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContrasenyaSignIn.Name = "ContrasenyaSignIn";
            this.ContrasenyaSignIn.Size = new System.Drawing.Size(112, 26);
            this.ContrasenyaSignIn.TabIndex = 19;
            // 
            // UsuariSignIn
            // 
            this.UsuariSignIn.Location = new System.Drawing.Point(143, 234);
            this.UsuariSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsuariSignIn.Name = "UsuariSignIn";
            this.UsuariSignIn.Size = new System.Drawing.Size(112, 26);
            this.UsuariSignIn.TabIndex = 20;
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(181, 312);
            this.SignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(74, 40);
            this.SignIn.TabIndex = 22;
            this.SignIn.Text = "go";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(181, 140);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(74, 38);
            this.Login.TabIndex = 23;
            this.Login.Text = "go";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SignIn);
            this.groupBox2.Controls.Add(this.Login);
            this.groupBox2.Controls.Add(this.ContrasenyaSignIn);
            this.groupBox2.Controls.Add(this.UsuariSignIn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.UsuariLogIn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.contrasenyaLogIn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(828, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(269, 374);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 865);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Usuari;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ConQuienJuego;
        private System.Windows.Forms.RadioButton MasPuntos;
        private System.Windows.Forms.RadioButton Mascorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partida;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsuariLogIn;
        private System.Windows.Forms.TextBox contrasenyaLogIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ContrasenyaSignIn;
        private System.Windows.Forms.TextBox UsuariSignIn;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

