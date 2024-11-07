using BE;
using System.Data.SqlClient;


namespace PartidoMapper
{
    public class PartidoMapper
    {
        public static Partido Map(SqlDataReader reader)
        {
            return new Partido
            {
                IdPartido = Convert.ToInt32(reader["ID_PARTIDO"]),
                EquipoLocal = reader["EQUIPO_LOCAL"].ToString(),
                EquipoVisitante = reader["EQUIPO_VISITANTE"].ToString(),
                FechaRegistro = Convert.ToDateTime(reader["FECHA_REGISTRO"]),
                FechaPartido = Convert.ToDateTime(reader["FECHA_PARTIDO"]),
                MarcadorLocal = Convert.ToInt32(reader["MARCADOR_LOCAL"]),
                MarcadorVisitante = Convert.ToInt32(reader["MARCADOR_VISITANTE"]),

                // Mapeo de la entidad Deporte
                Deporte = new Deporte
                {
                    IdDeporte = Convert.ToInt32(reader["ID_DEPORTE"]),
                    Descripcion = reader["DeporteDescripcion"].ToString()
                }
            };
        }
    }
}