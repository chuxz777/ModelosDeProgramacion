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
    public partial class frm_Analisis_Lexico_Escrito : Form
    {
        public frm_Analisis_Lexico_Escrito()
        {
            InitializeComponent();
        }

        #region Variables Globales

        Cls_Check_text_BL obj_Check_text_BL = new Cls_Check_text_BL();

        #endregion

        private void tls_Analizar_Click(object sender, EventArgs e)
        {
            try
            {
                rtxt_Tokens.Text = obj_Check_text_BL.Cargar_Lineas_Escritas(rtxt_Mostar.Text).ToString();
            }
            catch
            {
                MessageBox.Show("Se produjo un error al Analizar el archivo", "Texto Plano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tls_Save_tokens_Click(object sender, EventArgs e)
        {
            string path =
                 Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Tokens - "+ Guid.NewGuid().ToString()+".txt");
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
            string path =
                 Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Errores- " + Guid.NewGuid().ToString() + ".txt");
            //string path = @"C:\Users\JoséAlberto\Desktop\Errores.txt";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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

        private void frm_Analisis_Lexico_Escrito_Load(object sender, EventArgs e)
        {
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
