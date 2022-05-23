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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void img_aluno_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmAlunos cadAlunos = new frmAlunos();
            cadAlunos.ShowDialog();
            this.Visible = true;
        }

        private void img_disciplinas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmDisciplinas cadDisciplinas = new frmDisciplinas();
            cadDisciplinas.ShowDialog();
            this.Visible = true;
        }
    }
}
