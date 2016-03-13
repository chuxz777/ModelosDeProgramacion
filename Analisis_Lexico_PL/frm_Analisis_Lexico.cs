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
               rtxt_Tokens.Text = obj_Check_text_BL.CargarLineas(txt_RutaArchivo.Text).ToString();
            }
            catch 
            {
                MessageBox.Show("Se produjo un error al Analizar el archivo", "Texto Plano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (progressBar1.Value < progressBar1.Maximum)
            //    progressBar1.Increment(5);
            //else
            //    progressBar1.Value = progressBar1.Minimum;
        }

        private void StartBackgroundWork()
        {
            //if (Application.RenderWithVisualStyles)
            //    progressBar1.Style = ProgressBarStyle.Marquee;
            //else {
            //    progressBar1.Style = ProgressBarStyle.Continuous;
            //    progressBar1.Maximum = 100;
            //    progressBar1.Value = 0;
            //    timer1.Enabled = true;
            //}
            //BackgroundWorker.RunWorkerAsync();
        }

        private void tls_Save_tokens_Click(object sender, EventArgs e)
        {
            //string path = @"C:\Users\JoséAlberto\Desktop\Tokens.txt";
            string path = 
               Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Tokens- " + Guid.NewGuid().ToString() + ".txt");

            try
            {
                File.WriteAllLines(path, new[] { rtxt_Tokens.Text });
                MessageBox.Show("Se creó y guardó exitosamente su documento de tokens, ubicacion Mis Documentos", "Texto Plano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Se produjo un error al crear o guardar el archivo de Tokens", "Texto Plano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tls_Errores_Click(object sender, EventArgs e)
        {
            string sTodosErrores = obj_Check_text_BL.CargarErrores(rtxt_Tokens.Text);
           // string path = @"C:\Users\JoséAlberto\Desktop\Errores.txt";

            string path =
              Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Errores- " + Guid.NewGuid().ToString() + ".txt");

            try
            {
                File.WriteAllLines(path, new[] { sTodosErrores });
                MessageBox.Show("Se creó y guardó exitosamente su documento de errores, ubicacion Mis Documentos", "Texto Plano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Se produjo un error al crear o guardar el archivo de Errores", "Texto Plano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
