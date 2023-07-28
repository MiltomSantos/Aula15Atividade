namespace Aula15Atividade
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuarioAdm = new Usuario("ADM", "Senhafoda.com");
            Cliente admin = new Cliente("ADM", 0, usuarioAdm);
            Program.clientes.Add(admin);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtDigiteUsuario.Text;
            string senha = txtDigiteSenha.Text;

            for (int i = 0; i < Program.clientes.Count; i++)
            {
                if (Program.clientes[i].usuario.usuario == usuario && Program.clientes[i].usuario.senha == senha)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}