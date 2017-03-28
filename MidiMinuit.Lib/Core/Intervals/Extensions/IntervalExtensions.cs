using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Lib.Core.Intervals
{
    public static class IntervalExtensions
    {
        public static string GetNoteDetails(this List<Interval> intervals)
        {
            if (intervals == null)
            {
                throw new ArgumentNullException(nameof(intervals));
            }

            return intervals
                .Select(x => x.UpperNote.ToString())
                .Aggregate(string.Empty, (current, next) => current + " " + next);
        }
    }
}