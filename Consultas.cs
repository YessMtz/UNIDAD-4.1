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

        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-LRR3RR8/sqlexpres; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source =(local); Initial Catalog = FarmaciasMP; Integrated Security = True");

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

        //ACTULIZACION DE LOS DATOS CIUDAD
        public void Tabla_Ciudad()
        {
            presentacionConsultas.DataSource = ConsultaCiudad();
        }

        //TABLA REGISTRO MEDICAMENTOS
        public DataTable ConsultaMedicamentos()
        {

            string registro = "Select * From Registro_Medicamentos";
            SqlCommand instrucciones = new SqlCommand(registro, Conex);
            SqlDataAdapter data = new SqlDataAdapter(instrucciones);
            DataTable tablaMedicamentos = new DataTable();
            data.Fill(tablaMedicamentos);
            return tablaMedicamentos;

        }

        public void Tabla_Medicamentos()
        {
            presentacionConsultas.DataSource = ConsultaMedicamentos();
        }

        //TABLA REGISTRO FARMACIAS
        public DataTable ConsultaFarmacias()
        {
            string  registro = "Select * From Registro_Farmacias";
            SqlCommand instrucciones = new SqlCommand(registro, Conex);
            SqlDataAdapter data = new SqlDataAdapter(instrucciones);
            DataTable tablaFarmacias = new DataTable();
            data.Fill(tablaFarmacias);
            return tablaFarmacias;
        }

        public void Tabla_Farmacias()
            {
            presentacionConsultas.DataSource = ConsultaFarmacias();
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Reg_Click(object sender, EventArgs e)
        {
            string opcion= Convert.ToString(comboBox1.SelectedItem);
            if (opcion == "1(Propietarios)")
            {
                ConsultaPropietarios();
            }

            else if (opcion == "2(Ciudad)")
            {
                ConsultaCiudad();
            }

            else if (opcion == "2(Medicamentos)")
            {
                ConsultaMedicamentos();
            }
            else if (opcion == "4(Farmacias)")
            {
                ConsultaFarmacias();
            }

        }
    }
}
