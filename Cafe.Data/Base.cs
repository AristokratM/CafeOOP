using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    [DataContract]
    public class Base<T> where T : Base<T>
    {
        static internal TableManager tm; // об`єкт, за допомогою якого ми зможемо працювати з таблицею у базі 
                                         //даних для певного класу 

        static Base()
        {
            tm = TableManager.GetTableManager(typeof(T).Name);
        }
        static public T[] Items { get { return GetByQuery(""); } }

        static public T GetById(Guid id)
        {
            while (true)
            {
                try
                {
                    return (T)Activator.CreateInstance(typeof(T), new object[]
                        { tm.Table.Select("ID = '" + id + "'")[0]});
                }
                catch { }
                if (tm.Recharge("ID = '" + id + "'") == 0)
                {
                    return null;
                }
            }
        }

        static public T[] GetByQuery(string query) { return GetByQuery(query, true); } //виконуємо запит безпосередньо до БД
        static public T[] GetByQuery(string query, bool seekInDB)
        {
            List<T> res = new List<T>();
            List<DataRow> ldrs = new List<DataRow>();
            ldrs.AddRange(tm.Table.Select(query));
            if (seekInDB)
            {
                string strSel = "";
                if (ldrs.Count < 200)
                {
                    foreach (DataRow dr in ldrs)
                    {
                        strSel += "'" + dr["ID"] + "',";
                    }
                    if (strSel.Length > 0)
                    {
                        strSel = strSel.Remove(strSel.Length - 1);
                    }
                    if (tm.Recharge(query + ((strSel == "") ? "" : ((query == "") ? "" : " and") + " ID not in (" + strSel + ")")) > 0)
                    {
                        ldrs.Clear();
                        ldrs.AddRange(tm.Table.Select(query));
                    }
                }
                else
                {
                    int count = 0;
                    foreach (DataRow dr in tm.GetIds(query)) //_temp.Rows
                    {
                        if (tm.Table.Select("ID = '" + dr["ID"] + "'").Length == 0)
                        {
                            strSel += "'" + dr["ID"] + "',"; //яких ID немає у кеші
                            count++;
                        }
                        if (count == 200)
                        {
                            tm.Recharge(" ID in (" + strSel.Remove(strSel.Length - 1) + ")");
                            strSel = "";
                            count = 0;
                        }
                    }
                    if (strSel.Length > 0)
                    {
                        tm.Recharge(" ID in (" + strSel.Remove(strSel.Length - 1) + ")");
                        ldrs.Clear();
                        ldrs.AddRange(tm.Table.Select(query));
                    }
                }
            }
            foreach (DataRow dr in ldrs)
            {
                res.Add((T)Activator.CreateInstance(typeof(T), new object[] { dr }));
            }
            return res.ToArray();
        }

        internal DataRow _row; //рядок кешу
        private bool _isNew;

        internal Base() //коли створюємо новий об`єкт
        {
            _row = tm.Table.NewRow();
            _row["ID"] = Guid.NewGuid();
            _isNew = true;
        }

        internal Base(DataRow dr) //коли прочитали рядок з БД, і хочемо відновити по цьому рядку об`єкт
        {
            _row = dr;
            _isNew = false;
        }

        public Guid Id //отримання ID об`єкта
        {
            get
            {
                return new Guid(_row["ID"].ToString());
            }
        }

        public bool IsNew
        {
            get { return _isNew; }
        }
        public void Save()
        {
            if (IsNew)
            {
                _isNew = false;
                tm.Table.Rows.Add(_row);
            }
            tm.Update(_row);
        }

        public void Delete()
        {
            _row.Delete();
            tm.Update(_row);
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {   
                return this.Id == ((T)Convert.ChangeType(obj, typeof(T))).Id;
            }
        }
    }
}
    
