using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoListas
{
    public partial class Form1 : Form
    {
        private List<Clases.Estudiante> lista= new List<Clases.Estudiante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clases.Estudiante estudiante = new Clases.Estudiante();
            estudiante.NomreCompleto = this.txtNombreCompleto.Text;
            estudiante.Genero = this.cmbGenero.Text;
            estudiante.EstadoCivil = this.cmdEstadoCivil.Text;
            estudiante.edad = Convert.ToInt32(this.txtEdad.Text);

            lista.Add(estudiante);
            //mostrar los estudiante en el listView
            ListViewItem item = new ListViewItem(estudiante.NomreCompleto);
            listViewEstudiantes.Items.Add(item);
            item.SubItems.Add(estudiante.Genero);
            item.SubItems.Add(estudiante.EstadoCivil);
            item.SubItems.Add(estudiante.edad.ToString());
        }
    }
}
