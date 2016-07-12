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
using DALL;
using Microsoft.Reporting.WinForms;
using RecursosHumanos.Consultas;

namespace RecursosHumanos
{
    public partial class Reporte : Form
    {
  

        public Reporte()
        {
            InitializeComponent();
        }
         DbRecursosHumanos db = new DbRecursosHumanos();
        private void BuscarReportebutton_Click(object sender, EventArgs e)
        {
                   
            DatosDataGridView.DataSource = EmpleadoRegistro.Lista();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReViewer re = new ReViewer();
            re.reporteViewer.Reset();
            re.reporteViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            re.reporteViewer.LocalReport.ReportPath = @"C:\Users\juniorsantiago\Desktop\practicandoCapas\Practicando\SegundoParcial-JuniorSantiagoGuillenZ\RecursosHumanos\Reportes\ListarEmpleado.rdlc";

            re.reporteViewer.LocalReport.DataSources.Clear();
            re.reporteViewer.LocalReport.DataSources.Add(

                new ReportDataSource("Empleados",
                   EmpleadoRegistro.Lista())
                   );
            re.reporteViewer.LocalReport.Refresh();
            re.Show();
           
            
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }
    }
}
