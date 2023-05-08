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

        SqlConnection Conex = new SqlConnection(@"Server=.\SQLEXPRESS; Initial Catalog=Farmacias_Basedatos; integrated security=true");
        //  SqlConnection conexionLo = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=biblioteca; Integrated Security=SSPI");

        //BOTON PARA GUARDAR MEDICAMENTO
        private void Guardar_M_Click(object sender, EventArgs e)
        {
            //Valores para cada variable
            SqlCommand AltasMed = new SqlCommand("INSERT in to Registro_Medicamento (Id_Medicamento, Comercial_Name, Generic_Name, Similar, Precio)");

            AltasMed.Parameters.AddWithValue("Id_Medicamento", Id_Med.Text);
            AltasMed.Parameters.AddWithValue("Comercial_Name", Nom_Comercial.Text);
            AltasMed.Parameters.AddWithValue("Generic_Name", Generico.Text);
            AltasMed.Parameters.AddWithValue("Similar", Similares.Text);
            AltasMed.Parameters.AddWithValue("Precio", Precio.Text);

            //se abre la conexion con la base de datos
            Conex.Open();
            //se captura los valores en la base de datos
            AltasMed.ExecuteNonQuery();
            //se cierra la conexion
            Conex.Close();

            //mensaje de socio almancenado
            MessageBox.Show("Socio Almacenado");

            //se limpian los textbox para un nuevo almacenamiento
            Id_Med.Clear();
            Nom_Comercial.Clear();
            Generico.Clear();
            Similares.Clear();
            Precio.Clear();



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

        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            Form Form6 = new Pantalla_Inicio();
            Form6.Show();
            this.Hide();
        }

        private void Farmacias_Click(object sender, EventArgs e)
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

        private void Ciudad_Click(object sender, EventArgs e)
        {
            Form Form4 = new Registro_Ciudad();
            Form4.Show();
            this.Hide();
        }

        private void Consultas_Click(object sender, EventArgs e)
        {
            Form Form5 = new Consultas();
            Form5.Show();
            this.Hide();
        }

        private void Eliminar_M_Click(object sender, EventArgs e)
        {
            string bajaMedi = "DELETE FROM Registro_Medicamento WHERE Id_Medicamento";
            Conex.Open();
            SqlCommand cmdInstru = new SqlCommand(bajaMedi, Conex);
            cmdInstru.Parameters.Add("Id_Medicamento", Id_Med.Text);
            cmdInstru.ExecuteNonQuery();
            cmdInstru.Dispose();
            cmdInstru = null;
            Id_Med.Clear();

            Conex.Close();
            MessageBox.Show("Medicamento Eliminado");

        }
    }
}
