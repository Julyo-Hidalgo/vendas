namespace _211362.view
{
    partial class fm_produto
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
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.ofd_foto = new System.Windows.Forms.OpenFileDialog();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_venda = new System.Windows.Forms.DataGridView();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.estoque = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_foto
            // 
            this.pic_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_foto.Location = new System.Drawing.Point(738, 27);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(266, 224);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_foto.TabIndex = 4;
            this.pic_foto.TabStop = false;
            this.pic_foto.Click += new System.EventHandler(this.pic_foto_Click);
            // 
            // ofd_foto
            // 
            this.ofd_foto.FileName = "openFileDialog1";
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome.Location = new System.Drawing.Point(268, 132);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(320, 23);
            this.txt_nome.TabIndex = 41;
            // 
            // lbl_nome
            // 
            this.lbl_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome.Location = new System.Drawing.Point(392, 107);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(108, 22);
            this.lbl_nome.TabIndex = 40;
            this.lbl_nome.Text = "Descrição:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(392, 54);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(94, 23);
            this.txt_codigo.TabIndex = 39;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pesquisar.BackColor = System.Drawing.Color.LightGray;
            this.btn_pesquisar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(691, 563);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(113, 36);
            this.btn_pesquisar.TabIndex = 38;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fechar.BackColor = System.Drawing.Color.LightGray;
            this.btn_fechar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(782, 459);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(113, 50);
            this.btn_fechar.TabIndex = 37;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_excluir.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluir.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(663, 459);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(113, 50);
            this.btn_excluir.TabIndex = 36;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancelar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(544, 459);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(113, 50);
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_alterar.BackColor = System.Drawing.Color.LightGray;
            this.btn_alterar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(425, 459);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(113, 50);
            this.btn_alterar.TabIndex = 34;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            // 
            // btn_incluir
            // 
            this.btn_incluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_incluir.BackColor = System.Drawing.Color.LightGray;
            this.btn_incluir.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_incluir.ForeColor = System.Drawing.Color.White;
            this.btn_incluir.Location = new System.Drawing.Point(306, 459);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(113, 50);
            this.btn_incluir.TabIndex = 33;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(401, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Digite o nome do produto:";
            // 
            // dgv_venda
            // 
            this.dgv_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venda.Location = new System.Drawing.Point(126, 656);
            this.dgv_venda.Name = "dgv_venda";
            this.dgv_venda.RowTemplate.Height = 25;
            this.dgv_venda.Size = new System.Drawing.Size(878, 125);
            this.dgv_venda.TabIndex = 31;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pesquisar.Location = new System.Drawing.Point(370, 576);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(286, 23);
            this.txt_pesquisar.TabIndex = 30;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codigo.ForeColor = System.Drawing.Color.Black;
            this.lbl_codigo.Location = new System.Drawing.Point(401, 27);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(81, 22);
            this.lbl_codigo.TabIndex = 29;
            this.lbl_codigo.Text = "Código:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(392, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(392, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Marca:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_categoria.Enabled = false;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(268, 227);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(320, 23);
            this.cb_categoria.TabIndex = 47;
            // 
            // cb_marca
            // 
            this.cb_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_marca.Enabled = false;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(268, 312);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(320, 23);
            this.cb_marca.TabIndex = 48;
            // 
            // estoque
            // 
            this.estoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estoque.AutoSize = true;
            this.estoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estoque.ForeColor = System.Drawing.Color.Black;
            this.estoque.Location = new System.Drawing.Point(497, 391);
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(91, 22);
            this.estoque.TabIndex = 49;
            this.estoque.Text = "Estoque:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(497, 416);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 23);
            this.numericUpDown1.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(296, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 52;
            this.label4.Text = "Preço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 23);
            this.textBox1.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(367, 625);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(493, 28);
            this.label6.TabIndex = 55;
            this.label6.Text = "Dê dois cliques para selecionar as linhas:";
            // 
            // fm_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 793);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.estoque);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_venda);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.pic_foto);
            this.Name = "fm_produto";
            this.Text = "Cadastro de produto";
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button btn_pesquisar;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_cancelar;
        private Button btn_alterar;
        private Button btn_incluir;
        private Label label3;
        private TextBox txt_pesquisar;
        private TextBox txt_nome;
        private Label lbl_nome;
        private TextBox txt_codigo;
        private DataGridView dgv_cidade;
        private Label lbl_codigo;
        private OpenFileDialog ofd_;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private PictureBox pic_foto;
        private OpenFileDialog ofd_foto;
        private DataGridView dgv_venda;
        private Label label1;
        private ComboBox cb_categoria;
        private ComboBox cb_marca;
        private Label estoque;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
    }
}