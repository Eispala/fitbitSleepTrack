namespace FitBitSleeptrack
{
    partial class FitBitSleepTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpTimeSpan = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBeforeAfter = new System.Windows.Forms.ComboBox();
            this.daysToRetrieve = new System.Windows.Forms.NumericUpDown();
            this.cbTimeSpan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTargetDay = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.grpTimeSpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysToRetrieve)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpTimeSpan);
            this.groupBox1.Controls.Add(this.cbTimeSpan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTargetDay);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abrufzeitraum";
            // 
            // grpTimeSpan
            // 
            this.grpTimeSpan.Controls.Add(this.label4);
            this.grpTimeSpan.Controls.Add(this.label3);
            this.grpTimeSpan.Controls.Add(this.label2);
            this.grpTimeSpan.Controls.Add(this.cbBeforeAfter);
            this.grpTimeSpan.Controls.Add(this.daysToRetrieve);
            this.grpTimeSpan.Location = new System.Drawing.Point(6, 84);
            this.grpTimeSpan.Name = "grpTimeSpan";
            this.grpTimeSpan.Size = new System.Drawing.Size(474, 64);
            this.grpTimeSpan.TabIndex = 5;
            this.grpTimeSpan.TabStop = false;
            this.grpTimeSpan.Text = "Konfiguration Abrufzeitraum";
            this.grpTimeSpan.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "dem abzurufenden Tag ab";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tage";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rufe";
            this.label2.Visible = false;
            // 
            // cbBeforeAfter
            // 
            this.cbBeforeAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeforeAfter.FormattingEnabled = true;
            this.cbBeforeAfter.Items.AddRange(new object[] {
            "vor",
            "nach"});
            this.cbBeforeAfter.Location = new System.Drawing.Point(137, 22);
            this.cbBeforeAfter.Name = "cbBeforeAfter";
            this.cbBeforeAfter.Size = new System.Drawing.Size(49, 23);
            this.cbBeforeAfter.TabIndex = 8;
            this.cbBeforeAfter.Visible = false;
            // 
            // daysToRetrieve
            // 
            this.daysToRetrieve.Location = new System.Drawing.Point(43, 22);
            this.daysToRetrieve.Name = "daysToRetrieve";
            this.daysToRetrieve.Size = new System.Drawing.Size(51, 23);
            this.daysToRetrieve.TabIndex = 2;
            this.daysToRetrieve.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysToRetrieve.Visible = false;
            // 
            // cbTimeSpan
            // 
            this.cbTimeSpan.AutoSize = true;
            this.cbTimeSpan.Location = new System.Drawing.Point(6, 59);
            this.cbTimeSpan.Name = "cbTimeSpan";
            this.cbTimeSpan.Size = new System.Drawing.Size(136, 19);
            this.cbTimeSpan.TabIndex = 4;
            this.cbTimeSpan.Text = "Abruf nach Zeitraum";
            this.cbTimeSpan.UseVisualStyleBackColor = true;
            this.cbTimeSpan.CheckedChanged += new System.EventHandler(this.cbTimeSpan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abzurufender Tag:";
            // 
            // tbTargetDay
            // 
            this.tbTargetDay.Location = new System.Drawing.Point(156, 22);
            this.tbTargetDay.Name = "tbTargetDay";
            this.tbTargetDay.Size = new System.Drawing.Size(144, 23);
            this.tbTargetDay.TabIndex = 2;
            this.tbTargetDay.Text = "2022-01-25";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 235);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(104, 184);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(208, 23);
            this.tbFileName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dateiname:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel1.Text = "Bereit";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(504, 12);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(495, 157);
            this.rtbLog.TabIndex = 9;
            this.rtbLog.Text = "";
            // 
            // FitBitSleepTracker
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 294);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "FitBitSleepTracker";
            this.Text = "Fitbit SleepTrack";
            this.Load += new System.EventHandler(this.FitBitSleepTracker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTimeSpan.ResumeLayout(false);
            this.grpTimeSpan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysToRetrieve)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbTargetDay;
        private GroupBox grpTimeSpan;
        private NumericUpDown daysToRetrieve;
        private CheckBox cbTimeSpan;
        private Button btnStart;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbBeforeAfter;
        private TextBox tbFileName;
        private Label label5;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private RichTextBox rtbLog;
    }
}