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
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e) 
        {

            SqlConnection cn = new SqlConnection(@"Data Source=LOPEZH;Initial Catalog=votaciones;Integrated Security=True");
            cn.Open();



            SqlCommand cm = new SqlCommand("select carnet, contraseña from alumnos where carnet = '" + txtcarnet.Text + "' and contraseña ='" + txtcontra.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("DATOS CORRECTOS", "SESION");

                Form ftres = new Papeleta();
                ftres.Show();
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

