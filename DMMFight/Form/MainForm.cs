using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMMFight
{
    public partial class FightSimulations : Form
    {
        public FightSimulations()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 主窗口加载回调
        /// </summary>
        /// <param name="sender">回调发起</param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ChooseNumComboBox.SelectedIndex = 0;

        }

        /// <summary>
        /// 主界面点击下一步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            GlobalData.AttributesCSVs = CSVRead.ReadAttributesFromCSV();
            GlobalData.GetFightCSVs = CSVRead.ReadGetFightFromCSV();
            if (GlobalData.AttributesCSVs == null || GlobalData.GetFightCSVs == null)
            {
                MessageBox.Show("属性表解析失败,请检查CSV文件");
                return;
            }

            //CreatNewClassTxt();
            CreatNewGetFight();

            var content = ChooseNumComboBox.SelectedIndex;

            if (content == -1)
            {
                MessageBox.Show("请选择对战阵营数量!");
                return;
            }

            var newForm = new ChooseObjectForm(content, this);
            newForm.ShowDialog();

        }
        /// <summary>
        /// 根据属性表中的数据创建属性类
        /// </summary>
        private void CreatNewClassTxt()
        {
            FileStream fs = new FileStream("D:\\AAA\\A.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(936));
            for (int i = 0; i < GlobalData.AttributesCSVs.Count; i++)
            {
                var line1 = @"/// <summary>";
                var line2 = @"/// " + GlobalData.AttributesCSVs[i].name;
                var line3 = @"/// </summary>";
                var line4 = @"public float " + GlobalData.AttributesCSVs[i].key + @" { set; get; }";
                sw.WriteLine(line1);
                sw.WriteLine(line2);
                sw.WriteLine(line3);
                sw.WriteLine(line4);
            }

            sw.Close();
            fs.Close();
        }
        /// <summary>
        /// 战斗即时属性计算
        /// </summary>
        private void CreatNewGetFight()
        {
            FileStream fs = new FileStream("D:\\AAA\\B.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding(936));
            for (int i = 0; i < GlobalData.GetFightCSVs.Count; i++)
            {
                var line1 = @"/// <summary>";
                var line2 = @"/// " + GlobalData.GetFightCSVs[i].name;
                var line3 = @"/// </summary>";
                var line4 = @"public double " + GlobalData.GetFightCSVs[i].key + @"()";
                var line5 = @"{";
                var line6 = @"return " + GlobalData.GetFightCSVs[i].count + ";";
                var line7 = @"}";
                sw.WriteLine(line1);
                sw.WriteLine(line2);
                sw.WriteLine(line3);
                sw.WriteLine(line4);
                sw.WriteLine(line5);
                sw.WriteLine(line6);
                sw.WriteLine(line7);
            }

            sw.Close();
            fs.Close();
        }
    }
}
