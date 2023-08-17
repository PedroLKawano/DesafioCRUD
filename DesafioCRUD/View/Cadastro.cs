using Dapper;
using DesafioCRUD.Models;
using DesafioCRUD.Repositories;
using Microsoft.Data.SqlClient;

namespace DesafioCRUD.View
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public void EditarCadastro(int id, string nome, string sobrenome, string descricaoGenero, DateTime dataNascimento, string endereco, string numero, string cep, string bairro)
        {
            this.Text = "Edição";
            lblCod.Visible = true;
            txtCod.Visible = true;
            btnCadastrar.Visible = false;
            btnSalvar.Visible = true;

            txtCod.Text = id.ToString();
            txtNome.Text = nome;
            txtSobrenome.Text = sobrenome;
            txtGenero.Text = descricaoGenero;
            dtpNascimento.Value = dataNascimento;
            txtEndereco.Text = endereco;
            txtNumero.Text = numero;
            mtbCep.Text = cep;
            txtBairro.Text = bairro;
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
                Bairro = txtBairro.Text
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

        private void FecharFormulario()
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            new GeneroRepository().CadastrarGenero(txtGenero.Text);
            var generoId = new GeneroRepository().BuscarGeneroId(txtGenero.Text);
            var edicaoCadastro = new Cliente
            {
                Id = Convert.ToInt32(txtCod.Text),
                Nome = txtNome.Text,
                Sobrenome = txtSobrenome.Text,
                GeneroId = generoId,
                DataNascimento = dtpNascimento.Value,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Cep = mtbCep.Text,
                Bairro = txtBairro.Text
            };

            new ClienteRepository().EditarCliente(edicaoCadastro);
            FecharFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
