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
    public partial class RegistrarPC : Form
    {
        public RegistrarPC()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String lab = ClienteClioLogic.Logica.Laboratorios();
                char[] del = { '|' };
                char[] del2 = { '|' };                
                string[] words = lab.Split(del);
                Dictionary<string, string> test = new Dictionary<string, string>();
                foreach (String b in words) {
                    String key = "", value = "";
                    string[] c = b.Split(del2);
                    if (c[0] != null) {
                        key = c[0];
                    }
                    if (c[1] != null)
                    {
                        value = c[1];
                    }
                    test.Add(key, value);
                   
                }
                comboBox1.DataSource = new BindingSource(test, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";

                // Get combobox selection (in handler)
                comboBox1.Enabled = true;
               
            }catch(Exception ex){
                MessageBox.Show("Ha ocurrido un error con la conexión al servidor CLIO");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueCmb = ((KeyValuePair<string, string>)comboBox1.SelectedItem).Value;
            MessageBox.Show(valueCmb);
            try
            {
                
                if (textBox1.Text != null && textBox1.Text != "" && valueCmb != null)
                {
                    bool registro=ClienteClioLogic.Logica.registrarPC(textBox1.Text, valueCmb);
                    if(registro)
                         MessageBox.Show("Se registro la pc con exito");
                    else
                        MessageBox.Show("No se registro la pc con exito, verifique el nombre, ip y los laboratorios del sistema");
                    
                }
                else
                {
                    MessageBox.Show("Insertar un Nombre de la PC cliente y escoja un laboratorio");

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un error con la conexión al servidor CLIO");
            }

        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

}
