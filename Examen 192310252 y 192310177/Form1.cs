using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_192310252_y_192310177
{
    public partial class Form1 : Form
    {
        Graphics papel;
        int Ancho = 462;
        int Alto = 284;
        public Form1()
        {
            InitializeComponent();
            papel = pictureBox1.CreateGraphics();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {

            Dibujo_Figura ObjF = new Dibujo_Figura();
            ObjF.DibujarF(ref papel, Alto, Ancho);
        }

        private void lblAutores_Click(object sender, EventArgs e)
        {
            //Abre un nuevo formulario
            Form Formulario1 = new Autores();
            Formulario1.Show();
            //Mensaje de derechos de autor
            MessageBox.Show("Gracias Por Utilizar Nuestro Programa.", "Copyright Oficial ©:");
        }
    }
}
