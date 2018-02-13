namespace _501sales
{
    partial class EnterRebate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxAddByFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddManually = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentRebateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uxRebateText = new System.Windows.Forms.TextBox();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxAddRebate = new System.Windows.Forms.Button();
            this.uxCancelRebate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxAddByFile,
            this.uxAddManually,
            this.saveCurrentRebateToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(405, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxAddByFile
            // 
            this.uxAddByFile.Name = "uxAddByFile";
            this.uxAddByFile.Size = new System.Drawing.Size(117, 20);
            this.uxAddByFile.Text = "Add Rebate By File";
            this.uxAddByFile.Click += new System.EventHandler(this.uxAddByFile_Click);
            // 
            // uxAddManually
            // 
            this.uxAddManually.Name = "uxAddManually";
            this.uxAddManually.Size = new System.Drawing.Size(132, 20);
            this.uxAddManually.Text = "Add Rebate Manually";
            this.uxAddManually.Click += new System.EventHandler(this.uxAddManually_Click);
            // 
            // saveCurrentRebateToolStripMenuItem1
            // 
            this.saveCurrentRebateToolStripMenuItem1.Name = "saveCurrentRebateToolStripMenuItem1";
            this.saveCurrentRebateToolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.saveCurrentRebateToolStripMenuItem1.Text = "Save Current Rebate";
            // 
            // uxRebateText
            // 
            this.uxRebateText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRebateText.Enabled = false;
            this.uxRebateText.Location = new System.Drawing.Point(12, 27);
            this.uxRebateText.Multiline = true;
            this.uxRebateText.Name = "uxRebateText";
            this.uxRebateText.Size = new System.Drawing.Size(381, 331);
            this.uxRebateText.TabIndex = 1;
            this.uxRebateText.Text = " ";
            this.uxRebateText.TextChanged += new System.EventHandler(this.uxRebateText_TextChanged);
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog";
            // 
            // uxAddRebate
            // 
            this.uxAddRebate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAddRebate.Enabled = false;
            this.uxAddRebate.Location = new System.Drawing.Point(60, 364);
            this.uxAddRebate.Name = "uxAddRebate";
            this.uxAddRebate.Size = new System.Drawing.Size(75, 23);
            this.uxAddRebate.TabIndex = 2;
            this.uxAddRebate.Text = "Add";
            this.uxAddRebate.UseVisualStyleBackColor = true;
            this.uxAddRebate.Click += new System.EventHandler(this.uxAddRebate_Click);
            // 
            // uxCancelRebate
            // 
            this.uxCancelRebate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxCancelRebate.Location = new System.Drawing.Point(264, 364);
            this.uxCancelRebate.Name = "uxCancelRebate";
            this.uxCancelRebate.Size = new System.Drawing.Size(75, 23);
            this.uxCancelRebate.TabIndex = 3;
            this.uxCancelRebate.Text = "Cancel";
            this.uxCancelRebate.UseVisualStyleBackColor = true;
            this.uxCancelRebate.Click += new System.EventHandler(this.uxCancelRebate_Click);
            // 
            // EnterRebate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 397);
            this.Controls.Add(this.uxCancelRebate);
            this.Controls.Add(this.uxAddRebate);
            this.Controls.Add(this.uxRebateText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EnterRebate";
            this.Text = "EnterRebates";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxAddByFile;
        private System.Windows.Forms.ToolStripMenuItem uxAddManually;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentRebateToolStripMenuItem1;
        private System.Windows.Forms.TextBox uxRebateText;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.Button uxAddRebate;
        private System.Windows.Forms.Button uxCancelRebate;
    }
}