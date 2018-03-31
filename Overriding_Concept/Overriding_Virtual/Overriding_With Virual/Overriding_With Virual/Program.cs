using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overriding_With_Virual
{
    class Program
    {
        public virtual string GetString()
        {
            return "Base Class String";
        }
        public virtual void Show()
        {
            Console.WriteLine("Base Class Show Method");
        }
    }
    class NewProgram : Program
    {
        public override string GetString()
        {
            return "Derive Class String";
        }
        public override void Show()
        {
            Console.WriteLine("Derived Class Show Method");
        }
    }

    class ForMain
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            string str = obj.GetString();
            Console.WriteLine("Method Return:{0}", str);
            obj.Show();
            obj = new NewProgram();
            str = obj.GetString();
            Console.WriteLine("Method Return:{0}", str);  // in overriding it will give derived class method
            obj.Show();                                  // in overriding it will give derived class method
            NewProgram obj1 = new NewProgram();
            str = obj1.GetString();
            Console.WriteLine("Method Return:{0}", str);
            obj1.Show();
            obj1 = (NewProgram)obj;  // cast the Base class object to Derived class type
            Console.WriteLine("Method Return:{0}", obj1.GetString());
            obj1.Show();
            Program newObj = (Program)obj1;        // casting derived class object to base class type
            str = newObj.GetString();             // in overriding it will give derived class method
            Console.WriteLine("Method Return:{0}", str);    // in overriding it will give derived class method
            newObj.Show();                   // in overriding it will give derived class method
            Console.Read();
        }
    }
}
