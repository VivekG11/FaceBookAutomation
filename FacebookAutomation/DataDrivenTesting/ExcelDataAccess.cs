using System.Configuration.Assemblies;
using System.Data.OleDb;
using System.Linq;
using System;
using Dapper;
using System.Configuration;

namespace FacebookAutomation.DataDrivenTesting
{
     class ExcelDataAccess
    {
        public static string TestDataFileConnection()
        {
         
             var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
             path = path.Substring(6) + @"C:\Users\vivek.g\source\repos\FacebookAutomation\FacebookAutomation\DataDrivenTesting\TestData.xlsx";
             var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", path);
             return con;
         

           /* var TestData = ConfigurationManager.AppSettings[@"C:\Users\vivek.g\source\repos\FacebookAutomation\FacebookAutomation\DataDrivenTesting\TestData.xlsx"];
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = MSSQLLocalDB; Extended Properties=Excel 12.0;", TestData);
            return con;*/
           
        }

        public static DataAccess GetTestData(string login)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [TestData$] where key='{0}'", login);
                var value = connection.Query<DataAccess>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
