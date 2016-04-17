using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cls_Analisis_Lexico_BL;



namespace Cls_Analisis_Lexico_BL
{
    public class Cls_Gramatica_libre_contexto
    {

        #region Variables Globales
        
            Cls_Create_token_BL obj_cls_Create_Token_BL = new Cls_Create_token_BL();

        #endregion

        public String RevisarGramatica(string s_listaTokens)
        {
            string s_resultado = "";

            // reemplazarlo por s_listaTokens
            string temporal = s_listaTokens;
            // Logica

            string[] sPieza = temporal.Split('\n');

            int aux_anterior = 0;
            int aux_siguiente = 0;
            int diferencia = 0;

            for (int i = 0; i < sPieza.Length; i++)
            {
                if (sPieza[i].Contains("Token Fin de Linea") || (sPieza[i].Contains("Error:")))
                {
                    aux_siguiente = i;

                    //Operacion para conocer 
                    if ((aux_anterior != 0) && (aux_siguiente != 0))
                    {
                        diferencia = aux_siguiente - aux_anterior;
                    }

                    if ((diferencia > 3) || (i < 4))//Evaluar la opcion de gramatica 1) LETRAS NUMEROS LETRAS 3 variables
                    {
                        if ((sPieza[i - 3].Contains("Palabra")
                        && sPieza[i - 2].Contains("Numero")
                        && sPieza[i - 1].Contains("Palabra")))
                        {
                            s_resultado += "Gramatica correcta de LNL: " + (i + 1).ToString() + "\n";
                        }
                        else // opcion de gramatica 2) NUMEROS OPERADOR NUMEROS 3 variables
                        if ((sPieza[i - 3].Contains(" Numero")
                            && sPieza[i - 2].Contains("Operador")
                            && sPieza[i - 1].Contains("Numero")))
                        {
                            s_resultado += "Gramatica correcta de NoN: " + (i + 1).ToString() + "\n";
                        }
                    }
                    else
                    if ((diferencia < 3) || (i < 2))// opcion de gramatica 3) PALABRA/LETRAS 1 variable
                    {
                        if ((sPieza[i - 1].Contains("Palabra")))
                        {
                            s_resultado += "Gramatica correcta de L: " + (i + 1).ToString() + "\n";
                        }
                        // opcion de gramatica 4) NUMEROS 1 variable
                        if ((sPieza[i - 1].Contains("Numero")))
                        {
                            s_resultado += "Gramatica correcta de N: " + (i + 1).ToString() + "\n";
                        }
                    }
                    else
                    {
                        s_resultado += "Gramatica Incorrecta: " + (i + 1).ToString() + "\n";
                    }
                }
                aux_anterior = aux_siguiente;
            }
            // enviarl el resultado
            return s_resultado;
        }
    }
}
