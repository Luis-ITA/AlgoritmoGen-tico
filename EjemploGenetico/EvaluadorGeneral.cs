using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenetico
{
    class EvaluadorGeneral
    {
        public int TamCromosoma;
   
        string Modelo;

        public EvaluadorGeneral(string Modelo)
        {
            this.Modelo = Modelo;

            TamCromosoma = Modelo.Length;
        }

        public int Evaluar(Individuo individuo)
        {
            string cromosoma = individuo.GetCromosoma();
            int contador = 0;

            for (int i = 0; i < cromosoma.Length; i++)
            {
                if (cromosoma[i] == Modelo[i])
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
