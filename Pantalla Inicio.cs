using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_4
{
    public partial class Pantalla_Inicio : Form
    {
        public Pantalla_Inicio()
        {
            InitializeComponent();
        }

        //BOTON PANTALLA SOCIO
        private void FormSocio_Click(object sender, EventArgs e)
        {

            Form Form1 = new Registro_Propietarios();
            Form1.Show();
        }
        //PANTALLA REGISTRO MEDICAMENTO
        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form2 = new Registro_Medicamento();
            Form2.Show();
            this.Hide();
        }

        //PANTALLA REGISTRO DE CIUDADES
        private void Ciudades_Click(object sender, EventArgs e)
        {
            Form Form3 = new Registro_Ciudad();
            Form3.Show();
            this.Hide();
        }

        //PANTALLA DE REGISTRO DE FARMACIAS
        private void FormFarmacia_Click(object sender, EventArgs e)
        {
            Form Fomr4 = new RegistroFarmacias();
            Fomr4.Show();
            this.Hide();
        }

        //PANTALLA DE CONSULTAS 
        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form5 = new Consultas();
            Form5.Show();
            this.Hide();
        }
    }
}
