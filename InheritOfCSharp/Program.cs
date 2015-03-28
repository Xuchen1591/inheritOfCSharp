using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritOfCSharp
{
    //interface
    public interface IDisposable
    {
        void dispose();
    }

    class someClass : IDisposable
    {
        //this class MUST contain an implementation of the IDisposable.dispose()
        //or it will be error in compile
        public void dispose()
        {
            Console.WriteLine("this class MUST contain an implementation of the IDisposable.dispose()");
        }
    }


    //use 'sealed' to declare this class cant be inherited
    //like 'final' in java
    sealed class finalClass
    {
        //sealed function cant be override
        public void someFunc(){}
    }

    class myBaseClass
    {
        public virtual void virtualMethod()
        {
            Console.WriteLine("this is base menthod");
        }


        public void hidableMethod()
        {
            Console.WriteLine("this is base hidable method");
        }
    }

    class myDerivedClass : myBaseClass
    {
        public override void virtualMethod()
        {
            //if not override, default use base class's method
            base.virtualMethod();

            //if yes, rewrite and override baseclass function
            //Console.WriteLine("this is base menthod+ derived class");
        }

        //if the son-class has the same function(wi same name) with base class
        //we have to use key word:'new' to declare
        public new void hidableMethod()
        {
            Console.WriteLine("this is son hidable method");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            myBaseClass bc = new myBaseClass();
            myDerivedClass dc = new myDerivedClass();
            bc.virtualMethod();
            dc.virtualMethod();

            bc.hidableMethod();
            dc.hidableMethod();
        }
    }
}
