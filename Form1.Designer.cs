namespace Hash
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crc32box = new System.Windows.Forms.CheckBox();
            this.sha1box = new System.Windows.Forms.CheckBox();
            this.md5box = new System.Windows.Forms.CheckBox();
            this.datebox = new System.Windows.Forms.CheckBox();
            this.versionbox = new System.Windows.Forms.CheckBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.copy_button);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 572);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.crc32box);
            this.groupBox1.Controls.Add(this.sha1box);
            this.groupBox1.Controls.Add(this.md5box);
            this.groupBox1.Controls.Add(this.datebox);
            this.groupBox1.Controls.Add(this.versionbox);
            this.groupBox1.Location = new System.Drawing.Point(748, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // crc32box
            // 
            this.crc32box.AutoSize = true;
            this.crc32box.Checked = true;
            this.crc32box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crc32box.Location = new System.Drawing.Point(17, 128);
            this.crc32box.Name = "crc32box";
            this.crc32box.Size = new System.Drawing.Size(79, 22);
            this.crc32box.TabIndex = 4;
            this.crc32box.Text = "CRC32";
            this.crc32box.UseVisualStyleBackColor = true;
            // 
            // sha1box
            // 
            this.sha1box.AutoSize = true;
            this.sha1box.Checked = true;
            this.sha1box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sha1box.Location = new System.Drawing.Point(17, 100);
            this.sha1box.Name = "sha1box";
            this.sha1box.Size = new System.Drawing.Size(70, 22);
            this.sha1box.TabIndex = 3;
            this.sha1box.Text = "SHA1";
            this.sha1box.UseVisualStyleBackColor = true;
            // 
            // md5box
            // 
            this.md5box.AutoSize = true;
            this.md5box.Checked = true;
            this.md5box.CheckState = System.Windows.Forms.CheckState.Checked;
            this.md5box.Location = new System.Drawing.Point(17, 72);
            this.md5box.Name = "md5box";
            this.md5box.Size = new System.Drawing.Size(61, 22);
            this.md5box.TabIndex = 2;
            this.md5box.Text = "MD5";
            this.md5box.UseVisualStyleBackColor = true;
            // 
            // datebox
            // 
            this.datebox.AutoSize = true;
            this.datebox.Checked = true;
            this.datebox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.datebox.Location = new System.Drawing.Point(17, 44);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(70, 22);
            this.datebox.TabIndex = 1;
            this.datebox.Text = "Date";
            this.datebox.UseVisualStyleBackColor = true;
            // 
            // versionbox
            // 
            this.versionbox.AutoSize = true;
            this.versionbox.Checked = true;
            this.versionbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.versionbox.Location = new System.Drawing.Point(17, 16);
            this.versionbox.Name = "versionbox";
            this.versionbox.Size = new System.Drawing.Size(97, 22);
            this.versionbox.TabIndex = 0;
            this.versionbox.Text = "Version";
            this.versionbox.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(94, 509);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(622, 23);
            this.progressBar2.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(95, 471);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(622, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "File:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Location = new System.Drawing.Point(611, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "Stop";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(468, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Save...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // copy_button
            // 
            this.copy_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copy_button.Location = new System.Drawing.Point(318, 401);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(106, 38);
            this.copy_button.TabIndex = 3;
            this.copy_button.Text = "Copy";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(167, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(21, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(948, 374);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(976, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hash - 2024.6 - Desec - https://github.com/DATA-GaMi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox crc32box;
        private System.Windows.Forms.CheckBox sha1box;
        private System.Windows.Forms.CheckBox md5box;
        private System.Windows.Forms.CheckBox datebox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox versionbox;
    }
}

