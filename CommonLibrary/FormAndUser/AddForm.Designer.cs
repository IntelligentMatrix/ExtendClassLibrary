namespace CommonLibrary.FormAndUser
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label_Option = new System.Windows.Forms.Label();
            this.listView_OptionComponent = new System.Windows.Forms.ListView();
            this.comboBox_Option = new System.Windows.Forms.ComboBox();
            this.groupBox_Left = new System.Windows.Forms.GroupBox();
            this.textBox_Solution = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_OptionName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_DelOption = new System.Windows.Forms.Button();
            this.button_AddOption = new System.Windows.Forms.Button();
            this.comboBox_OptionList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Solution = new System.Windows.Forms.Label();
            this.propertyGrid_Para = new System.Windows.Forms.PropertyGrid();
            this.groupBox_ComponentList = new System.Windows.Forms.GroupBox();
            this.listView_ComponentList = new System.Windows.Forms.ListView();
            this.groupBox_OptionComponent = new System.Windows.Forms.GroupBox();
            this.groupBox_ParaConfig = new System.Windows.Forms.GroupBox();
            this.button_AddOptionComponent = new System.Windows.Forms.Button();
            this.button_DelOptionCOmponent = new System.Windows.Forms.Button();
            this.groupBox_Left.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_ComponentList.SuspendLayout();
            this.groupBox_OptionComponent.SuspendLayout();
            this.groupBox_ParaConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Option
            // 
            this.label_Option.AutoSize = true;
            this.label_Option.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Option.Location = new System.Drawing.Point(18, 124);
            this.label_Option.Name = "label_Option";
            this.label_Option.Size = new System.Drawing.Size(54, 21);
            this.label_Option.TabIndex = 0;
            this.label_Option.Text = "分组";
            // 
            // listView_OptionComponent
            // 
            this.listView_OptionComponent.Location = new System.Drawing.Point(16, 50);
            this.listView_OptionComponent.Name = "listView_OptionComponent";
            this.listView_OptionComponent.Size = new System.Drawing.Size(282, 456);
            this.listView_OptionComponent.TabIndex = 1;
            this.listView_OptionComponent.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox_Option
            // 
            this.comboBox_Option.FormattingEnabled = true;
            this.comboBox_Option.Location = new System.Drawing.Point(88, 120);
            this.comboBox_Option.Name = "comboBox_Option";
            this.comboBox_Option.Size = new System.Drawing.Size(216, 26);
            this.comboBox_Option.TabIndex = 3;
            this.comboBox_Option.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Option_SelectedIndexChanged);
            // 
            // groupBox_Left
            // 
            this.groupBox_Left.Controls.Add(this.textBox_Solution);
            this.groupBox_Left.Controls.Add(this.groupBox1);
            this.groupBox_Left.Controls.Add(this.label2);
            this.groupBox_Left.Controls.Add(this.button_Exit);
            this.groupBox_Left.Controls.Add(this.comboBox_Option);
            this.groupBox_Left.Controls.Add(this.button_Save);
            this.groupBox_Left.Controls.Add(this.label_Solution);
            this.groupBox_Left.Controls.Add(this.label_Option);
            this.groupBox_Left.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Left.Name = "groupBox_Left";
            this.groupBox_Left.Size = new System.Drawing.Size(1186, 220);
            this.groupBox_Left.TabIndex = 10;
            this.groupBox_Left.TabStop = false;
            // 
            // textBox_Solution
            // 
            this.textBox_Solution.Location = new System.Drawing.Point(88, 26);
            this.textBox_Solution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Solution.Name = "textBox_Solution";
            this.textBox_Solution.ReadOnly = true;
            this.textBox_Solution.Size = new System.Drawing.Size(216, 28);
            this.textBox_Solution.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_OptionName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_DelOption);
            this.groupBox1.Controls.Add(this.button_AddOption);
            this.groupBox1.Controls.Add(this.comboBox_OptionList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(392, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(430, 156);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // textBox_OptionName
            // 
            this.textBox_OptionName.Location = new System.Drawing.Point(117, 105);
            this.textBox_OptionName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_OptionName.Name = "textBox_OptionName";
            this.textBox_OptionName.Size = new System.Drawing.Size(193, 28);
            this.textBox_OptionName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "选项Name";
            // 
            // button_DelOption
            // 
            this.button_DelOption.BackColor = System.Drawing.SystemColors.Menu;
            this.button_DelOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DelOption.FlatAppearance.BorderSize = 0;
            this.button_DelOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DelOption.Image = global::CommonLibrary.Properties.Resources.Delete;
            this.button_DelOption.Location = new System.Drawing.Point(340, 93);
            this.button_DelOption.Name = "button_DelOption";
            this.button_DelOption.Size = new System.Drawing.Size(56, 56);
            this.button_DelOption.TabIndex = 13;
            this.button_DelOption.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_DelOption.UseVisualStyleBackColor = false;
            this.button_DelOption.Click += new System.EventHandler(this.Button_DelOption_Click);
            // 
            // button_AddOption
            // 
            this.button_AddOption.BackColor = System.Drawing.SystemColors.Menu;
            this.button_AddOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddOption.FlatAppearance.BorderSize = 0;
            this.button_AddOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOption.Image = global::CommonLibrary.Properties.Resources.Edit_Add;
            this.button_AddOption.Location = new System.Drawing.Point(339, 22);
            this.button_AddOption.Name = "button_AddOption";
            this.button_AddOption.Size = new System.Drawing.Size(56, 56);
            this.button_AddOption.TabIndex = 13;
            this.button_AddOption.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_AddOption.UseVisualStyleBackColor = false;
            this.button_AddOption.Click += new System.EventHandler(this.Button_AddOption_Click);
            // 
            // comboBox_OptionList
            // 
            this.comboBox_OptionList.FormattingEnabled = true;
            this.comboBox_OptionList.Location = new System.Drawing.Point(117, 34);
            this.comboBox_OptionList.Name = "comboBox_OptionList";
            this.comboBox_OptionList.Size = new System.Drawing.Size(193, 26);
            this.comboBox_OptionList.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "选项ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(334, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "-->";
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Image = global::CommonLibrary.Properties.Resources.Exit;
            this.button_Exit.Location = new System.Drawing.Point(1114, 22);
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
            // label_Solution
            // 
            this.label_Solution.AutoSize = true;
            this.label_Solution.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Solution.Location = new System.Drawing.Point(18, 30);
            this.label_Solution.Name = "label_Solution";
            this.label_Solution.Size = new System.Drawing.Size(54, 21);
            this.label_Solution.TabIndex = 9;
            this.label_Solution.Text = "方案";
            // 
            // propertyGrid_Para
            // 
            this.propertyGrid_Para.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_Para.Location = new System.Drawing.Point(3, 27);
            this.propertyGrid_Para.Name = "propertyGrid_Para";
            this.propertyGrid_Para.Size = new System.Drawing.Size(316, 492);
            this.propertyGrid_Para.TabIndex = 11;
            // 
            // groupBox_ComponentList
            // 
            this.groupBox_ComponentList.Controls.Add(this.listView_ComponentList);
            this.groupBox_ComponentList.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ComponentList.Location = new System.Drawing.Point(446, 254);
            this.groupBox_ComponentList.Name = "groupBox_ComponentList";
            this.groupBox_ComponentList.Size = new System.Drawing.Size(322, 522);
            this.groupBox_ComponentList.TabIndex = 11;
            this.groupBox_ComponentList.TabStop = false;
            this.groupBox_ComponentList.Text = "组件列表";
            // 
            // listView_ComponentList
            // 
            this.listView_ComponentList.Location = new System.Drawing.Point(21, 50);
            this.listView_ComponentList.Name = "listView_ComponentList";
            this.listView_ComponentList.Size = new System.Drawing.Size(282, 456);
            this.listView_ComponentList.TabIndex = 1;
            this.listView_ComponentList.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox_OptionComponent
            // 
            this.groupBox_OptionComponent.Controls.Add(this.listView_OptionComponent);
            this.groupBox_OptionComponent.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_OptionComponent.Location = new System.Drawing.Point(12, 254);
            this.groupBox_OptionComponent.Name = "groupBox_OptionComponent";
            this.groupBox_OptionComponent.Size = new System.Drawing.Size(322, 522);
            this.groupBox_OptionComponent.TabIndex = 12;
            this.groupBox_OptionComponent.TabStop = false;
            this.groupBox_OptionComponent.Text = "选项组件";
            // 
            // groupBox_ParaConfig
            // 
            this.groupBox_ParaConfig.Controls.Add(this.propertyGrid_Para);
            this.groupBox_ParaConfig.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ParaConfig.Location = new System.Drawing.Point(880, 254);
            this.groupBox_ParaConfig.Name = "groupBox_ParaConfig";
            this.groupBox_ParaConfig.Size = new System.Drawing.Size(322, 522);
            this.groupBox_ParaConfig.TabIndex = 12;
            this.groupBox_ParaConfig.TabStop = false;
            this.groupBox_ParaConfig.Text = "参数配置";
            // 
            // button_AddOptionComponent
            // 
            this.button_AddOptionComponent.BackColor = System.Drawing.SystemColors.Menu;
            this.button_AddOptionComponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddOptionComponent.FlatAppearance.BorderSize = 0;
            this.button_AddOptionComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddOptionComponent.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_AddOptionComponent.Location = new System.Drawing.Point(351, 489);
            this.button_AddOptionComponent.Name = "button_AddOptionComponent";
            this.button_AddOptionComponent.Size = new System.Drawing.Size(80, 52);
            this.button_AddOptionComponent.TabIndex = 14;
            this.button_AddOptionComponent.Text = "<--";
            this.button_AddOptionComponent.UseVisualStyleBackColor = false;
            // 
            // button_DelOptionCOmponent
            // 
            this.button_DelOptionCOmponent.BackColor = System.Drawing.SystemColors.Menu;
            this.button_DelOptionCOmponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DelOptionCOmponent.FlatAppearance.BorderSize = 0;
            this.button_DelOptionCOmponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DelOptionCOmponent.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_DelOptionCOmponent.Location = new System.Drawing.Point(351, 572);
            this.button_DelOptionCOmponent.Name = "button_DelOptionCOmponent";
            this.button_DelOptionCOmponent.Size = new System.Drawing.Size(80, 52);
            this.button_DelOptionCOmponent.TabIndex = 15;
            this.button_DelOptionCOmponent.Text = "X";
            this.button_DelOptionCOmponent.UseVisualStyleBackColor = false;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 794);
            this.Controls.Add(this.button_DelOptionCOmponent);
            this.Controls.Add(this.button_AddOptionComponent);
            this.Controls.Add(this.groupBox_ParaConfig);
            this.Controls.Add(this.groupBox_OptionComponent);
            this.Controls.Add(this.groupBox_ComponentList);
            this.Controls.Add(this.groupBox_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox_Left.ResumeLayout(false);
            this.groupBox_Left.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_ComponentList.ResumeLayout(false);
            this.groupBox_OptionComponent.ResumeLayout(false);
            this.groupBox_ParaConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Option;
        private System.Windows.Forms.ListView listView_OptionComponent;
        private System.Windows.Forms.ComboBox comboBox_Option;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.GroupBox groupBox_Left;
        private System.Windows.Forms.PropertyGrid propertyGrid_Para;
        private System.Windows.Forms.Label label_Solution;
        private System.Windows.Forms.GroupBox groupBox_ComponentList;
        private System.Windows.Forms.ListView listView_ComponentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DelOption;
        private System.Windows.Forms.Button button_AddOption;
        private System.Windows.Forms.ComboBox comboBox_OptionList;
        private System.Windows.Forms.GroupBox groupBox_OptionComponent;
        private System.Windows.Forms.GroupBox groupBox_ParaConfig;
        private System.Windows.Forms.Button button_AddOptionComponent;
        private System.Windows.Forms.Button button_DelOptionCOmponent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_OptionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Solution;
    }
}