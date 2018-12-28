using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using static DMMFight.GlobalType;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace DMMFight
{
    class CSVRead
    {

        private const string attributesCSVPath = @"C:\Users\mash\Desktop\DMM战斗模拟器\模拟\DMMFight\DMMFight\Tabels\S-属性定义_attributes.csv";
        private const string getFightCSVCSVPath = @"C:\Users\mash\Desktop\DMM战斗模拟器\模拟\DMMFight\DMMFight\Tables\S-属性定义_GetFight.csv";

        public static List<AttributesCSV> ReadAttributesFromCSV()
        {

            string[] des;
            string[] key;
            string[] typestr;
            string[] cs;
            List<AttributesCSV> attributesCSVs = new List<AttributesCSV>();

            FileStream fs = new FileStream(attributesCSVPath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(936));

            des = ConverStr(sr.ReadLine());
            key = ConverStr(sr.ReadLine());
            typestr = ConverStr(sr.ReadLine());
            cs = ConverStr(sr.ReadLine());

            string[] oneline = { "1" };

            while (oneline != null)
            {

                AttributesCSV o = new AttributesCSV();

                oneline = ConverStr(sr.ReadLine());
                if (oneline == null)
                {
                    break;
                }
                for (int i = 0; i < oneline.Length; i++)
                {
                    try
                    {
                        if (typestr[i] == "Int")
                        {
                            SetModelValue(key[i], int.Parse(oneline[i]), o);
                        }
                        else
                        {
                            SetModelValue(key[i], oneline[i], o);
                        }
                        
                    }
                    catch 
                    {
                        Debug.LogOut("设置属性失败,请检查CSV文件是否合法");
                        return null;
                    }
                    
                }
                attributesCSVs.Add(o);
            }

            fs.Close();
            return attributesCSVs;
        }

        public static List<GetFightCSV> ReadGetFightFromCSV()
        {


            string[] des;
            string[] key;
            string[] typestr;
            string[] cs;
            List<GetFightCSV> getFightCSVs = new List<GetFightCSV>();

            FileStream fs = new FileStream(attributesCSVPath, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding(936));

            des = ConverStr(sr.ReadLine());
            key = ConverStr(sr.ReadLine());
            typestr = ConverStr(sr.ReadLine());
            cs = ConverStr(sr.ReadLine());

            string[] oneline = { "1" };

            while (oneline != null)
            {

                GetFightCSV o = new GetFightCSV();

                oneline = ConverStr(sr.ReadLine());
                if (oneline == null)
                {
                    break;
                }
                for (int i = 0; i < oneline.Length; i++)
                {
                    try
                    {
                        if (typestr[i] == "Int")
                        {
                            SetModelValue(key[i], int.Parse(oneline[i]), o);
                        }
                        else
                        {
                            SetModelValue(key[i], oneline[i], o);
                        }

                    }
                    catch
                    {
                        Debug.LogOut("设置属性失败,请检查CSV文件是否合法");
                        return null;
                    }

                }
                getFightCSVs.Add(o);
            }

            fs.Close();
            return getFightCSVs;
        }


        /// <summary>
        /// 获取类中的属性值
        /// </summary>
        /// <param name="FieldName">属性名称</param>
        /// <param name="obj">对象类</param>
        /// <returns>属性的值</returns>
        public static string GetModelValue(string FieldName, object obj)
        {
            try
            {
                Type Ts = obj.GetType();
                object o = Ts.GetProperty(FieldName).GetValue(obj, null);
                string Value = Convert.ToString(o);
                if (string.IsNullOrEmpty(Value)) return null;
                return Value;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 设置类中的属性
        /// </summary>
        /// <param name="FieldName">属性名称</param>
        /// <param name="Value">值</param>
        /// <param name="obj">类对象</param>
        /// <returns></returns>
        public static bool SetModelValue(string FieldName, string Value, object obj)
        {

            try
            {
                Type Ts = obj.GetType();
                var a = Ts.GetProperty(FieldName);

                a.SetValue(obj, Value, null);
                return true;
            }
            catch (Exception e)
            {
                Debug.LogOut(e.Message);
                return false;
            }
        }


        /// <summary>
        /// 设置类中的属性
        /// </summary>
        /// <param name="FieldName">属性名称</param>
        /// <param name="Value">值</param>
        /// <param name="obj">类对象</param>
        /// <returns></returns>
        public static bool SetModelValue(string FieldName, float Value, object obj)
        {

            try
            {
                Type Ts = obj.GetType();
                var a = Ts.GetProperty(FieldName);

                a.SetValue(obj, Value, null);
                return true;
            }
            catch (Exception e)
            {
                Debug.LogOut(e.Message);
                return false;
            }
        }


        /// <summary>
        /// 设置类中的属性
        /// </summary>
        /// <param name="FieldName">属性名称</param>
        /// <param name="Value">值</param>
        /// <param name="obj">类对象</param>
        /// <returns></returns>
        public static bool SetModelValue(string FieldName, int Value, object obj)
        {

            try
            {
                Type Ts = obj.GetType();
                var a = Ts.GetProperty(FieldName);

                a.SetValue(obj, Value, null);
                return true;
            }
            catch (Exception e)
            {
                Debug.LogOut(e.Message);
                return false;
            }
        }

        public static string[] ConverStr(string str)
        {
            if (str == null)
            {
                return null;
            }
            string[] s;
            string b;
            b = str.Remove(0,1);
            b = b.Remove(b.Length - 1, 1);
            b = b.Replace("\",\"", "?");
            s = b.Split('?');
            s = s.Where(sa => !string.IsNullOrEmpty(sa)).ToArray();
            return s;
        }
        /// <summary>
        /// 保存对象到文件中
        /// </summary>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static bool SaveData(Attributes attributes, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            StreamWriter streamWriter = new StreamWriter(fs, Encoding.GetEncoding(936));
            try
            {
                string strxml = XmlSerialize(attributes);
                streamWriter.WriteLine(strxml);
                streamWriter.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                streamWriter.Close();
                fs.Close();
                return false;
                throw;
            }
            
            
        }

        public static Attributes ReadData(string dataSavePath)
        {
            Attributes attributes = new Attributes();
            //反序列化
            FileStream fs = new FileStream(dataSavePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            StreamReader streamReader = new StreamReader(fs, Encoding.GetEncoding(936));
            var str = streamReader.ReadToEnd();

            attributes = DESerializer<Attributes>(str);
            streamReader.Close();
            fs.Close();
            return attributes;
        }
        /// <summary>
        /// 将类序列化为xml格式的字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string XmlSerialize<T>(T obj)
        {
            using (StringWriter sw = new StringWriter())
            {
                Type t = obj.GetType();
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(sw, obj);
                sw.Close();
                return sw.ToString();
            }
        }
        /// <summary>
        /// 将xml格式的字符串反序列化为类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strXML"></param>
        /// <returns></returns>
        public static T DESerializer<T>(string strXML) where T : class
        {
            try
            {
                using (StringReader sr = new StringReader(strXML))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return serializer.Deserialize(sr) as T;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
