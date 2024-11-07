using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class PartidoBusiness
    {
        private readonly PartidoData partidoData = new PartidoData();

        // Lista para almacenar partidos en el borrador
        private List<Partido> borradorPartidos = new List<Partido>();

        // Método para agregar un partido al borrador
        public void AgregarPartidoAlBorrador(Partido partido)
        {
            // Validación antes de agregar al borrador
            if (string.IsNullOrEmpty(partido.EquipoLocal) || partido.EquipoLocal.Length <= 5)
                throw new Exception("El equipo local no puede estar vacío y debe tener más de 5 caracteres.");

            if (string.IsNullOrEmpty(partido.EquipoVisitante) || partido.EquipoVisitante.Length <= 5)
                throw new Exception("El equipo visitante no puede estar vacío y debe tener más de 5 caracteres.");

            if (partido.FechaPartido < DateTime.Now)
                throw new Exception("La fecha del partido no puede ser menor a la fecha actual.");

            if (partido.Deporte == null || partido.Deporte.IdDeporte <= 0)
                throw new Exception("Debe seleccionarse un deporte válido.");

            // Asignación de valores automáticos
            partido.FechaRegistro = DateTime.Now;
            partido.MarcadorLocal = 0;
            partido.MarcadorVisitante = 0;

            // Agregar partido al borrador
            borradorPartidos.Add(partido);
        }

        // Método para limpiar el borrador
        public void LimpiarBorrador()
        {
            borradorPartidos.Clear();
        }

        // Método para guardar todos los partidos en el borrador en la base de datos
        public void GuardarBorrador()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    // Guardar cada partido en el borrador en la base de datos
                    foreach (var partido in borradorPartidos)
                    {
                        partidoData.GuardarPartido(partido);
                    }

                    // Completa la transacción
                    scope.Complete();

                    // Limpiar el borrador después de guardar
                    LimpiarBorrador();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar los partidos en borrador: " + ex.Message);
                }
            }
        }

        // Método para guardar un partido directamente (sin pasar por el borrador)
        public void GuardarPartido(Partido partido)
        {
            try
            {
                // Validaciones de negocio para el alta de un nuevo partido
                if (string.IsNullOrEmpty(partido.EquipoLocal) || partido.EquipoLocal.Length <= 5)
                {
                    throw new Exception("El equipo local no puede estar vacío y debe tener más de 5 caracteres.");
                }

                if (string.IsNullOrEmpty(partido.EquipoVisitante) || partido.EquipoVisitante.Length <= 5)
                {
                    throw new Exception("El equipo visitante no puede estar vacío y debe tener más de 5 caracteres.");
                }

                if (partido.FechaPartido < DateTime.Now)
                {
                    throw new Exception("La fecha del partido no puede ser menor a la fecha actual.");
                }

                if (partido.Deporte == null || partido.Deporte.IdDeporte <= 0)
                {
                    throw new Exception("Debe seleccionarse un deporte válido.");
                }

                // Asignación de valores automáticos
                partido.FechaRegistro = DateTime.Now;
                partido.MarcadorLocal = 0;
                partido.MarcadorVisitante = 0;

                // Guardar partido en la base de datos a través de `DAL`
                partidoData.GuardarPartido(partido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el partido: " + ex.Message);
            }
        }

        // Método para obtener todos los partidos, incluyendo el objeto `Deporte`
        public List<Partido> ObtenerPartidos()
        {
            try
            {
                // Obtiene la lista completa de partidos, incluyendo el objeto `Deporte`
                return partidoData.ObtenerPartidos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los partidos: " + ex.Message);
            }
        }

        // Método para obtener un partido específico por su ID, incluyendo el objeto `Deporte`
        public Partido ObtenerPartidoPorId(int idPartido)
        {
            try
            {
                // Recupera un partido completo, incluyendo el objeto `Deporte`
                return partidoData.ObtenerPartidoPorId(idPartido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el partido: " + ex.Message);
            }
        }

        // Método para actualizar el marcador de un partido
        public void ActualizarMarcador(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            try
            {
                // Recupera el partido actual
                Partido partido = ObtenerPartidoPorId(idPartido);

                if (partido == null)
                {
                    throw new Exception("El partido con el ID especificado no existe.");
                }

                // Validación de la fecha para actualización del marcador
                if (partido.FechaPartido.Date != DateTime.Now.Date)
                {
                    throw new Exception("Solo puedes modificar el marcador de partidos que se juegan hoy.");
                }

                if (marcadorLocal < 0 || marcadorVisitante < 0)
                {
                    throw new Exception("El marcador no puede ser menor a cero.");
                }

                partido.MarcadorLocal = marcadorLocal;
                partido.MarcadorVisitante = marcadorVisitante;

                // Actualiza el marcador en la base de datos a través de `DAL`
                partidoData.ActualizarMarcador(partido);
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
                partidoData.EliminarPartido(idPartido);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el partido: " + ex.Message);
            }
        }
    }
}