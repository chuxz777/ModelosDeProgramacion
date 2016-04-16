using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cls_Analisis_Lexico_BL;



namespace Cls_Analisis_Lexico_BL
{
    class Cls_Gramatica_libre_contexto
    {

        #region Variables Globales
        
            Cls_Create_token_BL obj_cls_Create_Token_BL = new Cls_Create_token_BL();

        #endregion

        public String RevisarGramatica(string s_listaTokens)
        {
            string s_resultado = "";

            // reemplazarlo por s_listaTokens
            string temporal = "Token Numero: 8 Token Suma: +  \n Token Numero: 5 \n Token Fin de Linea: .\n Error: Final de archivo sin código EOF.\n";
            // Logica

            string[] sPieza = temporal.Split('\n');

            for (int i = 0; i < sPieza.Length; i++)
            {
                if ((sPieza[i].Contains("Token Fin de Linea")| (sPieza[i].Contains("Error:"))))
                {
                    int i_posicion = i;

                    // leer toda la linea del texto y  Evaluar la 
                    // opcion de gramatica 1 LETRAS NUMEROS LETRAS 3 variables
                    if ((sPieza[i_posicion - i_posicion].Contains("Token Palabra:")
                        & sPieza[i_posicion - 1].Contains("Token Numero:")
                        & sPieza[i_posicion].Contains("Token Palabra:")))
                        {
                           s_resultado = "Gramatica correcta de las lineas hasta la "+ i_posicion.ToString();
                        }
                    // opcion de gramatica 2 NUMEROS OPERADOR NUMEROS 3 variables
                    if ((sPieza[i_posicion - i_posicion].Contains("Token Numero:")
                        & sPieza[i_posicion - 1].Contains("Token Operador:")
                        & sPieza[i_posicion].Contains("Token Numero:")))
                    {
                        s_resultado = "Gramatica correcta de las lineas hasta la " + i_posicion.ToString();
                    }

           /// aca la logica seria diferente solo una pocicion y la siguiente sea un final de linea
                    // opcion de gramatica 3 LETRAS 1 variable
                    if ((sPieza[i_posicion - 1].Contains("Token Palabra:")))
                    {
                        s_resultado = "Gramatica correcta de la linea" + i_posicion.ToString();
                    }
                    // opcion de gramatica 4 NUMEROS 1 variable
                    if ((sPieza[i_posicion - 1].Contains("Token Numero:")))
                    {
                        s_resultado = "Gramatica correcta de la lineas" + i_posicion.ToString();
                    }
                }
            }
            //// enviarl el resultado
            return s_resultado;
        }
    }
}
