using Constructor.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {

        List<Alumno> ListaAlumno = new List<Alumno>();

        List<Alumno> ListaAlumno2 = new List<Alumno>();

        List<Alumno> ListaAlumno3 = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();


        }

        //aqui se crearo las vistas de la lista 
        public void AgregarAlumnoLista(Alumno alumno)
        {

            ListaAlumno.Add(alumno);
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaAlumno;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();

        }

        //aqui se crearo las vistas de la cola
        public void AgregarAlumnoColas(Alumno alumno2)
        {

            ListaAlumno2.Add(alumno2);
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaAlumno2;
            dataGridView2.DataSource = bs;
            dataGridView2.Refresh();

        }


        //aqui se crearo las vistas de la pilas
        public void AgregarAlumnoPilas(Alumno alumno3)
        {

            ListaAlumno3.Add(alumno3);
            BindingSource bs = new BindingSource();
            bs.DataSource = ListaAlumno3;
            dataGridView3.DataSource = bs;
            dataGridView3.Refresh();

        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //este es el enlace para el formulario de pilas

            using (Pilas pilas = new Pilas(this))
            {
                pilas.ShowDialog();
            }

        }

       

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //este es el enlace para el formulario colas
            using (Colas colas  = new Colas (this))
            {
                colas.ShowDialog();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (ListaForm Lista = new ListaForm(this))
            {
                Lista.ShowDialog();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
