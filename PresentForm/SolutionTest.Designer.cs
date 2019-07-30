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
            this.picShow1 = new CommonLibrary.PicShow();
            this.Stop_Button = new HslCommunication.Controls.UserButton();
            this.Test_Button = new HslCommunication.Controls.UserButton();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.Transparent;
            this.Start_Button.CustomerInformation = "";
            this.Start_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Start_Button.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Start_Button.Location = new System.Drawing.Point(621, 70);
            this.Start_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(94, 41);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.UIText = "启动";
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // picShow1
            // 
            this.picShow1.Location = new System.Drawing.Point(22, 19);
            this.picShow1.Name = "picShow1";
            this.picShow1.Size = new System.Drawing.Size(547, 313);
            this.picShow1.TabIndex = 0;
            // 
            // Stop_Button
            // 
            this.Stop_Button.BackColor = System.Drawing.Color.Transparent;
            this.Stop_Button.CustomerInformation = "";
            this.Stop_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Stop_Button.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Stop_Button.Location = new System.Drawing.Point(621, 155);
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
            this.Test_Button.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Test_Button.Location = new System.Drawing.Point(621, 240);
            this.Test_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Test_Button.Name = "Test_Button";
            this.Test_Button.Size = new System.Drawing.Size(94, 41);
            this.Test_Button.TabIndex = 3;
            this.Test_Button.UIText = "测试";
            this.Test_Button.Click += new System.EventHandler(this.Test_Button_Click);
            // 
            // SolutionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Test_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.picShow1);
            this.Name = "SolutionTest";
            this.Text = "SolutionTest";
            this.ResumeLayout(false);

        }

        #endregion

        private CommonLibrary.PicShow picShow1;
        private HslCommunication.Controls.UserButton Start_Button;
        private HslCommunication.Controls.UserButton Stop_Button;
        private HslCommunication.Controls.UserButton Test_Button;
    }
}