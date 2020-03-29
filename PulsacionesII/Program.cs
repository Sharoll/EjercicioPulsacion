using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using BLL;

namespace PulsacionesII
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            PersonaService personaService = new PersonaService();
            
            Console.WriteLine("Digite su identificacion: ");
            persona.Identificacion = Console.ReadLine();

            Console.WriteLine("Digite su Nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.WriteLine("Digite su edad: ");
            persona.Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite su sexo: ");
            persona.Sexo = Console.ReadLine();
            personaService.CalcularPulsacion(persona);
            personaService.Guardar(persona);

            Console.WriteLine($"El usuario {persona.Nombre}con identificación {persona.Identificacion} tiene pulsaciones de:{persona.Pulsaciones}");

            

            List<Persona> Personas;
            Personas = new List<Persona>();

            Personas = personaService.Consultar();

            foreach (Persona persona1  in Personas )
            {
                Console.WriteLine($"\nIdentificacion: {persona1.Identificacion} \nNombre: {persona1.Nombre}  \nEdad: {persona1.Edad} \nSexo: {persona1.Sexo} \nPulsaciones: {persona1.Pulsaciones}\n");


            }

            Console.ReadKey();
        }
    }
}
