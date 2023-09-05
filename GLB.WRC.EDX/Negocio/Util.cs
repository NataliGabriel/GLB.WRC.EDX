using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio
{
    public static class Util
    {
        public static string FormatoData (DateTime? dateTime)
        {
            if (dateTime != null)
            {
                DateTime formatar = (DateTime)dateTime;
                return formatar.ToString("yyyyMMdd"); 
            }
            return "";
        }
        public static string FormatoValor (double? valor, int numeroCasas)
        {
            if (valor != null)
            {
                string formato = $"0:0.".PadRight(numeroCasas, '#');
                return String.Format("{" + formato + "}", valor);
            }
            return "";
        }
       
        
    }
}
