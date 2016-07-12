using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.Consultas
{
    public partial class ReViewer : Form
    {
        public ReViewer()
        {
            InitializeComponent();
        }

        private void ReViewer_Load(object sender, EventArgs e)
        {

            this.reporteViewer.RefreshReport();
        }
    }
}
