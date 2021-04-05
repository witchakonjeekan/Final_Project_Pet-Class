using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Class
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
            Program.pets[Program.count] = new Pet(this.textBox1.Text, this.comboBox1.Text, this.textBox3.Text);
            list_pet.Add(new System.Windows.Forms.Label());
            this.Controls.Add(list_pet[Program.count]);
            list_pet[Program.count].AutoSize = false;
            list_pet[Program.count].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            list_pet[Program.count].Location = new System.Drawing.Point(36, 50 + (36 * (Program.count + 1)) + 10);
            list_pet[Program.count].Name = "label";
            list_pet[Program.count].Size = new System.Drawing.Size(350, 16);
            list_pet[Program.count].TabIndex = 7;
            list_pet[Program.count].Text = Program.pets[Program.count].show();
            Program.count++;

            this.textBox1.Text = "";
            this.textBox3.Text = "";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
