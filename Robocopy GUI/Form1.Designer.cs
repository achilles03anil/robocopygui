namespace Robocopy_GUI
{
    partial class frmRobocopy
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
            this.fbdSource = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSource = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btndestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rbMIR = new System.Windows.Forms.RadioButton();
            this.rbMov = new System.Windows.Forms.RadioButton();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.btnStartDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.chkdeletelog = new System.Windows.Forms.CheckBox();
            this.btnEmptyLocation = new System.Windows.Forms.Button();
            this.lblemptyFolder = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDeleteCommand = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(6, 38);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(134, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Source Location";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(53, 22);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(42, 13);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(78, 75);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(67, 13);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination";
            // 
            // btndestination
            // 
            this.btndestination.Location = new System.Drawing.Point(6, 91);
            this.btndestination.Name = "btndestination";
            this.btndestination.Size = new System.Drawing.Size(134, 23);
            this.btndestination.TabIndex = 2;
            this.btndestination.Text = "Destination Location";
            this.btndestination.UseVisualStyleBackColor = true;
            this.btndestination.Click += new System.EventHandler(this.btndestination_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destination :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Command :";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.Location = new System.Drawing.Point(78, 127);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(61, 13);
            this.lblCommand.TabIndex = 6;
            this.lblCommand.Text = "Command";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(5, 193);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(134, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Start Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rbMIR
            // 
            this.rbMIR.AutoSize = true;
            this.rbMIR.Checked = true;
            this.rbMIR.Location = new System.Drawing.Point(8, 151);
            this.rbMIR.Name = "rbMIR";
            this.rbMIR.Size = new System.Drawing.Size(51, 17);
            this.rbMIR.TabIndex = 9;
            this.rbMIR.TabStop = true;
            this.rbMIR.Tag = "/MIR";
            this.rbMIR.Text = "Mirror";
            this.rbMIR.UseVisualStyleBackColor = true;
            // 
            // rbMov
            // 
            this.rbMov.AutoSize = true;
            this.rbMov.Location = new System.Drawing.Point(99, 151);
            this.rbMov.Name = "rbMov";
            this.rbMov.Size = new System.Drawing.Size(52, 17);
            this.rbMov.TabIndex = 10;
            this.rbMov.Tag = "/MOVE";
            this.rbMov.Text = "Move";
            this.rbMov.UseVisualStyleBackColor = true;
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(8, 170);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(63, 17);
            this.chkLog.TabIndex = 11;
            this.chkLog.Text = "Log File";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // btnStartDelete
            // 
            this.btnStartDelete.Location = new System.Drawing.Point(17, 193);
            this.btnStartDelete.Name = "btnStartDelete";
            this.btnStartDelete.Size = new System.Drawing.Size(134, 23);
            this.btnStartDelete.TabIndex = 12;
            this.btnStartDelete.Text = "Start Delete";
            this.btnStartDelete.UseVisualStyleBackColor = true;
            this.btnStartDelete.Click += new System.EventHandler(this.btnStartDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSource);
            this.groupBox1.Controls.Add(this.lblSource);
            this.groupBox1.Controls.Add(this.chkLog);
            this.groupBox1.Controls.Add(this.btndestination);
            this.groupBox1.Controls.Add(this.rbMov);
            this.groupBox1.Controls.Add(this.lblDestination);
            this.groupBox1.Controls.Add(this.rbMIR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCommand);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 224);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copy/Move";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDeleteCommand);
            this.groupBox2.Controls.Add(this.btnEmptyLocation);
            this.groupBox2.Controls.Add(this.lblemptyFolder);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkdeletelog);
            this.groupBox2.Controls.Add(this.btnDeleteLocation);
            this.groupBox2.Controls.Add(this.lblDelete);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnStartDelete);
            this.groupBox2.Location = new System.Drawing.Point(230, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 224);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(62, 22);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(40, 13);
            this.lblDelete.TabIndex = 13;
            this.lblDelete.Text = "Delete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Delete :";
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Location = new System.Drawing.Point(17, 38);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteLocation.TabIndex = 15;
            this.btnDeleteLocation.Text = "Delete Location";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // chkdeletelog
            // 
            this.chkdeletelog.AutoSize = true;
            this.chkdeletelog.Location = new System.Drawing.Point(18, 173);
            this.chkdeletelog.Name = "chkdeletelog";
            this.chkdeletelog.Size = new System.Drawing.Size(63, 17);
            this.chkdeletelog.TabIndex = 16;
            this.chkdeletelog.Text = "Log File";
            this.chkdeletelog.UseVisualStyleBackColor = true;
            // 
            // btnEmptyLocation
            // 
            this.btnEmptyLocation.Location = new System.Drawing.Point(18, 79);
            this.btnEmptyLocation.Name = "btnEmptyLocation";
            this.btnEmptyLocation.Size = new System.Drawing.Size(134, 23);
            this.btnEmptyLocation.TabIndex = 19;
            this.btnEmptyLocation.Text = "Empty Location";
            this.btnEmptyLocation.UseVisualStyleBackColor = true;
            this.btnEmptyLocation.Click += new System.EventHandler(this.btnEmptyLocation_Click);
            // 
            // lblemptyFolder
            // 
            this.lblemptyFolder.AutoSize = true;
            this.lblemptyFolder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemptyFolder.Location = new System.Drawing.Point(63, 63);
            this.lblemptyFolder.Name = "lblemptyFolder";
            this.lblemptyFolder.Size = new System.Drawing.Size(40, 13);
            this.lblemptyFolder.TabIndex = 17;
            this.lblemptyFolder.Text = "Empty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Empty :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Command :";
            // 
            // lblDeleteCommand
            // 
            this.lblDeleteCommand.AutoSize = true;
            this.lblDeleteCommand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteCommand.Location = new System.Drawing.Point(88, 105);
            this.lblDeleteCommand.Name = "lblDeleteCommand";
            this.lblDeleteCommand.Size = new System.Drawing.Size(61, 13);
            this.lblDeleteCommand.TabIndex = 20;
            this.lblDeleteCommand.Text = "Command";
            // 
            // frmRobocopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRobocopy";
            this.Text = "RoboCopyGui";
            this.Load += new System.EventHandler(this.frmRobocopy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdSource;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btndestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RadioButton rbMIR;
        private System.Windows.Forms.RadioButton rbMov;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Button btnStartDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkdeletelog;
        private System.Windows.Forms.Button btnEmptyLocation;
        private System.Windows.Forms.Label lblemptyFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDeleteCommand;
    }
}

