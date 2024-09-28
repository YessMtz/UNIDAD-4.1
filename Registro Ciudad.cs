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

        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-LRR3RR8/sqlexpres; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source =(local); Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source = DESKTOP-D739HSR\\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = True");

       static string conexSql = "server= DESKTOP-D739HSR\\SQLEXPRESS; database= FarmaciasMP; Integrated Security= True";
        SqlConnection Conex = new SqlConnection(conexSql);

        //BOTON GUARDAR
        private void Guardar_P_Click(object sender, EventArgs e)
        { 
            //ABRIENDO CONEXION CON LA BASE DE DAATOS
            Conex.Open();
            string cadena = "insert into regCiudad(idCiudad, ciudadReg, estadoReg, habReg, superReg) values ('"+idCiudad+"', '"+ ciudadReg.Text+"', '"+estadoReg.Text+"', '"+habReg.Text+"', '"+superReg.Text+"')";
            SqlCommand comando = new SqlCommand(cadena, Conex);
            MessageBox.Show("registro guardado con exito");


            
            Conex.Close();

            MessageBox.Show("Registro de Ciudad almacenada correctamente.");

            ciudadReg.Clear();
            estadoReg.Clear();
            habReg.Clear();
            superReg.Clear();
            
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Ciudad_Load(object sender, EventArgs e)
        {

        }

        //BOTON PANTALLA REGISTRO DE CIUDADES
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
            Form Form2 = new RegistroFarmacias();
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

        //BOTON DE SALIR
        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //BOTON PARA ELIMINAR DEL REGISTRO
        private void Eliminar_P_Click(object sender, EventArgs e)
        {
            Conex.Open();
            string EliminarCd = "DELETE FROM regCiudad WHERE idCiudad = "+idCiudad.Text+"";

            SqlCommand DeleteCd = new SqlCommand(EliminarCd, Conex);
            
            
            DeleteCd.ExecuteNonQuery();

            ciudadReg.Clear();
            Conex.Close();
            MessageBox.Show("Registro de Ciudad eliminado correctamente.");

        }

        //BOTON PARA modificar UN REGISTRO EN ESPECIFICO
        private void Buscar_P_Click(object sender, EventArgs e)
        {
            Conex.Open();
            string consulta = "UPDATE regCiudad SET idCiudad =" + idCiudad.Text + "ciudadReg =" + ciudadReg.Text + "estadoReg = " + estadoReg.Text + "habReg ="
                + habReg.Text +"superReg ="+superReg.Text + "superReg=" + superReg.Text + "WHERE idCiudad= "+idCiudad.Text+"";

            SqlCommand comando = new SqlCommand(consulta, Conex);
            int cantidad;
            cantidad = comando.ExecuteNonQuery();

            if(cantidad >0)
            {
                MessageBox.Show("Registro modificado con exito");
            }

            Conex.Close();

            idCiudad.Clear();
            ciudadReg.Clear();
            estadoReg.Clear();
            habReg.Clear();
            superReg.Clear();


        }
    }
}
