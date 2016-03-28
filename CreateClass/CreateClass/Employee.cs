using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        private int salary;
        private string profession;
        public Room Room;

        public Employee()
        {
            Room = null;
        }

        public Employee(string name, DateTime birthDate, int salary, string profession): base(name, birthDate)
        {
            this.salary = salary;
            this.profession = profession;
            Room = null;
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(", salary:{0}, profession: {1},room:{2}", this.salary, this.profession, Room.Number);
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(Room.Number);
            return newEmployee;
        }
    }

    class Room
    {
        private int number;

        public Room(int number)
        {
            this.number = number;
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
