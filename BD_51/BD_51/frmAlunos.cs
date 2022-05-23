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
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
            listar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void listar(){
            sql = "select * from alunos";
            dgv_listar.DataSource = bd.ConsultarTabelas(sql);
        }
        public void limpar(){
            txt_matricula.Clear();
            txt_nome.Clear();
            txt_nota.Clear();
            dtp_data.Text = DateTime.Now.ToString();
            cbx_sexo.SelectedIndex = -1;
            img_foto.Load("D:/desktop/Cotemig/EXERCICIOS/Tec_Programação/BD_51/ico/semfoto.png");
        }
        ConexaoBD bd = new ConexaoBD();
        DateTime data;
        string sql, foto;

        private void btn_novo_Click(object sender, EventArgs e)
        {
            data = DateTime.Parse(dtp_data.Text);
            foto = foto.Replace(@"\", @"\\");
            sql = string.Format("insert into alunos values (null, '{0}','{1}','{2}','{3}','{4}')"
                                , txt_nome.Text, data.ToString("yyyy-MM-dd"), cbx_sexo.Text, txt_nota.Text, foto);        
            bd.AlterarTabelas(sql);
            MessageBox.Show("Aluno(a) cadastrado com sucesso!!", "Cadastro Alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();
            sql = string.Format("select * from alunos where matricula = '{0}' or nome = '{1}'", txt_matricula.Text, txt_nome.Text);
            buscar = bd.ConsultarTabelas(sql);
            if (buscar.Rows.Count > 0)
            {
                txt_matricula.Text = buscar.Rows[0]["matricula"].ToString();
                txt_nome.Text = buscar.Rows[0]["nome"].ToString();
                txt_nota.Text = buscar.Rows[0]["nota"].ToString();
                dtp_data.Text = buscar.Rows[0]["dt_nasc"].ToString();
                cbx_sexo.Text = buscar.Rows[0]["sexo"].ToString();               
                img_foto.Load(buscar.Rows[0]["foto"].ToString());
                //foto = buscar.Rows[0]["foto"].ToString();
            }
            else
            {
                MessageBox.Show("Cadastro do aluno(a) nao encontrado!!!", "Buscar Aluno.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            }
        }
        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            foto = foto.Replace(@"\", @"\\");
            data = DateTime.Parse(dtp_data.Text);        
            sql = string.Format("update alunos set nome = '{0}', dt_nasc = '{1}', nota = '{2}', sexo = '{3}', foto = '{5}' where matricula = '{4}'"
            , txt_nome.Text, data.ToString("yyyy-MM-dd"), txt_nota.Text, cbx_sexo.Text, txt_matricula.Text, foto);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Aluno(a) alterado com sucesso!!!", "Alterar Cadastro Alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listar();
            limpar();
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from alunos where matricula = '{0}'", txt_matricula.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Aluno(a) excluido com sucesso!!!", "Excluir cadastro alunos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listar();
            limpar();
        }
        private void btn_voltar_Click_1(object sender, EventArgs e)
        {          
            this.Close();
            
        }

        private void dgv_listar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                txt_matricula.Text = dgv_listar.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_nome.Text = dgv_listar.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtp_data.Text = dgv_listar.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbx_sexo.Text = dgv_listar.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_nota.Text = dgv_listar.Rows[e.RowIndex].Cells[4].Value.ToString();
                img_foto.Load(dgv_listar.Rows[e.RowIndex].Cells[5].Value.ToString());
                foto = dgv_listar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            foto = "";
            if (ofd_foto.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img_foto.Load(ofd_foto.FileName);
                foto = ofd_foto.FileName;
            }

        }
    }
}
