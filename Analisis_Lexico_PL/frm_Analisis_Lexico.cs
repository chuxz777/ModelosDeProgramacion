using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cls_Analisis_Lexico_BL;
using System.Windows.Input;


namespace Analisis_Lexico_PL
{
    public partial class frm_Analisis_Lexico : Form
    {
        #region Variables Globales

        Cls_Check_text_BL obj_Check_text_BL = new Cls_Check_text_BL();

        #endregion

        public frm_Analisis_Lexico()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Variable utilizada para mostrar el cuadro de seleccionar archivo
            OpenFileDialog objAbrirArchivo = new OpenFileDialog();

            // Solo se pueden seleccionar archivos de Texto Plano
            objAbrirArchivo.Filter = "Text Files (*.txt)|*txt";

            // Luego que se selecciona el archivo entonces se almacena la ruta del mismo
            if (objAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                txt_RutaArchivo.Text = objAbrirArchivo.FileName;
                // Se setea en el text box la ruta
                MessageBox.Show("Archivo abierto con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tls_Cargar.Enabled = true;
                tls_Analizar.Enabled = true;
                tls_Errores.Enabled = true;
            }
            else
            {
                MessageBox.Show("Archivo no pudo ser accesado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_Analisis_Lexico_Load(object sender, EventArgs e)
        {
            tls_Cargar.Enabled = false;
            tls_Analizar.Enabled = false;
            tls_Errores.Enabled = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
