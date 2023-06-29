using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice.Model
{
    class TaskDB
    {
        public int ID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public string FullTitle { get; set; }
        public string ShortTitle { get; set; }
        public string Description { get; set; }
        public Nullable<int> ExecutiveEmployeeID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
        public Nullable<System.DateTime> DeletedTime { get; set; }
        public string Deadline { get; set; }
        public System.TimeSpan StartActualTime { get; set; }
        public Nullable<System.TimeSpan> FinishActualTime { get; set; }
        public Nullable<int> PreviousTaskId { get; set; }
    }
}
