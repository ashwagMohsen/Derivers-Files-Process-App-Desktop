using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BAM_1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        DriveInfo[] allDrives = DriveInfo.GetDrives();
      
        private void loadDrivers()
        {
            listViewDir.Items.Clear();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    ListViewItem item1 = new ListViewItem(d.RootDirectory.ToString());
                    item1.SubItems.Add(d.DriveFormat.ToString());
                    item1.SubItems.Add(d.AvailableFreeSpace.ToString());
                    item1.SubItems.Add(d.TotalFreeSpace.ToString());
                    item1.SubItems.Add(d.TotalSize.ToString());
                    listViewDir.Items.Add(item1);
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listViewDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string[] fileArray = Directory.GetDirectories(listViewDir.SelectedItems[0].Text);

            for (int i = 0; i < fileArray.Length; i++)
            {

                listView1.Items.Add(fileArray[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadDrivers();
        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadDrivers();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
