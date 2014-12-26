using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VagrantGUI
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            findVagrantDir();
        }

        private void findVagrantDir()
        {
            vagrantFinder.ShowDialog();

            if (vagrantFinder.SelectedPath != vagrantFinder.RootFolder.ToString() && vagrantFinder.SelectedPath != "")
            {
                var result = MessageBox.Show("Are you sure this is the correct folder?\n\n" + vagrantFinder.SelectedPath, "Verify Directory", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {                    
                    //verified
                    this.Close();

                    //write dir
                    System.IO.File.WriteAllText(@"./vagrant_dir.txt", vagrantFinder.SelectedPath);

                    //restart
                    Application.Restart();
                }
                else
                {
                    //re-select
                    findVagrantDir();
                }
            }
        }
    }
}
