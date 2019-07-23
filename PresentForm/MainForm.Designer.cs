namespace PresentForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
            this.picShow2 = new CommonLibrary.PicShow();
            this.picShow1 = new CommonLibrary.PicShow();
            this.commonMethod1 = new EmguCVLibrary.Theories.CommonMethod(this.components);
            this.ocR_Recognition1 = new EmguCVLibrary.Theories.OCR_Recognition(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 482);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "聚焦测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 66);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "加载图片";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "处理图片";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(524, 448);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(356, 417);
            this.propertyGrid1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(206, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(210, 402);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emgu";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 204);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "光学识别";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // propertyGrid2
            // 
            this.propertyGrid2.Location = new System.Drawing.Point(946, 448);
            this.propertyGrid2.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid2.Name = "propertyGrid2";
            this.propertyGrid2.Size = new System.Drawing.Size(356, 417);
            this.propertyGrid2.TabIndex = 8;
            // 
            // picShow2
            // 
            this.picShow2.Location = new System.Drawing.Point(672, 63);
            this.picShow2.Margin = new System.Windows.Forms.Padding(6);
            this.picShow2.Name = "picShow2";
            this.picShow2.Size = new System.Drawing.Size(651, 370);
            this.picShow2.TabIndex = 1;
            // 
            // picShow1
            // 
            this.picShow1.Location = new System.Drawing.Point(9, 63);
            this.picShow1.Margin = new System.Windows.Forms.Padding(6);
            this.picShow1.Name = "picShow1";
            this.picShow1.Size = new System.Drawing.Size(651, 370);
            this.picShow1.TabIndex = 0;
            // 
            // ocR_Recognition1
            // 
            this.ocR_Recognition1.DataPath = null;
            this.ocR_Recognition1.EnforceLocale = false;
            this.ocR_Recognition1.EngineMode = Emgu.CV.OCR.OcrEngineMode.TesseractOnly;
            this.ocR_Recognition1.Language = "eng";
            this.ocR_Recognition1.LanguageType = EmguCVLibrary.Theories.LanguageType.英文;
            this.ocR_Recognition1.WhiteList = null;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(48, 275);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "测试";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 878);
            this.Controls.Add(this.propertyGrid2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picShow2);
            this.Controls.Add(this.picShow1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CommonLibrary.PicShow picShow1;
        private CommonLibrary.PicShow picShow2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private EmguCVLibrary.Theories.CommonMethod commonMethod1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PropertyGrid propertyGrid2;
        private EmguCVLibrary.Theories.OCR_Recognition ocR_Recognition1;
        private System.Windows.Forms.Button button5;
    }
}

