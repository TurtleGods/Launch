using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LaunchRand
{
    public partial class Form1 : Form
    {
        string path = $@"{System.Environment.CurrentDirectory}\launch.txt";
        public Form1()
        {
            InitializeComponent();
            creatLaunchTxt();
        }


        private void btnRand_Click(object sender, System.EventArgs e)
        {
            refresh();

        }
        private void rand(List<string> _launchLs)
        {
            Random rand = new Random();
            int ans = rand.Next(listbInput.Items.Count);
            MessageBox.Show(_launchLs[ans].ToString());
        }
        private void creatLaunchTxt()
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }

            }

        }
        private void refresh()
        {
            listbInput.Items.Clear();
            StreamReader sr = new StreamReader(path);
            List<string> launchLs = new List<string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                listbInput.Items.Add(line);
                launchLs.Add(line);
            }
            sr.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string add = tbAdd.Text;
            try
            {
                FileStream fsFile = new FileStream(path, FileMode.Append);
                using (StreamWriter sw = new StreamWriter(fsFile))
                {
                    sw.WriteLine(add);
                    sw.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int select = listbInput.SelectedIndex;

        }
    }
}
