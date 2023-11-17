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

	}

}

