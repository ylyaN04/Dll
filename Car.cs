// Car.cs
using System;

namespace NazarovaUlyana.Library
{
    public class Car : IComparable
    {
        public string Owner { get; set; }
        public string Number { get; set; }

        public void Show()
        {
            Console.WriteLine($"Car Owner: {Owner}, Number: {Number}");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Car otherCar = obj as Car;
            if (otherCar != null)
                return this.Owner.CompareTo(otherCar.Owner);
            else
                throw new ArgumentException("Object is not a Car");
        }
    }
}