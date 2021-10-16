using System;
using curzi.lorenzo._5h.PrimoEF.Models;

namespace curzi.lorenzo._5h.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello db-World!");

            // Apro il db
            DbPersone db = new();
            
            //creo delle persone
            for(int i = 0; i < 1000; i++)
            {
                db.Persone.Add(new Persona{Nome = "Lorenzo", Cognome = "Curzi", Email = "lorenzo.curzi@studenti.ittsrimini.edu.it"});
            }

            //salvo le modifiche
            db.SaveChanges();
        }
    }
}
