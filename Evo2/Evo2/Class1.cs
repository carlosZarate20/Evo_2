using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evo2
{
    public class Class1
    {
        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public bool Existe(int a)
        {
            int[] vector = new int[3];

            for (int i = 0; i < 3; i++)
            {
                vector[i] = i + 1;
            }

            for (int i = 0; i < 3; i++)
            {
                if (vector[i] == a)
                    return true;
            }
            return false;
        }

        public string Palabra()
        {
            string pa = "hola";
            return pa;
        }

        public List<int> RetornaLista()
        {
            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(2);
            lista.Add(3);

            return lista;
        }
    }
}