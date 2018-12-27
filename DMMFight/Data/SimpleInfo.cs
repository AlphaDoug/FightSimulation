using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMMFight.Data
{
    /// <summary>
    /// 在选择对象时进行简要属性的显示信息类
    /// </summary>
    class SimpleInfo :Panel
    {
        /// <summary>
        /// 名字
        /// </summary>
        private string name;
        /// <summary>
        /// 阵营
        /// </summary>
        private string camp;
        /// <summary>
        /// 最大生命
        /// </summary>
        private string maxHp;
        /// <summary>
        /// 最大攻击
        /// </summary>
        private string maxAtk;
        /// <summary>
        /// 最小攻击
        /// </summary>
        private string minAtk;
        /// <summary>
        /// 防御
        /// </summary>
        private string def;

        private Label nameLabel = new Label();

        private Label campLabel = new Label();

        private Label maxHpLabel = new Label();

        private Label maxAtkLabel = new Label();

        private Label minAtkLabel = new Label();

        private Label defLabel = new Label();

        public SimpleInfo()
        {
            //nameLabel.Size = new System.Drawing.Size()

            Controls.Add(nameLabel);
            Controls.Add(campLabel);
            Controls.Add(maxHpLabel);
            Controls.Add(maxAtkLabel);
            Controls.Add(minAtkLabel);
            Controls.Add(defLabel);
        }
    }
}
