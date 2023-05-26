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

        //SqlConnection Conex = new SqlConnection(@"Server=.\SQLEXPRESS; Initial Catalog=Farmacias_Basedatos; integrated security=true");
        //  SqlConnection conexionLo = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=biblioteca; Integrated Security=SSPI");

        SqlConnection Conex = new SqlConnection("Data Source = (local); Initial Catalog = FarmaciasMP;Integrated Security = True");

        //BOTON GUARDAR
        private void Guardar_P_Click(object sender, EventArgs e)
        {
            //declaracion del comando para agregar a la tabla
            SqlCommand AltaCiudad = new SqlCommand("Insert into Registro_Cd(Ciudad, Estado, Hab, Sup)", Conex);
            AltaCiudad.Parameters.AddWithValue("Ciudad", Ciudad.Text);
            AltaCiudad.Parameters.AddWithValue("Estado", Estado.Text);
            AltaCiudad.Parameters.AddWithValue("Hab", Hab.Text);
            AltaCiudad.Parameters.AddWithValue("Sup", Sup.Text);

            //ABRIENDO CONEXION CON LA BASE DE DAATOS
            Conex.Open();
            AltaCiudad.ExecuteNonQuery();
            Conex.Close();

            MessageBox.Show("Registro de Ciudad almacenada correctamente.");

            Ciudad.Clear();
            Estado.Clear();
            Hab.Clear();
            Sup.Clear();
            
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

        //BOTON SOCIO
        private void FormSocio_Click(object sender, EventArgs e)
        {
            Form Form1 = new Registro_Propietarios();
            Form1.Show();
                this.Hide();
        }

        //BOTON FARMACIAS
        private void FormFarmacia_Click(object sender, EventArgs e)
        {
            Form Form2 = new Registro_Farmacias();
            Form2.Show();
            this.Hide();
        }

        //BTON MEDICAMENTO
        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form3 = new Registro_Medicamento();
            Form3.Show();
            this.Hide();
        }

        //BOTON PARA CONSULTAS
        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form4 = new Consultas();
            Form4.Show();
            this.Hide();
        }

        //BOTON PANTALLA DE INICIO
        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            Form Form5 = new Pantalla_Inicio();
            Form5.Show();
            this.Hide();
        }

        //BOTON DE SALID
        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Eliminar_P_Click(object sender, EventArgs e)
        {
            string EliminarCd = "DELETE FROM Regristro_Cd WHERE Ciudad = @Ciudad";
            Conex.Open();
            SqlCommand DeleteCd = new SqlCommand(EliminarCd, Conex);
            DeleteCd.Parameters.Add("Ciudad", Ciudad.Text);
            DeleteCd.ExecuteNonQuery();
            DeleteCd.Dispose();
            DeleteCd = null;
            Ciudad.Clear();
            Conex.Close();
            MessageBox.Show("Registro de Ciudad eliminado correctamente.");

        }
    }
}
