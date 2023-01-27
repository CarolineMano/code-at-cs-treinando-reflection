using System;
using System.Collections.Generic;
using System.Linq;

namespace code_at_cs_treinando_reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListarPropriedadesEMetodos(1);

            var instancia = InstanciarObjeto<int>();
        }

        public static void ListarPropriedadesEMetodos<T>(T objeto)
        {
            var tipo = objeto.GetType();
            var propriedades = tipo.GetProperties().ToList();
            var metodos = tipo.GetMethods().ToList();

            Console.WriteLine("**Propriedades**");
            foreach (var propriedade in propriedades)
            {
                Console.WriteLine(propriedade.Name);
            }

            Console.WriteLine($"{Environment.NewLine}**Métodos**");
            foreach (var metodo in metodos)
            {
                Console.WriteLine(metodo.Name);
            }
        }

        public static T InstanciarObjeto<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}