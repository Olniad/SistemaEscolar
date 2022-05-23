using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_51
{
    public partial class frmDisciplinas : Form
    {
        public frmDisciplinas()
        {
            InitializeComponent();
            listar();
        }
        public void listar()
        {
            sql = "select * from disciplinas";
            dgv_listar.DataSource = bd.ConsultarTabelas(sql);
        }
        public void limpar()
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_descricao.Clear();
            txt_carga.Clear();
            txt_professor.Clear();
            cbx_ano.SelectedIndex = -1;
        }
        ConexaoBD bd = new ConexaoBD();
        double carga;
        string sql, foto;

        private void cbx_ano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btn_alterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update disciplinas set nome = '{0}', carga_horaria = '{1}', ano = '{2}', professor = '{3}', descricao = '{4}' where codigo = '{5}'"
            , txt_nome.Text, txt_carga.Text, cbx_ano.Text, txt_professor.Text ,txt_descricao.Text, txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Professor(a) alterado com sucesso!!!", "Alterar Cadastro Professores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format(" delete from disciplinas where codigo = '{0}'", txt_codigo.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Professor(a) excluido com sucesso!!!", "Excluir cadastro Professores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listar();
            limpar();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from disciplinas where codigo = '{0}' or nome = '{1}'", txt_codigo.Text, txt_nome.Text);
            buscar = bd.ConsultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                txt_codigo.Text = buscar.Rows[0]["codigo"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_descricao.Text = buscar.Rows[0]["descricao"].ToString();
                cbx_ano.Text = buscar.Rows[0]["ano"].ToString();
                txt_professor.Text = buscar.Rows[0]["professor"].ToString();
                txt_carga.Text = buscar.Rows[0]["carga_horaria"].ToString();
            }
            else
            {
                MessageBox.Show("Cadastro do Professor(a) nao encontrado!!!", "Buscar Professor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            double carga = Convert.ToDouble(txt_carga.Text) ;
            sql = string.Format("insert into disciplinas values (null, '{0}','{1}','{2}','{3}','{4}')" 
                                , txt_nome.Text, carga, cbx_ano.Text, txt_professor.Text, txt_descricao.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Professor(a) cadastrado com sucesso!!", "Cadastro Professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }

        private void dgv_listar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbx_ano.Text = dgv_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_professor.Text = dgv_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_carga.Text = dgv_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void frmDisciplinas_Load(object sender, EventArgs e)
        {
            listar();
            limpar();
        }
    }
}
