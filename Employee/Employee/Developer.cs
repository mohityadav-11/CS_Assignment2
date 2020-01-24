using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Developer : Employee
    {
        public Developer(int id, string name, string des, int sal, int exp, DateTime jd) : base(id, name, des, sal, exp, jd)
        {}

        public override int salary()
        {
            return getSal()+(getExp()* 2000);
        }

    }
}
