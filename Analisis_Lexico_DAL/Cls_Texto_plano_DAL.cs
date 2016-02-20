using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Analisis_Lexico_DAL
{
    public class Cls_Texto_plano_DAL
    {
        #region Variables de la clase tipada para archivos de texto plano

        // Data table para cargar los datos de la lista al gridview
        private DataTable _dtTokens;

        #endregion

        #region Constructores
        public DataTable DtTokens
        {
            get
            {
                return _dtTokens;
            }

            set
            {
                _dtTokens = value;
            }
        }

        #endregion
    }
}
