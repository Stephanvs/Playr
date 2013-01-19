using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Play
{
    public static class Helpers
    {
        public static string GetApiUrl()
        {
            return WebConfigurationManager.AppSettings["playr:ApiUrl"];
        }

        public static string GetNotificationUrl()
        {
            return WebConfigurationManager.AppSettings["playr:NotificationUrl"];
        }
    }
}