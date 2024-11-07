using BE;
using MPP;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class DeporteData
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PartidosGestionConn"].ConnectionString;

        public List<Deporte> ObtenerDeportes()
        {
            var deportes = new List<Deporte>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ID_DEPORTE, DESCRIPCION FROM DEPORTE";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                deportes.Add(DeporteMapper.Map(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los deportes: " + ex.Message);
            }

            return deportes;
        }
    }
}
