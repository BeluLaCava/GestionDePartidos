using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using PartidoMapper;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class PartidoData
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["PartidosGestionConn"].ConnectionString;

        // Método para guardar un nuevo partido en la base de datos
        public void GuardarPartido(Partido partido)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO PARTIDO 
                        (ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_REGISTRO, FECHA_PARTIDO, MARCADOR_LOCAL, MARCADOR_VISITANTE)
                        VALUES
                        (@IdDeporte, @EquipoLocal, @EquipoVisitante, @FechaRegistro, @FechaPartido, @MarcadorLocal, @MarcadorVisitante)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdDeporte", partido.Deporte.IdDeporte);
                        command.Parameters.AddWithValue("@EquipoLocal", partido.EquipoLocal);
                        command.Parameters.AddWithValue("@EquipoVisitante", partido.EquipoVisitante);
                        command.Parameters.AddWithValue("@FechaRegistro", partido.FechaRegistro);
                        command.Parameters.AddWithValue("@FechaPartido", partido.FechaPartido);
                        command.Parameters.AddWithValue("@MarcadorLocal", partido.MarcadorLocal);
                        command.Parameters.AddWithValue("@MarcadorVisitante", partido.MarcadorVisitante);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el partido: " + ex.Message);
            }
        }

        // Método para obtener todos los partidos de la base de datos, incluyendo la información completa del deporte
        public List<Partido> ObtenerPartidos()
        {
            var listaPartidos = new List<Partido>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            p.ID_PARTIDO, 
                            p.EQUIPO_LOCAL, 
                            p.EQUIPO_VISITANTE, 
                            p.FECHA_REGISTRO, 
                            p.FECHA_PARTIDO, 
                            p.MARCADOR_LOCAL, 
                            p.MARCADOR_VISITANTE,
                            d.ID_DEPORTE, 
                            d.DESCRIPCION AS DeporteDescripcion
                        FROM PARTIDO p
                        JOIN DEPORTE d ON p.ID_DEPORTE = d.ID_DEPORTE";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Usamos el Mapper para llenar el Partido y su objeto Deporte completo
                                listaPartidos.Add(PartidoMapper.PartidoMapper.Map(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los partidos: " + ex.Message);
            }

            return listaPartidos;
        }

        // Método para obtener un partido específico por su ID, incluyendo la información completa del deporte
        public Partido ObtenerPartidoPorId(int idPartido)
        {
            Partido partido = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            p.ID_PARTIDO, 
                            p.EQUIPO_LOCAL, 
                            p.EQUIPO_VISITANTE, 
                            p.FECHA_REGISTRO, 
                            p.FECHA_PARTIDO, 
                            p.MARCADOR_LOCAL, 
                            p.MARCADOR_VISITANTE,
                            d.ID_DEPORTE, 
                            d.DESCRIPCION AS DeporteDescripcion
                        FROM PARTIDO p
                        JOIN DEPORTE d ON p.ID_DEPORTE = d.ID_DEPORTE
                        WHERE p.ID_PARTIDO = @IdPartido";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdPartido", idPartido);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                partido = PartidoMapper.PartidoMapper.Map(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el partido: " + ex.Message);
            }

            return partido;
        }

        // Método para actualizar el marcador de un partido en la base de datos
        public void ActualizarMarcador(Partido partido)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE PARTIDO SET MARCADOR_LOCAL = @MarcadorLocal, MARCADOR_VISITANTE = @MarcadorVisitante WHERE ID_PARTIDO = @IdPartido";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MarcadorLocal", partido.MarcadorLocal);
                        command.Parameters.AddWithValue("@MarcadorVisitante", partido.MarcadorVisitante);
                        command.Parameters.AddWithValue("@IdPartido", partido.IdPartido);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el marcador: " + ex.Message);
            }
        }

        // Método para eliminar un partido de la base de datos por su ID
        public void EliminarPartido(int idPartido)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM PARTIDO WHERE ID_PARTIDO = @IdPartido";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdPartido", idPartido);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el partido: " + ex.Message);
            }
        }
    }
}
