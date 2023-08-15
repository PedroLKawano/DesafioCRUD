namespace DesafioCRUD.View
{
    partial class Cadastro
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
            btnListagem = new Button();
            btnCadastrar = new Button();
            label8 = new Label();
            txtBairro = new TextBox();
            mtbCep = new MaskedTextBox();
            txtNumero = new TextBox();
            label7 = new Label();
            txtEndereco = new TextBox();
            dtpNascimento = new DateTimePicker();
            txtGenero = new TextBox();
            txtSobrenome = new TextBox();
            txtNome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSalvar = new Button();
            lblCod = new Label();
            txtCod = new TextBox();
            SuspendLayout();
            // 
            // btnListagem
            // 
            btnListagem.Location = new Point(27, 233);
            btnListagem.Name = "btnListagem";
            btnListagem.Size = new Size(95, 35);
            btnListagem.TabIndex = 35;
            btnListagem.Text = "Listar";
            btnListagem.UseVisualStyleBackColor = true;
            btnListagem.Click += btnListagem_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(562, 233);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(95, 35);
            btnCadastrar.TabIndex = 34;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(399, 174);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 33;
            label8.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.CharacterCasing = CharacterCasing.Upper;
            txtBairro.Location = new Point(464, 168);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(193, 23);
            txtBairro.TabIndex = 32;
            // 
            // mtbCep
            // 
            mtbCep.Location = new Point(464, 132);
            mtbCep.Mask = "99999-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(100, 23);
            mtbCep.TabIndex = 31;
            // 
            // txtNumero
            // 
            txtNumero.CharacterCasing = CharacterCasing.Upper;
            txtNumero.Location = new Point(464, 96);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 135);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 29;
            label7.Text = "CEP";
            // 
            // txtEndereco
            // 
            txtEndereco.CharacterCasing = CharacterCasing.Upper;
            txtEndereco.Location = new Point(464, 57);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(193, 23);
            txtEndereco.TabIndex = 28;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(161, 168);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(101, 23);
            dtpNascimento.TabIndex = 27;
            // 
            // txtGenero
            // 
            txtGenero.CharacterCasing = CharacterCasing.Upper;
            txtGenero.Location = new Point(161, 132);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(193, 23);
            txtGenero.TabIndex = 26;
            // 
            // txtSobrenome
            // 
            txtSobrenome.CharacterCasing = CharacterCasing.Upper;
            txtSobrenome.Location = new Point(161, 95);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(193, 23);
            txtSobrenome.TabIndex = 25;
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(161, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(193, 23);
            txtNome.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 99);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 23;
            label6.Text = "Número";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 60);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 22;
            label5.Text = "Endereço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 174);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 21;
            label4.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 140);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 20;
            label3.Text = "Gênero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 98);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 19;
            label2.Text = "Sobrenome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 60);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 18;
            label1.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(299, 233);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(95, 35);
            btnSalvar.TabIndex = 36;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Visible = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(27, 24);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(32, 15);
            lblCod.TabIndex = 37;
            lblCod.Text = "Cód.";
            lblCod.Visible = false;
            // 
            // txtCod
            // 
            txtCod.Location = new Point(161, 21);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(74, 23);
            txtCod.TabIndex = 38;
            txtCod.Visible = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 314);
            Controls.Add(txtCod);
            Controls.Add(lblCod);
            Controls.Add(btnSalvar);
            Controls.Add(btnListagem);
            Controls.Add(btnCadastrar);
            Controls.Add(label8);
            Controls.Add(txtBairro);
            Controls.Add(mtbCep);
            Controls.Add(txtNumero);
            Controls.Add(label7);
            Controls.Add(txtEndereco);
            Controls.Add(dtpNascimento);
            Controls.Add(txtGenero);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListagem;
        private Button btnCadastrar;
        private Label label8;
        private TextBox txtBairro;
        private MaskedTextBox mtbCep;
        private TextBox txtNumero;
        private Label label7;
        private TextBox txtEndereco;
        private DateTimePicker dtpNascimento;
        private TextBox txtGenero;
        private TextBox txtSobrenome;
        private TextBox txtNome;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalvar;
        private Label lblCod;
        private TextBox txtCod;
    }
}