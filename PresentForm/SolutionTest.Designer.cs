namespace PresentForm
{
    partial class SolutionTest
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
            this.Start_Button = new HslCommunication.Controls.UserButton();
            this.Stop_Button = new HslCommunication.Controls.UserButton();
            this.Test_Button = new HslCommunication.Controls.UserButton();
            this.Ini_Button = new HslCommunication.Controls.UserButton();
            this.Config_Button = new HslCommunication.Controls.UserButton();
            this.picShow_Tmlate = new CommonLibrary.PicShow();
            this.picShow_Dst = new CommonLibrary.PicShow();
            this.picShow_Src = new CommonLibrary.PicShow();
            this.picShow_Temp = new CommonLibrary.PicShow();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.Transparent;
            this.Start_Button.CustomerInformation = "";
            this.Start_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Start_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Start_Button.Location = new System.Drawing.Point(688, 179);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(94, 41);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.UIText = "启动";
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.BackColor = System.Drawing.Color.Transparent;
            this.Stop_Button.CustomerInformation = "";
            this.Stop_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Stop_Button.Location = new System.Drawing.Point(688, 269);
            this.Stop_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(94, 41);
            this.Stop_Button.TabIndex = 2;
            this.Stop_Button.UIText = "停止";
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Test_Button
            // 
            this.Test_Button.BackColor = System.Drawing.Color.Transparent;
            this.Test_Button.CustomerInformation = "";
            this.Test_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Test_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Test_Button.Location = new System.Drawing.Point(688, 359);
            this.Test_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Test_Button.Name = "Test_Button";
            this.Test_Button.Size = new System.Drawing.Size(94, 41);
            this.Test_Button.TabIndex = 3;
            this.Test_Button.UIText = "测试";
            this.Test_Button.Click += new System.EventHandler(this.Test_Button_Click);
            // 
            // Ini_Button
            // 
            this.Ini_Button.BackColor = System.Drawing.Color.Transparent;
            this.Ini_Button.CustomerInformation = "";
            this.Ini_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Ini_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Ini_Button.Location = new System.Drawing.Point(688, 89);
            this.Ini_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ini_Button.Name = "Ini_Button";
            this.Ini_Button.Size = new System.Drawing.Size(94, 41);
            this.Ini_Button.TabIndex = 4;
            this.Ini_Button.UIText = "初始化";
            this.Ini_Button.Click += new System.EventHandler(this.Ini_Button_Click);
            // 
            // Config_Button
            // 
            this.Config_Button.BackColor = System.Drawing.Color.Transparent;
            this.Config_Button.CustomerInformation = "";
            this.Config_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Config_Button.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Config_Button.Location = new System.Drawing.Point(794, 89);
            this.Config_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Config_Button.Name = "Config_Button";
            this.Config_Button.Size = new System.Drawing.Size(94, 41);
            this.Config_Button.TabIndex = 5;
            this.Config_Button.UIText = "配置";
            this.Config_Button.Click += new System.EventHandler(this.Config_Button_Click);
            // 
            // picShow_Tmlate
            // 
            this.picShow_Tmlate.Location = new System.Drawing.Point(333, 278);
            this.picShow_Tmlate.Name = "picShow_Tmlate";
            this.picShow_Tmlate.Size = new System.Drawing.Size(295, 200);
            this.picShow_Tmlate.TabIndex = 7;
            // 
            // picShow_Dst
            // 
            this.picShow_Dst.Location = new System.Drawing.Point(333, 38);
            this.picShow_Dst.Name = "picShow_Dst";
            this.picShow_Dst.Size = new System.Drawing.Size(295, 200);
            this.picShow_Dst.TabIndex = 6;
            // 
            // picShow_Src
            // 
            this.picShow_Src.Location = new System.Drawing.Point(14, 38);
            this.picShow_Src.Name = "picShow_Src";
            this.picShow_Src.Size = new System.Drawing.Size(295, 200);
            this.picShow_Src.TabIndex = 0;
            // 
            // picShow_Temp
            // 
            this.picShow_Temp.Location = new System.Drawing.Point(14, 278);
            this.picShow_Temp.Name = "picShow_Temp";
            this.picShow_Temp.Size = new System.Drawing.Size(295, 200);
            this.picShow_Temp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(141, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "原图";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(452, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "结果图";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(133, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Temp图";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(436, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Template图";
            // 
            // SolutionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picShow_Temp);
            this.Controls.Add(this.picShow_Tmlate);
            this.Controls.Add(this.picShow_Dst);
            this.Controls.Add(this.Config_Button);
            this.Controls.Add(this.Ini_Button);
            this.Controls.Add(this.Test_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.picShow_Src);
            this.Name = "SolutionTest";
            this.Text = "SolutionTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommonLibrary.PicShow picShow_Src;
        private HslCommunication.Controls.UserButton Start_Button;
        private HslCommunication.Controls.UserButton Stop_Button;
        private HslCommunication.Controls.UserButton Test_Button;
        private HslCommunication.Controls.UserButton Ini_Button;
        private HslCommunication.Controls.UserButton Config_Button;
        private CommonLibrary.PicShow picShow_Dst;
        private CommonLibrary.PicShow picShow_Tmlate;
        private CommonLibrary.PicShow picShow_Temp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}