namespace _211362.view
{
    partial class fm_cidade
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.dgv_cidade = new System.Windows.Forms.DataGridView();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_codigo.Location = new System.Drawing.Point(285, 141);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(103, 28);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "Código:";
            // 
            // dgv_cidade
            // 
            this.dgv_cidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cidade.Location = new System.Drawing.Point(201, 526);
            this.dgv_cidade.Name = "dgv_cidade";
            this.dgv_cidade.RowTemplate.Height = 25;
            this.dgv_cidade.Size = new System.Drawing.Size(837, 184);
            this.dgv_cidade.TabIndex = 2;
            this.dgv_cidade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_codigo.Location = new System.Drawing.Point(286, 172);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(94, 35);
            this.txt_codigo.TabIndex = 11;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(286, 250);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(320, 35);
            this.txt_nome.TabIndex = 13;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nome.Location = new System.Drawing.Point(285, 219);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(87, 28);
            this.lbl_nome.TabIndex = 12;
            this.lbl_nome.Text = "Nome:";
            // 
            // txt_uf
            // 
            this.txt_uf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_uf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_uf.Location = new System.Drawing.Point(491, 172);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(115, 35);
            this.txt_uf.TabIndex = 15;
            this.txt_uf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_uf.Location = new System.Drawing.Point(490, 141);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(52, 28);
            this.lbl_uf.TabIndex = 14;
            this.lbl_uf.Text = "UF:";
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.LightGray;
            this.btn_fechar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(831, 313);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(113, 50);
            this.btn_fechar.TabIndex = 32;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.LightGray;
            this.btn_excluir.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(712, 313);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(113, 50);
            this.btn_excluir.TabIndex = 31;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancelar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(593, 313);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(113, 50);
            this.btn_cancelar.TabIndex = 30;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.LightGray;
            this.btn_alterar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(474, 313);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(113, 50);
            this.btn_alterar.TabIndex = 29;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.BackColor = System.Drawing.Color.LightGray;
            this.btn_incluir.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_incluir.ForeColor = System.Drawing.Color.White;
            this.btn_incluir.Location = new System.Drawing.Point(355, 313);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(113, 50);
            this.btn_incluir.TabIndex = 28;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = false;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(362, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "Dê dois cliques para selecionar as linhas:";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.LightGray;
            this.btn_pesquisar.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(781, 444);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(113, 36);
            this.btn_pesquisar.TabIndex = 37;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(444, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Digite o nome da cidade:";
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pesquisar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pesquisar.Location = new System.Drawing.Point(445, 445);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(286, 35);
            this.txt_pesquisar.TabIndex = 35;
            this.txt_pesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fm_cidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 722);
            this.ControlBox = false;
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.lbl_uf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.dgv_cidade);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "fm_cidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cidades";
            this.Load += new System.EventHandler(this.fm_cidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_codigo;
        private DataGridView dgv_cidade;
        private TextBox txt_codigo;
        private TextBox txt_nome;
        private Label lbl_nome;
        private TextBox txt_uf;
        private Label lbl_uf;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_cancelar;
        private Button btn_alterar;
        private Button btn_incluir;
        private Label label1;
        private Button btn_pesquisar;
        private Label label2;
        private TextBox txt_pesquisar;
    }
}