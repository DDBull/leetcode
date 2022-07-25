/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace lintcode
{
    class Solution {
        /**
         * @param intervals: an array of meeting time intervals
         * @return: if a person could attend all meetings
         */
        public bool CanAttendMeetings(List<Interval> intervals) {
            // Write your code here
            if (intervals is null) return true;
            intervals.Sort(new IntevalComparer());

            int last = -1;

            foreach(Interval meeting in intervals)
            {
                if (last > meeting.start) return false;
                last = meeting.end;
            }

            return true;
        }

        class IntevalComparer : IComparer<Interval>
        {
            public int Compare(Interval a, Interval b)
            {
                if (a.start == b.start) return a.end - b.end;
                return a.start - b.start;
            }
        }   
    }
}
