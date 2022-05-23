
namespace BD_51
{
    partial class frmAlunos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlunos));
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.dgv_listar = new System.Windows.Forms.DataGridView();
            this.img_foto = new System.Windows.Forms.PictureBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.ofd_foto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(9, 13);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(50, 13);
            this.lbl_matricula.TabIndex = 0;
            this.lbl_matricula.Text = "Matricula";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(172, 13);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(9, 79);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(104, 13);
            this.lbl_data.TabIndex = 2;
            this.lbl_data.Text = "Data de Nascimento";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(260, 79);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 3;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(414, 79);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(30, 13);
            this.lbl_nota.TabIndex = 4;
            this.lbl_nota.Text = "Nota";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(12, 29);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(175, 29);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(342, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 106);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(229, 20);
            this.dtp_data.TabIndex = 7;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cbx_sexo.Location = new System.Drawing.Point(263, 104);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(121, 21);
            this.cbx_sexo.TabIndex = 8;
            this.cbx_sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(417, 105);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(100, 20);
            this.txt_nota.TabIndex = 9;
            // 
            // dgv_listar
            // 
            this.dgv_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar.Location = new System.Drawing.Point(12, 143);
            this.dgv_listar.Name = "dgv_listar";
            this.dgv_listar.Size = new System.Drawing.Size(505, 193);
            this.dgv_listar.TabIndex = 10;
            this.dgv_listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listar_CellContentClick_1);
            // 
            // img_foto
            // 
            this.img_foto.Location = new System.Drawing.Point(532, 12);
            this.img_foto.Name = "img_foto";
            this.img_foto.Size = new System.Drawing.Size(237, 324);
            this.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_foto.TabIndex = 11;
            this.img_foto.TabStop = false;
            // 
            // btn_novo
            // 
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(12, 342);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 45);
            this.btn_novo.TabIndex = 12;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(118, 342);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(94, 45);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(218, 342);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(93, 45);
            this.btn_alterar.TabIndex = 14;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click_1);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(317, 342);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(97, 45);
            this.btn_excluir.TabIndex = 15;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(420, 342);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(97, 45);
            this.btn_voltar.TabIndex = 16;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click_1);
            // 
            // btn_foto
            // 
            this.btn_foto.Image = ((System.Drawing.Image)(resources.GetObject("btn_foto.Image")));
            this.btn_foto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_foto.Location = new System.Drawing.Point(532, 342);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(237, 45);
            this.btn_foto.TabIndex = 17;
            this.btn_foto.Text = "Escolher Foto...";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // ofd_foto
            // 
            this.ofd_foto.FileName = "openFileDialog1";
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.img_foto);
            this.Controls.Add(this.dgv_listar);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.cbx_sexo);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_matricula);
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.DataGridView dgv_listar;
        private System.Windows.Forms.PictureBox img_foto;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.OpenFileDialog ofd_foto;
    }
}

