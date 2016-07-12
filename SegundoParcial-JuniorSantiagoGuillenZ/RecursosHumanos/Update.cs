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
using Entidad;

namespace RecursosHumanos
{
    public partial class Update : Form
    {
        int id;
        public Update()
        {
            InitializeComponent();
            id = 0;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
             id = int.Parse(idBuscartextBox.Text);

            string Nombres;
            string Direccion;
            string Telefono;
            string Celular;
            string Cedula;
            string Cargo; 
            string Sueldo;
            string Incentivo;
            using (DbRecursosHumanos db = new DbRecursosHumanos())
            {
                Nombres = db.Empleados.FirstOrDefault(x=>x.IdEmpleado==id).Nombres.ToString() ;
                Direccion = db.Empleados.FirstOrDefault(x => x.IdEmpleado == id).Direccion.ToString();
                 Telefono = db.Empleados.FirstOrDefault(x => x.IdEmpleado == id).Telefono.ToString();
                Celular = db.Empleados.FirstOrDefault(x => x.IdEmpleado == id).Celular.ToString();
                Cedula = db.Empleados.FirstOrDefault(x => x.IdEmpleado == id).Cedula.ToString();
                 Cargo = db.Empleados.FirstOrDefault(x => x.IdEmpleado == id).Cargo.ToString();
                 Sueldo = db.Empleados.FirstOrDefault(x => x.IdEmpleado == id).Sueldo.ToString();
                 Incentivo = db.Empleados.FirstOrDefault(x => x.IdEmpleado == id).Incentivo.ToString();

            }
            NombreUpdtextBox.Text =Nombres;
            DireccionUpdtextBox.Text = Direccion;
            TelefonoUpdtextBox.Text = Telefono;
            CelularUpdtextBox.Text = Telefono;
            CedulaUpdtextBox.Text = Cedula;
            CargoUpdtextBox.Text = Cargo;
            SueldoUpdtextBox.Text = Sueldo;
            IncentivoUpdtextBox.Text = Incentivo;
        
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            EmpleadoRegistro em = new EmpleadoRegistro();

            float sueldo = float.Parse(SueldoUpdtextBox.Text);
            float incentivo = float.Parse(IncentivoUpdtextBox.Text);

            em.Actualizar(id, NombreUpdtextBox.Text, DireccionUpdtextBox.Text, TelefonoUpdtextBox.Text, CelularUpdtextBox.Text, CedulaUpdtextBox.Text, CargoUpdtextBox.Text, sueldo, incentivo);

            MessageBox.Show("Se a Actualizado");
        }
    }
    }

