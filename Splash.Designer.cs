namespace VagrantGUI
{
    partial class Splash
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
            this.title = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(131, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(245, 60);
            this.title.TabIndex = 0;
            this.title.Text = "VagrantGUI";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loading.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.Location = new System.Drawing.Point(120, 148);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(289, 39);
            this.loading.TabIndex = 1;
            this.loading.Text = "Initializing...";
            this.loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progress
            // 
            this.progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress.Location = new System.Drawing.Point(0, 257);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(513, 23);
            this.progress.TabIndex = 2;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 280);
            this.ControlBox = false;
            this.Controls.Add(this.progress);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(513, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(513, 280);
            this.Name = "Splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VagrantGUI - Initializing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label loading;
        public System.Windows.Forms.ProgressBar progress;
    }
}