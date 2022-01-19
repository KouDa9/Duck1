using System;
using System.Collections.Generic;
using System.Text;

namespace Duck1
{
    abstract class Duck
    {
        public string quack()
        {
            return "quack" + this.GetType();
        }

        public string swim()
        {
            return "swim" + this.GetType();
        }

        public abstract string display();
    }

    class MallarDuck : Duck
    {
        public override string display()
        {
            return "display" + this.GetType();
        }
    }
    class RedheadDuck : Duck
    {
        public override string display()
        {
            return "display" + this.GetType();
        }
    }
}
