using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Data
{
    public class TableManager
    {
        static private Dictionary<string, TableManager> _tableManagers = new Dictionary<string, TableManager>();
        static private DbProviderFactory _DbProviderFactory = DbProviderFactories.GetFactory("Oracle.DataAccess.Client");
        static private DbConnection _connection = _DbProviderFactory.CreateConnection();

        static private DbConnection Connection
        {
            get
            {
                while (true)
                {
                    try
                    {
                        if (_connection.State == ConnectionState.Broken)
                        {
                            _connection.Close();
                        }
                        if (_connection.State == ConnectionState.Closed)
                        {
                            _connection.Open();
                        }
                        return _connection;
                    }
                    catch(Exception e) {
                        Console.WriteLine("1");
                        Console.WriteLine(e);
                        }
                }
            }
        }

        static TableManager()
        {
            _connection.ConnectionString = "Data Source = (DESCRIPTION = " +
                        "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-GTG9OD4)(PORT = 1521))" +
                        "(CONNECT_DATA = " +
                        "(SERVER = DEDICATED)" +
                        "(SERVICE_NAME = XE)" +
                        ")" +
                        ");User Id=system;password=Optimist1";
        }

        static public TableManager GetTableManager(string tableName)
        {
            TableManager tm = null;
            try
            {
                tm = _tableManagers[tableName]; //намагаємось по ключу у словнику знайти відповідну таблицю
            }
            catch //якщо такої не має
            {
                try
                {
                    tm = new TableManager(tableName); //створюємо новий об`єкт, за допомогою якого ми будемо працювати з таблицею з БД
                    _tableManagers.Add(tableName, tm);
                }
                catch (Exception e)
                {
                    Console.WriteLine("2");
                    Console.WriteLine(e);
                }
            }
            return tm;
        }

        private DbDataAdapter _da;
        private DataTable _dt;
        private DataTable _temp;
        private DbCommand _cmd;

        public DataTable Table { get { return _dt; } }

        internal TableManager(string tableName)
        {
            try
            {
                _da = _DbProviderFactory.CreateDataAdapter();
                _cmd = _DbProviderFactory.CreateCommand();
                DbCommandBuilder cb = _DbProviderFactory.CreateCommandBuilder();
                _cmd.Connection = Connection;
                cb.ConflictOption = ConflictOption.OverwriteChanges;
                cb.DataAdapter = _da;
                _dt = new DataTable();
                _temp = new DataTable();
                _dt.TableName = _temp.TableName = tableName;
                _cmd.CommandText = "SELECT * FROM CAFEBD." + Table.TableName;
                _da.SelectCommand = _cmd;
                _da.InsertCommand = cb.GetInsertCommand();
                _da.DeleteCommand = cb.GetDeleteCommand();
                Recharge("1 = 2");
            }
            catch (Exception e)
            {
                Console.WriteLine("3");
                Console.WriteLine(e);
            }
        }

        internal int Recharge(string query) //заново заповнюємо табличку _dt - представлення фізичної таблиці з БД у класі 
        {
            _cmd.CommandText = "SELECT CAFEBD." + Table.TableName + ".* FROM CAFEBD." + Table.TableName + ((query == "") ? "" : " WHERE " + query);
            try { return _da.Fill(_dt); }
            catch (Exception e)
            {
                Console.WriteLine("4");
                Console.WriteLine(e);
            }
            return 0;
        }

        internal DataRowCollection GetIds(string query) //хочемо наповнити табличку _temp ID-шками
        {
            _cmd.CommandText = "SELECT ID FROM CAFEBD." + Table.TableName + ((query == null) ? "" : " WHERE " + query);
            try
            {
                _da.Fill(_temp);
                return _temp.Rows; //повертаємо рядки даної таблиці 
            }
            catch (Exception e)
            {
                Console.WriteLine("5");
                Console.WriteLine(e);
            }
            return null;
        }

        internal int Update(DataRow dr) { return _da.Update(new[] { dr }); }
        internal int Update(DataRow[] drs) { return _da.Update(drs); }
    }
}

