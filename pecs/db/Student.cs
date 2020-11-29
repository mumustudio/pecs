using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pecs.db
{
    class Student
    {
        public string name;
        public string sex;
        public string birthYear;
        public string birthMon;
        public string className;
        public string require;
        public string memo;

        public Student()
        {

        }

        public Student(DataTable dataTable)
        {
            name = dataTable.Rows[0]["StudentName"].ToString();
            sex = dataTable.Rows[0]["Sex"].ToString();
            birthYear = dataTable.Rows[0]["BirthYear"].ToString();
            birthMon = dataTable.Rows[0]["BirthMon"].ToString();
            className = dataTable.Rows[0]["Class"].ToString();
            require = dataTable.Rows[0]["Require"].ToString();
            memo = dataTable.Rows[0]["Memo"].ToString();
        }
    }
}
