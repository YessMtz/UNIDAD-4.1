using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UNIDAD_4
{
    public partial class Registro_Propietarios : Form
    {
        public Registro_Propietarios()
        {
            InitializeComponent();
        }

        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-LRR3RR8/sqlexpres; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source =(local); Initial Catalog = FarmaciasMP; Integrated Security = True");

        SqlConnection Conex = new SqlConnection("Data Source = (local); Initial Catalog = FarmaciasMP; Integrated Security = True");

        private void Registro_Propietarios_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Farm_Click(object sender, EventArgs e)
        {
            Close(); //cierra la forma
        }

        private void Guardar_Farm_Click(object sender, EventArgs e)
        {
           
        }

        //BOTON GUARDAR PARA ALMACENAR EN LA BASE DE DATOS
        private void Guardar_P_Click(object sender, EventArgs e)
        {
            //DECLARACION DE ALTA PARA LA BASE DE DATOS
            SqlCommand Altas = new SqlCommand("insert into RegistroProp(Id_Prop, Nombre, Direccion, Ciudad, Tel)", Conex);
            
            //ASIGNACION DE CADA VARIABLE BASEDATOS, TEXTBOX
            Altas.Parameters.AddWithValue("Id_Prop", Id_Prop.Text);
            Altas.Parameters.AddWithValue("Nombre", Nombre.Text);
            Altas.Parameters.AddWithValue("Direccion", Direccion.Text);
            Altas.Parameters.AddWithValue("Ciudad", Cd_Prop.Text);
            Altas.Parameters.AddWithValue("Tel", Tel_Prop.Text);

            //se abre la conexion con la base de datos
            Conex.Open();
            //se captura los valores en la base de datos
            Altas.ExecuteNonQuery();
            //se cierra la conexion
            Conex.Close();

            //mensaje de socio almancenado
            MessageBox.Show("Socio Almacenado");
            
            //se limpian los textbox para un nuevo almacenamiento
            Id_Prop.Clear();
            Nombre.Clear();
            Direccion.Clear();  
            Cd_Prop.Clear();
            Tel_Prop.Clear();

        }
        //BOTON PARA SALIR
        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Eliminar_P_Click(object sender, EventArgs e)
        {
            string baja = "DELETE FROM RegistroProp WHERE Id_Prop = @Id_Prop";
            Conex.Open();
            SqlCommand cmdInstr = new SqlCommand(baja, Conex);
            cmdInstr.Parameters.Add("Id_Prop", Id_Prop.Text);
            cmdInstr.ExecuteNonQuery();
            cmdInstr.Dispose();
            cmdInstr = null;
            Id_Prop.Clear();
            Conex.Close();
            MessageBox.Show("Registro Eliminado");
        }
       
        private void Buscar_P_Click(object sender, EventArgs e)
        {
            string buscar = "SELECT FROM RegistroProp WHERE Id_Prop = @Id_Prop";
            Conex.Open();
            SqlCommand nuevaBusqueda = new SqlCommand(buscar, Conex);
            nuevaBusqueda.Parameters.AddWithValue("Id_Prop", Id_Prop.Text);
            SqlDataReader leerB = nuevaBusqueda.ExecuteReader();
            MessageBox.Show(Convert.ToString(leerB));
            Conex.Close();
        }        
        
        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form2 = new Consultas();
            Form2.Show();
            this.Hide();
        }

        private void FormFarmacia_Click(object sender, EventArgs e)
        {
            Form Form3 = new Registro_Farmacias();
            Form3.Show();
            this.Hide();
        }

        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form4 = new Registro_Medicamento();
            Form4.Show();   
            this.Hide();
        }

        private void Ciudades_Click(object sender, EventArgs e)
        {
            Form Form5 = new Registro_Ciudad();
            Form5.Show();
            this.Hide();
        }

        private void FormSocio_Click(object sender, EventArgs e)
        {
            Form Form1 = new Registro_Propietarios();
            Form1.Show();
            this.Hide();
        }

        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            Form Form6 = new Pantalla_Inicio();
            Form6.Show();
            this.Hide();
        }


    }
}
