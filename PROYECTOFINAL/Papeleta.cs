using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PROYECTOFINAL
{
    public partial class Papeleta : Form
    {
        
        public Papeleta()
        {
            InitializeComponent();
        }
       /* int c1 = 0;
        int c2 = 0;
        int c3 = 0;
        int c4 = 0;
        int contador = 0;*/

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CentroDeVotaciones_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            cbnombre.Text = "";
            txtcarnet.Text = "";
            txtcarnet.Focus();
        }

        private void btnvotar_Click(object sender, EventArgs e)
        {
            
            

            double carnet = double.Parse(txtcarnet.Text);
            string nombre = cbnombre.Text;
            string candidato = "";
            
            if (rdc1.Checked)
            {
                candidato = rdc1.Text;
            }
            if (rdc2.Checked)
            {
                candidato = rdc2.Text;
            }
            if (rdc3.Checked)
            {
                candidato = rdc3.Text;
            }
            if (rdc4.Checked)
            {
                candidato = rdc4.Text;
            }


            MessageBox.Show("░▒▓█►─═  Voto guardado con éxito ═─◄█▓▒░" + "\n"+"\n" + "𝗖𝗔𝗥𝗡𝗘𝗧:" + carnet+  "\n" +
                "𝗘𝗦𝗧𝗨𝗗𝗜𝗔𝗡𝗧𝗘:" + nombre + "\n" +
                "𝗖𝗔𝗡𝗗𝗜𝗗𝗔𝗧𝗢:" + candidato + "\n");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

       /* private void rdc1_CheckedChanged(object sender, EventArgs e)
        {
            c1 = c1 + 1;
            contador = contador + 1;

            StreamWriter escrito = File.CreateText("D:/PROYECTOFINAL/resultados/resultado.txt");
            string escritoc1 = c1.ToString();
            string salto = (Environment.NewLine);
            string escritoc2 = c2.ToString();
            string salto1 = (Environment.NewLine);
            string escritoc3 = c3.ToString();
            string salto2 = (Environment.NewLine);
            string escritoc4 = c4.ToString();
            string salto3 = (Environment.NewLine);
            string escritocontador = contador.ToString();

            escrito.Write("SOFTWARE: " + escritoc1);
            escrito.Write(salto);
            escrito.Write("LOGISTICA: " + escritoc2);
            escrito.Write(salto1);
            escrito.Write("ELECTRONICA: " + escritoc3);
            escrito.Write(salto2);
            escrito.Write("HARDWARE: " + escritoc4);
            escrito.Write(salto3);
            escrito.Write("TOTAL DE ESTUDIANTES QUE HAN VOTADO HASTA EL MOMENTO: " + escritocontador);

            escrito.Flush();
            escrito.Close();

        }

        private void rdc2_CheckedChanged(object sender, EventArgs e)
        {
            c2 = c2 + 1;
            contador = contador + 1;

            StreamWriter escrito = File.CreateText("D:/PROYECTOFINAL/resultados/resultado.txt");
            string escritoc1 = c1.ToString();
            string salto = (Environment.NewLine);
            string escritoc2 = c2.ToString();
            string salto1 = (Environment.NewLine);
            string escritoc3 = c3.ToString();
            string salto2 = (Environment.NewLine);
            string escritoc4 = c4.ToString();
            string salto3 = (Environment.NewLine);
            string escritocontador = contador.ToString();

            escrito.Write("SOFTWARE: " + escritoc1);
            escrito.Write(salto);
            escrito.Write("LOGISTICA: " + escritoc2);
            escrito.Write(salto1);
            escrito.Write("ELECTRONICA: " + escritoc3);
            escrito.Write(salto2);
            escrito.Write("HARDWARE: " + escritoc4);
            escrito.Write(salto3);
            escrito.Write("TOTAL DE ESTUDIANTES QUE HAN VOTADO HASTA EL MOMENTO: " + escritocontador);

            escrito.Flush();
            escrito.Close();
        }

        private void rdc3_CheckedChanged(object sender, EventArgs e)
        {
            c3 = c3 + 1;
            contador = contador + 1;

            StreamWriter escrito = File.CreateText("D:/PROYECTOFINAL/resultados/resultado.txt");
            string escritoc1 = c1.ToString();
            string salto = (Environment.NewLine);
            string escritoc2 = c2.ToString();
            string salto1 = (Environment.NewLine);
            string escritoc3 = c3.ToString();
            string salto2 = (Environment.NewLine);
            string escritoc4 = c4.ToString();
            string salto3 = (Environment.NewLine);
            string escritocontador = contador.ToString();

            escrito.Write("SOFTWARE: " + escritoc1);
            escrito.Write(salto);
            escrito.Write("LOGISTICA: " + escritoc2);
            escrito.Write(salto1);
            escrito.Write("ELECTRONICA: " + escritoc3);
            escrito.Write(salto2);
            escrito.Write("HARDWARE: " + escritoc4);
            escrito.Write(salto3);
            escrito.Write("TOTAL DE ESTUDIANTES QUE HAN VOTADO HASTA EL MOMENTO: " + escritocontador);

            escrito.Flush();
            escrito.Close();
        }

        private void rdc4_CheckedChanged(object sender, EventArgs e)
        {
            c4 = c4 + 1;
            contador = contador + 1;

            StreamWriter escrito = File.CreateText("D:/PROYECTOFINAL/resultados/resultado.txt");
            string escritoc1 = c1.ToString();
            string salto = (Environment.NewLine);
            string escritoc2 = c2.ToString();
            string salto1 = (Environment.NewLine);
            string escritoc3 = c3.ToString();
            string salto2 = (Environment.NewLine);
            string escritoc4 = c4.ToString();
            string salto3 = (Environment.NewLine);
            string escritocontador = contador.ToString();

            escrito.Write("SOFTWARE: " + escritoc1);
            escrito.Write(salto);
            escrito.Write("LOGISTICA: " + escritoc2);
            escrito.Write(salto1);
            escrito.Write("ELECTRONICA: " + escritoc3);
            escrito.Write(salto2);
            escrito.Write("HARDWARE: " + escritoc4);
            escrito.Write(salto3);
            escrito.Write("TOTAL DE ESTUDIANTES QUE HAN VOTADO HASTA EL MOMENTO: " + escritocontador);

            escrito.Flush();
            escrito.Close();
        }*/
    }
}
