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
    public partial class RegistroFarmacias : Form
    {
        public RegistroFarmacias()
        {
            InitializeComponent();
        }
        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-D739HSR\\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source =(local); Initial Catalog = FarmaciasMP; Integrated Security = True");

        //SqlConnection Conex = new SqlConnection("Data Source=.DESKTOP-D739HSR\\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = SSPI");

        static string conexSql = "server= DESKTOP-D739HSR\\SQLEXPRESS; database= FarmaciasMP; Integrated Security= True";
        SqlConnection Conex = new SqlConnection(conexSql);
        //BOTON PARA GUARDAR REGISTROS
        private void Guardar_M_Click(object sender, EventArgs e)
        {
            
            SqlCommand AltaFarmacia = new SqlCommand("Insert into regFarmacia( idFarmacia, idProp, direFarmacia, cdFarmacia, estadoFarmacia, habFarmcia, superFarmacia) values(@idFarmacia, @idProp, @direFarmacia, @cdFarmacia, @estadoFarmacia, @habFarmacia, @superFarmacia)", Conex);

            AltaFarmacia.Parameters.AddWithValue("idFarmacia", idFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("idProp", idProp.Text);
            AltaFarmacia.Parameters.AddWithValue("direFarmacia", direFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("cdFarmacia", cdFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("estadoFarmacia", estadoFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("habFarmacia", habFarmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("superFarmacia", superFarmacia.Text);

            //ABRIENDO CONEXION CON LA BASE DE DAATOS
            Conex.Open();
            //ENVIANDO INFORMACION
            AltaFarmacia.ExecuteNonQuery();
            //CERRANDO CONEXION CON LA BASE DE DATOS
            Conex.Close();
            //MENSAJE DE CONFIRMACION
            MessageBox.Show("FARMACIA ALMACENADA CORRECTAMENTE");

            //LIMPIEZA DE LOS CUADROS DE TEXTO
            idFarmacia.Clear();
            idProp.Clear();
            direFarmacia.Clear();
            cdFarmacia.Clear();
            estadoFarmacia.Clear();
            habFarmacia.Clear();
            superFarmacia.Clear();
        }

        //BOTON PARA modificar REGISTROS
        private void Buscar_M_Click(object sender, EventArgs e)
        {
            Conex.Open();

            string modificar = "UPDATE regFarmacia SET idFarmacia =" + idFarmacia.Text + "', idProp ='" + idProp.Text + "', direFarmacia= '" + direFarmacia.Text + "', cdFarmacia= '" + cdFarmacia.Text + "'estadoFarmacia= '" + estadoFarmacia.Text + "', habFarmacia ='" + habFarmacia.Text + "', superFarmacia ='" + superFarmacia.Text + "', WHERE idFarmacia ='" + idFarmacia.Text + "";
            SqlCommand comando = new SqlCommand(modificar, Conex);
            int cantidad;
            cantidad = comando.ExecuteNonQuery();

            if (cantidad > 0)
            {
                MessageBox.Show("Registro Modificado");
            }

            Conex.Close();

            idFarmacia.Clear();
            idProp.Clear();
            direFarmacia.Clear();
            cdFarmacia.Clear();
            estadoFarmacia.Clear();
            habFarmacia.Clear();
            superFarmacia.Clear();
        }

        //BOTON PARA ELIMINAR REGISTROS
        private void Eliminar_M_Click(object sender, EventArgs e)
        {
            String bajaFarm = "DELETE FROM regFarmacia WHERE idFarmacia ="+idFarmacia.Text+"";
            Conex.Open();
            SqlCommand Instruc = new SqlCommand(bajaFarm, Conex);
            
            Instruc.ExecuteNonQuery();
            
            idFarmacia.Clear();
            Conex.Close();
            MessageBox.Show("Registro de Farmacia eliminada");
        }

        //BOTON PARA SALIR DE LA FORMA
        private void Salir_M_Click(object sender, EventArgs e)
        {
            Close();
        }

        //PANTALLA DE REGISTRO DE PROPIETARIO
        private void Propietario_Click(object sender, EventArgs e)
        {
            Form Form1 = new Registro_Propietarios();
            Form1.Show();
            this.Hide();
        }

        //PANTALLA DE REGISTRO DE FARMACIA
        private void Farmacias_Click(object sender, EventArgs e)
        {
            Form Form2 = new RegistroFarmacias();
            Form2.Show();
            this.Hide();
        }

        //PANTALLA DE REGISTRO MEDICAMENTO
        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form3 = new Registro_Medicamento();
            Form3.Show();
            this.Hide();
        }

        //PANTALLA DE REGISTRO DE CIUDAD
        private void Ciudad_Click(object sender, EventArgs e)
        {
            Form Form4 = new Registro_Ciudad();
            Form4.Show();
            this.Hide();
        }

        //PANTALLA DE REGISTRO DE PANTALLA
        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form5 = new Consultas();
            Form5.Show();
            this.Hide();
        }

        //PANTALLA DE INCIO
        private void Inicio_Click(object sender, EventArgs e)
        {
            Form Form6 = new Pantalla_Inicio();
            Form6.Show();
            this.Hide();
        }
    }
}
