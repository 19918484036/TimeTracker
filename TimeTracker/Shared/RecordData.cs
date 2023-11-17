using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace TimeTracker.Shared
{
	public class RecordData
	{
		public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime WorkStartTimeMorning { get; set; }
        public DateTime WorkEndTimeMorning { get; set; }
        public DateTime WorkStartTimeAfternoon { get; set; }
        public DateTime WorkEndTimeAfternoon { get; set; }

        //public int TestConSql()
        //{
        //    //测试连接数据库
        //    string connStr = "Data Source=LAPTOP-79F0QJ0Q;Initial Catalog=TimeTrackerRecordData;Integrated Security=True;User ID = lbr;Password=l3221513124";//自己替换一下服务器名字和数据库名字
        //    SqlConnection conn = new SqlConnection(connStr);//这里如果报错，请退回去检查你的NUget包
        //                                                    //打开数据库
        //    conn.Open(); 
        //    Console.WriteLine("打开数据库连接");
        //    return 1;
        //    //关闭数据库
        //    conn.Close();
        //    Console.WriteLine("关闭数据库连接");
        //}

	}

}

