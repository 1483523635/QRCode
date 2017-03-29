using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode;
namespace 二维码生成器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = 1.ToString();
            textBox2.Text = 2.ToString();
            comboBox1.SelectedValue = 0;
            comboBox2.SelectedValue = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string content = richTextBox1.Text==""? "0":richTextBox1.Text;
            string Encode = comboBox1.SelectedItem.ToString();
            string level = comboBox2.SelectedItem.ToString();
            int version = int.Parse(textBox1.Text);
            int size = int.Parse(textBox2.Text);
            //MessageBox.Show(content + " " + Encode + " " + level + " " + version + " " + size);
            getQRCode code=new getQRCode();
         Image image=  code.simpleQRCode(content);
            pictureBox1.Width = image.Width;
            pictureBox1.Height = image.Height;
            pictureBox1.Image = image;
        }

     
    }
}
