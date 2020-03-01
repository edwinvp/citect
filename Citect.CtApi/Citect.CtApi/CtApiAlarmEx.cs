﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Citect.CtApi
{
    /// <summary>
    /// Extension methods for alarms management
    /// </summary>
    public static class CtApiAlarmEx
    {
        /// <summary>
        /// Acknowledge a specified alarm.
        /// </summary>
        /// <param name="ctApi"></param>
        /// <param name="tag">A string that identifies the alarm to acknowledge
        /// <param name="clusterName">The cluster where the tag resides</param>
        /// <returns>0 (zero) if successful, otherwise an error code will return</returns>
        public static string AlarmAckTag(this CtApi ctApi, string tag, string clusterName = "")
        {
            var result = ctApi.Cicode($"AlarmAckTag({tag}, {clusterName})");
            return result;
        }
    }
}