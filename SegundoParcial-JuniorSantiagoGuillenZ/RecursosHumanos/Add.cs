using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using BLL;
using DALL;

namespace RecursosHumanos
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            EmpleadoRegistro em = new EmpleadoRegistro();

            float sueldo = float.Parse(SueldoAddtextBox.Text);
            float incentivo = float.Parse(IncentivotextBox.Text);
            em.Crear(NombreAddtextBox.Text, DireccionAddtextBox.Text, TelefonoAddtextBox.Text, CelularAddtextBox.Text, CedulaAddtextBox.Text, CargoAddtextBox.Text, sueldo, incentivo);

            MessageBox.Show("Se A guardado");
            
        }
    }
}
