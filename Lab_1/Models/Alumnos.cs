using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Lab_1.Models
{
    public class Alumnos : BaseModel

    {
        #region Popiedades
        [Key]
        public int AlumnoId { get; set; }
        [Required (ErrorMessage ="Nombre is requerired")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Apellido is requerired")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Edad is requerired")]
        public int Edad { get; set; }
        [Required(ErrorMessage = "Carnet is requerired")]
        public string Carnet { get; set; }
        [Required(ErrorMessage = "CantidadMaterias is requerired")]
        public int CantidadMaterias { get; set; }
        [Required(ErrorMessage = "Ciclo is requerired")]
        public int Ciclo { get; set; }
        [Required(ErrorMessage = "FechaNacimiento is requerired")]
        public DateTime FechaNacimiento { get; set; }
        [NotMapped]
        public string NombreCompleto { get; set; }

        #endregion Propiedades

        #region Constructor
        public Alumnos() {
            FechaNacimiento = DateTime.Now.Date;
            IsActive = true;
            Created = DateTime.Now;
            CreatedBy = "ADMIN";
        }

        public Alumnos( string nombres, int edad, string apellidos, DateTime fechanacimiento)
        {
            Nombres = nombres;
            Edad = edad;
            Apellidos = apellidos;
            FechaNacimiento = fechanacimiento;
            NombreCompleto = $"{Nombres} {Apellidos}";
        }

     
        #endregion Constructor 

        #region Funciones
      

        public bool EsMayorDeEdad()
        {
            return Edad > 18; 
        }
        #endregion Funciones

    }
}
