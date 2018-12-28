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
    class SimpleInfo
    {

        /// <summary>
        /// 对象唯一标识符
        /// </summary>
        public int ID;
        /// <summary>
        /// 名字
        /// </summary>
        public string name;
        /// <summary>
        /// 阵营
        /// </summary>
        public int camp;
        /// <summary>
        /// 最大生命
        /// </summary>
        public float maxHp;
        /// <summary>
        /// 最大攻击
        /// </summary>
        public float maxAtk;
        /// <summary>
        /// 最小攻击
        /// </summary>
        public float minAtk;
        /// <summary>
        /// 防御
        /// </summary>
        public float def;


        public SimpleInfo(int id)
        {
            ID = id;
            //nameLabel.Size = new System.Drawing.Size()
            for (int i = 0; i < GlobalData.Attributes.Count; i++)
            {
                if (GlobalData.Attributes[i].id == ID)
                {
                    name = GlobalData.Attributes[i].name;
                    camp = GlobalData.Attributes[i].camp;
                    maxHp = GlobalData.Attributes[i].hp;
                    maxAtk = GlobalData.Attributes[i].atkMax;
                    def = GlobalData.Attributes[i].def;
                }
            }
            

        }
    }
}
