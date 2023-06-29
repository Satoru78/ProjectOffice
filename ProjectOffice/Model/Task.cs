using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice.Model
{
    public partial class Task
    {
        public int ID { get; set; }
        public string ProjectTitle { get; set; }
        public string FullTitle { get; set; }
        public string ShortTitle { get; set; }
        public string Description { get; set; }
        public string ExecutiveEmployee { get; set; }
        public string StatusTitle { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
        public Nullable<System.DateTime> DeletedTime { get; set; }
        public string Deadline { get; set; }
        public System.TimeSpan StartActualTime { get; set; }
        public Nullable<System.TimeSpan> FinishActualTime { get; set; }
        public string PreviousTaskShortTitle { get; set; }
        public string StatusColor { get; set; }

        public override string ToString()
        {
            return $"{ID};{ProjectTitle};{FullTitle};";
        }
    }
}
