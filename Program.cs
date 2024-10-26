using System;

namespace SortNames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insert names
            string[] firstname = {"Carlos", "Fernanda", "Nicole", "Eduarda", "Manuela", "Constança", "Emilia", "Samanta", "Micael", "Jorge", "Mateus", "Tomás", "Angelo"};
            // ----------------------------------------------------------------------
            string[] lastname = {"Silva", "Almeida", "Ferreira", "Sousa", "Oliveira", "Lima", "Costa", "Piques", "Ribeiro"};        
        

            // Random number generator
            Random random = new Random();

            // Random index numbers for the names
            int xfirstname = random.Next(firstname.Length);
            int xlastname = random.Next(lastname.Length);

            // Getting the random names
            string fnr = firstname[xfirstname];
            string lnr = lastname[xlastname];

            // result
            string bothnames = $"{fnr} {lnr}";
            Console.WriteLine("Random Name: " + bothnames);
        }
    }
}