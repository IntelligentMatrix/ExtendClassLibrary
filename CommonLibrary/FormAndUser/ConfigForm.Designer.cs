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
            this.label_Project = new System.Windows.Forms.Label();
            this.listView_ProjectFlow = new System.Windows.Forms.ListView();
            this.label_ProjectFlow = new System.Windows.Forms.Label();
            this.comboBox_Project = new System.Windows.Forms.ComboBox();
            this.label_Module = new System.Windows.Forms.Label();
            this.listView_Module = new System.Windows.Forms.ListView();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_Right = new System.Windows.Forms.GroupBox();
            this.groupBox_Left = new System.Windows.Forms.GroupBox();
            this.propertyGrid_Mix = new System.Windows.Forms.PropertyGrid();
            this.groupBox_Right.SuspendLayout();
            this.groupBox_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Project
            // 
            this.label_Project.AutoSize = true;
            this.label_Project.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Project.Location = new System.Drawing.Point(109, 30);
            this.label_Project.Name = "label_Project";
            this.label_Project.Size = new System.Drawing.Size(106, 24);
            this.label_Project.TabIndex = 0;
            this.label_Project.Text = "项目列表";
            // 
            // listView_ProjectFlow
            // 
            this.listView_ProjectFlow.Location = new System.Drawing.Point(22, 148);
            this.listView_ProjectFlow.Name = "listView_ProjectFlow";
            this.listView_ProjectFlow.Size = new System.Drawing.Size(281, 552);
            this.listView_ProjectFlow.TabIndex = 1;
            this.listView_ProjectFlow.UseCompatibleStateImageBehavior = false;
            // 
            // label_ProjectFlow
            // 
            this.label_ProjectFlow.AutoSize = true;
            this.label_ProjectFlow.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ProjectFlow.Location = new System.Drawing.Point(109, 108);
            this.label_ProjectFlow.Name = "label_ProjectFlow";
            this.label_ProjectFlow.Size = new System.Drawing.Size(106, 24);
            this.label_ProjectFlow.TabIndex = 2;
            this.label_ProjectFlow.Text = "项目流程";
            // 
            // comboBox_Project
            // 
            this.comboBox_Project.FormattingEnabled = true;
            this.comboBox_Project.Location = new System.Drawing.Point(22, 71);
            this.comboBox_Project.Name = "comboBox_Project";
            this.comboBox_Project.Size = new System.Drawing.Size(281, 26);
            this.comboBox_Project.TabIndex = 3;
            // 
            // label_Module
            // 
            this.label_Module.AutoSize = true;
            this.label_Module.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Module.Location = new System.Drawing.Point(106, 104);
            this.label_Module.Name = "label_Module";
            this.label_Module.Size = new System.Drawing.Size(106, 24);
            this.label_Module.TabIndex = 5;
            this.label_Module.Text = "模块列表";
            // 
            // listView_Module
            // 
            this.listView_Module.Location = new System.Drawing.Point(22, 144);
            this.listView_Module.Name = "listView_Module";
            this.listView_Module.Size = new System.Drawing.Size(281, 633);
            this.listView_Module.TabIndex = 4;
            this.listView_Module.UseCompatibleStateImageBehavior = false;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Image = global::CommonLibrary.Properties.Resources.Delete;
            this.button_Delete.Location = new System.Drawing.Point(230, 722);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(55, 55);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Delete.UseVisualStyleBackColor = false;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Image = global::CommonLibrary.Properties.Resources.Edit_Add;
            this.button_Add.Location = new System.Drawing.Point(40, 722);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(55, 55);
            this.button_Add.TabIndex = 7;
            this.button_Add.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Add.UseVisualStyleBackColor = false;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Image = global::CommonLibrary.Properties.Resources.Exit;
            this.button_Exit.Location = new System.Drawing.Point(248, 37);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(55, 55);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Exit.UseVisualStyleBackColor = false;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Image = global::CommonLibrary.Properties.Resources.Save_File;
            this.button_Save.Location = new System.Drawing.Point(22, 37);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(55, 55);
            this.button_Save.TabIndex = 5;
            this.button_Save.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_Save.UseVisualStyleBackColor = false;
            // 
            // groupBox_Right
            // 
            this.groupBox_Right.Controls.Add(this.label_Module);
            this.groupBox_Right.Controls.Add(this.listView_Module);
            this.groupBox_Right.Controls.Add(this.button_Exit);
            this.groupBox_Right.Controls.Add(this.button_Save);
            this.groupBox_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_Right.Location = new System.Drawing.Point(894, 0);
            this.groupBox_Right.Name = "groupBox_Right";
            this.groupBox_Right.Size = new System.Drawing.Size(323, 801);
            this.groupBox_Right.TabIndex = 9;
            this.groupBox_Right.TabStop = false;
            // 
            // groupBox_Left
            // 
            this.groupBox_Left.Controls.Add(this.button_Delete);
            this.groupBox_Left.Controls.Add(this.button_Add);
            this.groupBox_Left.Controls.Add(this.comboBox_Project);
            this.groupBox_Left.Controls.Add(this.label_ProjectFlow);
            this.groupBox_Left.Controls.Add(this.listView_ProjectFlow);
            this.groupBox_Left.Controls.Add(this.label_Project);
            this.groupBox_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_Left.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Left.Name = "groupBox_Left";
            this.groupBox_Left.Size = new System.Drawing.Size(322, 801);
            this.groupBox_Left.TabIndex = 10;
            this.groupBox_Left.TabStop = false;
            // 
            // propertyGrid_Mix
            // 
            this.propertyGrid_Mix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_Mix.Location = new System.Drawing.Point(322, 0);
            this.propertyGrid_Mix.Name = "propertyGrid_Mix";
            this.propertyGrid_Mix.Size = new System.Drawing.Size(572, 801);
            this.propertyGrid_Mix.TabIndex = 11;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 801);
            this.Controls.Add(this.propertyGrid_Mix);
            this.Controls.Add(this.groupBox_Left);
            this.Controls.Add(this.groupBox_Right);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.groupBox_Right.ResumeLayout(false);
            this.groupBox_Right.PerformLayout();
            this.groupBox_Left.ResumeLayout(false);
            this.groupBox_Left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Project;
        private System.Windows.Forms.ListView listView_ProjectFlow;
        private System.Windows.Forms.Label label_ProjectFlow;
        private System.Windows.Forms.ComboBox comboBox_Project;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_Module;
        private System.Windows.Forms.ListView listView_Module;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.GroupBox groupBox_Right;
        private System.Windows.Forms.GroupBox groupBox_Left;
        private System.Windows.Forms.PropertyGrid propertyGrid_Mix;
    }
}