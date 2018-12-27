namespace DMMFight
{
    partial class FightSimulations
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChooseNumComboBox = new System.Windows.Forms.ComboBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(65, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择对战阵营数量";
            // 
            // ChooseNumComboBox
            // 
            this.ChooseNumComboBox.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChooseNumComboBox.FormattingEnabled = true;
            this.ChooseNumComboBox.Items.AddRange(new object[] {
            "两个",
            "三个",
            "四个",
            "五个",
            "六个"});
            this.ChooseNumComboBox.Location = new System.Drawing.Point(459, 69);
            this.ChooseNumComboBox.Name = "ChooseNumComboBox";
            this.ChooseNumComboBox.Size = new System.Drawing.Size(158, 41);
            this.ChooseNumComboBox.TabIndex = 1;
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextBtn.Location = new System.Drawing.Point(324, 289);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(142, 49);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "下一步";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // FightSimulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ChooseNumComboBox);
            this.Controls.Add(this.label1);
            this.Name = "FightSimulations";
            this.Text = "战斗模拟";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseNumComboBox;
        private System.Windows.Forms.Button NextBtn;
    }
}

