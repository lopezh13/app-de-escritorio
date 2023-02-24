
namespace PROYECTOFINAL
{
    partial class Conteo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.votacionesDataSet3 = new PROYECTOFINAL.votacionesDataSet3();
            this.registrovotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registro_votoTableAdapter = new PROYECTOFINAL.votacionesDataSet3TableAdapters.registro_votoTableAdapter();
            this.candidatounoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatodosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatotresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatocuatroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votacionesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrovotoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidatounoDataGridViewTextBoxColumn,
            this.candidatodosDataGridViewTextBoxColumn,
            this.candidatotresDataGridViewTextBoxColumn,
            this.candidatocuatroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registrovotoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(175, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // votacionesDataSet3
            // 
            this.votacionesDataSet3.DataSetName = "votacionesDataSet3";
            this.votacionesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrovotoBindingSource
            // 
            this.registrovotoBindingSource.DataMember = "registro_voto";
            this.registrovotoBindingSource.DataSource = this.votacionesDataSet3;
            // 
            // registro_votoTableAdapter
            // 
            this.registro_votoTableAdapter.ClearBeforeFill = true;
            // 
            // candidatounoDataGridViewTextBoxColumn
            // 
            this.candidatounoDataGridViewTextBoxColumn.DataPropertyName = "candidato_uno";
            this.candidatounoDataGridViewTextBoxColumn.HeaderText = "candidato_uno";
            this.candidatounoDataGridViewTextBoxColumn.Name = "candidatounoDataGridViewTextBoxColumn";
            // 
            // candidatodosDataGridViewTextBoxColumn
            // 
            this.candidatodosDataGridViewTextBoxColumn.DataPropertyName = "candidato_dos";
            this.candidatodosDataGridViewTextBoxColumn.HeaderText = "candidato_dos";
            this.candidatodosDataGridViewTextBoxColumn.Name = "candidatodosDataGridViewTextBoxColumn";
            // 
            // candidatotresDataGridViewTextBoxColumn
            // 
            this.candidatotresDataGridViewTextBoxColumn.DataPropertyName = "candidato_tres";
            this.candidatotresDataGridViewTextBoxColumn.HeaderText = "candidato_tres";
            this.candidatotresDataGridViewTextBoxColumn.Name = "candidatotresDataGridViewTextBoxColumn";
            // 
            // candidatocuatroDataGridViewTextBoxColumn
            // 
            this.candidatocuatroDataGridViewTextBoxColumn.DataPropertyName = "candidato_cuatro";
            this.candidatocuatroDataGridViewTextBoxColumn.HeaderText = "candidato_cuatro";
            this.candidatocuatroDataGridViewTextBoxColumn.Name = "candidatocuatroDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(667, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "SALIR ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ac
            // 
            this.ac.AutoSize = true;
            this.ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac.ForeColor = System.Drawing.Color.White;
            this.ac.Location = new System.Drawing.Point(379, 54);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(310, 25);
            this.ac.TabIndex = 18;
            this.ac.Text = "CONTEO TOTAL DE VOTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 67);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Conteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Conteo";
            this.Text = "Conteo";
            this.Load += new System.EventHandler(this.Conteo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votacionesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrovotoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private votacionesDataSet3 votacionesDataSet3;
        private System.Windows.Forms.BindingSource registrovotoBindingSource;
        private votacionesDataSet3TableAdapters.registro_votoTableAdapter registro_votoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatounoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatodosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatotresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatocuatroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ac;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}