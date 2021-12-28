namespace LineCounter
{
    partial class FrmLineCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLineCounter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbCalcLines = new System.Windows.Forms.CheckBox();
            this.tbxExt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbSubDirectory = new System.Windows.Forms.CheckBox();
            this.tbxPath = new System.Windows.Forms.TextBox();
            this.btnSelPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvData = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxFileLines = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTotalFileCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbCalcLines);
            this.groupBox1.Controls.Add(this.tbxExt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ckbSubDirectory);
            this.groupBox1.Controls.Add(this.tbxPath);
            this.groupBox1.Controls.Add(this.btnSelPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ckbCalcLines
            // 
            this.ckbCalcLines.AutoSize = true;
            this.ckbCalcLines.Location = new System.Drawing.Point(275, 22);
            this.ckbCalcLines.Name = "ckbCalcLines";
            this.ckbCalcLines.Size = new System.Drawing.Size(98, 17);
            this.ckbCalcLines.TabIndex = 5;
            this.ckbCalcLines.Text = "Calculate Lines";
            this.ckbCalcLines.UseVisualStyleBackColor = true;
            // 
            // tbxExt
            // 
            this.tbxExt.Location = new System.Drawing.Point(57, 20);
            this.tbxExt.Name = "tbxExt";
            this.tbxExt.Size = new System.Drawing.Size(66, 20);
            this.tbxExt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Extension";
            // 
            // ckbSubDirectory
            // 
            this.ckbSubDirectory.AutoSize = true;
            this.ckbSubDirectory.Location = new System.Drawing.Point(132, 22);
            this.ckbSubDirectory.Name = "ckbSubDirectory";
            this.ckbSubDirectory.Size = new System.Drawing.Size(128, 17);
            this.ckbSubDirectory.TabIndex = 2;
            this.ckbSubDirectory.Text = "Include Sub Directory";
            this.ckbSubDirectory.UseVisualStyleBackColor = true;
            // 
            // tbxPath
            // 
            this.tbxPath.Location = new System.Drawing.Point(92, 49);
            this.tbxPath.Name = "tbxPath";
            this.tbxPath.ReadOnly = true;
            this.tbxPath.Size = new System.Drawing.Size(281, 20);
            this.tbxPath.TabIndex = 4;
            // 
            // btnSelPath
            // 
            this.btnSelPath.Location = new System.Drawing.Point(57, 47);
            this.btnSelPath.Name = "btnSelPath";
            this.btnSelPath.Size = new System.Drawing.Size(29, 23);
            this.btnSelPath.TabIndex = 3;
            this.btnSelPath.Text = "...";
            this.btnSelPath.UseVisualStyleBackColor = true;
            this.btnSelPath.Click += new System.EventHandler(this.btnSelPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(397, 18);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(90, 38);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show Files";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvData);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File List";
            // 
            // lsvData
            // 
            this.lsvData.FullRowSelect = true;
            this.lsvData.GridLines = true;
            this.lsvData.Location = new System.Drawing.Point(7, 19);
            this.lsvData.Name = "lsvData";
            this.lsvData.Size = new System.Drawing.Size(848, 355);
            this.lsvData.TabIndex = 6;
            this.lsvData.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxFileLines);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbxTotalFileCount);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(494, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 88);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tbxFileLines
            // 
            this.tbxFileLines.Location = new System.Drawing.Point(269, 32);
            this.tbxFileLines.Name = "tbxFileLines";
            this.tbxFileLines.ReadOnly = true;
            this.tbxFileLines.Size = new System.Drawing.Size(100, 20);
            this.tbxFileLines.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total File Lines";
            // 
            // tbxTotalFileCount
            // 
            this.tbxTotalFileCount.Location = new System.Drawing.Point(83, 32);
            this.tbxTotalFileCount.Name = "tbxTotalFileCount";
            this.tbxTotalFileCount.ReadOnly = true;
            this.tbxTotalFileCount.Size = new System.Drawing.Size(100, 20);
            this.tbxTotalFileCount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total File Count";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(397, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(398, 61);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 38);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export Result";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FrmLineCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 537);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLineCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line Counter - by Mohammad Ali Mirzaei";
            this.Load += new System.EventHandler(this.FrmCodeCounter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxPath;
        private System.Windows.Forms.ListView lsvData;
        private System.Windows.Forms.TextBox tbxTotalFileCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbSubDirectory;
        private System.Windows.Forms.TextBox tbxExt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbxFileLines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbCalcLines;
        private System.Windows.Forms.Button btnExport;
    }
}

