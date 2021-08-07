﻿using System;

namespace YOVPS.Core.Extensions
{
    public static class TimeSpanExtensions
    {
        public static bool TryParseToTimeSpan(this string str, out TimeSpan timespan)
        {
            // Input formats:
            // 0:00
            // 00:00
            // 00:00:00

            if (str.Length == 5) // 00:00
            {
                var parts = str.Split(':');
                timespan = new TimeSpan(
                    0, // hours
                    int.Parse(parts[0]), // minutes
                    int.Parse(parts[1])); // seconds
                return true;
            }

            return TimeSpan.TryParse(str, out timespan);
        }
    }
}