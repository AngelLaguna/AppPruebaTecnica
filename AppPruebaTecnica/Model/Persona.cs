//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppPruebaTecnica.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public Nullable<System.DateTime> FNacimiento { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> Telefono { get; set; }
    }
}