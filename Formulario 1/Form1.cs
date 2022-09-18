using System.ComponentModel;

namespace Formulario_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + textBox1.Text;
            textBox1.Focus(); 
        }

        private void button2_Click(object sender, EventArgs e)
        { 
             Form2 form2 = new Form2(textBox2.Text,this); //TextBox1 como parametro ao clicar, o parametro this
             form2.ShowDialog();                          //significa que terei acesso a classe toda em Form2
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}