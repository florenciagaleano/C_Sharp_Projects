using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Archivos
{
    public static class DAO
    {
        private static string conexion = Properties.Settings.Default.KeyDB;

        public static bool Leer()
        {
            return true;
        }

        public static bool Guardar()
        {
            return true;
        }
    }
}
