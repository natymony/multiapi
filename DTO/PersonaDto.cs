﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.DTO
{
    public class PersonaDto
    {
        [Key]
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}
