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
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNovoCadastro = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // dgvDados
            // 
            dgvDados.BackgroundColor = SystemColors.ControlLight;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(33, 177);
            dgvDados.MultiSelect = false;
            dgvDados.Name = "dgvDados";
            dgvDados.ReadOnly = true;
            dgvDados.RowTemplate.Height = 25;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.Size = new Size(667, 206);
            dgvDados.TabIndex = 6;
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
            txtCod.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(84, 64);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(227, 23);
            txtNome.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(84, 93);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(77, 23);
            txtIdade.TabIndex = 3;
            // 
            // txtGenero
            // 
            txtGenero.CharacterCasing = CharacterCasing.Upper;
            txtGenero.Location = new Point(84, 123);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(227, 23);
            txtGenero.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.DimGray;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(568, 396);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 50);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.SkyBlue;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.List;
            btnFiltrar.IconColor = Color.DimGray;
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFiltrar.IconSize = 25;
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.Location = new Point(569, 114);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(131, 50);
            btnFiltrar.TabIndex = 11;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Khaki;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEditar.IconColor = Color.Gray;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(33, 396);
            btnEditar.Name = "btnEditar";
            btnEditar.RightToLeft = RightToLeft.No;
            btnEditar.Size = new Size(131, 50);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.BackColor = Color.YellowGreen;
            btnNovoCadastro.FlatStyle = FlatStyle.Flat;
            btnNovoCadastro.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnNovoCadastro.IconColor = Color.DimGray;
            btnNovoCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNovoCadastro.IconSize = 20;
            btnNovoCadastro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovoCadastro.Location = new Point(300, 396);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(131, 50);
            btnNovoCadastro.TabIndex = 13;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.UseVisualStyleBackColor = false;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
            // 
            // Listagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(731, 458);
            Controls.Add(btnNovoCadastro);
            Controls.Add(btnEditar);
            Controls.Add(btnFiltrar);
            Controls.Add(btnEliminar);
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
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNovoCadastro;
    }
}