using DesafioCRUD.Models;
using DesafioCRUD.Repositories;
using System.Drawing.Text;

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

            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtGenero.Text = string.Empty;
            dtpNascimento.Value = DateTime.Now;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            mtbCep.Text = string.Empty;
            txtBairro.Text = string.Empty;
        }
    }
}
