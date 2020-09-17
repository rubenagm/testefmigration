using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF.Models
{
    public class Table1: FullAuditedEntity<long>
    {

        public int Prop1 { get; set; }
        public int Prop2 { get; set; }
        public string Prop3 { get; set; }
    }
}
