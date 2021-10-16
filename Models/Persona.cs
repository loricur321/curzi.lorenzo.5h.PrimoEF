using System;
using System.ComponentModel.DataAnnotations;

namespace curzi.lorenzo._5h.PrimoEF.Models
{
    public class Persona
    {
        [Key]
        public int idPersona { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}