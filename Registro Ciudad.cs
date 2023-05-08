using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIDAD_4
{
    public partial class Registro_Ciudad : Form
    {
        public Registro_Ciudad()
        {
            InitializeComponent();
        }

        SqlConnection Conex = new SqlConnection(@"Server=.\SQLEXPRESS; Initial Catalog=Farmacias_Basedatos; integrated security=true");
        //  SqlConnection conexionLo = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=biblioteca; Integrated Security=SSPI");
        
        //BOTON GUARDAR
        private void Guardar_P_Click(object sender, EventArgs e)
        {
            //declaracion del comando para agregar a la tabla
            SqlCommand AltaCiudad = new SqlCommand("Insert into RegistroCd()");
            AltaCiudad.Parameters.AddWithValue();
            
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Ciudad_Load(object sender, EventArgs e)
        {

        }

        private void Ciudades_Click(object sender, EventArgs e)
        {
            Form Form0 = new Registro_Ciudad();
            Form0.Show();
            this.Hide();
        }

        private void FormSocio_Click(object sender, EventArgs e)
        {
            Form Form1 = new Registro_Propietarios();
            Form1.Show();
                this.Hide();
        }

        private void FormFarmacia_Click(object sender, EventArgs e)
        {
            Form Form2 = new Registro_Farmacias();
            Form2.Show();
            this.Hide();
        }

        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form3 = new Registro_Medicamento();
            Form3.Show();
            this.Hide();
        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form4 = new Consultas();
            Form4.Show();
            this.Hide();
        }

        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            Form Form5 = new Pantalla_Inicio();
            Form5.Show();
            this.Hide();
        }

        
    }
}
