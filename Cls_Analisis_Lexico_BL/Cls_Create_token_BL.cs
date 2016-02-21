using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cls_Analisis_Lexico_BL
{
    public class Cls_Create_token_BL
    {
        /*
        TOKENS
        palabra
        numero
        operadores {+,-,*,/,(,),=}        
        */

        // Signo positivo o negativo, Cualquier digito del 0 al 9, al menos una vez
        public static readonly string
            Numero = "[0-9]";
        // Cualquier caracter de la a hasta la z una o mas veces
        public static readonly string
            Palabra = "(?!EOF)[a-z]";
        //Caracter de suma
        public static readonly string
            Suma = "[\\+]";
        //Caracter de resta
        public static readonly string
            Resta = "[\\-]";
        //Caracter de multiplicacion
        public static readonly string
            Multiplicacion = "[\\*]";
        //Caracter de division
        public static readonly string
            Division = "[\\/]";
        //Caracteres de parentesis
        public static readonly string
            Parentesis = "[\\(|\\)]";
        //Caracter de asignacion
        public static readonly string
            Asignacion = "[\\=]";
        //Caracters para fin de archivo
        public static readonly string
            FinArchivo = "[EOF]";
        public static readonly string
            FinLinea = "[\\.]";

        public string TipoDeToken(string sEvaluar)
        {
            string sResultado;

            Match matchPalabra = Regex.Match(sEvaluar, Palabra);
            Match matchNumero = Regex.Match(sEvaluar, Numero);
            Match matchSuma = Regex.Match(sEvaluar, Suma);
            Match matchResta = Regex.Match(sEvaluar, Resta);
            Match matchMultiplicacion = Regex.Match(sEvaluar, Multiplicacion);
            Match matchDivision = Regex.Match(sEvaluar, Division);
            Match matchParentesis = Regex.Match(sEvaluar, Parentesis);
            Match matchAsignacion = Regex.Match(sEvaluar, Asignacion);
            Match matchFinArchivo = Regex.Match(sEvaluar, FinArchivo);
            Match matchFinLinea = Regex.Match(sEvaluar, FinLinea);

            if (matchPalabra.Success)
            {
                sResultado = "Token Palabra: " + sEvaluar;
            }
            else if (matchNumero.Success)
            {
                sResultado = "Token Numero: " + sEvaluar;
            }
            else if (matchSuma.Success)
            {
                sResultado = "Token Suma: " + sEvaluar;
            }
            else if (matchResta.Success)
            {
                sResultado = "Token Resta: " + sEvaluar;
            }
            else if (matchMultiplicacion.Success)
            {
                sResultado = "Token Multiplicacion: " + sEvaluar;
            }
            else if (matchDivision.Success)
            {
                sResultado = "Token Division: " + sEvaluar;
            }
            else if (matchParentesis.Success)
            {
                sResultado = "Token Parentesis: " + sEvaluar;
            }
            else if (matchAsignacion.Success)
            {
                sResultado = "Token Asignacion: " + sEvaluar;
            }
            else if (matchFinArchivo.Success)
            {
                sResultado = "Token Fin Archivo: " + sEvaluar;
            }
            else if (matchFinLinea.Success)
            {
                sResultado = "Token Fin de Linea: " + sEvaluar;
            }
            else
            {
                return "chupe pija";
            }
            return sResultado;
        }


    }
}
