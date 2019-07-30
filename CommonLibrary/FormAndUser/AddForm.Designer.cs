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
            this.ID_Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Component_Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_Option = new System.Windows.Forms.ComboBox();
            this.groupBox_Left = new System.Windows.Forms.GroupBox();
            this.textBox_Solution = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_OptionList = new System.Windows.Forms.ComboBox();
            this.button_DelOption = new System.Windows.Forms.Button();
            this.button_AddOption = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Solution = new System.Windows.Forms.Label();
            this.propertyGrid_Para = new System.Windows.Forms.PropertyGrid();
            this.groupBox_ComponentList = new System.Windows.Forms.GroupBox();
            this.listView_ComponentList = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Component = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Para = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_OptionComponent = new System.Windows.Forms.GroupBox();
            this.groupBox_ParaConfig = new System.Windows.Forms.GroupBox();
            this.button_AddOptionComponent = new System.Windows.Forms.Button();
            this.button_DelOptionCOmponent = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
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
            this.label_Option.Location = new System.Drawing.Point(12, 62);
            this.label_Option.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Option.Name = "label_Option";
            this.label_Option.Size = new System.Drawing.Size(35, 14);
            this.label_Option.TabIndex = 0;
            this.label_Option.Text = "分组";
            // 
            // listView_OptionComponent
            // 
            this.listView_OptionComponent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_OptionComponent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Header,
            this.Name_Header,
            this.Component_Header});
            this.listView_OptionComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_OptionComponent.Location = new System.Drawing.Point(2, 18);
            this.listView_OptionComponent.Margin = new System.Windows.Forms.Padding(2);
            this.listView_OptionComponent.MultiSelect = false;
            this.listView_OptionComponent.Name = "listView_OptionComponent";
            this.listView_OptionComponent.Size = new System.Drawing.Size(258, 328);
            this.listView_OptionComponent.TabIndex = 1;
            this.listView_OptionComponent.UseCompatibleStateImageBehavior = false;
            this.listView_OptionComponent.View = System.Windows.Forms.View.Details;
            this.listView_OptionComponent.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_OptionComponent_ItemSelectionChanged);
            // 
            // ID_Header
            // 
            this.ID_Header.Text = "ID";
            // 
            // Name_Header
            // 
            this.Name_Header.Text = "Name";
            this.Name_Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Header.Width = 200;
            // 
            // Component_Header
            // 
            this.Component_Header.Text = "Component";
            this.Component_Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Component_Header.Width = 200;
            // 
            // comboBox_Option
            // 
            this.comboBox_Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Option.FormattingEnabled = true;
            this.comboBox_Option.Location = new System.Drawing.Point(59, 59);
            this.comboBox_Option.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Option.Name = "comboBox_Option";
            this.comboBox_Option.Size = new System.Drawing.Size(145, 20);
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
            this.groupBox_Left.Location = new System.Drawing.Point(8, 8);
            this.groupBox_Left.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Left.Name = "groupBox_Left";
            this.groupBox_Left.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Left.Size = new System.Drawing.Size(910, 130);
            this.groupBox_Left.TabIndex = 10;
            this.groupBox_Left.TabStop = false;
            // 
            // textBox_Solution
            // 
            this.textBox_Solution.Location = new System.Drawing.Point(59, 17);
            this.textBox_Solution.Name = "textBox_Solution";
            this.textBox_Solution.ReadOnly = true;
            this.textBox_Solution.Size = new System.Drawing.Size(145, 21);
            this.textBox_Solution.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_OptionList);
            this.groupBox1.Controls.Add(this.button_DelOption);
            this.groupBox1.Controls.Add(this.button_AddOption);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(326, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 104);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_OptionList
            // 
            this.comboBox_OptionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OptionList.FormattingEnabled = true;
            this.comboBox_OptionList.Location = new System.Drawing.Point(78, 23);
            this.comboBox_OptionList.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_OptionList.Name = "comboBox_OptionList";
            this.comboBox_OptionList.Size = new System.Drawing.Size(168, 20);
            this.comboBox_OptionList.TabIndex = 17;
            // 
            // button_DelOption
            // 
            this.button_DelOption.BackColor = System.Drawing.SystemColors.Menu;
            this.button_DelOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DelOption.FlatAppearance.BorderSize = 0;
            this.button_DelOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DelOption.Image = global::CommonLibrary.Properties.Resources.Delete;
            this.button_DelOption.Location = new System.Drawing.Point(194, 51);
            this.button_DelOption.Margin = new System.Windows.Forms.Padding(2);
            this.button_DelOption.Name = "button_DelOption";
            this.button_DelOption.Size = new System.Drawing.Size(52, 47);
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
            this.button_AddOption.Location = new System.Drawing.Point(16, 51);
            this.button_AddOption.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddOption.Name = "button_AddOption";
            this.button_AddOption.Size = new System.Drawing.Size(52, 47);
            this.button_AddOption.TabIndex = 13;
            this.button_AddOption.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_AddOption.UseVisualStyleBackColor = false;
            this.button_AddOption.Click += new System.EventHandler(this.Button_AddOption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "选项列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(252, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "-->";
            // 
            // label_Solution
            // 
            this.label_Solution.AutoSize = true;
            this.label_Solution.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Solution.Location = new System.Drawing.Point(12, 20);
            this.label_Solution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Solution.Name = "label_Solution";
            this.label_Solution.Size = new System.Drawing.Size(35, 14);
            this.label_Solution.TabIndex = 9;
            this.label_Solution.Text = "方案";
            // 
            // propertyGrid_Para
            // 
            this.propertyGrid_Para.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_Para.Location = new System.Drawing.Point(2, 18);
            this.propertyGrid_Para.Margin = new System.Windows.Forms.Padding(2);
            this.propertyGrid_Para.Name = "propertyGrid_Para";
            this.propertyGrid_Para.Size = new System.Drawing.Size(291, 328);
            this.propertyGrid_Para.TabIndex = 11;
            this.propertyGrid_Para.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid_Para_PropertyValueChanged);
            // 
            // groupBox_ComponentList
            // 
            this.groupBox_ComponentList.Controls.Add(this.listView_ComponentList);
            this.groupBox_ComponentList.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ComponentList.Location = new System.Drawing.Point(331, 144);
            this.groupBox_ComponentList.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_ComponentList.Name = "groupBox_ComponentList";
            this.groupBox_ComponentList.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_ComponentList.Size = new System.Drawing.Size(262, 348);
            this.groupBox_ComponentList.TabIndex = 11;
            this.groupBox_ComponentList.TabStop = false;
            this.groupBox_ComponentList.Text = "组件列表";
            // 
            // listView_ComponentList
            // 
            this.listView_ComponentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Component,
            this.columnHeader_Para});
            this.listView_ComponentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_ComponentList.Location = new System.Drawing.Point(2, 18);
            this.listView_ComponentList.Name = "listView_ComponentList";
            this.listView_ComponentList.Size = new System.Drawing.Size(258, 328);
            this.listView_ComponentList.TabIndex = 0;
            this.listView_ComponentList.UseCompatibleStateImageBehavior = false;
            this.listView_ComponentList.View = System.Windows.Forms.View.Details;
            this.listView_ComponentList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ComponentList_ItemSelectionChanged);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 260;
            // 
            // columnHeader_Component
            // 
            this.columnHeader_Component.Text = "Component";
            this.columnHeader_Component.Width = 260;
            // 
            // columnHeader_Para
            // 
            this.columnHeader_Para.Text = "Para";
            this.columnHeader_Para.Width = 260;
            // 
            // groupBox_OptionComponent
            // 
            this.groupBox_OptionComponent.Controls.Add(this.listView_OptionComponent);
            this.groupBox_OptionComponent.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_OptionComponent.Location = new System.Drawing.Point(8, 144);
            this.groupBox_OptionComponent.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_OptionComponent.Name = "groupBox_OptionComponent";
            this.groupBox_OptionComponent.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_OptionComponent.Size = new System.Drawing.Size(262, 348);
            this.groupBox_OptionComponent.TabIndex = 12;
            this.groupBox_OptionComponent.TabStop = false;
            this.groupBox_OptionComponent.Text = "选项组件";
            // 
            // groupBox_ParaConfig
            // 
            this.groupBox_ParaConfig.Controls.Add(this.propertyGrid_Para);
            this.groupBox_ParaConfig.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ParaConfig.Location = new System.Drawing.Point(623, 144);
            this.groupBox_ParaConfig.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_ParaConfig.Name = "groupBox_ParaConfig";
            this.groupBox_ParaConfig.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_ParaConfig.Size = new System.Drawing.Size(295, 348);
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
            this.button_AddOptionComponent.Location = new System.Drawing.Point(274, 271);
            this.button_AddOptionComponent.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddOptionComponent.Name = "button_AddOptionComponent";
            this.button_AddOptionComponent.Size = new System.Drawing.Size(53, 35);
            this.button_AddOptionComponent.TabIndex = 14;
            this.button_AddOptionComponent.Text = "<--";
            this.button_AddOptionComponent.UseVisualStyleBackColor = false;
            this.button_AddOptionComponent.Click += new System.EventHandler(this.Button_AddOptionComponent_Click);
            // 
            // button_DelOptionCOmponent
            // 
            this.button_DelOptionCOmponent.BackColor = System.Drawing.SystemColors.Menu;
            this.button_DelOptionCOmponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DelOptionCOmponent.FlatAppearance.BorderSize = 0;
            this.button_DelOptionCOmponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DelOptionCOmponent.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_DelOptionCOmponent.Location = new System.Drawing.Point(274, 326);
            this.button_DelOptionCOmponent.Margin = new System.Windows.Forms.Padding(2);
            this.button_DelOptionCOmponent.Name = "button_DelOptionCOmponent";
            this.button_DelOptionCOmponent.Size = new System.Drawing.Size(53, 35);
            this.button_DelOptionCOmponent.TabIndex = 15;
            this.button_DelOptionCOmponent.Text = "X";
            this.button_DelOptionCOmponent.UseVisualStyleBackColor = false;
            this.button_DelOptionCOmponent.Click += new System.EventHandler(this.Button_DelOptionCOmponent_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Image = global::CommonLibrary.Properties.Resources.Exit;
            this.button_Exit.Location = new System.Drawing.Point(849, 42);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(37, 37);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Image = global::CommonLibrary.Properties.Resources.Save_File;
            this.button_Save.Location = new System.Drawing.Point(777, 43);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(37, 37);
            this.button_Save.TabIndex = 5;
            this.button_Save.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 518);
            this.Controls.Add(this.button_DelOptionCOmponent);
            this.Controls.Add(this.button_AddOptionComponent);
            this.Controls.Add(this.groupBox_ParaConfig);
            this.Controls.Add(this.groupBox_OptionComponent);
            this.Controls.Add(this.groupBox_ComponentList);
            this.Controls.Add(this.groupBox_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
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
        private System.Windows.Forms.GroupBox groupBox_Left;
        private System.Windows.Forms.PropertyGrid propertyGrid_Para;
        private System.Windows.Forms.Label label_Solution;
        private System.Windows.Forms.GroupBox groupBox_ComponentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DelOption;
        private System.Windows.Forms.Button button_AddOption;
        private System.Windows.Forms.GroupBox groupBox_OptionComponent;
        private System.Windows.Forms.GroupBox groupBox_ParaConfig;
        private System.Windows.Forms.Button button_AddOptionComponent;
        private System.Windows.Forms.Button button_DelOptionCOmponent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Solution;
        private System.Windows.Forms.ComboBox comboBox_OptionList;
        private System.Windows.Forms.ColumnHeader ID_Header;
        private System.Windows.Forms.ColumnHeader Name_Header;
        private System.Windows.Forms.ColumnHeader Component_Header;
        private System.Windows.Forms.ListView listView_ComponentList;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Component;
        private System.Windows.Forms.ColumnHeader columnHeader_Para;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Save;
    }
}