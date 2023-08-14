using DesafioCRUD.Repositories;

namespace DesafioCRUD.View
{
    public partial class Listagem : Form
    {
        public Listagem()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int? codigo = string.IsNullOrEmpty(txtCod.Text) ? (int?)null : int.Parse(txtCod.Text);
            string? nome = string.IsNullOrEmpty(txtNome.Text) ? (string?)null : txtNome.Text;
            string? genero = string.IsNullOrEmpty(txtGenero.Text) ? (string?)null : txtGenero.Text;
            int? idade = string.IsNullOrEmpty(txtIdade.Text) ? (int?)null : int.Parse(txtIdade.Text);

            var clientes = new ClienteRepository().ListarClientes(codigo, nome, idade, genero);
            dgvDados.DataSource = clientes;
        }
    }
}
