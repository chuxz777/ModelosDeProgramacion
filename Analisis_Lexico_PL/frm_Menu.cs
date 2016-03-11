using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_Lexico_PL
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm_Analisis_Lexico frm_ana = new frm_Analisis_Lexico();
            frm_ana.ShowDialog();
        }

        private void tlbtn_Nuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
