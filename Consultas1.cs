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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        //SqlConnection Conex = new SqlConnection("Data Source = DESKTOP-D739HSR\\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = True");
        //SqlConnection Conex = new SqlConnection(@"server = .DESKTOP-D739HSR\\SQLEXPRESS; Initial Catalog = FarmaciasMP; Integrated Security = True");
        static string conexSql = "server= DESKTOP-D739HSR\\SQLEXPRESS; database= FarmaciasMP; Integrated Security= True";
        SqlConnection Conex = new SqlConnection(conexSql);

        //boton para buscar
        private void Buscar_Reg_Click(object sender, EventArgs e)
        {

        }

        //salir de la pantalla
        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //PANTALLA REGISTRO SOCIO
        //Yesseniaa
        private void FormSocio_Click(object sender, EventArgs e)
        {
            Form form1 = new Registro_Propietarios();
            form1.Show();
            this.Hide();
        }

        //pantalla de registro farmacia
        private void FormFarmacia_Click(object sender, EventArgs e)
        {
            Form form2 = new RegistroFarmacias();
            form2.Show();
            this.Hide();
        }

        //PANTALLA REGISTRO MEDICAMENTO
        private void Medicamento_Click(object sender, EventArgs e)
        {
            Form form3 = new Registro_Medicamento();
            form3.Show();
            this.Hide();
        }

        //pantalla registro 
        private void Ciudades_Click(object sender, EventArgs e)
        {
            Form form4 = new Registro_Ciudad();
            form4.Show();
            this.Hide();
        }

        //pantalla consulta
        private void Consulta_Click(object sender, EventArgs e)
        {
            Form form5 = new Consultas();
            form5.Show();
            this.Hide();
        }

        //PANTALLA DE INICIO
        private void bunifuIconButton6_Click(object sender, EventArgs e)
        {
            Form form6 = new Pantalla_Inicio();
            form6.Show();
            this.Hide();
        }
    }
}
