using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoCSharp_41
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }


        //using Abstract classes allows you to create a "stubbed out" method
        //use the abstract keyword for stubbed out methods
        //using abstract means you HAVE to use the override keyword in the derived class
        public abstract void AbstractAnimal();

        //using virtual is a method that already does something at creation in the template (non stubbed out)
        //using virtual means you DO NOT have to use the override keyword in the derived classes, but can do so optionally
        public virtual void VirtualAnimal()
        {
            Console.WriteLine("Animal is virtual!");
        }

    }
}
