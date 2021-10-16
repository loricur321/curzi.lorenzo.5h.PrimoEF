using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

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

        public override string ToString()
        {
            return $"{idPersona}\t{Nome}  {Cognome}  {Email}";
        }
    }
}