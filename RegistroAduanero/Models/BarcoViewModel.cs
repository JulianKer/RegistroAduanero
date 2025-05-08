using System.ComponentModel.DataAnnotations;
using RegistroAduanero.Entidades;

namespace RegistroAduanero.Models
{
    public class BarcoViewModel
    {

        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [StringLength(40, ErrorMessage = "Hasta 40 caracteres.")]
        public string _nombre { get; set; }

        [Required(ErrorMessage = "El campo Antiguedad es requerido.")]
        [Range(0, 50, ErrorMessage = "Antiguedad debe ser mayor a 0 y menor a 50.")]
        public int _antiguedad { get; set; }

        [Required(ErrorMessage = "El campo Tripulacion Max. es requerido.")]
        [Range(10, 1000, ErrorMessage = "La Tripulacion Máx. debe ser mayor o igual a 10 y menor a 1000.")]
        public int _tripulacionMax { get; set; }

        public BarcoViewModel() { }
        public BarcoViewModel(string nombre, int antiguedad, int tripulacionMax)
        {
            this._nombre = nombre;
            this._antiguedad = antiguedad;
            this._tripulacionMax = tripulacionMax;
        }


        public Barco MapearseAEntidadBarco()
        {
            return new Barco(this._nombre, this._antiguedad, this._tripulacionMax);
        }
    }
}
