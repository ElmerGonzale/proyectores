using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresEnMemoriaService : IProyectoresService
    {
        private static List<Proyector> _proyectores = LoadData();
        public void AddProyector(Proyector proyector)
        {
            if (proyector != null) {
            _proyectores.Add(proyector);
            }
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _proyectores;
        }

        private static List<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();
            {
                proyectores.Add(new Proyector()
                {
                    Id = 1,
                    Marca = "Epson",
                    Modelo = "PowerLite X49",
                    NumeroDeSerie = "981130",
                    Situacion = SituacionProyector.Bueno,
                    FechaDeAlta = DateTime.Now
                });
                proyectores.Add(new Proyector()
                {
                    Id = 2,
                    Marca = "Samsung",
                    Modelo = "SM X49",
                    NumeroDeSerie = "189267",
                    Situacion = SituacionProyector.Regular,
                    FechaDeAlta = DateTime.Now
                });
                proyectores.Add(new Proyector()
                {
                    Id = 3,
                    Marca = "Epson",
                    Modelo = "Smart x50",
                    NumeroDeSerie = "165289",
                    Situacion = SituacionProyector.Bueno,
                    FechaDeAlta = DateTime.Now
                });
                proyectores.Add(new Proyector()
                {
                    Id = 4,
                    Marca = "LG",
                    Modelo = "LiGa RX",
                    NumeroDeSerie = "764190",
                    Situacion = SituacionProyector.Malo,
                    FechaDeAlta = DateTime.Now
                });
                proyectores.Add(new Proyector()
                {
                    Id = 5,
                    Marca = "Epson",
                    Modelo = "Light 34",
                    NumeroDeSerie = "172693",
                    Situacion = SituacionProyector.Regular,
                    FechaDeAlta = DateTime.Now
                });
            }
            return proyectores;

        }
    }
}
