using RegistroAduanero.Entidades;

namespace RegistroAduanero.Servicios
{

    public interface IServicioBarcos
    {
        List<Barco> ObtenerBarcos();
        void RegistrarBarco(Barco nuevoBarco);
    }
    public class ServicioBarcos : IServicioBarcos
    {
        public static List<Barco> misBarcos { get; set; } = new List<Barco>();
        // lista static de resultados o usar los mismos barcos
        
        public List<Barco> ObtenerBarcos()
        {
            return ServicioBarcos.misBarcos;
        }

        public void RegistrarBarco(Barco nuevoBarco)
        {
            nuevoBarco._tasa = (nuevoBarco._antiguedad * 0.25) + (nuevoBarco._tripulacionMax / 3);
            nuevoBarco._idBarco = (ServicioBarcos.misBarcos.Count() + 1);

            ServicioBarcos.misBarcos.Add(nuevoBarco);
        }
    }
}
