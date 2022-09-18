using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_1
{
    public partial class Form2 : Form
    {
        // fp sendo declarado fora do contrutor, para que seja possivel acessar em qualquer construtor

        Form1 fp;
        public Form2(string v,Form1 txt) //'v' recebe dos dados de textbox2.txt de Form1
        {                                //'txt' conseguimos acessar Todos os componentes de Form1
                                         //os componentes por padrão são private, em propriedades colocar public
            InitializeComponent();       //para que sejam acessiveis por outros fomularios diferentes.
            textBox1.Text = v; // coloca os dados de 'v' em textbox1 no formulario atual
            fp = txt;
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.textBox2.Text = textBox1.Text;
            // com fp conseguimos acessar todos os componentes de Form1 
            
        }
    }
}
