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

        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-D739HSR\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source =(local); Initial Catalog = FarmaciasMP; Integrated Security = True");

        //SqlConnection Conex = new SqlConnection("server=DESKTOP-D739HSR\\SQLEXPRESS; database = FarmaciasMP; Integrated Security = True");

        //SqlConnection Conex = new SqlConnection(@"Database= .DESKTOP-D739HSR\\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = True");

        static string conexSql = "server= DESKTOP-D739HSR\\SQLEXPRESS; database= FarmaciasMP; Integrated Security= True";
        SqlConnection Conex = new SqlConnection(conexSql);

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
            //se abre la conexion con la base de datos
            Conex.Open();
            string consulta = "INSERT INTO regProp VALUES(" + idProp.Text + ", '" + nombreProp.Text + "', '" + direccionProp + "', '" + cdProp.Text + "', '" + telProp.Text + "', '" + emailProp.Text + "', '";

            //se captura los valores en la base de datos
            SqlCommand comando = new SqlCommand(consulta, Conex);
            comando.ExecuteNonQuery();

           

            //mensaje de socio almancenado
            MessageBox.Show("Socio Almacenado");
             //se cierra la conexion
            Conex.Close();
            //se limpian los textbox para un nuevo almacenamiento
            idProp.Clear();
            nombreProp.Clear();
            direccionProp.Clear();  
            cdProp.Clear();
            telProp.Clear();
            emailProp.Clear();

        }
        //BOTON PARA SALIR
        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //BOTON PARA ELIMINAR LA BASE DE DATOS
        private void Eliminar_P_Click(object sender, EventArgs e)
        {
            Conex.Open();
            
            string baja = "DELETE FROM regProp WHERE idProp =" +idProp.Text+"";
            
            SqlCommand cmdInstr = new SqlCommand(baja, Conex);

            cmdInstr.ExecuteNonQuery();

            idProp.Clear();
            Conex.Close();

            MessageBox.Show("Registro Eliminado");
        }
       
        //BOTON PARA modificar EN LA BASE DE DATOS
        private void Buscar_P_Click(object sender, EventArgs e)
        {
            Conex.Open();

            string buscar = "UPDATE regProp SET idProp =" + idProp.Text + ", nombreProp= '" + nombreProp.Text + "', direccionProp='" + direccionProp.Text + "', ciudadProp='" + cdProp.Text + "', telProp'" + telProp.Text + "', emailProp ='" + emailProp.Text + "' WHERE idProp ='" + idProp.Text + "";
            
            SqlCommand nuevaBusqueda = new SqlCommand(buscar, Conex);
            int cant;
            cant = nuevaBusqueda.ExecuteNonQuery();

            if(cant >0 )
            {
                MessageBox.Show("Registro Modificado");
                    
            }
            Conex.Close();

            idProp.Clear();
            nombreProp.Clear();
            direccionProp.Clear();
            cdProp.Clear();
            telProp.Clear();
            emailProp.Clear();
        }        
        
        //REGISTRO CONSULTAS 
        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form2 = new Consultas();
            Form2.Show();
            this.Hide();
        }

        //PANTALLA REGISTRO FARMACIA
        private void FormFarmacia_Click(object sender, EventArgs e)
        {
            Form Form3 = new RegistroFarmacias();
            Form3.Show();
            this.Hide();
        }

        //PANTALLA REGISTRO MEDICAMENTO
        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form4 = new Registro_Medicamento();
            Form4.Show();   
            this.Hide();
        }

        //PANTALLA REGISTRO CIUDADES
        private void Ciudades_Click(object sender, EventArgs e)
        {
            Form Form5 = new Registro_Ciudad();
            Form5.Show();
            this.Hide();
        }

        //PANTALLA REGISTRO SOCIO
        private void FormSocio_Click(object sender, EventArgs e)
        {
            Form Form1 = new Registro_Propietarios();
            Form1.Show();
            this.Hide();
        }

        //PANTALLA DE INICIO
        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            Form Form6 = new Pantalla_Inicio();
            Form6.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
