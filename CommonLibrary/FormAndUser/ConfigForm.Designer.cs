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
            this.label_OptionFlow = new System.Windows.Forms.Label();
            this.comboBox_Option = new System.Windows.Forms.ComboBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_Left = new System.Windows.Forms.GroupBox();
            this.propertyGrid_Mix = new System.Windows.Forms.PropertyGrid();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_Solution = new System.Windows.Forms.Label();
            this.groupBox_Right = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_Component = new System.Windows.Forms.ComboBox();
            this.label_ComponentList = new System.Windows.Forms.Label();
            this.listView_ComponentList = new System.Windows.Forms.ListView();
            this.label_Component = new System.Windows.Forms.Label();
            this.groupBox_Top = new System.Windows.Forms.GroupBox();
            this.groupBox_Left.SuspendLayout();
            this.groupBox_Right.SuspendLayout();
            this.groupBox_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Option
            // 
            this.label_Option.AutoSize = true;
            this.label_Option.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Option.Location = new System.Drawing.Point(73, 20);
            this.label_Option.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Option.Name = "label_Option";
            this.label_Option.Size = new System.Drawing.Size(72, 16);
            this.label_Option.TabIndex = 0;
            this.label_Option.Text = "选项分类";
            // 
            // listView_ProjectFlow
            // 
            this.listView_ProjectFlow.Location = new System.Drawing.Point(15, 99);
            this.listView_ProjectFlow.Margin = new System.Windows.Forms.Padding(2);
            this.listView_ProjectFlow.Name = "listView_ProjectFlow";
            this.listView_ProjectFlow.Size = new System.Drawing.Size(189, 321);
            this.listView_ProjectFlow.TabIndex = 1;
            this.listView_ProjectFlow.UseCompatibleStateImageBehavior = false;
            // 
            // label_OptionFlow
            // 
            this.label_OptionFlow.AutoSize = true;
            this.label_OptionFlow.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OptionFlow.Location = new System.Drawing.Point(73, 72);
            this.label_OptionFlow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OptionFlow.Name = "label_OptionFlow";
            this.label_OptionFlow.Size = new System.Drawing.Size(72, 16);
            this.label_OptionFlow.TabIndex = 2;
            this.label_OptionFlow.Text = "选项组件";
            // 
            // comboBox_Option
            // 
            this.comboBox_Option.FormattingEnabled = true;
            this.comboBox_Option.Location = new System.Drawing.Point(15, 47);
            this.comboBox_Option.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Option.Name = "comboBox_Option";
            this.comboBox_Option.Size = new System.Drawing.Size(189, 20);
            this.comboBox_Option.TabIndex = 3;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Image = global::CommonLibrary.Properties.Resources.Delete;
            this.button_Delete.Location = new System.Drawing.Point(487, 470);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(37, 37);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Delete.UseVisualStyleBackColor = false;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Image = global::CommonLibrary.Properties.Resources.Edit_Add;
            this.button_Add.Location = new System.Drawing.Point(277, 470);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(37, 37);
            this.button_Add.TabIndex = 7;
            this.button_Add.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Add.UseVisualStyleBackColor = false;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Image = global::CommonLibrary.Properties.Resources.Exit;
            this.button_Exit.Location = new System.Drawing.Point(725, 16);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(37, 37);
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
            this.button_Save.Location = new System.Drawing.Point(572, 16);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(37, 37);
            this.button_Save.TabIndex = 5;
            this.button_Save.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Save.UseVisualStyleBackColor = false;
            // 
            // groupBox_Left
            // 
            this.groupBox_Left.Controls.Add(this.comboBox_Option);
            this.groupBox_Left.Controls.Add(this.label_OptionFlow);
            this.groupBox_Left.Controls.Add(this.listView_ProjectFlow);
            this.groupBox_Left.Controls.Add(this.label_Option);
            this.groupBox_Left.Location = new System.Drawing.Point(11, 87);
            this.groupBox_Left.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Left.Name = "groupBox_Left";
            this.groupBox_Left.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Left.Size = new System.Drawing.Size(215, 431);
            this.groupBox_Left.TabIndex = 10;
            this.groupBox_Left.TabStop = false;
            // 
            // propertyGrid_Mix
            // 
            this.propertyGrid_Mix.Location = new System.Drawing.Point(261, 107);
            this.propertyGrid_Mix.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGrid_Mix.Name = "propertyGrid_Mix";
            this.propertyGrid_Mix.Size = new System.Drawing.Size(285, 346);
            this.propertyGrid_Mix.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // label_Solution
            // 
            this.label_Solution.AutoSize = true;
            this.label_Solution.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Solution.Location = new System.Drawing.Point(11, 26);
            this.label_Solution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Solution.Name = "label_Solution";
            this.label_Solution.Size = new System.Drawing.Size(72, 16);
            this.label_Solution.TabIndex = 9;
            this.label_Solution.Text = "解决方案";
            // 
            // groupBox_Right
            // 
            this.groupBox_Right.Controls.Add(this.button1);
            this.groupBox_Right.Controls.Add(this.button2);
            this.groupBox_Right.Controls.Add(this.comboBox_Component);
            this.groupBox_Right.Controls.Add(this.label_ComponentList);
            this.groupBox_Right.Controls.Add(this.listView_ComponentList);
            this.groupBox_Right.Controls.Add(this.label_Component);
            this.groupBox_Right.Location = new System.Drawing.Point(581, 87);
            this.groupBox_Right.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Right.Name = "groupBox_Right";
            this.groupBox_Right.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Right.Size = new System.Drawing.Size(215, 431);
            this.groupBox_Right.TabIndex = 11;
            this.groupBox_Right.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CommonLibrary.Properties.Resources.Delete;
            this.button1.Location = new System.Drawing.Point(153, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 37);
            this.button1.TabIndex = 8;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::CommonLibrary.Properties.Resources.Edit_Add;
            this.button2.Location = new System.Drawing.Point(27, 481);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 37);
            this.button2.TabIndex = 7;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox_Component
            // 
            this.comboBox_Component.FormattingEnabled = true;
            this.comboBox_Component.Location = new System.Drawing.Point(15, 47);
            this.comboBox_Component.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Component.Name = "comboBox_Component";
            this.comboBox_Component.Size = new System.Drawing.Size(189, 20);
            this.comboBox_Component.TabIndex = 3;
            // 
            // label_ComponentList
            // 
            this.label_ComponentList.AutoSize = true;
            this.label_ComponentList.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ComponentList.Location = new System.Drawing.Point(73, 72);
            this.label_ComponentList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ComponentList.Name = "label_ComponentList";
            this.label_ComponentList.Size = new System.Drawing.Size(72, 16);
            this.label_ComponentList.TabIndex = 2;
            this.label_ComponentList.Text = "组件列表";
            // 
            // listView_ComponentList
            // 
            this.listView_ComponentList.Location = new System.Drawing.Point(15, 99);
            this.listView_ComponentList.Margin = new System.Windows.Forms.Padding(2);
            this.listView_ComponentList.Name = "listView_ComponentList";
            this.listView_ComponentList.Size = new System.Drawing.Size(189, 321);
            this.listView_ComponentList.TabIndex = 1;
            this.listView_ComponentList.UseCompatibleStateImageBehavior = false;
            // 
            // label_Component
            // 
            this.label_Component.AutoSize = true;
            this.label_Component.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Component.Location = new System.Drawing.Point(73, 20);
            this.label_Component.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Component.Name = "label_Component";
            this.label_Component.Size = new System.Drawing.Size(72, 16);
            this.label_Component.TabIndex = 0;
            this.label_Component.Text = "组件类型";
            // 
            // groupBox_Top
            // 
            this.groupBox_Top.Controls.Add(this.comboBox1);
            this.groupBox_Top.Controls.Add(this.button_Exit);
            this.groupBox_Top.Controls.Add(this.label_Solution);
            this.groupBox_Top.Controls.Add(this.button_Save);
            this.groupBox_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Top.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Top.Name = "groupBox_Top";
            this.groupBox_Top.Size = new System.Drawing.Size(812, 71);
            this.groupBox_Top.TabIndex = 12;
            this.groupBox_Top.TabStop = false;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 527);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.groupBox_Top);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.groupBox_Right);
            this.Controls.Add(this.propertyGrid_Mix);
            this.Controls.Add(this.groupBox_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox_Left.ResumeLayout(false);
            this.groupBox_Left.PerformLayout();
            this.groupBox_Right.ResumeLayout(false);
            this.groupBox_Right.PerformLayout();
            this.groupBox_Top.ResumeLayout(false);
            this.groupBox_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Option;
        private System.Windows.Forms.ListView listView_ProjectFlow;
        private System.Windows.Forms.Label label_OptionFlow;
        private System.Windows.Forms.ComboBox comboBox_Option;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.GroupBox groupBox_Left;
        private System.Windows.Forms.PropertyGrid propertyGrid_Mix;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Solution;
        private System.Windows.Forms.GroupBox groupBox_Right;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_Component;
        private System.Windows.Forms.Label label_ComponentList;
        private System.Windows.Forms.ListView listView_ComponentList;
        private System.Windows.Forms.Label label_Component;
        private System.Windows.Forms.GroupBox groupBox_Top;
    }
}