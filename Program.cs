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
            int middlename = random.Next(lastname.Length);
            do
            {
                middlename = random.Next(lastname.Length);
            } while (middlename == xlastname);
            

            // Getting the random names
            string fnr = firstname[xfirstname];
            string lnr = lastname[xlastname];
            string mnr = lastname[middlename];

            // result
            string allnames = $"{fnr} {lnr} {mnr}";
            Console.WriteLine("Random Name: " + allnames);
        }
    }
}