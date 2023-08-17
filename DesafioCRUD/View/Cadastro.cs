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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarDadosPreenchidos())
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
                MessageBox.Show("Cliente cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarDadosPreenchidos())
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
                MessageBox.Show("Edição realizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FecharFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar a operação? Qualquer informação inserida será perdida.", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
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

        private bool ValidarDadosPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtSobrenome.Text) || string.IsNullOrWhiteSpace(txtGenero.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) || string.IsNullOrWhiteSpace(txtNumero.Text) || string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (dtpNascimento.Value >= DateTime.Now.Date)
            {
                MessageBox.Show("A data de nascimento não pode ser maior ou igual que a data atual.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
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
    }
}
