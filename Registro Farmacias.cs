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
    public partial class Registro_Farmacias : Form
    {
        public Registro_Farmacias()
        {
            InitializeComponent();
        }

        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-LRR3RR8/sqlexpres; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection("Data Source =(local); Initial Catalog = FarmaciasMP; Integrated Security = True");

        SqlConnection Conex = new SqlConnection("Data Source = (local); Initial Catalog = FarmaciasMP; Integrated Security = True");

        private void Guardar_P_Click(object sender, EventArgs e)
        {
            SqlCommand AltaFarmacia = new SqlCommand("Insert into Registro_Farmacia(Id_Farmacias, Id_Prop, Farm_Direc, Ciudad, Estado, Hab, Sup)", Conex);

            AltaFarmacia.Parameters.AddWithValue("Id_Farmacias", Id_Farmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("Id_Prop", Id_Propietario.Text);
            AltaFarmacia.Parameters.AddWithValue("Farm_Direc", Direccion_Farmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("Ciudad", Cd_Farmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("Estado", Estado.Text);
            AltaFarmacia.Parameters.AddWithValue("Hab", Hab.Text);
            AltaFarmacia.Parameters.AddWithValue("Sup", Sup.Text);

            //ABRIENDO CONEXION CON LA BASE DE DAATOS
            Conex.Open();
            //ENVIANDO INFORMACION
            AltaFarmacia.ExecuteNonQuery();
            //CERRANDO CONEXION CON LA BASE DE DATOS
            Conex.Close();
            //MENSAJE DE CONFIRMACION
            MessageBox.Show("FARMACIA ALMACENADA CORRECTAMENTE");

            //LIMPIEZA DE LOS CUADROS DE TEXTO
            Id_Farmacia.Clear();
            Id_Propietario.Clear();
            Direccion_Farmacia.Clear();
            Cd_Farmacia.Clear();
            Estado.Clear();
            Hab.Clear();
            Sup.Clear();
        }

        private void Buscar_P_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_P_Click(object sender, EventArgs e)
        {
            String bajaFarm ="DELETE FROM Registro_Farmacias WHERE Id_Farmacias = @Id_Farmacias";
            Conex.Open();
            SqlCommand Instruc = new SqlCommand(bajaFarm, Conex);
            Instruc.Parameters.Add("Id_Farmacias", Id_Farmacia.Text);
            Instruc.ExecuteNonQuery();
            Instruc.Dispose();
            Instruc = null;
            Id_Farmacia.Clear();
            Conex.Close();
            MessageBox.Show("Registro de Farmacia eliminada");


        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
