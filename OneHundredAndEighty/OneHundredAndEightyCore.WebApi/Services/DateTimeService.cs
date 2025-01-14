﻿#region Usings

using System;
using System.Diagnostics;

#endregion

namespace OneHundredAndEightyCore.WebApi.Services
{
    public class DateTimeService : IDateTimeService
    {
        private static DateTime Now => DateTime.Now;

        public string GetUptimeString()
        {
            var uptime = GetUptime();
            return "App runs for " +
                   $"{uptime.Days} days, " +
                   $"{uptime.Hours} hours, " +
                   $"{uptime.Minutes} minutes and " +
                   $"{uptime.Seconds} seconds";
        }

        private TimeSpan GetUptime()
        {
            return Now - Process.GetCurrentProcess().StartTime;
        }
    }
}