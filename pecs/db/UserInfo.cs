using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pecs.db
{
    class UserInfo
    {
        public string studentName;
        public string leaderName;
        public DateTime lastTime;

        public UserInfo()
        {
        }

        public UserInfo(DataTable dataTable)
        {
            studentName = dataTable.Rows[1]["StudentName"].ToString();
            leaderName = dataTable.Rows[1]["LeaderName"].ToString();
            lastTime = DateTime.Parse(dataTable.Rows[1]["LastUseTime"].ToString());
        }
    }
}