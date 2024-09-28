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
    public partial class Registro_Medicamento : Form
    {
        public Registro_Medicamento()
        {
            InitializeComponent();
        }

        //BASE DE DATOS CONEXION

        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-LRR3RR8/sqlexpres; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source =(local); Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source = DESKTOP-D739HSR\\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-D739HSR\\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = True");
        static string conexSql = "server= DESKTOP-D739HSR\\SQLEXPRESS; database= FarmaciasMP; Integrated Security= True";
        SqlConnection Conex = new SqlConnection(conexSql);

        //BOTON PARA GUARDAR MEDICAMENTO
        private void Guardar_M_Click(object sender, EventArgs e)
        {
             //se abre la conexion con la base de datos
            Conex.Open();
            
            //Valores para cada variable
            SqlCommand AltasMed = new SqlCommand("INSERT in to regMedicamento (idMedi, comercialMedi, genericoMedi, similarMedi, precioMedi, descripMedi)");

            AltasMed.Parameters.AddWithValue("idMedi", idMedi.Text);
            AltasMed.Parameters.AddWithValue("ComercialMedi", nomComercial.Text);
            AltasMed.Parameters.AddWithValue("genericoMedi", genericomedi.Text);
            AltasMed.Parameters.AddWithValue("similarMedi", similarMedi.Text);
            AltasMed.Parameters.AddWithValue("precioMedi", precioMedi.Text);
            AltasMed.Parameters.AddWithValue("descrioMedi", descripcionMedi.Text);

            //se captura los valores en la base de datos
            AltasMed.ExecuteNonQuery();
            //se cierra la conexion
            Conex.Close();

            //mensaje de socio almancenado
            MessageBox.Show("Socio Almacenado");

            //se limpian los textbox para un nuevo almacenamiento
            idMedi.Clear();
            nomComercial.Clear();
            genericomedi.Clear();
            similarMedi.Clear();
            precioMedi.Clear();
            descripcionMedi.Clear();

        }

        //BOTON PARA CERRAR LA FORMA
        private void Salir_M_Click(object sender, EventArgs e)
        {
            Close();
        }

        //BOTONES DEL MENU
        //REGISTRO DE PROPIETARIOS
        private void bunifuIconButton1_Click(object sender, EventArgs e)
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

        //REGISRO DE FARMACIAS
        private void Farmacias_Click(object sender, EventArgs e)
        {
            Form Form2 = new RegistroFarmacias();
            Form2.Show();
            this.Hide();
        }

        //REGISTRO DE MEDICAMENTO
        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form Form3 = new Registro_Medicamento();
            Form3.Show();
            this.Hide();
        }

        //REGISTRO DE CIUDAD
        private void Ciudad_Click(object sender, EventArgs e)
        {
            Form Form4 = new Registro_Ciudad();
            Form4.Show();
            this.Hide();
        }

        //REGISTRO CONSULTAS
        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form5 = new Consultas();
            Form5.Show();
            this.Hide();
        }

        //BOTON ELIMINAR DATOS DE LA BASE DE DATOS
        private void Eliminar_M_Click(object sender, EventArgs e)
        {
            Conex.Open();
            
            string bajaMedi = "DELETE FROM regMedicamento WHERE idMedicamento = "+idMedi.Text+"";
            
            SqlCommand cmdBorrar = new SqlCommand(bajaMedi, Conex);
            cmdBorrar.ExecuteNonQuery();
            
            idMedi.Clear();

            Conex.Close();
            MessageBox.Show("Medicamento Eliminado");

        }

        private void Registro_Medicamento_Load(object sender, EventArgs e)
        {

        }

        //BOTON PARA BUSCAR
        private void Buscar_M_Click(object sender, EventArgs e)
        {

        }

        //boton para modificar un registro
        private void modificar_Click(object sender, EventArgs e)
        {
            Conex.Open();
            string consulta = "UPDATE regMedicamento SET idMedi =" +idMedi.Text+ "comercialMed = '" + nomComercial.Text + "'genericoMedi'" 
                + genericomedi.Text+"'similarMedi'" +similarMedi.Text+ "'precioMedi'" +precioMedi.Text+ "'descripMedi'" +descripcionMedi.Text+ "'WHERE idMedi='" +idMedi.Text+"";
            SqlCommand comando = new SqlCommand(consulta, Conex);
            int cantidad;
            cantidad = comando.ExecuteNonQuery();

            if (cantidad > 0)
            {
                MessageBox.Show("Registro modificado con exito");
            }

            Conex.Close();

            idMedi.Clear();
            nomComercial.Clear();
            genericomedi.Clear();
            similarMedi.Clear();
            precioMedi.Clear();
            descripcionMedi.Clear();
        }
    }
}
