﻿using System.Globalization;

// A classe deve ser static


namespace ExtensionMethods.Extension
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            else
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}