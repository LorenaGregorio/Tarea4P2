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
    public partial class ListaForm : Form

    
    {
        private Form1 form1;

        public ListaForm(Form1 form1)
        {
            InitializeComponent();

            //Asignando a la variable form1 el formulario padre

            this.form1 = form1;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var alumno = new Alumno {
                Nombre = textBox2.Text,
                Apellido = textBox3.Text,
                Carne = Convert.ToInt32(textBox1.Text) 

            };
            //linea de codigo para enviar datos al formulario principal
            form1.AgregarAlumnoLista(alumno);
            this.Close();

            
        }













        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
