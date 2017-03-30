using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.Intervals
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
                .Select(x => x.UpperPitch.ToString())
                .Aggregate(string.Empty, (current, next) => current + " " + next);
        }
    }
}