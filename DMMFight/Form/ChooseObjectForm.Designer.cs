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
            this.FightObjPanel = new System.Windows.Forms.Panel();
            this.StartFight = new System.Windows.Forms.Button();
            this.ReadData = new System.Windows.Forms.Button();
            this.SaveData = new System.Windows.Forms.Button();
            this.AddObj = new System.Windows.Forms.Button();
            this.DeleteObj = new System.Windows.Forms.Button();
            this.RefreshObj = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label84 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.FightObjPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FightObjPanel);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(42, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "对象池";
            // 
            // FightObjPanel
            // 
            this.FightObjPanel.Controls.Add(this.panel3);
            this.FightObjPanel.Location = new System.Drawing.Point(21, 42);
            this.FightObjPanel.Name = "FightObjPanel";
            this.FightObjPanel.Size = new System.Drawing.Size(570, 337);
            this.FightObjPanel.TabIndex = 0;
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
            this.SaveData.Size = new System.Drawing.Size(148, 31);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label95);
            this.panel3.Controls.Add(this.label94);
            this.panel3.Controls.Add(this.label93);
            this.panel3.Controls.Add(this.label92);
            this.panel3.Controls.Add(this.label91);
            this.panel3.Controls.Add(this.label84);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 40);
            this.panel3.TabIndex = 0;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label84.Location = new System.Drawing.Point(7, 10);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(74, 21);
            this.label84.TabIndex = 0;
            this.label84.Text = "模拟小微";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label91.Location = new System.Drawing.Point(101, 10);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(64, 21);
            this.label91.TabIndex = 0;
            this.label91.Text = "label84";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label92.Location = new System.Drawing.Point(209, 10);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(64, 21);
            this.label92.TabIndex = 0;
            this.label92.Text = "label84";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label93.Location = new System.Drawing.Point(303, 10);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(64, 21);
            this.label93.TabIndex = 0;
            this.label93.Text = "label84";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label94.Location = new System.Drawing.Point(397, 10);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(64, 21);
            this.label94.TabIndex = 0;
            this.label94.Text = "label84";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label95.Location = new System.Drawing.Point(479, 10);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(64, 21);
            this.label95.TabIndex = 0;
            this.label95.Text = "label84";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(718, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 405);
            this.tabControl1.TabIndex = 3;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(342, 373);
            this.flowLayoutPanel1.TabIndex = 0;
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
            // ChooseObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1122, 612);
            this.Controls.Add(this.tabControl1);
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
            this.FightObjPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel FightObjPanel;
        private System.Windows.Forms.Button RefreshObj;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}