namespace BatchResizer
{
    partial class BatchResizeForm
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
            this.selectedFolderTxt = new System.Windows.Forms.TextBox();
            this.chooseFolderBtn = new System.Windows.Forms.Button();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.heightNud = new System.Windows.Forms.NumericUpDown();
            this.widthNud = new System.Windows.Forms.NumericUpDown();
            this.heightLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.replaceOriginalsCb = new System.Windows.Forms.CheckBox();
            this.resizeTypeCb = new System.Windows.Forms.ComboBox();
            this.currentFileLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedFolderTxt
            // 
            this.selectedFolderTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedFolderTxt.Location = new System.Drawing.Point(13, 34);
            this.selectedFolderTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectedFolderTxt.Name = "selectedFolderTxt";
            this.selectedFolderTxt.Size = new System.Drawing.Size(353, 26);
            this.selectedFolderTxt.TabIndex = 0;
            // 
            // chooseFolderBtn
            // 
            this.chooseFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFolderBtn.Location = new System.Drawing.Point(253, 70);
            this.chooseFolderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseFolderBtn.Name = "chooseFolderBtn";
            this.chooseFolderBtn.Size = new System.Drawing.Size(113, 32);
            this.chooseFolderBtn.TabIndex = 1;
            this.chooseFolderBtn.Text = "Choose Folder";
            this.chooseFolderBtn.UseVisualStyleBackColor = true;
            this.chooseFolderBtn.Click += new System.EventHandler(this.chooseFolderBtn_Click);
            // 
            // resizeBtn
            // 
            this.resizeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resizeBtn.Location = new System.Drawing.Point(72, 331);
            this.resizeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(100, 32);
            this.resizeBtn.TabIndex = 4;
            this.resizeBtn.Text = "Resize";
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // heightNud
            // 
            this.heightNud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.heightNud.Location = new System.Drawing.Point(123, 37);
            this.heightNud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heightNud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.heightNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNud.Name = "heightNud";
            this.heightNud.Size = new System.Drawing.Size(88, 26);
            this.heightNud.TabIndex = 0;
            this.heightNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightNud.Enter += new System.EventHandler(this.Nud_Enter);
            // 
            // widthNud
            // 
            this.widthNud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.widthNud.Location = new System.Drawing.Point(123, 77);
            this.widthNud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.widthNud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.widthNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNud.Name = "widthNud";
            this.widthNud.Size = new System.Drawing.Size(88, 26);
            this.widthNud.TabIndex = 1;
            this.widthNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthNud.Enter += new System.EventHandler(this.Nud_Enter);
            // 
            // heightLbl
            // 
            this.heightLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.heightLbl.Location = new System.Drawing.Point(23, 37);
            this.heightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(92, 31);
            this.heightLbl.TabIndex = 5;
            this.heightLbl.Text = "Max Height";
            this.heightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // widthLbl
            // 
            this.widthLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.widthLbl.Location = new System.Drawing.Point(23, 77);
            this.widthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(92, 31);
            this.widthLbl.TabIndex = 6;
            this.widthLbl.Text = "Max Width";
            this.widthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.replaceOriginalsCb);
            this.groupBox1.Controls.Add(this.heightLbl);
            this.groupBox1.Controls.Add(this.widthLbl);
            this.groupBox1.Controls.Add(this.heightNud);
            this.groupBox1.Controls.Add(this.widthNud);
            this.groupBox1.Location = new System.Drawing.Point(72, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // replaceOriginalsCb
            // 
            this.replaceOriginalsCb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.replaceOriginalsCb.Location = new System.Drawing.Point(50, 118);
            this.replaceOriginalsCb.Name = "replaceOriginalsCb";
            this.replaceOriginalsCb.Size = new System.Drawing.Size(134, 24);
            this.replaceOriginalsCb.TabIndex = 2;
            this.replaceOriginalsCb.Text = "Replace Originals";
            this.replaceOriginalsCb.UseVisualStyleBackColor = true;
            this.replaceOriginalsCb.CheckedChanged += new System.EventHandler(this.replaceOriginalsCb_CheckedChanged);
            // 
            // resizeTypeCb
            // 
            this.resizeTypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resizeTypeCb.FormattingEnabled = true;
            this.resizeTypeCb.Items.AddRange(new object[] {
            "Shrink to Max Size",
            "Grow to Min Size",
            "Set Exact Size",
            "By Percent"});
            this.resizeTypeCb.Location = new System.Drawing.Point(72, 127);
            this.resizeTypeCb.Name = "resizeTypeCb";
            this.resizeTypeCb.Size = new System.Drawing.Size(235, 28);
            this.resizeTypeCb.TabIndex = 2;
            this.resizeTypeCb.SelectedIndexChanged += new System.EventHandler(this.resizeTypeCb_SelectedIndexChanged);
            // 
            // currentFileLbl
            // 
            this.currentFileLbl.AutoEllipsis = true;
            this.currentFileLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.currentFileLbl.Location = new System.Drawing.Point(0, 377);
            this.currentFileLbl.Name = "currentFileLbl";
            this.currentFileLbl.Size = new System.Drawing.Size(379, 25);
            this.currentFileLbl.TabIndex = 8;
            this.currentFileLbl.Text = "[show current file]";
            this.currentFileLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Location = new System.Drawing.Point(207, 331);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 32);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(379, 402);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.currentFileLbl);
            this.Controls.Add(this.resizeTypeCb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resizeBtn);
            this.Controls.Add(this.chooseFolderBtn);
            this.Controls.Add(this.selectedFolderTxt);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Image Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.heightNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedFolderTxt;
        private System.Windows.Forms.Button chooseFolderBtn;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.NumericUpDown heightNud;
        private System.Windows.Forms.NumericUpDown widthNud;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox resizeTypeCb;
        private System.Windows.Forms.CheckBox replaceOriginalsCb;
        private System.Windows.Forms.Label currentFileLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button cancelBtn;
    }
}

