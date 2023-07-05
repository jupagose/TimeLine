using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLineControl
{
    public static class TimeLineDataExtensions
    {
        public static TimeLineEntry AddEntry(this TimeLineData timeLine, DateTime start, double duration, DurationUnit durationUnit)
        {
            throw new NotImplementedException();
        }

        public static TimeLineData Initialize(this TimeLineData timeLine, DurationUnit durationUnit, int totalDuration , double minEntryDuration)
        {
            switch (durationUnit)
            {
                case DurationUnit.Seconds:
                    timeLine.TotalDuration = new TimeSpan(0, 0, totalDuration);
                    break;
                case DurationUnit.Hours:
                    timeLine.TotalDuration = new TimeSpan(totalDuration, 0, 0);
                    break;
                case DurationUnit.Minutes:
                    timeLine.TotalDuration = new TimeSpan(0, totalDuration, 0);
                    break;
                case DurationUnit.Days:
                    timeLine.TotalDuration = new TimeSpan(totalDuration, 0, 0, 0);
                    break;
                default:
                    throw new NotImplementedException();
            }
            timeLine.MinEntryDuration = minEntryDuration;
            timeLine.DurationUnit = durationUnit;
            return timeLine;
        }

        public static TimeLineData SetMinEntryDuration(this TimeLineData timeLine, double minEntryDuration )
        {
            timeLine.MinEntryDuration = minEntryDuration;
            return timeLine;
        }

        public static TimeLineEntry AddEntry(this TimeLineData timeLine, TimeSpan start, TimeSpan duration, string name, object data)
        {
            TimeLineEntry timeLineEntry = new TimeLineEntry() { Start = start, Duration = duration, Name = name, Data = data, Index = timeLine.Entries.Count };
            timeLine.Entries.Add(timeLineEntry);
            return timeLineEntry;
        }
    }
}
