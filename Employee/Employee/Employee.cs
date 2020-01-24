using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public abstract class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int base_sal;
        private int exp;
        private DateTime joindate;

        public Employee(int id, string name, string des, int sal,int exp,DateTime jd)
        {
            this.id = id;
            this.name = name;
            this.designation = des;
            this.base_sal = sal;
            this.exp = exp;
            this.joindate = jd;
        }

        public int getSal()
        {
            return this.base_sal;
        }

        public int getExp()
        {
            return this.exp;
        }

        public abstract int salary();

    }
}
