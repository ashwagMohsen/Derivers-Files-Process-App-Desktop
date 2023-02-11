using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace BAM_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listViewProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FormProcess_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Process.Start(Convert.ToString(textBoxProcessName.Text + ".exe"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listProcess();

        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            try
            {
                string item = listViewProcesses.SelectedItems[0].Text;
                foreach (Process p in Process.GetProcessesByName(item))
                {
                    p.Kill();
                }
                listProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listProcess()
        {
            Process[] p = Process.GetProcesses();
            listViewProcesses.Items.Clear();
            foreach (Process p1 in p)
            {

                listViewProcesses.Items.Add(p1.ProcessName).SubItems.Add(p1.Id.ToString());


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBoxProcessName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listProcess();
        }
    }
}
