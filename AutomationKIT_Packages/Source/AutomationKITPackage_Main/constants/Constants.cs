using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationKIT_Main
{
    public class Constants
    {
        public static class Workflow
        {
            /// <summary>
            /// Definition option set value for type option set.
            /// </summary>
            public const int TypeDefinition = 1;

            /// <summary>
            /// Modern flow option set value for type option set.
            /// </summary>
            public const int CategoryModernFlow = 5;

            /// <summary>
            /// The logical name.
            /// </summary>
            public const string LogicalName = "workflow";

            /// <summary>
            /// An active state code.
            /// </summary>
            public const int StateCodeActive = 1;

            /// <summary>
            /// An inactive state code.
            /// </summary>
            public const int StateCodeInactive = 0;

            /// <summary>
            /// An active status code.
            /// </summary>
            public const int StatusCodeActive = 2;

            /// <summary>
            /// An inactive status code.
            /// </summary>
            public const int StatusCodeInactive = 1;

            /// <summary>
            /// Field logical names.
            /// </summary>
            public static class Fields
            {
                /// <summary>
                /// The workflow ID.
                /// </summary>
                public const string WorkflowId = "workflowid";

                /// <summary>
                /// The workflow category.
                /// </summary>
                public const string Category = "category";

                /// <summary>
                /// The process type.
                /// </summary>
                public const string Type = "type";

                /// <summary>
                /// The name of the process.
                /// </summary>
                public const string Name = "name";

                /// <summary>
                /// The name of the process.
                /// </summary>
                public const string StateCode = "statecode";
            }
        }

        public static class systemuser
        {

            /// <summary>
            /// The logical name.
            /// </summary>
            public const string LogicalName = "systemuser";

            public static class Fields
            {
                /// <summary>
                /// The workflow ID.
                /// </summary>
                public const string systemuserid = "systemuserid";
                /// <summary>
                /// The workflow category.
                /// </summary>
                public const string internalemailaddress = "internalemailaddress";

            }
        }

        public static class role
        {

            /// <summary>
            /// The logical name.
            /// </summary>
            public const string LogicalName = "role";

            public static class Fields
            {
                /// <summary>
                /// The workflow ID.
                /// </summary>
                public const string roleid = "roleid";
                /// <summary>
                /// The workflow category.
                /// </summary>
                public const string name = "name";

            }
        }



    }
}
