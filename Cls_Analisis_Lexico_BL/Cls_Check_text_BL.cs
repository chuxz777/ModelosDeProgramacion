using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using Analisis_Lexico_DAL;
using Cls_Analisis_Lexico_BL;

namespace Cls_Analisis_Lexico_BL
{
    public class Cls_Check_text_BL
    {
        #region Variables Globales

        Cls_Texto_plano_DAL obj_cls_Texto_plano_DAL = new Cls_Texto_plano_DAL();
        Cls_Create_token_BL obj_cls_Create_Token_BL = new Cls_Create_token_BL();
        #endregion

        public string CargarLineas(string sRutaArchivo)
        {
            string a;
            a = string.Empty;

            foreach (string sLinea in File.ReadAllLines(sRutaArchivo))
            {
                if (sLinea.Contains('.'))
                {
                    // Separa cada linea del archivo con el caracter delimitador usando espacio para las columnas y \n junto con \r para salto de linea 
                    string[] sPieza = sLinea.Split(' ');

                    foreach (string token in sPieza)
                    {
                        if (token == string.Empty)
                        {
                            continue;
                        }
                        a = a + obj_cls_Create_Token_BL.TipoDeToken(token) + "\r\n";
                    }
                }
                else
                {
                    a = a + "Error: Final de linea sin delimitador '.' \r\n";
                }
            }
            return a;
        }

        public string Cargar_Lineas_Escritas(string sTextoEscrito)
        {
            string a, aux1, aux2;
            a = string.Empty;
            aux1 = string.Empty;
            aux2 = string.Empty;

            // Reemplaza los puntos simples por puntos con espacio, asi no falla en el string.split con espacio vacio
            aux1 = sTextoEscrito.Replace(".", " . ");
            aux2 = Regex.Replace(aux1, "\\n", "");

            string[] sLinea = aux2.Split(' ');

            foreach (string Opera in sLinea)
            {            
                if (Opera == string.Empty)
                {
                    continue;
                }
                a = a + obj_cls_Create_Token_BL.TipoDeToken(Opera) + "\r\n";
            }            
            return a;
        }

        public string CargarErrores(string sTextoError)
        {
            string a;
            a = string.Empty;

                    string[] sPieza = Regex.Split(sTextoError, "\n");

                    foreach (string sTablaTokens in sPieza)
                    {
                        if (sTablaTokens.Contains("Error"))
                        {
                            a = a + sTablaTokens + "\r\n";
                        }
                    }
            return a;
        }
    }
}
