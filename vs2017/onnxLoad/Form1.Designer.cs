namespace onnxLoad
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_OpenModel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_onnxFilePath = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox_onnxModelReport = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox_openImagePathes = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button_OpenImage = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox_src = new System.Windows.Forms.PictureBox();
            this.pictureBox_dst = new System.Windows.Forms.PictureBox();
            this.pictureBox_mask = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mask)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(904, 40);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_OpenModel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(85, 34);
            this.panel2.TabIndex = 4;
            // 
            // button_OpenModel
            // 
            this.button_OpenModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_OpenModel.Location = new System.Drawing.Point(3, 3);
            this.button_OpenModel.Name = "button_OpenModel";
            this.button_OpenModel.Size = new System.Drawing.Size(79, 25);
            this.button_OpenModel.TabIndex = 1;
            this.button_OpenModel.Text = "OpenModel";
            this.button_OpenModel.UseVisualStyleBackColor = true;
            this.button_OpenModel.Click += new System.EventHandler(this.button_OpenModel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_onnxFilePath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(88, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(813, 34);
            this.panel3.TabIndex = 5;
            // 
            // textBox_onnxFilePath
            // 
            this.textBox_onnxFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_onnxFilePath.Location = new System.Drawing.Point(6, 6);
            this.textBox_onnxFilePath.Name = "textBox_onnxFilePath";
            this.textBox_onnxFilePath.Size = new System.Drawing.Size(801, 19);
            this.textBox_onnxFilePath.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(904, 156);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(904, 156);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ModelInfo";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox_onnxModelReport);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 17);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.panel6.Size = new System.Drawing.Size(904, 139);
            this.panel6.TabIndex = 1;
            // 
            // textBox_onnxModelReport
            // 
            this.textBox_onnxModelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_onnxModelReport.Location = new System.Drawing.Point(6, 3);
            this.textBox_onnxModelReport.Multiline = true;
            this.textBox_onnxModelReport.Name = "textBox_onnxModelReport";
            this.textBox_onnxModelReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_onnxModelReport.Size = new System.Drawing.Size(892, 130);
            this.textBox_onnxModelReport.TabIndex = 6;
            this.textBox_onnxModelReport.WordWrap = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 196);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3);
            this.panel7.Size = new System.Drawing.Size(904, 99);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBox_openImagePathes);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(88, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(6);
            this.panel8.Size = new System.Drawing.Size(813, 93);
            this.panel8.TabIndex = 5;
            // 
            // textBox_openImagePathes
            // 
            this.textBox_openImagePathes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_openImagePathes.Location = new System.Drawing.Point(6, 6);
            this.textBox_openImagePathes.Multiline = true;
            this.textBox_openImagePathes.Name = "textBox_openImagePathes";
            this.textBox_openImagePathes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_openImagePathes.Size = new System.Drawing.Size(801, 81);
            this.textBox_openImagePathes.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button_OpenImage);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(3);
            this.panel9.Size = new System.Drawing.Size(85, 93);
            this.panel9.TabIndex = 4;
            // 
            // button_OpenImage
            // 
            this.button_OpenImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_OpenImage.Location = new System.Drawing.Point(3, 3);
            this.button_OpenImage.Name = "button_OpenImage";
            this.button_OpenImage.Size = new System.Drawing.Size(79, 25);
            this.button_OpenImage.TabIndex = 1;
            this.button_OpenImage.Text = "OpenImage";
            this.button_OpenImage.UseVisualStyleBackColor = true;
            this.button_OpenImage.Click += new System.EventHandler(this.button_OpenImage_Click);
            // 
            // panel10
            // 
            this.panel10.AutoScroll = true;
            this.panel10.Controls.Add(this.pictureBox_mask);
            this.panel10.Controls.Add(this.pictureBox_dst);
            this.panel10.Controls.Add(this.pictureBox_src);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 295);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(904, 446);
            this.panel10.TabIndex = 6;
            // 
            // pictureBox_src
            // 
            this.pictureBox_src.Location = new System.Drawing.Point(12, 27);
            this.pictureBox_src.Name = "pictureBox_src";
            this.pictureBox_src.Size = new System.Drawing.Size(224, 224);
            this.pictureBox_src.TabIndex = 0;
            this.pictureBox_src.TabStop = false;
            // 
            // pictureBox_dst
            // 
            this.pictureBox_dst.Location = new System.Drawing.Point(269, 27);
            this.pictureBox_dst.Name = "pictureBox_dst";
            this.pictureBox_dst.Size = new System.Drawing.Size(224, 224);
            this.pictureBox_dst.TabIndex = 1;
            this.pictureBox_dst.TabStop = false;
            // 
            // pictureBox_mask
            // 
            this.pictureBox_mask.Location = new System.Drawing.Point(542, 27);
            this.pictureBox_mask.Name = "pictureBox_mask";
            this.pictureBox_mask.Size = new System.Drawing.Size(224, 224);
            this.pictureBox_mask.TabIndex = 2;
            this.pictureBox_mask.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 741);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "OnnxLoad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_onnxFilePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_OpenModel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox_onnxModelReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox_openImagePathes;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button_OpenImage;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox_mask;
        private System.Windows.Forms.PictureBox pictureBox_dst;
        private System.Windows.Forms.PictureBox pictureBox_src;
    }
}

