using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Utilities
{
   public class Constants
    {
        public const string DateFormat = "MM/dd/yyyy";

        public const int DefaultPageSize = 10;

        public enum RecordStatus { Created, Active, Inactive, Deleted }


        public enum PostType { }


        public struct UserType
        {
            public const string Admin = "Administrator";
            public const string Employee = "Employee";
        }

        public struct EmailTemplateType
        {
            public const string ToCustomerOnRegistration = "to_customer_on_registration.html";
            public const string ToAdminOnCustomerRegistration = "to_admin_on_customer_registration.html";
        }
        public const string SessionKeyName = "CompanyTenantId";
        public string SessionInfo_Name { get; private set; }

    }
}
