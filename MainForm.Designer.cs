namespace LANSpeed
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            cbLanAdapters = new ComboBox();
            lblSpeed = new Label();
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // cbLanAdapters
            // 
            cbLanAdapters.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLanAdapters.FormattingEnabled = true;
            cbLanAdapters.Location = new Point(12, 92);
            cbLanAdapters.Name = "cbLanAdapters";
            cbLanAdapters.Size = new Size(453, 23);
            cbLanAdapters.TabIndex = 0;
            // 
            // lblSpeed
            // 
            lblSpeed.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpeed.ForeColor = SystemColors.ControlText;
            lblSpeed.Location = new Point(26, 9);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(425, 69);
            lblSpeed.TabIndex = 1;
            lblSpeed.TextAlign = ContentAlignment.MiddleCenter;
            lblSpeed.UseCompatibleTextRendering = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(160, 121);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(241, 121);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 150);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblSpeed);
            Controls.Add(cbLanAdapters);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LANSpeed";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbLanAdapters;
        private Label lblSpeed;
        private Button btnStart;
        private Button btnStop;
    }
}
