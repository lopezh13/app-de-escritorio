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

namespace PROYECTOFINAL
{
    public partial class admi : Form
    {
        public admi()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LOPEZH;Initial Catalog=votaciones;Integrated Security=True");
            cn.Open();



            SqlCommand cm = new SqlCommand("select carnet, contraseña from usuarioad where carnet = '" + txtcar.Text + "' and contraseña ='" + txtcon.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("DATOS CORRECTOS", "SESION");

                Form fdos = new acciones();
                fdos.Show();
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS", "SESION");
            }



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
