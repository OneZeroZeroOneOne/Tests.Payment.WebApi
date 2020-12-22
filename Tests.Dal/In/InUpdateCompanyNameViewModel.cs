﻿using System.Collections.Generic;

namespace Tests.Dal.In
{
    public class InUpdateCompanyNameViewModel
    {
        public string Name { get; set; }
    }

    public class InUpdateEmailViewModel
    {
        public string Email { get; set; }
    }
    public class InUpdatePassword
    {
        public string Password { get; set; }
    }
    public class InUpdateNotifications
    {
        public List<InUpdateNotificationSetting> Email { get; set; }
        public List<InUpdateNotificationSetting> Web { get; set; }
    }

    public class InUpdateNotificationSetting
    {
        public int NotificationTypeId { get; set; }
        public bool IsEnabled { get; set; }
    }
}
