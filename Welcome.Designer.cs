namespace VagrantGUI
{
    partial class WelcomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcome = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vagrantFinder = new System.Windows.Forms.FolderBrowserDialog();
            this.welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.ColumnCount = 1;
            this.welcome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.welcome.Controls.Add(this.label1, 0, 0);
            this.welcome.Controls.Add(this.label2, 0, 1);
            this.welcome.Controls.Add(this.button1, 0, 2);
            this.welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome.Location = new System.Drawing.Point(0, 0);
            this.welcome.Name = "welcome";
            this.welcome.RowCount = 3;
            this.welcome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.74194F));
            this.welcome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.1828F));
            this.welcome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.07527F));
            this.welcome.Size = new System.Drawing.Size(434, 372);
            this.welcome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi There!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 115);
            this.label2.TabIndex = 1;
            this.label2.Text = "We need you to locate your vagrant directory. Don\'t worry - it\'s just a one time " +
    "thing";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(155, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vagrantFinder
            // 
            this.vagrantFinder.Description = "Select the vagrant directory";
            this.vagrantFinder.ShowNewFolderButton = false;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 372);
            this.Controls.Add(this.welcome);
            this.Name = "WelcomePage";
            this.Text = "VagrantGUI - First time setup";
            this.TopMost = true;
            this.welcome.ResumeLayout(false);
            this.welcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog vagrantFinder;
    }
}

