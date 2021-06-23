using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenetico
{
    class Poblacion
    {
        List<Individuo> Individuos;
        List<Individuo> IndividuosSeleccionados;
        Random Aleatorio;
        EvaluadorGeneral Evaluador;

        public Poblacion(int tam, string modelo)
        {
            Individuos = new List<Individuo>();
            Aleatorio = new Random();
            Evaluador = new EvaluadorGeneral(modelo);
            for (int i = 0; i < tam; i++)
            {
                Individuos.Add(new Individuo(new EvaluadorGeneral(modelo), Aleatorio));
            }
        }

        public string GetCromosomaYFitness()
        {
            StringBuilder datos = new StringBuilder();

            for (int i = 0; i < Individuos.Count; i++)
            {
                datos.Append(Individuos[i].GetCromosoma() + "   " + Individuos[i].GetFitness() + "\n");
            }

            return datos.ToString();
        }


        public string Seleccion(float presion)
        {
            int cant_seleccionados = (int)Math.Round((100.0 - presion) * Individuos.Count / 100);

            StringBuilder info = new StringBuilder();

            Individuo individuo_aux;

            for (int a = 1; a < Individuos.Count; a++)
            {
                for (int b = 0; b < Individuos.Count -1 ; b++)
                {
                    if (Individuos[b].GetFitness() < Individuos[b + 1].GetFitness())
                    {
                        individuo_aux = Individuos[b];
                        Individuos[b] = Individuos[b + 1];
                        Individuos[b + 1] = individuo_aux;
                    }
                }
            }

            IndividuosSeleccionados = new List<Individuo>();

            for (int i = 0; i < cant_seleccionados; i++)
            {
                IndividuosSeleccionados.Add(Individuos[i]);
            }

            for (int i = 0; i < IndividuosSeleccionados.Count; i++)
            {
                info.Append(Individuos[i].GetCromosoma() + "   " + Individuos[i].GetFitness() + "\n");
            }

            return info.ToString();

        }

        public void Cruzamiento()
        {
            int num_hijos = Individuos.Count - IndividuosSeleccionados.Count;
            int indice_madre;
            int indice_padre;

            for (int i = 0; i < num_hijos; i++)
            {
                indice_padre = Aleatorio.Next(IndividuosSeleccionados.Count);
                indice_madre = Aleatorio.Next(IndividuosSeleccionados.Count);

                Individuos[IndividuosSeleccionados.Count + i] = new Individuo(Evaluador, Aleatorio, IndividuosSeleccionados[indice_padre], IndividuosSeleccionados[indice_madre]);
            }
        }

        public void Mutacion(float porcentaje_mutacion)
        {
            for (int i = 0; i < Individuos.Count; i++)
            {
                Individuos[i].Mutar(porcentaje_mutacion);
            }

        }

    }
}
