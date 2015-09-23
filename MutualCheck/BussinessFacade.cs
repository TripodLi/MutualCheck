using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MutualCheck
{
    public class BussinessFacade
    {
        /// <summary>
        /// 写日志时加锁
        /// </summary>
        private static object m_Lock = new object();
        /// <summary>
        /// 程序启动路径
        /// </summary>
        public static string BasePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
        /// <summary>
        /// 读取数据库和功能配置文件文件
        /// </summary>
        /// <param name="node"></param>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public static string GetXml(string node, string attribute)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "DataBaseMap.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("Config");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.Name == node)
                {
                    result = xe.GetAttribute(attribute);
                }
            }
            return result;
        }
        /// <summary>
        /// 读取最后一条序列号的相关信息
        /// </summary>
        /// <param name="node"></param>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public static string GetLastNoXml(string attribute)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "LastNo.xml";
            xmlDoc.Load(addr);
            XmlNode alarmNode = xmlDoc.SelectSingleNode("config");
            XmlNodeList keys = alarmNode.ChildNodes;
            foreach (XmlNode key in keys)
            {
                if (key.Attributes["name"] != null && key.Attributes["name"].Value.Length > 0 && key.Attributes["name"].Value == attribute)
                {
                    result = key.InnerText;
                }
            }
            return result;
        }
        /// <summary>
        /// 写入每次生成的序列号
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static bool SetLastNoXml(string name, string value)
        {
            var result = true;
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                string addr = "LastNo.xml";
                xmlDoc.Load(addr);
                XmlNode config = xmlDoc.SelectSingleNode("config");
                XmlNodeList keys = config.ChildNodes;
                foreach (XmlNode key in keys)
                {
                    if (key.Attributes["name"] != null && key.Attributes["name"].Value.Length > 0 && key.Attributes["name"].Value == name)
                    {
                        key.InnerText = value;
                    }
                }
                xmlDoc.Save(addr);
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
        /// <summary>
        /// 获取配置文件工位
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetStationByItem(string item)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "opc.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("OPC");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("client") == item)
                {
                    result = xe.GetAttribute("station");
                }
            }
            return result;
        }
        /// <summary>
        /// 获取配置文件类型
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetTypeByItem(string item)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "opc.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("OPC");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("client") == item)
                {
                    result = xe.GetAttribute("type");
                }
            }
            return result;
        }
        /// <summary>
        /// 获取配置文件顺序
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string GetOrderByItem(string item)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "opc.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("OPC");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("client") == item)
                {
                    result = xe.GetAttribute("order");
                }
            }
            return result;
        }
        public static string GetClientByStationAndType(string station, string type)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "opc.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("OPC");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("station") == station && xe.GetAttribute("type") == type)
                {
                    result = xe.GetAttribute("client");
                }
            }
            return result;
        }
        /// <summary>
        /// 读取opc配置文件 根据工位和order 得到特定变量的值
        /// </summary>
        /// <param name="node"></param>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public static string GetOpcConfigXml(string station, string order, string type)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "opc.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("OPC");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("station") == station && xe.GetAttribute("order") == order && xe.GetAttribute("type") == type)
                {
                    result = xe.GetAttribute("client");
                }
            }
            return result;
        }
        /// <summary>
        /// 获取CONFIG配置文件中的值
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetConfigXml(string type, string goal)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "config.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("Config");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("type") == type)
                {
                    result = xe.GetAttribute(goal);
                }
            }
            return result;
        }
        /// <summary>  
        /// datatable转换为list的方法
        /// </summary>  
        /// <param name="dt"></param>  
        /// <returns></returns>  
        public static List<String> ConvertToList(DataTable dt)
        {

            // 定义集合  
            List<String> ts = new List<String>();

            // 获得此模型的类型  
            Type type = typeof(String);
            //定义一个临时变量  
            string tempName = string.Empty;
            //遍历DataTable中所有的数据行  
            foreach (DataRow dr in dt.Rows)
            {
                String t = null;
                // 获得此模型的公共属性  
                PropertyInfo[] propertys = t.GetType().GetProperties();
                //遍历该对象的所有属性  
                foreach (PropertyInfo pi in propertys)
                {
                    tempName = pi.Name;//将属性名称赋值给临时变量  
                    //检查DataTable是否包含此列（列名==对象的属性名）    
                    if (dt.Columns.Contains(tempName))
                    {
                        // 判断此属性是否有Setter  
                        if (!pi.CanWrite) continue;//该属性不可写，直接跳出  
                        //取值  
                        object value = dr[tempName];
                        //如果非空，则赋给对象的属性  
                        if (value != DBNull.Value)
                            pi.SetValue(t, value, null);
                    }
                }
                //对象添加到泛型集合中  
                ts.Add(t);
            }

            return ts;

        }
        /// <summary>
        /// 写一条日志到日志文件中
        /// </summary>
        /// <param name="data"></param>
        public static void WriteLog(string data)
        {
            if (!Directory.Exists(BasePath + "\\log\\"))
            {
                Directory.CreateDirectory(BasePath + "\\log\\");
            }
            var logFiles = Directory.GetFiles(BasePath + "\\log\\");
            if (logFiles.Length >= 5 && !logFiles.Contains<string>(DateTime.Now.ToString("yyyyMMdd") + ".log"))
            {
                var deleteFile = BasePath + "\\log\\" + DateTime.Now.AddDays(-logFiles.Length).ToString("yyyyMMdd") + ".log";
                if (File.Exists(deleteFile))
                {
                    File.Delete(deleteFile);
                }
            }
            var fileName = BasePath + "\\log\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            lock (m_Lock)
            {
                try
                {
                    FileInfo file = new FileInfo(fileName);
                    if (!file.Exists)
                    {
                        file.Create();
                    }
                    //定位到文件尾
                    StreamWriter stream = file.AppendText();
                    //写当前的时间
                    stream.Write(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss fff]"));
                    //写用户传过来的字符串
                    stream.WriteLine(data);
                    //最后记着要关了它
                    stream.Close();
                }
                catch
                {
                }
            }
        }
        /// <summary>
        /// 记录生成的序列号和时间，以及总个数
        /// </summary>
        /// <param name="data"></param>
        public static void WreteSerialNumberLog(string data)
        {
            if (!Directory.Exists(BasePath + "\\number\\"))
            {
                Directory.CreateDirectory(BasePath + "\\number\\");
            }
            var logFiles = Directory.GetFiles(BasePath + "\\number\\");
            if (logFiles.Length >= 5 && !logFiles.Contains<string>(DateTime.Now.ToString("yyyyMMdd") + ".log"))
            {
                var deleteFile = BasePath + "\\number\\" + DateTime.Now.AddDays(-logFiles.Length).ToString("yyyyMMdd") + ".log";
                if (File.Exists(deleteFile))
                {
                    File.Delete(deleteFile);
                }
            }
            var fileName = BasePath + "\\number\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            lock (m_Lock)
            {
                try
                {
                    FileInfo file = new FileInfo(fileName);
                    if (!file.Exists)
                    {
                        file.Create();
                    }
                    //定位到文件尾
                    StreamWriter stream = file.AppendText();
                    //写当前的时间
                    stream.Write(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss fff]"));
                    //写用户传过来的字符串
                    stream.WriteLine(data);
                    //最后记着要关了它
                    stream.Close();
                }
                catch
                {
                }
            }
        }
        /// <summary>
        /// 根据配置获取变量DB
        /// </summary>
        /// <param name="feerackNo"></param>
        /// <returns></returns>
        public static int GetDBByConfig(string station, string order,string type)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "PLCADDRESSCONFIG.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("PLC");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("STATION") == station && xe.GetAttribute("ORDER") == order && xe.GetAttribute("TYPE")==type)
                {
                    result = xe.GetAttribute("DB");
                }
            }
            return Convert.ToInt32(result);
        }
        /// <summary>
        /// 根据配置获取变量Address
        /// </summary>
        /// <param name="feerack"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static int GetAddressByConfig(string station, string order,string type)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "PLCADDRESSCONFIG.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("PLC");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("STATION") == station && xe.GetAttribute("ORDER") == order && xe.GetAttribute("TYPE") == type)
                {
                    result = xe.GetAttribute("ADDRESS");
                }
            }
            return Convert.ToInt32(result);
        }
        /// <summary>
        /// 根据配置获取变量长度
        /// </summary>
        /// <param name="feerack"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static int GetLengthByConfig(string station, string order,string type)
        {
            string result = null;
            XmlDocument xmlDoc = new XmlDocument();
            string addr = "PLCADDRESSCONFIG.xml";
            xmlDoc.Load(addr);
            XmlNode nd;
            nd = xmlDoc.SelectSingleNode("PLC");
            XmlNodeList xnl = nd.ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("STATION") == station && xe.GetAttribute("ORDER") == order && xe.GetAttribute("TYPE") == type)
                {
                    result = xe.GetAttribute("LENGTH");
                }
            }
            return Convert.ToInt32(result);
        }
    }
}
