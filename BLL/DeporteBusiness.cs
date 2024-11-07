using DAL;
using BE;

namespace BLL
{
    public class DeporteBusiness
    {
        private readonly DeporteData deporteData = new DeporteData();

        public List<Deporte> ObtenerDeportes()
        {
            // Obtiene todos los deportes completos de la base de datos
            return deporteData.ObtenerDeportes();
        }
    }
}
