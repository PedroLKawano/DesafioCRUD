using DesafioCRUD.Models;
using DesafioCRUD.Repositories;

namespace DesafioCRUD.View
{
    public partial class Cadastro : Form
    {

        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            var form = new Listagem();

            form.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new GeneroRepository().CadastrarGenero(txtGenero.Text);
            var generoId = new GeneroRepository().BuscarGeneroId(txtGenero.Text);
            var novoCadastro = new Cliente
            {
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                GeneroId = generoId,
                DataNascimento = dtpNascimento.Value,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Cep = mtbCep.Text,
                Bairro = txtBairro.Text,
            };

            new ClienteRepository().CadastrarCliente(novoCadastro);
        }
    }
}
