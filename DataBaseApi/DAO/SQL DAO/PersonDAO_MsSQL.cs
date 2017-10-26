using DataBaseApi.Api.LibraryFiles_DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApi
{
    class PersonDAO_MsSQL : PersonDAO_SQL
    {
        SqlConnection connection = null;
        public PersonDAO_MsSQL()
        {
            string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB" +
                             @";AttachDbFilename=" + Path.GetFullPath(@"..\..\..\DataBaseApi\DataBase\LocalDB.mdf") +
                             @";Integrated Security=True";
            //string absStrConn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            //                 @"AttachDbFilename=" + @"D:\ORT\ORT_all\Database_App\7\DataBase\DataBaseApi\DataBase\LocalDB.mdf" + ";" +
            //                 @"Integrated Security=True";

            connection = new SqlConnection(strConn);
        }

        protected override void CloseConnection()
        {
            connection.Close();
        }

        protected override void OpenConnection()
        {
            connection.Open();
        }

        protected override void ExecuteCommand(string cmd)
        {
            SqlCommand sqlCmd = new SqlCommand(cmd, connection);
            sqlCmd.ExecuteNonQuery();
        }

        protected override List<Person> ReadData(string cmd)
        {
            SqlCommand sqlCmd = new SqlCommand(cmd, connection);
            SqlDataReader reader = sqlCmd.ExecuteReader();

            List<Person> listPerson = new List<Person>();
            while (reader.Read())
            {
                listPerson.Add(new Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
            }
            reader.Close();
            return listPerson;
        }
    }
}
