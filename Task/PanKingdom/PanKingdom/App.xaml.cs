using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using System.IO;
using System.Data.SqlServerCe;

namespace PanKingdom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       
        public SqlCeConnection _con;
        public SqlCeCommand _cmd;
        protected override void OnStartup(StartupEventArgs e)
        {
            string _connStr = "Data Source = PanKingdom.sdf; Password = Xtreamit@123";

            if (File.Exists("PanKingdom.sdf"))
            {
                //File.Delete("PanKingdom.sdf");
            }
            else
            {
                if (CreateDatabase(_connStr))
                {
                    if (CreateTables(_connStr))
                    {

                    }
                }
            }
        }

        public bool CreateDatabase(string connStr)
        {
            bool result = false;
            try
            {
                SqlCeEngine engine = new SqlCeEngine(connStr);
                engine.CreateDatabase();
                result = true;
            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        public bool CreateTables(string connStr)
        {
            bool result = false;
            try
            {
                _con = new SqlCeConnection(connStr);
                _con.Open();
                _cmd = new SqlCeCommand(@"create table Test
(Id int primary key identity(1,1),Name nvarchar(100) not null)", _con);
                _cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                result = false;
                _con.Close();

            }
            finally
            {
                result = false;
                _con.Close();

            }
            return result;
        }

       // public bool insertDefaulData()
    }
}
