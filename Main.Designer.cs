namespace VagrantGUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.actions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destroyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.console = new System.Windows.Forms.TextBox();
            this.statusToolStrip = new System.Windows.Forms.ToolTip(this.components);
            this.actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 3;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 2;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Size = new System.Drawing.Size(474, 282);
            this.buttonPanel.TabIndex = 0;
            // 
            // actions
            // 
            this.actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.destroyToolStripMenuItem,
            this.sSHToolStripMenuItem});
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(115, 92);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // destroyToolStripMenuItem
            // 
            this.destroyToolStripMenuItem.Name = "destroyToolStripMenuItem";
            this.destroyToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.destroyToolStripMenuItem.Text = "Destroy";
            this.destroyToolStripMenuItem.Click += new System.EventHandler(this.destroyToolStripMenuItem_Click);
            // 
            // sSHToolStripMenuItem
            // 
            this.sSHToolStripMenuItem.Name = "sSHToolStripMenuItem";
            this.sSHToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sSHToolStripMenuItem.Text = "SSH";
            this.sSHToolStripMenuItem.Click += new System.EventHandler(this.sSHToolStripMenuItem_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.console.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.console.Location = new System.Drawing.Point(0, 288);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(474, 88);
            this.console.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(474, 376);
            this.Controls.Add(this.console);
            this.Controls.Add(this.buttonPanel);
            this.Name = "Main";
            this.Text = "VagrantGUI";
            this.Load += new System.EventHandler(this.Main_Load);
            this.actions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.ContextMenuStrip actions;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destroyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSHToolStripMenuItem;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.ToolTip statusToolStrip;

    }
}