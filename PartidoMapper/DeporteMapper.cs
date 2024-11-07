using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace MPP
{
    public class DeporteMapper
    {
        public static Deporte Map(SqlDataReader reader)
        {
            return new Deporte
            {
                IdDeporte = Convert.ToInt32(reader["ID_DEPORTE"]),
                Descripcion = reader["DESCRIPCION"].ToString()
            };
        }
    }
}
