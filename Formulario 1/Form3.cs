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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void check()
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Carro 1");
            }
        }

        public void CheckStatus()
        {
            if (checkBox1.Checked)
            {
                var result = MessageBox.Show("Tudo certo por aqui", "Titulo", MessageBoxButtons.YesNo);               

                if (result == DialogResult.Yes)
                {
                    label1.Text = "Deu bom";
                }
                else
                {
                    label1.Text = "Deu Ruim";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                var result = MessageBox.Show("Check Tudo ok?", "Tudo certo?", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                  label2.Text = "Aceito";
                }
                else if (result == DialogResult.No)
                {
                    label2.Text = "Nao Aceito";
                }
                else
                {
                    label2.Text = "Cancelado";
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("Gol", true);  // true ou false determina se ele já terao o chekbox selecionado.
            checkedListBox1.Items.Add("Paio", false);
            checkedListBox1.Items.Add("Uno", true);
            checkedListBox1.Items.Add("Fusca", false);
             var txt = checkedListBox1.Items[0]; // por se tratar de uma coleção, tambem podemos referenciar pelo indice manualmente

              // Selecionando e mostrando apenas os itens que estao com checkbox marcado (checkedListBox1.CheckedItems)
              for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
              {
                txt = checkedListBox1.CheckedItems[i];
                label4.Text += txt.ToString()+"\n";
              }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // criando uma lista com para usar no checkListBox1 usando AddRange
            List<string> list = new List<string>();
            list.Add("BARCO");
            list.Add("BIKE");
            list.Add("MOTO");
            list.Add("CHARRETE");
            list.Add("TREM");

            checkedListBox1.Items.AddRange(list.ToArray());
            // AddRange precisa ser uma coleção.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }
    }
}
