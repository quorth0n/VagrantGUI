using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VagrantGUI
{
    public partial class Main : Form
    {
        string vagrantdir;
        /**
         * -1 = not created
         * 0 = off
         * 1 = on
         * */
        int status;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //splash
            var splash = new Splash();
            splash.Show();

            //init
            if (!System.IO.File.Exists("./vagrant_dir.txt"))
            {
                var welcome = new WelcomePage();
                welcome.Show();

                //buttonPanel.Visible = false;
            }
            else
            {
                vagrantdir = System.IO.File.ReadAllText(@"./vagrant_dir.txt");

                var folders = System.IO.Directory.GetDirectories(vagrantdir);

                splash.progress.Increment(10);
                //@10

                foreach (string foldername in folders)
                {
                    var addedButton = new TextBox();
                    addedButton.Text = foldername.Split('\\')[foldername.Split('\\').Length - 2];
                    addedButton.AutoSize = true;
                    addedButton.Parent = buttonPanel;
                    addedButton.Anchor = AnchorStyles.Left;
                    addedButton.ReadOnly = true;
                    //get status
                    if (executeCommand("vagrant status").Contains("not created"))
                    {
                        status = -1;
                    }
                    else if (executeCommand("vagrant status").Contains("running"))
                    {
                        status = 1;
                    }
                    else if (executeCommand("vagrant status").Contains("poweroff"))
                    {
                        status = 0;
                    }

                    splash.progress.Increment(50);
                    //@60

                    //status img
                    var addedStatus = new PictureBox();
                    addedStatus.SizeMode = PictureBoxSizeMode.Zoom;
                    addedStatus.Parent = buttonPanel;
                    addedStatus.Anchor = AnchorStyles.None;

                    //set img
                    switch (status)
                    {
                        case -1:
                            addedStatus.Image = global::VagrantGUI.Properties.Resources.Circle_Grey;
                            statusToolStrip.SetToolTip(addedStatus, "Not Yet Created");
                            break;
                        case 0:
                            addedStatus.Image = global::VagrantGUI.Properties.Resources.Circle_Red;
                            statusToolStrip.SetToolTip(addedStatus, "Off");
                            break;
                        case 1:
                            addedStatus.Image = global::VagrantGUI.Properties.Resources.Circle_Green;
                            statusToolStrip.SetToolTip(addedStatus, "Running");
                            break;
                    }

                    int namingnumber = 0;
                    addedStatus.Name = "status" + namingnumber++;

                    splash.progress.Increment(20);
                    //@80

                    //action btn
                    var addedActions = new Button();
                    addedActions.Text = "...";
                    addedActions.Parent = buttonPanel;
                    addedActions.Anchor = AnchorStyles.None;
                    addedActions.Font = new Font("Arial", 25);
                    addedActions.AutoSize = true;
                    addedActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                    addedActions.TextAlign = ContentAlignment.TopCenter;
                    addedActions.Click += addedActions_Click;

                    splash.progress.Increment(20);
                    //@100... woo-hoo. :/
                    //close da splash
                    splash.Close();
                }
            }


        }

        private void addedActions_Click(object sender, EventArgs e)
        {
            actions.Show(System.Windows.Forms.Cursor.Position);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            executeCommand("vagrant up");
            refresh();
        }

        private string executeCommand(string command)
        {
            this.Cursor = Cursors.WaitCursor;
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe");
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardInput = true;

            process = Process.Start(processInfo);
            using (StreamWriter sw = process.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd " + vagrantdir);
                    sw.WriteLine(command);
                }
            }
            process.WaitForExit();


            // *** Read the streams ***
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exitCode = process.ExitCode;

            console.AppendText((String.IsNullOrEmpty(output) ? "(none)" : output));
            console.AppendText("\n ERROR: \n" + (String.IsNullOrEmpty(error) ? "(none)" : error));

            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
            process.Close();

            this.Cursor = Cursors.Default;
            return output;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            executeCommand("vagrant halt");
            refresh();
        }

        private void destroyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            executeCommand("vagrant destroy --force");
            refresh();
        }

        private void sSHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            executeCommand("vagrant ssh");
            refresh();
        }

        private void refresh()
        {
            this.Cursor = Cursors.WaitCursor;
            MessageBox.Show("run1");
            if (executeCommand("vagrant status").Contains("not created"))
            {
                status = -1;
            }
            else if (executeCommand("vagrant status").Contains("running"))
            {
                status = 1;
            }
            else if (executeCommand("vagrant status").Contains("poweroff"))
            {
                status = 0;
            }

 
            foreach (Control c in buttonPanel.Controls)
            {
                MessageBox.Show(c.GetType().ToString());
                if (c is PictureBox)
                {
                    MessageBox.Show("run3");
                    switch (status)
                        {
                            case -1:
                                ((PictureBox)c).Image = global::VagrantGUI.Properties.Resources.Circle_Grey;
                                statusToolStrip.SetToolTip(((PictureBox)c), "Not Yet Created");
                                break;
                            case 0:
                                ((PictureBox)c).Image = global::VagrantGUI.Properties.Resources.Circle_Red;
                                statusToolStrip.SetToolTip(((PictureBox)c), "Off");
                                break;
                            case 1:
                                ((PictureBox)c).Image = global::VagrantGUI.Properties.Resources.Circle_Green;
                                statusToolStrip.SetToolTip(((PictureBox)c), "Running");
                                break;
                        }
                }
            }
            this.Cursor = Cursors.Default;
            
        }

    }
}
