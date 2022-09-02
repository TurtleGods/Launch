using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LaunchRand
{
    public partial class Form1 : Form
    {
        string path = $@"{System.Environment.CurrentDirectory}\launch.txt";
        enum TxtMode
        {
            add, delete,
        }
        public Form1()
        {
            InitializeComponent();
            creatLaunchTxt();
            refresh();
        }


        private void btnRand_Click(object sender, System.EventArgs e)
        {
            rand();

        }
        private void rand()
        {
            Random rand = new Random();
            int ans = rand.Next(listbInput.Items.Count);
            MessageBox.Show(listbInput.Items[ans].ToString());
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
            UpdateTxt(TxtMode.add);
            refresh();
            tbAdd.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listbInput.Items.Remove(listbInput.SelectedItem);
            UpdateTxt(TxtMode.delete);
        }
        private void UpdateTxt(TxtMode _mode)
        {
            try
            {
                FileStream fsFile = null;

                switch (_mode)
                {
                    case TxtMode.add:

                        fsFile = new FileStream(path, FileMode.Append);
                        break;
                    case TxtMode.delete:
                        fsFile = new FileStream(path, FileMode.Create);
                        break;
                    default:
                        break;
                }
                using (StreamWriter sw = new StreamWriter(fsFile))
                {
                    if (_mode == TxtMode.add)
                    {
                        sw.WriteLine(tbAdd.Text);
                    }
                    else if (_mode == TxtMode.delete)
                    {
                        foreach (var _line in listbInput.Items)
                        {
                            sw.WriteLine(_line);
                        }
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
