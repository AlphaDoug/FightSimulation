using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMMFight
{
    public partial class FightingForm : Form
    {
        /// <summary>
        ///  当前是否仍有对象正在战斗
        /// </summary>
        private bool isFighting = false;
        /// <summary>
        /// 对象池中所有对象的实时战斗类
        /// </summary>
        private List<Fight> fights = new List<Fight>();

        public FightingForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 窗口加载完成之后加载人物属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FightingForm_Load(object sender, EventArgs e)
        {
            CreatRealtimeInfo();
        }
        /// <summary>
        /// 战斗开始,开启对象池中所有玩家的战斗协程
        /// </summary>
        private void FightStart()
        {
            if (isFighting)
            {
                return;
            }
            FightingInfoTextBox.Text = "";
            if (fights.Count != 0)
            {
                fights.Clear();
            }
            for (int i = 0; i < GlobalData.Attributes.Count; i++)
            {
                Fight fight = new Fight(GlobalData.Attributes[i]);
                fight.FightStart();
                fight.OutputInfoEvent += Fight_OutputInfoEvent;
                fights.Add(fight);
            }
            isFighting = true;
        }
        /// <summary>
        /// 输出即时战斗信息并更新血量
        /// </summary>
        /// <param name="fightInfo"></param>
        private void Fight_OutputInfoEvent(FightInfo fightInfo)
        {
            FightingInfoTextBox.Text += fightInfo.GetInfo() + Environment.NewLine;
            //受击方的血量条
            var hpBar = ChooseObjectForm.GetControls(this, "HPBar_" + fightInfo.targetID, 1);
            float maxHP = 0;
            for (int i = 0; i < GlobalData.Attributes.Count; i++)
            {
                if (GlobalData.Attributes[i].id == fightInfo.targetID)
                {
                    maxHP = (float)GlobalData.Attributes[i].GetFightHpMax();
                }
            }
            hpBar[0].Size = new Size((int)(hpBar[0].Size.Width * fightInfo.targetRealtimeHP / maxHP), hpBar[0].Size.Height);
        }
        /// <summary>
        /// 检测战斗是否结束
        /// </summary>
        /// <returns></returns>
        private bool CheckEnd()
        {



            return true;
        }
        /// <summary>
        /// 只剩一方,战斗结束
        /// </summary>
        private void FightStop()
        {
            for (int i = 0; i < fights.Count; i++)
            {
                fights[i].FightStop();
                fights[i].OutputInfoEvent -= Fight_OutputInfoEvent;
                fights[i] = null;
            }
            isFighting = false;
        }
        /// <summary>
        /// 战斗窗口关闭,需要停止所有战斗协程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FightingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < fights.Count; i++)
            {
                fights[i].FightStop();
                fights[i].OutputInfoEvent -= Fight_OutputInfoEvent;
                fights[i] = null;
            }
            //清空数组
            fights.Clear();
        }
        /// <summary>
        /// 开始战斗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartFightBtn_Click(object sender, EventArgs e)
        {
            FightStart();
        }
        /// <summary>
        /// 停止战斗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopFightBtn_Click(object sender, EventArgs e)
        {
            FightStop();
        }
        /// <summary>
        /// 创建实时信息控件
        /// </summary>
        private void CreatRealtimeInfo()
        {
            for (int i = 0; i < GlobalData.Attributes.Count; i++)
            {
                System.Windows.Forms.Panel RealtimeInfo_0;
                System.Windows.Forms.PictureBox pictureBox1;
                System.Windows.Forms.Label NameBox_0;
                System.Windows.Forms.PictureBox HPBar_0;

                NameBox_0 = new System.Windows.Forms.Label();
                RealtimeInfo_0 = new System.Windows.Forms.Panel();
                pictureBox1 = new System.Windows.Forms.PictureBox();
                HPBar_0 = new System.Windows.Forms.PictureBox();

                // 
                // NameBox_0
                // 
                NameBox_0.AutoSize = true;
                NameBox_0.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                NameBox_0.Location = new System.Drawing.Point(29, 7);
                NameBox_0.Name = "NameBox_" + GlobalData.Attributes[i].id;
                NameBox_0.Size = new System.Drawing.Size(93, 19);
                NameBox_0.TabIndex = 0;
                NameBox_0.Text = GlobalData.Attributes[i].name;
                NameBox_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // pictureBox1
                // 
                pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
                pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                pictureBox1.Location = new System.Drawing.Point(7, 30);
                pictureBox1.Name = "pictureBox1";
                pictureBox1.Size = new System.Drawing.Size(134, 18);
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureBox1.TabIndex = 0;
                pictureBox1.TabStop = false;
                // 
                // HPBar_0
                // 
                HPBar_0.Image = global::DMMFight.Properties.Resources.血条1;
                HPBar_0.Location = new System.Drawing.Point(9, 32);
                HPBar_0.Name = "HPBar_" + GlobalData.Attributes[i].id;
                HPBar_0.Size = new System.Drawing.Size(130, 14);
                HPBar_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                HPBar_0.TabIndex = 1;
                HPBar_0.TabStop = false;
                // 
                // RealtimeInfo_0
                // 
                RealtimeInfo_0.AutoSize = true;
                RealtimeInfo_0.Controls.Add(HPBar_0);
                RealtimeInfo_0.Controls.Add(pictureBox1);
                RealtimeInfo_0.Controls.Add(NameBox_0);
                RealtimeInfo_0.Location = new System.Drawing.Point(3, 3);
                RealtimeInfo_0.Name = "RealtimeInfo_" + GlobalData.Attributes[i].id;
                RealtimeInfo_0.Size = new System.Drawing.Size(144, 51);
                RealtimeInfo_0.TabIndex = 0;


                switch (GlobalData.Attributes[i].camp)
                {
                    case 0:
                        CampA.Controls.Add(RealtimeInfo_0);
                        break;
                    case 1:
                        CampB.Controls.Add(RealtimeInfo_0);
                        break;
                    case 2:
                        CampC.Controls.Add(RealtimeInfo_0);
                        break;
                    case 3:
                        CampD.Controls.Add(RealtimeInfo_0);
                        break;
                    case 4:
                        CampE.Controls.Add(RealtimeInfo_0);
                        break;
                    case 5:
                        CampF.Controls.Add(RealtimeInfo_0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
