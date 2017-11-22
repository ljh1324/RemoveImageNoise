namespace RemoveImageNoise
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadPicture = new System.Windows.Forms.PictureBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.savePicture = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rgbLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadPicture
            // 
            this.loadPicture.Location = new System.Drawing.Point(3, 3);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(291, 345);
            this.loadPicture.TabIndex = 0;
            this.loadPicture.TabStop = false;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(15, 379);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(291, 39);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(340, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "→";
            // 
            // savePicture
            // 
            this.savePicture.Location = new System.Drawing.Point(3, 3);
            this.savePicture.Name = "savePicture";
            this.savePicture.Size = new System.Drawing.Size(291, 345);
            this.savePicture.TabIndex = 3;
            this.savePicture.TabStop = false;
            this.savePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.savePicture_MouseMove);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(396, 379);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(291, 39);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.loadPicture);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 353);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.savePicture);
            this.panel2.Location = new System.Drawing.Point(393, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 353);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Length";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(698, 36);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(17, 12);
            this.lengthLabel.TabIndex = 8;
            this.lengthLabel.Text = " : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(698, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "RGB";
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Location = new System.Drawing.Point(698, 82);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(21, 12);
            this.rgbLabel.TabIndex = 10;
            this.rgbLabel.Text = " :  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 431);
            this.Controls.Add(this.rgbLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBtn);
            this.Name = "Form1";
            this.Text = "RemoveImageNoise";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadPicture;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox savePicture;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rgbLabel;
    }
}

