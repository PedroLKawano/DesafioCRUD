namespace DesafioCRUD.View
{
    partial class Listagem
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
            dgvDados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCod = new TextBox();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtGenero = new TextBox();
            btnFiltrar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnNovoCadastro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(33, 170);
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowTemplate.Height = 25;
            dgvDados.Size = new Size(666, 206);
            dgvDados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Cód.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 67);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Location = new Point(33, 96);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 126);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "Gênero";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(84, 37);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(77, 23);
            txtCod.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(84, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(227, 23);
            txtNome.TabIndex = 6;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(84, 93);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(77, 23);
            txtIdade.TabIndex = 7;
            // 
            // txtGenero
            // 
            txtGenero.CharacterCasing = CharacterCasing.Upper;
            txtGenero.Location = new Point(84, 123);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(227, 23);
            txtGenero.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(604, 116);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(95, 35);
            btnFiltrar.TabIndex = 9;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(33, 396);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 35);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(604, 396);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 35);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.Location = new Point(318, 396);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(95, 35);
            btnNovoCadastro.TabIndex = 12;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.UseVisualStyleBackColor = true;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
            // 
            // Listagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 458);
            Controls.Add(btnNovoCadastro);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnFiltrar);
            Controls.Add(txtGenero);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(txtCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDados);
            Name = "Listagem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCod;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtGenero;
        private Button btnFiltrar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnNovoCadastro;
    }
}