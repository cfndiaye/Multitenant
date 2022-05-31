using System;
using System.Collections.Generic;

namespace Core.Settings
{
    public class TenantSettings
    {
        public Configuration Defaults { get; set; }
        public List<Tenant> Tenants { get; set; }
    }
}
