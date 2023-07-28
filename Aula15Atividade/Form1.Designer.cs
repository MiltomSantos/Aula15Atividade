namespace Aula15Atividade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFaçaLogin = new System.Windows.Forms.Label();
            this.lblDigiteUsuario = new System.Windows.Forms.Label();
            this.txtDigiteUsuario = new System.Windows.Forms.TextBox();
            this.lblDigiteSenha = new System.Windows.Forms.Label();
            this.txtDigiteSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFaçaLogin
            // 
            this.lblFaçaLogin.AutoSize = true;
            this.lblFaçaLogin.Location = new System.Drawing.Point(90, 27);
            this.lblFaçaLogin.Name = "lblFaçaLogin";
            this.lblFaçaLogin.Size = new System.Drawing.Size(141, 15);
            this.lblFaçaLogin.TabIndex = 0;
            this.lblFaçaLogin.Text = "Faça login para continuar";
            // 
            // lblDigiteUsuario
            // 
            this.lblDigiteUsuario.AutoSize = true;
            this.lblDigiteUsuario.Location = new System.Drawing.Point(32, 72);
            this.lblDigiteUsuario.Name = "lblDigiteUsuario";
            this.lblDigiteUsuario.Size = new System.Drawing.Size(104, 15);
            this.lblDigiteUsuario.TabIndex = 1;
            this.lblDigiteUsuario.Text = "Digite seu usuário:";
            // 
            // txtDigiteUsuario
            // 
            this.txtDigiteUsuario.Location = new System.Drawing.Point(32, 90);
            this.txtDigiteUsuario.Name = "txtDigiteUsuario";
            this.txtDigiteUsuario.Size = new System.Drawing.Size(248, 23);
            this.txtDigiteUsuario.TabIndex = 2;
            // 
            // lblDigiteSenha
            // 
            this.lblDigiteSenha.AutoSize = true;
            this.lblDigiteSenha.Location = new System.Drawing.Point(32, 159);
            this.lblDigiteSenha.Name = "lblDigiteSenha";
            this.lblDigiteSenha.Size = new System.Drawing.Size(96, 15);
            this.lblDigiteSenha.TabIndex = 3;
            this.lblDigiteSenha.Text = "Digite sua senha:";
            // 
            // txtDigiteSenha
            // 
            this.txtDigiteSenha.Location = new System.Drawing.Point(32, 177);
            this.txtDigiteSenha.Name = "txtDigiteSenha";
            this.txtDigiteSenha.PasswordChar = '•';
            this.txtDigiteSenha.Size = new System.Drawing.Size(248, 23);
            this.txtDigiteSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(90, 232);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(119, 42);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 327);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtDigiteSenha);
            this.Controls.Add(this.lblDigiteSenha);
            this.Controls.Add(this.txtDigiteUsuario);
            this.Controls.Add(this.lblDigiteUsuario);
            this.Controls.Add(this.lblFaçaLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFaçaLogin;
        private Label lblDigiteUsuario;
        private TextBox txtDigiteUsuario;
        private Label lblDigiteSenha;
        private TextBox txtDigiteSenha;
        private Button btnEntrar;
    }
}