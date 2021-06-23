using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploGenetico
{
    public partial class Form1 : Form
    {
        Poblacion LaPoblacion;
        int Generaciones;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Inicio_Click(object sender, EventArgs e)
        {
            LaPoblacion = new Poblacion((int)NUD_Poblacion.Value, TB_Funcion.Text);

            RTB_Poblacion.Text = LaPoblacion.GetCromosomaYFitness();

            BTN_Seleccion.Enabled = true;
            BTN_Inicio.Enabled = false;

        }

        private void BTN_Cruzar_Click(object sender, EventArgs e)
        {
            LaPoblacion.Cruzamiento();

            RTB_Cruzamiento.Text = LaPoblacion.GetCromosomaYFitness();

            BTN_Cruzar.Enabled = false;
            BTN_Mutar.Enabled = true;

        }

        private void BTN_Mutar_Click(object sender, EventArgs e)
        {
            LaPoblacion.Mutacion((float)NUD_Mutar.Value);

            RTB_Mutados.Text = LaPoblacion.GetCromosomaYFitness();

            RTB_Poblacion.Text = LaPoblacion.GetCromosomaYFitness();

            BTN_Seleccion.Enabled = true;
            BTN_Mutar.Enabled = false;

            Generaciones++;

            LABEL_Generaciones.Text = Generaciones.ToString();
        }

        private void BTN_Seleccion_Click(object sender, EventArgs e)
        {
            RTB_NuevaPoblacion.Text = LaPoblacion.Seleccion((float)NUD_Presion.Value);
            BTN_Seleccion.Enabled = false;
            BTN_Cruzar.Enabled = true;
        }
    }
}
