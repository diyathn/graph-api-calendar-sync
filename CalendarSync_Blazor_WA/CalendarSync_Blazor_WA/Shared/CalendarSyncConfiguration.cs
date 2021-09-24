using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarSync_Blazor_WA.Shared
{
    public class CalendarSyncConfiguration
    {
        public string ApplicationId { get; set; }
        public string DirectoryId { get; set; }
        public string ServiceAccountEmail { get; set; }
        public string Password { get; set; }
    }
}
