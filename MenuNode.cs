using DevExpress.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressDemo
{
    public class MenuNode
    {
        public string Id { get; set; }
        public string? ParentId { get; set; }
        public string DisplayName { get; set; }
        public string TargetPage { get; set; }
        public string IconName { get; set; }
        public bool IsDefault { get; set; }
        public string PermissionCode { get; set; }
    }
}
