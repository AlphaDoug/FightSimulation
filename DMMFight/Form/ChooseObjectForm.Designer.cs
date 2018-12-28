namespace DMMFight
{
    partial class ChooseObjectForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowPanel_0 = new System.Windows.Forms.Panel();
            this.CampCombox_0 = new System.Windows.Forms.ComboBox();
            this.ShowMaxDef_0 = new System.Windows.Forms.Label();
            this.ShowMaxAtk_0 = new System.Windows.Forms.Label();
            this.ShowHP_0 = new System.Windows.Forms.Label();
            this.ShowPanel_1 = new System.Windows.Forms.Panel();
            this.CampCombox_1 = new System.Windows.Forms.ComboBox();
            this.ShowMaxDef_1 = new System.Windows.Forms.Label();
            this.labelShowMaxAtk_193 = new System.Windows.Forms.Label();
            this.ShowHP_1 = new System.Windows.Forms.Label();
            this.StartFight = new System.Windows.Forms.Button();
            this.ReadData = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.AddObj = new System.Windows.Forms.Button();
            this.DeleteObj = new System.Windows.Forms.Button();
            this.RefreshObj = new System.Windows.Forms.Button();
            this.AttribatesShowTab_0 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowName_0 = new System.Windows.Forms.TextBox();
            this.ShowName_1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.ShowPanel_0.SuspendLayout();
            this.ShowPanel_1.SuspendLayout();
            this.AttribatesShowTab_0.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel4);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(42, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "对象池";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.ShowPanel_0);
            this.flowLayoutPanel4.Controls.Add(this.ShowPanel_1);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 42);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(602, 357);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // ShowPanel_0
            // 
            this.ShowPanel_0.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ShowPanel_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShowPanel_0.Controls.Add(this.ShowName_0);
            this.ShowPanel_0.Controls.Add(this.CampCombox_0);
            this.ShowPanel_0.Controls.Add(this.ShowMaxDef_0);
            this.ShowPanel_0.Controls.Add(this.ShowMaxAtk_0);
            this.ShowPanel_0.Controls.Add(this.ShowHP_0);
            this.ShowPanel_0.Location = new System.Drawing.Point(3, 3);
            this.ShowPanel_0.Name = "ShowPanel_0";
            this.ShowPanel_0.Size = new System.Drawing.Size(587, 44);
            this.ShowPanel_0.TabIndex = 0;
            // 
            // CampCombox_0
            // 
            this.CampCombox_0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CampCombox_0.FormattingEnabled = true;
            this.CampCombox_0.Items.AddRange(new object[] {
            "阵营A",
            "阵营B",
            "阵营C",
            "阵营D",
            "阵营E",
            "阵营F"});
            this.CampCombox_0.Location = new System.Drawing.Point(110, 3);
            this.CampCombox_0.Name = "CampCombox_0";
            this.CampCombox_0.Size = new System.Drawing.Size(85, 30);
            this.CampCombox_0.TabIndex = 1;
            // 
            // ShowMaxDef_0
            // 
            this.ShowMaxDef_0.AutoSize = true;
            this.ShowMaxDef_0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowMaxDef_0.Location = new System.Drawing.Point(465, 10);
            this.ShowMaxDef_0.Name = "ShowMaxDef_0";
            this.ShowMaxDef_0.Size = new System.Drawing.Size(109, 21);
            this.ShowMaxDef_0.TabIndex = 0;
            this.ShowMaxDef_0.Text = "防御:1000000";
            // 
            // ShowMaxAtk_0
            // 
            this.ShowMaxAtk_0.AutoSize = true;
            this.ShowMaxAtk_0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowMaxAtk_0.Location = new System.Drawing.Point(314, 10);
            this.ShowMaxAtk_0.Name = "ShowMaxAtk_0";
            this.ShowMaxAtk_0.Size = new System.Drawing.Size(141, 21);
            this.ShowMaxAtk_0.TabIndex = 0;
            this.ShowMaxAtk_0.Text = "最大攻击:2100000";
            // 
            // ShowHP_0
            // 
            this.ShowHP_0.AutoSize = true;
            this.ShowHP_0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowHP_0.Location = new System.Drawing.Point(201, 10);
            this.ShowHP_0.Name = "ShowHP_0";
            this.ShowHP_0.Size = new System.Drawing.Size(108, 21);
            this.ShowHP_0.TabIndex = 0;
            this.ShowHP_0.Text = "HP:10000000";
            // 
            // ShowPanel_1
            // 
            this.ShowPanel_1.BackColor = System.Drawing.SystemColors.Control;
            this.ShowPanel_1.Controls.Add(this.ShowName_1);
            this.ShowPanel_1.Controls.Add(this.CampCombox_1);
            this.ShowPanel_1.Controls.Add(this.ShowMaxDef_1);
            this.ShowPanel_1.Controls.Add(this.labelShowMaxAtk_193);
            this.ShowPanel_1.Controls.Add(this.ShowHP_1);
            this.ShowPanel_1.Location = new System.Drawing.Point(3, 53);
            this.ShowPanel_1.Name = "ShowPanel_1";
            this.ShowPanel_1.Size = new System.Drawing.Size(587, 44);
            this.ShowPanel_1.TabIndex = 0;
            // 
            // CampCombox_1
            // 
            this.CampCombox_1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CampCombox_1.FormattingEnabled = true;
            this.CampCombox_1.Items.AddRange(new object[] {
            "阵营A",
            "阵营B",
            "阵营C",
            "阵营D",
            "阵营E",
            "阵营F"});
            this.CampCombox_1.Location = new System.Drawing.Point(110, 3);
            this.CampCombox_1.Name = "CampCombox_1";
            this.CampCombox_1.Size = new System.Drawing.Size(85, 30);
            this.CampCombox_1.TabIndex = 1;
            // 
            // ShowMaxDef_1
            // 
            this.ShowMaxDef_1.AutoSize = true;
            this.ShowMaxDef_1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowMaxDef_1.Location = new System.Drawing.Point(465, 10);
            this.ShowMaxDef_1.Name = "ShowMaxDef_1";
            this.ShowMaxDef_1.Size = new System.Drawing.Size(109, 21);
            this.ShowMaxDef_1.TabIndex = 0;
            this.ShowMaxDef_1.Text = "防御:1000000";
            // 
            // labelShowMaxAtk_193
            // 
            this.labelShowMaxAtk_193.AutoSize = true;
            this.labelShowMaxAtk_193.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelShowMaxAtk_193.Location = new System.Drawing.Point(314, 10);
            this.labelShowMaxAtk_193.Name = "labelShowMaxAtk_193";
            this.labelShowMaxAtk_193.Size = new System.Drawing.Size(141, 21);
            this.labelShowMaxAtk_193.TabIndex = 0;
            this.labelShowMaxAtk_193.Text = "最大攻击:2100000";
            // 
            // ShowHP_1
            // 
            this.ShowHP_1.AutoSize = true;
            this.ShowHP_1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowHP_1.Location = new System.Drawing.Point(201, 10);
            this.ShowHP_1.Name = "ShowHP_1";
            this.ShowHP_1.Size = new System.Drawing.Size(108, 21);
            this.ShowHP_1.TabIndex = 0;
            this.ShowHP_1.Text = "HP:10000000";
            // 
            // StartFight
            // 
            this.StartFight.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartFight.Location = new System.Drawing.Point(926, 535);
            this.StartFight.Name = "StartFight";
            this.StartFight.Size = new System.Drawing.Size(148, 65);
            this.StartFight.TabIndex = 2;
            this.StartFight.Text = "开始模拟";
            this.StartFight.UseVisualStyleBackColor = true;
            this.StartFight.Click += new System.EventHandler(this.StartFight_Click);
            // 
            // ReadData
            // 
            this.ReadData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadData.Location = new System.Drawing.Point(926, 479);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(148, 33);
            this.ReadData.TabIndex = 2;
            this.ReadData.Text = "读取玩家属性";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // SaveData
            // 
            this.SaveData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveData.Location = new System.Drawing.Point(718, 479);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(142, 31);
            this.SaveData.TabIndex = 2;
            this.SaveData.Text = "存储玩家属性";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // AddObj
            // 
            this.AddObj.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddObj.Location = new System.Drawing.Point(279, 477);
            this.AddObj.Name = "AddObj";
            this.AddObj.Size = new System.Drawing.Size(148, 31);
            this.AddObj.TabIndex = 2;
            this.AddObj.Text = "增加对象";
            this.AddObj.UseVisualStyleBackColor = true;
            // 
            // DeleteObj
            // 
            this.DeleteObj.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteObj.Location = new System.Drawing.Point(42, 479);
            this.DeleteObj.Name = "DeleteObj";
            this.DeleteObj.Size = new System.Drawing.Size(148, 31);
            this.DeleteObj.TabIndex = 2;
            this.DeleteObj.Text = "删除对象";
            this.DeleteObj.UseVisualStyleBackColor = true;
            // 
            // RefreshObj
            // 
            this.RefreshObj.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RefreshObj.Location = new System.Drawing.Point(508, 477);
            this.RefreshObj.Name = "RefreshObj";
            this.RefreshObj.Size = new System.Drawing.Size(148, 31);
            this.RefreshObj.TabIndex = 2;
            this.RefreshObj.Text = "刷新对象";
            this.RefreshObj.UseVisualStyleBackColor = true;
            this.RefreshObj.Click += new System.EventHandler(this.RefreshObj_Click);
            // 
            // AttribatesShowTab_0
            // 
            this.AttribatesShowTab_0.Controls.Add(this.tabPage1);
            this.AttribatesShowTab_0.Controls.Add(this.tabPage2);
            this.AttribatesShowTab_0.Controls.Add(this.tabPage3);
            this.AttribatesShowTab_0.Location = new System.Drawing.Point(718, 34);
            this.AttribatesShowTab_0.Name = "AttribatesShowTab_0";
            this.AttribatesShowTab_0.SelectedIndex = 0;
            this.AttribatesShowTab_0.Size = new System.Drawing.Size(356, 405);
            this.AttribatesShowTab_0.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基础属性";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(342, 373);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(348, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "进阶属性";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 373);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(348, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "特殊属性";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(342, 373);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // ShowName_0
            // 
            this.ShowName_0.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowName_0.Location = new System.Drawing.Point(5, 4);
            this.ShowName_0.Name = "ShowName_0";
            this.ShowName_0.Size = new System.Drawing.Size(100, 29);
            this.ShowName_0.TabIndex = 2;
            // 
            // ShowName_1
            // 
            this.ShowName_1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowName_1.Location = new System.Drawing.Point(7, 4);
            this.ShowName_1.Name = "ShowName_1";
            this.ShowName_1.Size = new System.Drawing.Size(100, 29);
            this.ShowName_1.TabIndex = 3;
            // 
            // ChooseObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1122, 612);
            this.Controls.Add(this.AttribatesShowTab_0);
            this.Controls.Add(this.DeleteObj);
            this.Controls.Add(this.RefreshObj);
            this.Controls.Add(this.AddObj);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.ReadData);
            this.Controls.Add(this.StartFight);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChooseObjectForm";
            this.Text = "选择对象";
            this.Load += new System.EventHandler(this.ChooseObjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ShowPanel_0.ResumeLayout(false);
            this.ShowPanel_0.PerformLayout();
            this.ShowPanel_1.ResumeLayout(false);
            this.ShowPanel_1.PerformLayout();
            this.AttribatesShowTab_0.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartFight;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button AddObj;
        private System.Windows.Forms.Button DeleteObj;
        private System.Windows.Forms.Button RefreshObj;
        private System.Windows.Forms.Panel ShowPanel_1;
        private System.Windows.Forms.Label ShowMaxDef_1;
        private System.Windows.Forms.Label labelShowMaxAtk_193;
        private System.Windows.Forms.Label ShowHP_1;
        private System.Windows.Forms.TabControl AttribatesShowTab_0;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox CampCombox_1;
        private System.Windows.Forms.Panel ShowPanel_0;
        private System.Windows.Forms.ComboBox CampCombox_0;
        private System.Windows.Forms.Label ShowMaxDef_0;
        private System.Windows.Forms.Label ShowMaxAtk_0;
        private System.Windows.Forms.Label ShowHP_0;
        private System.Windows.Forms.TextBox ShowName_0;
        private System.Windows.Forms.TextBox ShowName_1;
    }
}