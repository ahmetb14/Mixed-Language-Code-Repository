using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ahmet = new Employee { Name = "Ahmet Yılmaz" };

            Employee burak = new Employee { Name = "Burak Aktaş" };

            ahmet.AddSubordinate(burak);

            Employee berkay = new Employee { Name = "Berkay Yılmaz" };
            ahmet.AddSubordinate(berkay);

            Contractor görkem = new Contractor { Name = "Görkem" };
            berkay.AddSubordinate(görkem);

            Employee tuğra = new Employee { Name = "Tuğra Dönmez" };
            burak.AddSubordinate(tuğra);

            Console.WriteLine(ahmet.Name);

            foreach (Employee manager in ahmet)
            {
                Console.WriteLine("  {0}", manager.Name);
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("    {0}", employee.Name);
                }
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        string Name { get; set; }
    }

    class Contractor : IPerson
    {
        public string Name { get; set; }
    }

    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
