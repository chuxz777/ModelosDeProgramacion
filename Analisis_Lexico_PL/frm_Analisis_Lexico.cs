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
                tls_Save_tokens.Enabled = true;
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
            tls_Save_tokens.Enabled = false;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
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
                this.timer1.Start();
               rtxt_Tokens.Text = obj_Check_text_BL.CargarLineas(txt_RutaArchivo.Text).ToString();
                this.timer1.Stop();
            }
            catch 
            {

  
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(100);
        }
    }
}
