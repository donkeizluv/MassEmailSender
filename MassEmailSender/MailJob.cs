using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MassEmailSender
{
    public class MailJob
    {
        public string Sheet { get; set; }
        public string Group { get; set; }
        public MailJob(string sheetName, string group)
        {
            Sheet = sheetName;
            Group = group;
        }
        public object[] ToObjectArray()
        {
            return new object[2] { Sheet, Group };
        }
    }
}
