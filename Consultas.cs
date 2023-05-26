using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UNIDAD_4
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        SqlConnection Conex = new SqlConnection("Data Source = (local); Initial Catalog = FarmaciasMP; Integrated Security = True");

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

        //TABLA REGISTRO PROPIEDAD
            public DataTable ConsultaPropietarios()
        {
            string query = "Select * from RegistroProp";
            SqlCommand instrucciones = new SqlCommand(query, Conex);
            SqlDataAdapter data = new SqlDataAdapter(instrucciones);
            DataTable tablaPropietarios = new DataTable();
            data.Fill(tablaPropietarios);
            return tablaPropietarios;
        }

        //actualizar tabla con los datos
        public void Tabla_Propietarios()
        {
            presentacionConsultas.DataSource = ConsultaPropietarios();
        }

        //TABLA REGISTRO CIUDAD
        public DataTable ConsultaCiudad()
        {
            string registro = "Select * From Registro_Cd";
            SqlCommand instrucciones = new SqlCommand(registro, Conex);
            SqlDataAdapter data = new SqlDataAdapter(instrucciones);
            DataTable tablaCiudad = new DataTable();
            data.Fill(tablaCiudad);
            return tablaCiudad;

        }
    }
}
