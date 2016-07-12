using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entidad;
using DALL;
using RecursosHumanos.Consultas;

namespace RecursosHumanos
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Eliminar el = new Eliminar();
            el.Show();
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            Update u = new Update();
            u.Show();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {          
          EmpleadoRegistro em = new EmpleadoRegistro();
         
            try
            {
                IniciodataGridView.DataSource = EmpleadoRegistro.Lista();
               
            catch (Exception) { MessageBox.Show("Id Incorrecto");}
           
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.recursosHumanosDataSet.Empleados);

        }

        private void Reportebutton_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
