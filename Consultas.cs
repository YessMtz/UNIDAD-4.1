using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_4
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSocio_Click(object sender, EventArgs e)
        {
            Form Form1 = new Registro_Propietarios();
            Form1.ShowDialog();
            this.Hide();
        }

        private void FormFarmacia_Click(object sender, EventArgs e)
        {
            Form Form2 = new Registro_Farmacias();
            Form2.ShowDialog();
            this.Hide();
        }

        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form3 = new Registro_Medicamento();
            Form3.ShowDialog();
            this.Hide();
        }

        private void Ciudades_Click(object sender, EventArgs e)
        {
            Form Form4 = new Registro_Ciudad();
            Form4.ShowDialog();
            this.Hide();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Form Form4 = new Consultas();
            Form4.ShowDialog();
            this.Hide();
        }
    }
}
