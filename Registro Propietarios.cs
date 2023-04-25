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

        SqlConnection Conex = new SqlConnection("Data Source=. \\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = SSPI ");
           //  SqlConnection conexionLo = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=biblioteca; Integrated Security=SSPI");


        private void Registro_Propietarios_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Farm_Click(object sender, EventArgs e)
        {
            Close(); //cierra la forma
        }

        private void Guardar_Farm_Click(object sender, EventArgs e)
        {
            SqlCommand Altas = new SqlCommand("insert into Registro_Socio(Id_Prop, Nombre, Direccion, Ciudad, Tel)", Conex);
            Altas.Parameters.AddWithValue("Id_Prop", Id_Prop.Text);
            Altas.Parameters.AddWithValue("Nombre", Nombre.Text);
            Altas.Parameters.AddWithValue("Direccion", Direccion.Text);
            Altas.Parameters.AddWithValue("Ciudad", Cd_Prop.Text);
            Altas.Parameters.AddWithValue("Tel", Tel_Prop.Text);

            Conex.Open();
            Altas.ExecuteNonQuery();
            Conex.Close();
            MessageBox.Show("Socio Almacen");
        }
    }
}
