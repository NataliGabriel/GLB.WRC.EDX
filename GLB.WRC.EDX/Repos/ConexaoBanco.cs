using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace GLB.WRC.EDX.Repos
{
    public class ConexaoBanco
    {
        public SqlConnection sqlConnection()
        {
            string ipGlobal = ConfigurationManager.AppSettings["ipConexao"];
            string SenhaGlobal = ConfigurationManager.AppSettings["pass"];
            if (SenhaGlobal == "k")
                SenhaGlobal = "kurumin";
            else
                SenhaGlobal = "S0lut@3e4r";

            return new SqlConnection("Data Source=" + ipGlobal + ";Initial Catalog=SISTEMA_GLOBAL;Persist Security Info=True;User ID=global;Password=" + SenhaGlobal + ";MultipleActiveResultSets=True;Connection Timeout=5");

        }
    }
}
