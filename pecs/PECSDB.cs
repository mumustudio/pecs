using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pecs
{
    public enum PECSDBSTATUS
    {
        DB_UNKNOW = 0,
        DB_CONNECTED,
        DB_CONNECTFAIL,

    }
    public class PECSDB
    {
        public PECSDBSTATUS Status { get { lock (threadLock) { return status; } } }
        private string connStr = "";
        private SqlConnection conn = null;
        private Thread th_connect;
        private Object threadLock = new Object();
        private PECSDBSTATUS status;
        private bool stop_flag=false;

        public PECSDB(string __connStr)
        {
            connStr = __connStr;
            status = PECSDBSTATUS.DB_UNKNOW;
        }

        internal string[] QueryLogininfo(string qString)
        {
            string[] rev = new string[4];
            SqlCommand cmd = new SqlCommand(qString, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                rev[0] = sdr.GetString(0);
                rev[1] = sdr.GetString(1);
                rev[2] = sdr.GetString(2);
                rev[3] = sdr.GetDateTime(3).ToString("yyyy - MM - dd HH: mm:ss");
                //rev[3] = dt.ToString("yyyy - MM - dd HH: mm:ss");
            }
            sdr.Close();
            return rev;

        }

        public void Connect()
        {
            th_connect = new Thread(ConnectDB);
            th_connect.Start();
        }

        public void DisConnect()
        {
            stop_flag = true;
            if (conn != null) conn.Close();
        }

        public string QueryPassword(string qString)
        {
            string s = "-1";
            SqlCommand cmd = new SqlCommand(qString, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                s = sdr.GetString(0);
            }
            sdr.Close();
            return s;
        }

        public string QueryName(string qString)
        {
            return QueryPassword(qString);
        }

        public bool ExecuteNonQuery(string s)
        {
            SqlCommand cmd = new SqlCommand(s, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ConnectDB()
        {
            while ((status != PECSDBSTATUS.DB_CONNECTED) && (!stop_flag))
            {
                try
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();
                    lock (threadLock) { status = PECSDBSTATUS.DB_CONNECTED; }
                }
                catch(Exception ee)
                {
                    string s = ee.ToString();
                    lock (threadLock) { status = PECSDBSTATUS.DB_CONNECTFAIL; }
                    Thread.Sleep(100);
                }
            }
        }
    }
}
