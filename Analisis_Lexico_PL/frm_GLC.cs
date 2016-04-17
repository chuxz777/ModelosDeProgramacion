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
using System.IO;

namespace Analisis_Lexico_PL
{
    public partial class frm_GLC : Form
    {
        public frm_GLC()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Cls_Gramatica_libre_contexto obj_Gramatica = new Cls_Gramatica_libre_contexto();

        #endregion

        private void tls_Abrir_Click(object sender, EventArgs e)
        {
            // Variable utilizada para mostrar el cuadro de seleccionar archivo
            OpenFileDialog objAbrirArchivo = new OpenFileDialog();

            // Solo se pueden seleccionar archivos de Texto Plano
            objAbrirArchivo.Filter = "Text Files (*.txt)|*txt";

            if (objAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                txt_RutaArchivo.Text = objAbrirArchivo.FileName;
                // Se setea en el text box la ruta
                MessageBox.Show("Archivo abierto con éxito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tls_Cargar.Enabled = true;
                tls_Analizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Archivo no pudo ser accesado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tls_Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                rtxt_Tokens.Text = string.Empty;
                //Se pregunta si la ruta del archivo es distinta de null, si lo es llama al metodo de cargar el archivo.
                if (txt_RutaArchivo.Text != null)
                {
                    rtxt_Mostar.Text = File.ReadAllText(txt_RutaArchivo.Text);
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error al abrir el archivo", "Texto Plano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tls_Analizar_Click(object sender, EventArgs e)
        {
            try
            {
                rtxt_Tokens.Text = obj_Gramatica.RevisarGramatica(rtxt_Mostar.Text).ToString();
            }
            catch
            {
                MessageBox.Show("Se produjo un error al Analizar el archivo", "Texto Plano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tls_Errores_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
