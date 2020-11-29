using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pecs.db
{
    class PecsDB
    {
        static private string database = "pecs.db";
        static private string studentInfoTable = "StudentInfo";
        static private string userInfoTable = "UserInfo";

        static public SQLiteConnection OpenConnection()
        {
            var connection = new SQLiteConnection()
            {
                ConnectionString = $"Data Source={database};Version=3;New=False;Compress=True;"
            };

            if (connection.State == ConnectionState.Open) connection.Close();
            connection.Open();
            return connection;
        }

        static public void CreateDatabase()
        {
            var connection = new SQLiteConnection()
            {
                ConnectionString = $"Data Source=Data/{database};Version=3;New=True;Compress=True;"
            };
            connection.Open();
            connection.Close();
        }

        static public void CheckTableExist(string tableName)
        {
            var connection = OpenConnection();
            var command = new SQLiteCommand(@"SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + @"';", connection);
            var mySqlTransaction = connection.BeginTransaction();
            try
            {
                command.Transaction = mySqlTransaction;
                command.ExecuteNonQuery();
                mySqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                mySqlTransaction.Rollback();
                throw (ex);
            }
            connection.Close();
        }

        static public void CreateTable(string sqlCreateTable)
        {
            var connection = OpenConnection();
            var command = new SQLiteCommand(sqlCreateTable, connection);
            var mySqlTransaction = connection.BeginTransaction();
            try
            {
                command.Transaction = mySqlTransaction;
                command.ExecuteNonQuery();
                mySqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                //mySqlTransaction.Rollback();
                //throw (ex);
            }
            if (connection.State == ConnectionState.Open) connection.Close();
        }

        static public bool CheckDataExist(string tableName, string field, string data)
        {
            var connection = OpenConnection();

            var dataAdapter = new SQLiteDataAdapter(String.Format(@"select * from {0} where {1} = '{2}'", tableName, field, data), connection);
            var myDataTable = new DataTable();
            var myDataSet = new DataSet();
            myDataSet.Clear();
            dataAdapter.Fill(myDataSet);
            myDataTable = myDataSet.Tables[0];

            connection.Close();
            if (myDataTable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        static public void RegStu(Student student)
        {
            var connection = OpenConnection();
            var command = new SQLiteCommand($"INSERT or replace INTO {studentInfoTable}" +
                $"(StudentName,Sex,BirthYear,BirthMon,Class,Require,Memo) " +
                $"VALUES('{student.name}','{student.sex}','{student.birthYear}','{student.birthMon}','{student.className}','{student.require}','{student.memo}');"
                , connection);
            command.ExecuteReader();
            connection.Close();
        }

        static public void DelStu(String studentName)
        {
            var connection = OpenConnection();
            var command = new SQLiteCommand($"DELETE FROM {studentInfoTable} WHERE StudentName = '{studentName}';"
                , connection);
            command.ExecuteReader();
            connection.Close();
        }

        static public Student GetStu(string studentName)
        {
            var connection = OpenConnection();
            var dataAdapter = new SQLiteDataAdapter(String.Format(@"select * from {0} where {1} = '{2}'", studentInfoTable, "StudentName", studentName), connection);
            var myDataTable = new DataTable();
            var myDataSet = new DataSet();
            myDataSet.Clear();
            dataAdapter.Fill(myDataSet);
            myDataTable = myDataSet.Tables[0];
            Student student = new Student(myDataTable);
            connection.Close();
            return student;
        }

        static public bool Login(string studentName, string password, string leader, string leaderName, DateTime now)
        {
            var connection = OpenConnection();
            bool isExist;
            isExist = CheckDataExist(studentInfoTable, "StudentName", studentName);
            bool success = false;

            if (isExist)
            {
                Student student = GetStu(studentName);
                string currentPassword = "";
                currentPassword = Convert.ToInt32(student.birthYear).ToString("000") + (Convert.ToInt32(student.birthMon) + 1).ToString("00");
                if (currentPassword == password)
                {
                    var command = new SQLiteCommand($"INSERT INTO {userInfoTable}" +
                   $"(StudentName,LeaderName,LastUseTime) " +
                   $"VALUES('{student.name}','{leaderName}','{now.ToString("yyyy-MM-dd hh:mm:ss")}');"
                   , connection);
                    command.ExecuteReader();
                    success = true;
                }
            }
            connection.Close();
            return success;
        }

        static public UserInfo GetUser(string studentName)
        {
            bool isExist;
            isExist = CheckDataExist(userInfoTable, "StudentName", studentName);
            UserInfo userInfo = new UserInfo();
            if (isExist)
            {
                var connection = OpenConnection();
                var dataAdapter = new SQLiteDataAdapter(String.Format(@"select * from {0} where {1} = '{2}' order by LastUseTime desc limit 2", userInfoTable, "StudentName", studentName), connection);
                var myDataTable = new DataTable();
                var myDataSet = new DataSet();
                myDataSet.Clear();
                dataAdapter.Fill(myDataSet);
                myDataTable = myDataSet.Tables[0];
                if (myDataTable.Rows.Count >= 2)
                {
                    userInfo = new UserInfo(myDataTable);
                }
                else
                {
                    userInfo = new UserInfo();
                }

                connection.Close();
                return userInfo;
            }
            return userInfo;
        }
    }
}
