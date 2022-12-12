namespace _211362.view
{
    partial class fm_cliente
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
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.dgv_cidade = new System.Windows.Forms.DataGridView();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.dtp_data_nascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_bloqueia = new System.Windows.Forms.CheckBox();
            this.txt_renda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.LightGray;
            this.btn_pesquisar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(579, 560);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(113, 36);
            this.btn_pesquisar.TabIndex = 67;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(279, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 28);
            this.label2.TabIndex = 66;
            this.label2.Text = "Digite o nome da categoria:";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pesquisar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisar.Location = new System.Drawing.Point(279, 561);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(286, 35);
            this.txt_pesquisar.TabIndex = 65;
            this.txt_pesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(279, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 28);
            this.label1.TabIndex = 64;
            this.label1.Text = "Dê dois cliques para selecionar as linhas:";
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.LightGray;
            this.btn_fechar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(659, 456);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(113, 50);
            this.btn_fechar.TabIndex = 63;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluir.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(540, 456);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(113, 50);
            this.btn_excluir.TabIndex = 62;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancelar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(421, 456);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(113, 50);
            this.btn_cancelar.TabIndex = 61;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.LightGray;
            this.btn_alterar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(302, 456);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(113, 50);
            this.btn_alterar.TabIndex = 60;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.BackColor = System.Drawing.Color.LightGray;
            this.btn_incluir.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_incluir.ForeColor = System.Drawing.Color.White;
            this.btn_incluir.Location = new System.Drawing.Point(183, 456);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(113, 50);
            this.btn_incluir.TabIndex = 59;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(158, 156);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(320, 35);
            this.txt_nome.TabIndex = 58;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome.Location = new System.Drawing.Point(158, 125);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(87, 28);
            this.lbl_nome.TabIndex = 57;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_codigo.Location = new System.Drawing.Point(158, 72);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(94, 35);
            this.txt_codigo.TabIndex = 56;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_cidade
            // d
            this.dgv_cidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cidade.Location = new System.Drawing.Point(80, 635);
            this.dgv_cidade.Name = "dgv_cidade";
            this.dgv_cidade.RowTemplate.Height = 25;
            this.dgv_cidade.Size = new System.Drawing.Size(837, 184);
            this.dgv_cidade.TabIndex = 55;
            this.dgv_cidade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_click);
            this.dgv_cidade.DoubleClick += new System.EventHandler(this.dgv_click);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codigo.Location = new System.Drawing.Point(158, 41);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(103, 28);
            this.lbl_codigo.TabIndex = 54;
            this.lbl_codigo.Text = "Código:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pic_foto
            // 
            this.pic_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_foto.Location = new System.Drawing.Point(711, 111);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(206, 179);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto.TabIndex = 68;
            this.pic_foto.TabStop = false;
            // 
            // cb_cidade
            // 
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Location = new System.Drawing.Point(158, 242);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(179, 23);
            this.cb_cidade.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 70;
            this.label3.Text = "Cidade:";
            // 
            // mtxt_cpf
            // 
            this.mtxt_cpf.Location = new System.Drawing.Point(449, 322);
            this.mtxt_cpf.Mask = "___.___.__-__";
            this.mtxt_cpf.Name = "mtxt_cpf";
            this.mtxt_cpf.Size = new System.Drawing.Size(139, 23);
            this.mtxt_cpf.TabIndex = 71;
            // 
            // dtp_data_nascimento
            // 
            this.dtp_data_nascimento.Location = new System.Drawing.Point(158, 322);
            this.dtp_data_nascimento.Name = "dtp_data_nascimento";
            this.dtp_data_nascimento.Size = new System.Drawing.Size(200, 23);
            this.dtp_data_nascimento.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(449, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 73;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(158, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 28);
            this.label5.TabIndex = 74;
            this.label5.Text = "Data de nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(158, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 28);
            this.label6.TabIndex = 76;
            this.label6.Text = "Renda:";
            // 
            // cb_bloqueia
            // 
            this.cb_bloqueia.AutoSize = true;
            this.cb_bloqueia.Location = new System.Drawing.Point(421, 242);
            this.cb_bloqueia.Name = "cb_bloqueia";
            this.cb_bloqueia.Size = new System.Drawing.Size(107, 19);
            this.cb_bloqueia.TabIndex = 77;
            this.cb_bloqueia.Text = "Bloqueia venda";
            this.cb_bloqueia.UseVisualStyleBackColor = true;
            // 
            // txt_renda
            // 
            this.txt_renda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_renda.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_renda.Location = new System.Drawing.Point(158, 404);
            this.txt_renda.Name = "txt_renda";
            this.txt_renda.Size = new System.Drawing.Size(179, 35);
            this.txt_renda.TabIndex = 78;
            this.txt_renda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 825);
            this.Controls.Add(this.txt_renda);
            this.Controls.Add(this.cb_bloqueia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_data_nascimento);
            this.Controls.Add(this.mtxt_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_cidade);
            this.Controls.Add(this.pic_foto);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.dgv_cidade);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "fm_cliente";
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.fm_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_pesquisar;
        private Label label2;
        private TextBox txt_pesquisar;
        private Label label1;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_cancelar;
        private Button btn_alterar;
        private Button btn_incluir;
        private TextBox txt_nome;
        private Label lbl_nome;
        private TextBox txt_codigo;
        private DataGridView dgv_cidade;
        private Label lbl_codigo;
        private OpenFileDialog openFileDialog1;
        private PictureBox pic_foto;
        private ComboBox cb_cidade;
        private Label label3;
        private MaskedTextBox mtxt_cpf;
        private DateTimePicker dtp_data_nascimento;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox cb_bloqueia;
        private TextBox txt_renda;
    }
}