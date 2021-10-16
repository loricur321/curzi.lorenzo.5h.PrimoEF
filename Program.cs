using System;
using System.Linq;
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
            
            // //creo delle persone
            // for(int i = 0; i < 1000; i++)
            // {
            //     db.Persone.Add(new Persona{Nome = "Lorenzo", Cognome = "Curzi", Email = "lorenzo.curzi@studenti.ittsrimini.edu.it"});
            // }

            //Visualizzo l'intero contenuto del db
            foreach(var r in db.Persone)
            {
                Console.WriteLine(r);
            }

            //salvo le modifiche
            db.SaveChanges();

            // var p = db.Persone.First();
            // db.Remove(p);
            db.Persone.RemoveRange(db.Persone);
            db.Persone.Add(new Persona{Nome = "Lorenzo", Cognome = "Curzi", Email = "lorenzo.curzi@studenti.ittsrimini.edu.it"});
            var p = db.Persone.Max(Lorenzo => Lorenzo.idPersona);
            Console.WriteLine(p);
            db.SaveChanges();
        }
    }
}
