namespace GoogleOauthAPI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIssued = new System.Windows.Forms.TextBox();
            this.tbExpiresIn = new System.Windows.Forms.TextBox();
            this.tbTokenType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbRefreshToken = new System.Windows.Forms.TextBox();
            this.tbAccessToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnStored = new System.Windows.Forms.Button();
            this.btnLoadSavedData = new System.Windows.Forms.Button();
            this.tbFileCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access Token";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Refresh Token";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbIssued);
            this.groupBox1.Controls.Add(this.tbExpiresIn);
            this.groupBox1.Controls.Add(this.tbTokenType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.tbRefreshToken);
            this.groupBox1.Controls.Add(this.tbAccessToken);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Using FileDataStore";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "FileDataStore Data";
            // 
            // tbIssued
            // 
            this.tbIssued.Location = new System.Drawing.Point(88, 107);
            this.tbIssued.Name = "tbIssued";
            this.tbIssued.Size = new System.Drawing.Size(341, 20);
            this.tbIssued.TabIndex = 12;
            // 
            // tbExpiresIn
            // 
            this.tbExpiresIn.Location = new System.Drawing.Point(88, 85);
            this.tbExpiresIn.Name = "tbExpiresIn";
            this.tbExpiresIn.Size = new System.Drawing.Size(341, 20);
            this.tbExpiresIn.TabIndex = 11;
            // 
            // tbTokenType
            // 
            this.tbTokenType.Location = new System.Drawing.Point(88, 63);
            this.tbTokenType.Name = "tbTokenType";
            this.tbTokenType.Size = new System.Drawing.Size(341, 20);
            this.tbTokenType.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Issued";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expires in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Token Type";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(585, 20);
            this.textBox4.TabIndex = 6;
            // 
            // tbRefreshToken
            // 
            this.tbRefreshToken.Location = new System.Drawing.Point(88, 40);
            this.tbRefreshToken.Name = "tbRefreshToken";
            this.tbRefreshToken.Size = new System.Drawing.Size(352, 20);
            this.tbRefreshToken.TabIndex = 5;
            // 
            // tbAccessToken
            // 
            this.tbAccessToken.Location = new System.Drawing.Point(88, 18);
            this.tbAccessToken.Name = "tbAccessToken";
            this.tbAccessToken.Size = new System.Drawing.Size(507, 20);
            this.tbAccessToken.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "FileDataStore Location";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 91);
            this.textBox1.TabIndex = 2;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(23, 344);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(109, 23);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "Load FileDataStore";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnStored
            // 
            this.btnStored.Location = new System.Drawing.Point(157, 344);
            this.btnStored.Name = "btnStored";
            this.btnStored.Size = new System.Drawing.Size(161, 23);
            this.btnStored.TabIndex = 4;
            this.btnStored.Text = "Load SavedDataStore";
            this.btnStored.UseVisualStyleBackColor = true;
            this.btnStored.Click += new System.EventHandler(this.btnStored_Click);
            // 
            // btnLoadSavedData
            // 
            this.btnLoadSavedData.Location = new System.Drawing.Point(324, 344);
            this.btnLoadSavedData.Name = "btnLoadSavedData";
            this.btnLoadSavedData.Size = new System.Drawing.Size(140, 23);
            this.btnLoadSavedData.TabIndex = 5;
            this.btnLoadSavedData.Text = "Load From Saved Data";
            this.btnLoadSavedData.UseVisualStyleBackColor = true;
            this.btnLoadSavedData.Click += new System.EventHandler(this.btnLoadSavedData_Click);
            // 
            // tbFileCount
            // 
            this.tbFileCount.Location = new System.Drawing.Point(108, 310);
            this.tbFileCount.Name = "tbFileCount";
            this.tbFileCount.Size = new System.Drawing.Size(100, 20);
            this.tbFileCount.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Drive FileCount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 379);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFileCount);
            this.Controls.Add(this.btnLoadSavedData);
            this.Controls.Add(this.btnStored);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbRefreshToken;
        private System.Windows.Forms.TextBox tbAccessToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIssued;
        private System.Windows.Forms.TextBox tbExpiresIn;
        private System.Windows.Forms.TextBox tbTokenType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnStored;
        private System.Windows.Forms.Button btnLoadSavedData;
        private System.Windows.Forms.TextBox tbFileCount;
        private System.Windows.Forms.Label label8;
    }
}

