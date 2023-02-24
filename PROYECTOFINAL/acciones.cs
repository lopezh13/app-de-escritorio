using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOFINAL
{
    public partial class acciones : Form
    {
        public acciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fc = new Conteo();
            fc.Show();

        }

        /*private void label2_Click(object sender, EventArgs e)
        {
            ac.Text = Database.carnet;
            if (Database.contraseña == "itca12")
            {
                panel1.Visible = true;
            }
        }*/
    }
}
