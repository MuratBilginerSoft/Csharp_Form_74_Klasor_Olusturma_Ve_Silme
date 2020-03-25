using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Klasör_Oluşturma_Ve_Silme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(@"C:\");
            comboBox1.Items.Add(@"D:\");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Klasör Oluşturulacak Dizini Seçin veya Manual Giriş Yapın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                if (textBox2.Text == "")
                {
                    MessageBox.Show("Lütfen Klasör İsmini Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (comboBox1.Text != "")
                    {
                        Directory.CreateDirectory(comboBox1.Text + textBox2.Text);
                    }

                    else
                    {
                        Directory.CreateDirectory(textBox1.Text + textBox2.Text);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Klasör Oluşturulacak Dizini Seçin veya Manual Giriş Yapın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (comboBox1.Text != "")
                {
                    Directory.Delete(comboBox1.Text + textBox2.Text);
                }

                else
                {
                    Directory.Delete(textBox1.Text + textBox2.Text);
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
