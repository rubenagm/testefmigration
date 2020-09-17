using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.Models
{
    public class Table2: FullAuditedEntity<long>
    {
        public int T2Prop1 { get; set; }
        public int T2Prop2 { get; set; }
        public int T2Prop3 { get; set; }
    }
}
