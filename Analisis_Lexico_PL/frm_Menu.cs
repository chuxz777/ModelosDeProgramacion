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
            frm_Analisis_Lexico_Escrito frm_ana1 = new frm_Analisis_Lexico_Escrito();
            frm_ana1.ShowDialog();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void tlsbtn_GLC_Click(object sender, EventArgs e)
        {
            frm_GLC frm_veriGLC = new frm_GLC();
            frm_veriGLC.ShowDialog();
        }
    }
}
