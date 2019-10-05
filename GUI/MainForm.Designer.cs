namespace GUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.computerInfoGB = new System.Windows.Forms.GroupBox();
            this.manufacturerBox = new System.Windows.Forms.TextBox();
            this.manufacturerLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.performanceGB = new System.Windows.Forms.GroupBox();
            this.ramBox = new System.Windows.Forms.TextBox();
            this.ramLoadLabel = new System.Windows.Forms.Label();
            this.cpuBox = new System.Windows.Forms.TextBox();
            this.cpuLoadLabel = new System.Windows.Forms.Label();
            this.usersGB = new System.Windows.Forms.GroupBox();
            this.usersList = new System.Windows.Forms.ListBox();
            this.computerInfoGB.SuspendLayout();
            this.performanceGB.SuspendLayout();
            this.usersGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // computerInfoGB
            // 
            this.computerInfoGB.BackColor = System.Drawing.SystemColors.Control;
            this.computerInfoGB.Controls.Add(this.manufacturerBox);
            this.computerInfoGB.Controls.Add(this.manufacturerLabel);
            this.computerInfoGB.Controls.Add(this.nameBox);
            this.computerInfoGB.Controls.Add(this.labelName);
            this.computerInfoGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.computerInfoGB.Location = new System.Drawing.Point(12, 12);
            this.computerInfoGB.Name = "computerInfoGB";
            this.computerInfoGB.Size = new System.Drawing.Size(575, 154);
            this.computerInfoGB.TabIndex = 0;
            this.computerInfoGB.TabStop = false;
            this.computerInfoGB.Text = "Computer Info";
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manufacturerBox.Enabled = false;
            this.manufacturerBox.Location = new System.Drawing.Point(207, 98);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.ReadOnly = true;
            this.manufacturerBox.Size = new System.Drawing.Size(349, 39);
            this.manufacturerBox.TabIndex = 3;
            // 
            // manufacturerLabel
            // 
            this.manufacturerLabel.AutoSize = true;
            this.manufacturerLabel.Location = new System.Drawing.Point(6, 101);
            this.manufacturerLabel.Name = "manufacturerLabel";
            this.manufacturerLabel.Size = new System.Drawing.Size(195, 32);
            this.manufacturerLabel.TabIndex = 2;
            this.manufacturerLabel.Text = "Manufacturer";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(207, 41);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(349, 39);
            this.nameBox.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(81, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 32);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "PC Name";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // performanceGB
            // 
            this.performanceGB.BackColor = System.Drawing.SystemColors.Control;
            this.performanceGB.Controls.Add(this.ramBox);
            this.performanceGB.Controls.Add(this.ramLoadLabel);
            this.performanceGB.Controls.Add(this.cpuBox);
            this.performanceGB.Controls.Add(this.cpuLoadLabel);
            this.performanceGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.performanceGB.Location = new System.Drawing.Point(12, 194);
            this.performanceGB.Name = "performanceGB";
            this.performanceGB.Size = new System.Drawing.Size(575, 154);
            this.performanceGB.TabIndex = 4;
            this.performanceGB.TabStop = false;
            this.performanceGB.Text = "Performance";
            // 
            // ramBox
            // 
            this.ramBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ramBox.Enabled = false;
            this.ramBox.Location = new System.Drawing.Point(207, 98);
            this.ramBox.Name = "ramBox";
            this.ramBox.ReadOnly = true;
            this.ramBox.Size = new System.Drawing.Size(349, 39);
            this.ramBox.TabIndex = 3;
            // 
            // ramLoadLabel
            // 
            this.ramLoadLabel.AutoSize = true;
            this.ramLoadLabel.Location = new System.Drawing.Point(66, 101);
            this.ramLoadLabel.Name = "ramLoadLabel";
            this.ramLoadLabel.Size = new System.Drawing.Size(135, 32);
            this.ramLoadLabel.TabIndex = 2;
            this.ramLoadLabel.Text = "RAM Load";
            // 
            // cpuBox
            // 
            this.cpuBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuBox.Enabled = false;
            this.cpuBox.Location = new System.Drawing.Point(207, 41);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.ReadOnly = true;
            this.cpuBox.Size = new System.Drawing.Size(349, 39);
            this.cpuBox.TabIndex = 1;
            // 
            // cpuLoadLabel
            // 
            this.cpuLoadLabel.AutoSize = true;
            this.cpuLoadLabel.Location = new System.Drawing.Point(66, 44);
            this.cpuLoadLabel.Name = "cpuLoadLabel";
            this.cpuLoadLabel.Size = new System.Drawing.Size(135, 32);
            this.cpuLoadLabel.TabIndex = 0;
            this.cpuLoadLabel.Text = "CPU Load";
            // 
            // usersGB
            // 
            this.usersGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usersGB.BackColor = System.Drawing.SystemColors.Control;
            this.usersGB.Controls.Add(this.usersList);
            this.usersGB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersGB.Location = new System.Drawing.Point(617, 12);
            this.usersGB.Name = "usersGB";
            this.usersGB.Size = new System.Drawing.Size(575, 336);
            this.usersGB.TabIndex = 5;
            this.usersGB.TabStop = false;
            this.usersGB.Text = "Users";
            // 
            // usersList
            // 
            this.usersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 32;
            this.usersList.Location = new System.Drawing.Point(3, 35);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(569, 298);
            this.usersList.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 370);
            this.Controls.Add(this.usersGB);
            this.Controls.Add(this.performanceGB);
            this.Controls.Add(this.computerInfoGB);
            this.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.Text = "ComputerInfo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.computerInfoGB.ResumeLayout(false);
            this.computerInfoGB.PerformLayout();
            this.performanceGB.ResumeLayout(false);
            this.performanceGB.PerformLayout();
            this.usersGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox computerInfoGB;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox manufacturerBox;
        private System.Windows.Forms.Label manufacturerLabel;
        private System.Windows.Forms.GroupBox performanceGB;
        private System.Windows.Forms.TextBox ramBox;
        private System.Windows.Forms.Label ramLoadLabel;
        private System.Windows.Forms.TextBox cpuBox;
        private System.Windows.Forms.Label cpuLoadLabel;
        private System.Windows.Forms.GroupBox usersGB;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Timer timer;
    }
}

