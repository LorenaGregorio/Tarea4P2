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
    public partial class Colas : Form
    {
        private Form1 form1;

        public Colas(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
        }

        private void Colas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alumno2 = new Alumno
            {
                Nombre = textBox2.Text,
                Apellido = textBox3.Text,
                Carne = Convert.ToInt32(textBox1.Text)

            };
            //linea de codigo para enviar datos al formulario principal
            form1.AgregarAlumnoColas(alumno2);
            this.Close();
        }
    }
}
