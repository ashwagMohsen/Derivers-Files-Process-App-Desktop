using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BAM_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form4 = new Form1();
            form4.Show();
        }

        private void textBoxProcessName_TextChanged(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            textBoxSourceFile.Text = readfile;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string sourcefile = textBoxSourceFile.Text;
            if (String.IsNullOrEmpty(textBoxSourceFile.Text))
            {
                MessageBox.Show("no path entry please write a bath ");
            }

            else if (sourcefile.Contains('/'))
            {
                MessageBox.Show("wrong syntax !!!");


            }

            else if (!sourcefile.Contains("."))
            {
                MessageBox.Show("wrong syntax !!!");

            }
            else if (!sourcefile.Contains(":"))
            {
                MessageBox.Show("wrong syntax !!!");

            }
            else
            {
                if (File.Exists(sourcefile))
                {
                    MessageBox.Show("file name is already existing");
                }
                else
                {
                    File.Create(sourcefile);
                    MessageBox.Show("the file create successfuly");
                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string sourcefile = textBoxSourceFile.Text;
            if (String.IsNullOrEmpty(textBoxSourceFile.Text))
            {
                MessageBox.Show("no path entry please write a bath ");
            }

            else if (sourcefile.Contains('/'))
            {
                MessageBox.Show("wrong syntax !!!");


            }

            else if (!sourcefile.Contains("."))
            {
                MessageBox.Show("wrong syntax !!!");

            }
            else if (!sourcefile.Contains(":"))
            {
                MessageBox.Show("wrong syntax !!!");

            }
            else
            {
                if (File.Exists(sourcefile))
                {
                    File.Delete(sourcefile);

                    MessageBox.Show("the file deleted successfuly");
                }
                else
                {
                    MessageBox.Show("no file found check your path");
                }
            }
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;
                string desfile = textBoxDestinationFile.Text;
                if (!File.Exists(sourcefile))
                {
                    MessageBox.Show("file not found");
                }
                else
                {
                    File.Move(sourcefile, desfile);
                    MessageBox.Show("the file cut successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            try
            {
                string sourcefile = textBoxSourceFile.Text;
                string desfile = textBoxDestinationFile.Text;
                if (!File.Exists(sourcefile))
                {
                    MessageBox.Show("file not found");
                }
                else
                {
                    File.Copy(sourcefile, desfile);
                    MessageBox.Show("the file copied successfuly");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxSourceFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
