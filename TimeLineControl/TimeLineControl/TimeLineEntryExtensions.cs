using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLineControl
{
    public static class TimeLineEntryExtensions
    {
        public static TimeLineEntry MakeMovable(this TimeLineEntry timeLineEntry)
        {
            timeLineEntry.CanBeMoved = true;
            return timeLineEntry;
        }

        public static TimeLineEntry CanNotMove(this TimeLineEntry timeLineEntry)
        {
            timeLineEntry.CanBeMoved = false;
            return timeLineEntry;
        }

        public static TimeLineEntry LockDuration(this TimeLineEntry timeLineEntry)
        {
            timeLineEntry.DurationLocked = true;
            return timeLineEntry;
        }

        public static TimeLineEntry UnLockDuration(this TimeLineEntry timeLineEntry)
        {
            timeLineEntry.DurationLocked = false;
            return timeLineEntry;
        }
    }
}
