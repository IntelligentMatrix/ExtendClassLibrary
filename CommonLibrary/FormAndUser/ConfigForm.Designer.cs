namespace CommonLibrary.FormAndUser
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.label_Option = new System.Windows.Forms.Label();
            this.listView_ProjectFlow = new System.Windows.Forms.ListView();
            this.comboBox_Option = new System.Windows.Forms.ComboBox();
            this.groupBox_Left = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_Solution = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.propertyGrid_Mix = new System.Windows.Forms.PropertyGrid();
            this.groupBox_Right = new System.Windows.Forms.GroupBox();
            this.listView_ComponentList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox_Left.SuspendLayout();
            this.groupBox_Right.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Option
            // 
            this.label_Option.AutoSize = true;
            this.label_Option.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Option.Location = new System.Drawing.Point(18, 78);
            this.label_Option.Name = "label_Option";
            this.label_Option.Size = new System.Drawing.Size(54, 21);
            this.label_Option.TabIndex = 0;
            this.label_Option.Text = "分组";
            // 
            // listView_ProjectFlow
            // 
            this.listView_ProjectFlow.Location = new System.Drawing.Point(17, 50);
            this.listView_ProjectFlow.Name = "listView_ProjectFlow";
            this.listView_ProjectFlow.Size = new System.Drawing.Size(282, 455);
            this.listView_ProjectFlow.TabIndex = 1;
            this.listView_ProjectFlow.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox_Option
            // 
            this.comboBox_Option.FormattingEnabled = true;
            this.comboBox_Option.Location = new System.Drawing.Point(88, 75);
            this.comboBox_Option.Name = "comboBox_Option";
            this.comboBox_Option.Size = new System.Drawing.Size(216, 26);
            this.comboBox_Option.TabIndex = 3;
            // 
            // groupBox_Left
            // 
            this.groupBox_Left.Controls.Add(this.comboBox1);
            this.groupBox_Left.Controls.Add(this.button4);
            this.groupBox_Left.Controls.Add(this.button_Exit);
            this.groupBox_Left.Controls.Add(this.comboBox_Option);
            this.groupBox_Left.Controls.Add(this.button_Save);
            this.groupBox_Left.Controls.Add(this.button3);
            this.groupBox_Left.Controls.Add(this.comboBox2);
            this.groupBox_Left.Controls.Add(this.label_Solution);
            this.groupBox_Left.Controls.Add(this.label_Option);
            this.groupBox_Left.Controls.Add(this.label1);
            this.groupBox_Left.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Left.Name = "groupBox_Left";
            this.groupBox_Left.Size = new System.Drawing.Size(1187, 220);
            this.groupBox_Left.TabIndex = 10;
            this.groupBox_Left.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 26);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(88, 125);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 26);
            this.comboBox2.TabIndex = 11;
            // 
            // label_Solution
            // 
            this.label_Solution.AutoSize = true;
            this.label_Solution.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Solution.Location = new System.Drawing.Point(18, 28);
            this.label_Solution.Name = "label_Solution";
            this.label_Solution.Size = new System.Drawing.Size(54, 21);
            this.label_Solution.TabIndex = 9;
            this.label_Solution.Text = "方案";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "选项";
            // 
            // propertyGrid_Mix
            // 
            this.propertyGrid_Mix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_Mix.Location = new System.Drawing.Point(3, 27);
            this.propertyGrid_Mix.Name = "propertyGrid_Mix";
            this.propertyGrid_Mix.Size = new System.Drawing.Size(316, 492);
            this.propertyGrid_Mix.TabIndex = 11;
            // 
            // groupBox_Right
            // 
            this.groupBox_Right.Controls.Add(this.listView_ComponentList);
            this.groupBox_Right.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Right.Location = new System.Drawing.Point(446, 253);
            this.groupBox_Right.Name = "groupBox_Right";
            this.groupBox_Right.Size = new System.Drawing.Size(322, 522);
            this.groupBox_Right.TabIndex = 11;
            this.groupBox_Right.TabStop = false;
            this.groupBox_Right.Text = "组件列表";
            // 
            // listView_ComponentList
            // 
            this.listView_ComponentList.Location = new System.Drawing.Point(21, 50);
            this.listView_ComponentList.Name = "listView_ComponentList";
            this.listView_ComponentList.Size = new System.Drawing.Size(282, 455);
            this.listView_ComponentList.TabIndex = 1;
            this.listView_ComponentList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_ProjectFlow);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 522);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项组件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.propertyGrid_Mix);
            this.groupBox2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(880, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 522);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数配置";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::CommonLibrary.Properties.Resources.Delete;
            this.button4.Location = new System.Drawing.Point(248, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 56);
            this.button4.TabIndex = 13;
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Image = global::CommonLibrary.Properties.Resources.Exit;
            this.button_Exit.Location = new System.Drawing.Point(1114, 23);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(56, 56);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Exit.UseVisualStyleBackColor = false;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Image = global::CommonLibrary.Properties.Resources.Save_File;
            this.button_Save.Location = new System.Drawing.Point(1014, 26);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(56, 56);
            this.button_Save.TabIndex = 5;
            this.button_Save.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Save.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::CommonLibrary.Properties.Resources.Edit_Add;
            this.button3.Location = new System.Drawing.Point(88, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 56);
            this.button3.TabIndex = 13;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 790);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Right);
            this.Controls.Add(this.groupBox_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox_Left.ResumeLayout(false);
            this.groupBox_Left.PerformLayout();
            this.groupBox_Right.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Option;
        private System.Windows.Forms.ListView listView_ProjectFlow;
        private System.Windows.Forms.ComboBox comboBox_Option;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.GroupBox groupBox_Left;
        private System.Windows.Forms.PropertyGrid propertyGrid_Mix;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Solution;
        private System.Windows.Forms.GroupBox groupBox_Right;
        private System.Windows.Forms.ListView listView_ComponentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}