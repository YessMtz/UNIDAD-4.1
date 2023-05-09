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

        SqlConnection Conex = new SqlConnection(@"Server=.\SQLEXPRESS; Initial Catalog=Farmacias_Basedatos; integrated security=true");
        //  SqlConnection conexionLo = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=biblioteca; Integrated Security=SSPI");

        private void Guardar_P_Click(object sender, EventArgs e)
        {
            SqlCommand AltaFarmacia = new SqlCommand("Insert into Registro_Farmacia(Id_Farmacias, Id_Prop, Farm_Direc, Farm_Cd, Farm_Estado, Farm_Hab, Farm_Sup)", Conex);

            AltaFarmacia.Parameters.AddWithValue("Id_Farmacias", Id_Farmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("Id_Prop", Id_Propietario.Text);
            AltaFarmacia.Parameters.AddWithValue("Farm_Direc", Direccion_Farmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("Farm_Cd", Cd_Farmacia.Text);
            AltaFarmacia.Parameters.AddWithValue("Farm_Estado", Estado.Text);
            AltaFarmacia.Parameters.AddWithValue("Farm_Hab", Hab.Text);
            AltaFarmacia.Parameters.AddWithValue("Farm_Sup", Sup.Text);

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


        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
