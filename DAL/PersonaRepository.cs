using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;

namespace DAL
{
    
    public class PersonaRepository
    {
        private string ruta = "Persona.txt";
        List<Persona> Personas;

        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{ persona.Identificacion}+{ persona.Nombre }+{ persona.Sexo}+{ persona.Edad}+{ persona.Pulsaciones}") ;

            escritor.Close();
            file.Close();

        }

        public List <Persona> Consultar()
        {
            Personas = new List<Persona>();
            string Linea = string.Empty;
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader escritor = new StreamReader(file);
            while ((Linea = escritor.ReadLine())!= null){
                Persona persona = new Persona();
                char delimiter = '+';
                string[] DatosPersona = Linea.Split(delimiter);
                persona.Identificacion = DatosPersona[0];
                persona.Nombre = DatosPersona[1];
                persona.Sexo = DatosPersona[2];
                persona.Edad = Convert.ToInt32(DatosPersona[3]);
                
                persona.Pulsaciones = Convert.ToInt32(DatosPersona[4]);
                Personas.Add(persona);

            }
            escritor.Close();
            file.Close();
            return Personas;

        }

    }

    
}
