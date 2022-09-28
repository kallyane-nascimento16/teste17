using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncadastro_Click(object sender, EventArgs e)
        {
            pessoa obs=new pessoa();
            obs.nome=textBox3.Text;
            obs.endereco=textBox2.Text;
            obs.cpf=int.Parse(textBox1.Text);
            
            listBox1.Items.Add(obs);
            listBox1.Items.Add("DADOS :");
            listBox1.Items.Add("nome do usuario :" +obs.nome); 
            listBox1.Items.Add("o endereço do usuario :" +obs.endereco);
            listBox1.Items.Add("o CPF do usuario :" + obs.cpf);

        }
    }
}
