using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClienteClioView
{
    public partial class Mensaje : Form        
    {
        private  String mensaje_servidor;
        public Mensaje(String mensajeserver)
        {
            mensaje_servidor = mensajeserver;
            InitializeComponent();
            label1.Text = mensaje_servidor;
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mensaje_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
