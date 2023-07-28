namespace Aula15Atividade
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDigiteUsuario = new System.Windows.Forms.Label();
            this.txtDigiteUsuario = new System.Windows.Forms.TextBox();
            this.lblDigiteSenha = new System.Windows.Forms.Label();
            this.txtDigiteSenha = new System.Windows.Forms.TextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-Vindo ao gerenciador de clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnoNascimento);
            this.groupBox1.Controls.Add(this.lblAnoNascimento);
            this.groupBox1.Controls.Add(this.txtNomeCompleto);
            this.groupBox1.Controls.Add(this.lblNomeCompleto);
            this.groupBox1.Controls.Add(this.txtDigiteSenha);
            this.groupBox1.Controls.Add(this.lblDigiteSenha);
            this.groupBox1.Controls.Add(this.txtDigiteUsuario);
            this.groupBox1.Controls.Add(this.lblDigiteUsuario);
            this.groupBox1.Location = new System.Drawing.Point(27, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // lblDigiteUsuario
            // 
            this.lblDigiteUsuario.AutoSize = true;
            this.lblDigiteUsuario.Location = new System.Drawing.Point(14, 27);
            this.lblDigiteUsuario.Name = "lblDigiteUsuario";
            this.lblDigiteUsuario.Size = new System.Drawing.Size(93, 15);
            this.lblDigiteUsuario.TabIndex = 0;
            this.lblDigiteUsuario.Text = "Digite o usuario:";
            // 
            // txtDigiteUsuario
            // 
            this.txtDigiteUsuario.Location = new System.Drawing.Point(14, 45);
            this.txtDigiteUsuario.Name = "txtDigiteUsuario";
            this.txtDigiteUsuario.Size = new System.Drawing.Size(258, 23);
            this.txtDigiteUsuario.TabIndex = 1;
            // 
            // lblDigiteSenha
            // 
            this.lblDigiteSenha.AutoSize = true;
            this.lblDigiteSenha.Location = new System.Drawing.Point(14, 110);
            this.lblDigiteSenha.Name = "lblDigiteSenha";
            this.lblDigiteSenha.Size = new System.Drawing.Size(84, 15);
            this.lblDigiteSenha.TabIndex = 2;
            this.lblDigiteSenha.Text = "Digite a senha:";
            // 
            // txtDigiteSenha
            // 
            this.txtDigiteSenha.Location = new System.Drawing.Point(14, 128);
            this.txtDigiteSenha.Name = "txtDigiteSenha";
            this.txtDigiteSenha.Size = new System.Drawing.Size(258, 23);
            this.txtDigiteSenha.TabIndex = 3;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(14, 195);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(99, 15);
            this.lblNomeCompleto.TabIndex = 4;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(14, 213);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(258, 23);
            this.txtNomeCompleto.TabIndex = 5;
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(14, 268);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(113, 15);
            this.lblAnoNascimento.TabIndex = 6;
            this.lblAnoNascimento.Text = "Ano de nascimento:";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(14, 286);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(258, 23);
            this.txtAnoNascimento.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewClientes);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnProcurar);
            this.groupBox2.Controls.Add(this.txtBuscarCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(415, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 339);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Clientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "buscar cliente pelo nome:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(18, 45);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(269, 23);
            this.txtBuscarCliente.TabIndex = 8;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(18, 80);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(269, 36);
            this.btnProcurar.TabIndex = 9;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Clientes cadastrados";
            // 
            // listViewClientes
            // 
            this.listViewClientes.Location = new System.Drawing.Point(18, 170);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(269, 163);
            this.listViewClientes.TabIndex = 11;
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            this.listViewClientes.View = System.Windows.Forms.View.List;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtAnoNascimento;
        private Label lblAnoNascimento;
        private TextBox txtNomeCompleto;
        private Label lblNomeCompleto;
        private TextBox txtDigiteSenha;
        private Label lblDigiteSenha;
        private TextBox txtDigiteUsuario;
        private Label lblDigiteUsuario;
        private GroupBox groupBox2;
        private Label label6;
        private ListView listViewClientes;
        private Label label7;
        private Button btnProcurar;
        private TextBox txtBuscarCliente;
    }
}