using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class PersonaService
    
    {
        PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        Persona persona = new Persona();

        public void CalcularPulsacion(Persona persona)
        {
            if (persona.Sexo.Equals("F") || persona.Sexo.Equals("f"))
            {
                persona.Pulsaciones = (220 - persona.Edad) / 10;
            }
            else
                persona.Pulsaciones = (210 - persona.Edad) / 10;
        }

         public void Guardar(Persona persona)
        {
            personaRepository.Guardar(persona);
        }

        public List<Persona> Consultar()
        {
           return personaRepository.Consultar();

            
        }


    }
}
