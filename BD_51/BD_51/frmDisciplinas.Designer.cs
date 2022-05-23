
namespace BD_51
{
    partial class frmDisciplinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisciplinas));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.dgv_listar = new System.Windows.Forms.DataGridView();
            this.txt_professor = new System.Windows.Forms.TextBox();
            this.cbx_ano = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_cargahr = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_carga = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(423, 358);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(97, 45);
            this.btn_voltar.TabIndex = 34;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(320, 358);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(97, 45);
            this.btn_excluir.TabIndex = 33;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterar.Image")));
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.Location = new System.Drawing.Point(221, 358);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(93, 45);
            this.btn_alterar.TabIndex = 32;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(121, 358);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(94, 45);
            this.btn_buscar.TabIndex = 31;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo.Location = new System.Drawing.Point(15, 358);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 45);
            this.btn_novo.TabIndex = 30;
            this.btn_novo.Text = "Novo";
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // dgv_listar
            // 
            this.dgv_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar.Location = new System.Drawing.Point(15, 159);
            this.dgv_listar.Name = "dgv_listar";
            this.dgv_listar.Size = new System.Drawing.Size(505, 193);
            this.dgv_listar.TabIndex = 28;
            this.dgv_listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listar_CellContentClick);
            // 
            // txt_professor
            // 
            this.txt_professor.Location = new System.Drawing.Point(292, 72);
            this.txt_professor.Name = "txt_professor";
            this.txt_professor.Size = new System.Drawing.Size(212, 20);
            this.txt_professor.TabIndex = 27;
            // 
            // cbx_ano
            // 
            this.cbx_ano.FormattingEnabled = true;
            this.cbx_ano.Items.AddRange(new object[] {
            "Primeiro",
            "Segundo",
            "Terceiro"});
            this.cbx_ano.Location = new System.Drawing.Point(143, 71);
            this.cbx_ano.Name = "cbx_ano";
            this.cbx_ano.Size = new System.Drawing.Size(131, 21);
            this.cbx_ano.TabIndex = 26;
            this.cbx_ano.SelectedIndexChanged += new System.EventHandler(this.cbx_ano_SelectedIndexChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(143, 25);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(361, 20);
            this.txt_nome.TabIndex = 24;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(15, 25);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 23;
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.Location = new System.Drawing.Point(289, 56);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(116, 13);
            this.lbl_professor.TabIndex = 22;
            this.lbl_professor.Text = "Professor Responsavel";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(140, 55);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(26, 13);
            this.lbl_sexo.TabIndex = 21;
            this.lbl_sexo.Text = "Ano";
            // 
            // lbl_cargahr
            // 
            this.lbl_cargahr.AutoSize = true;
            this.lbl_cargahr.Location = new System.Drawing.Point(12, 56);
            this.lbl_cargahr.Name = "lbl_cargahr";
            this.lbl_cargahr.Size = new System.Drawing.Size(72, 13);
            this.lbl_cargahr.TabIndex = 20;
            this.lbl_cargahr.Text = "Carga Horaria";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(140, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 19;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(12, 9);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_codigo.TabIndex = 18;
            this.lbl_codigo.Text = "Codigo";
            // 
            // txt_carga
            // 
            this.txt_carga.Location = new System.Drawing.Point(15, 71);
            this.txt_carga.Name = "txt_carga";
            this.txt_carga.Size = new System.Drawing.Size(100, 20);
            this.txt_carga.TabIndex = 35;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(15, 122);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(489, 20);
            this.txt_descricao.TabIndex = 36;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(12, 106);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(55, 13);
            this.lbl_descricao.TabIndex = 37;
            this.lbl_descricao.Text = "Descrição";
            // 
            // frmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 414);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_carga);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.dgv_listar);
            this.Controls.Add(this.txt_professor);
            this.Controls.Add(this.cbx_ano);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_professor);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_cargahr);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "frmDisciplinas";
            this.Text = "frmDisciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.DataGridView dgv_listar;
        private System.Windows.Forms.TextBox txt_professor;
        private System.Windows.Forms.ComboBox cbx_ano;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_professor;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_cargahr;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_carga;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label lbl_descricao;
    }
}