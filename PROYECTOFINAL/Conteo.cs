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
    public partial class Conteo : Form
    {
        public Conteo()
        {
            InitializeComponent();
        }

        private void Conteo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'votacionesDataSet3.registro_voto' Puede moverla o quitarla según sea necesario.
            this.registro_votoTableAdapter.Fill(this.votacionesDataSet3.registro_voto);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
