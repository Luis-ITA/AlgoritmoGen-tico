using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploGenetico
{
    class Individuo
    {
        int Fitness;
        string Cromosoma;

        Random Aleatorio;
        EvaluadorGeneral Evaluador;

        char[] ABC = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q',
                           'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                           'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q','r', 's', 't', 'u', 'v', 'w', 'x',
                            'y', 'z', ' ' , 'Á','É','Í','Ó','Ú','á','é','í', 'ó','ú'};


        public Individuo(EvaluadorGeneral Evaluador, Random Aleatorio)
        {
            this.Evaluador = Evaluador;
            Cromosoma = "";
            this.Aleatorio = Aleatorio;

            for (int i = 0; i < Evaluador.TamCromosoma; i++)
            {
                Cromosoma += ABC [Aleatorio.Next(0, 64)];
            }
        }

        public Individuo(EvaluadorGeneral Evaluador, Random Aleatorio, Individuo Padre, Individuo Madre)
        {
            this.Evaluador = Evaluador;
            this.Aleatorio = Aleatorio;

            int punto_cruzamiento = Aleatorio.Next(Evaluador.TamCromosoma);
            Cromosoma = Padre.Cromosoma.Substring(0, punto_cruzamiento);
            Cromosoma += Madre.Cromosoma.Substring(punto_cruzamiento);
        }

        public int GetFitness()
        {
            Fitness = Evaluador.Evaluar(this);
            return Fitness;
        }
        public string GetCromosoma()
        {
            return Cromosoma;
        }

        public void Mutar(float porcentaje_mutacion)
        {
            double probabilidad_mutacion = porcentaje_mutacion / 100;
            string CromosomaMutado = "";

            for (int i = 0; i < Evaluador.TamCromosoma; i++)
                if (Aleatorio.NextDouble() < probabilidad_mutacion)
                    CromosomaMutado += ABC[Aleatorio.Next(0, 64)];
                else
                    CromosomaMutado += Cromosoma[i];

            Cromosoma = CromosomaMutado;

        }

    }

}
