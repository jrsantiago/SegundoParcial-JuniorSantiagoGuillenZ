using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALL;
using Entidad;
using BLL;

namespace RecursosHumanos
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EliminartextBox.Text);
            EmpleadoRegistro em = new EmpleadoRegistro();

            em.Eliminar(id);

            MessageBox.Show("Se A eliminado");

        }
    }
}
