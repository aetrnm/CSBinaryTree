using System;

namespace BinaryTreeProject
{
    public class Human : IComparable<Human>
    {
        private int _age;
        private string _name = "Oleg";
        private string _surname = "Gnat";
        //Да да, все люди рождаются Олегами

        public Human(int age)
        {
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }

        public int CompareTo(Human other)
        {
            if (other == null)
            {
                return 0;
            }

            if (other._age.CompareTo(_age) == -1)
            {
                return 1;
            }

            if (other._age.CompareTo(_age) == 1)
            {
                return -1;
            }

            return 0;
        }

        public override string ToString()
        {
            return _name + _surname + " " + _age;
        }
    }
}