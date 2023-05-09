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

        private void FormSocio_Click(object sender, EventArgs e)
        {

            Form Form1 = new Registro_Propietarios();
            Form1.Show();
        }

        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form2 = new Registro_Medicamento();
            Form2.Show();
            this.Hide();
        }

        private void Ciudades_Click(object sender, EventArgs e)
        {
            Form Form3 = new Registro_Ciudad();
            Form3.Show();
            this.Hide();
        }

        private void FormFarmacia_Click(object sender, EventArgs e)
        {
            Form Fomr4 = new Registro_Farmacias();
            Fomr4.Show();
            this.Hide();
        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form5 = new Consultas();
            Form5.Show();
            this.Hide();
        }
    }
}
