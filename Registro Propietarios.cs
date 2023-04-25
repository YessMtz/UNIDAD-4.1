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

        SqlConnection Conex = new SqlConnection("server=. ")
        private void Registro_Propietarios_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Farm_Click(object sender, EventArgs e)
        {
            Close(); //cierra la forma
        }
    }
}
