using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GaoShan.Sales.SQL
{
    public class SqlManager
    {
        private Dictionary<string, string> sqlDic = new Dictionary<string, string>();

        private void LoadSQL()
        {
            //string sqlPath = "Sql.xml";
            //XDocument xdoc = XDocument.Load(sqlPath);

            Assembly asm = Assembly.GetExecutingAssembly();//读取嵌入式资源
            Stream sm = asm.GetManifestResourceStream("GaoShan.Sales.SQL.Sql.xml");
            XDocument xdoc = XDocument.Load(sm);

            var sqls = xdoc.Root.Elements(XName.Get("sql")).Select(s => new SqlInfo
            {
                Name = s.Attribute("name").Value,
                Sql = s.Value
            });

            sqlDic.Clear();
            foreach (var item in sqls)
            {
                sqlDic.Add(item.Name, item.Sql);
            }
        }

        private SqlManager()
        {
            LoadSQL();
        }

        static SqlManager _Intance = null;
        public static SqlManager Intance
        {
            get
            {
                if (_Intance == null)
                {
                    _Intance = new SqlManager();
                }

                return _Intance;
            }
        }

        public string GetSql(string name)
        {
            return sqlDic.ContainsKey(name) ? sqlDic[name] : null;
        }

    }
}
