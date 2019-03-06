using System;
//student name yogesh yogesh
// student id c0722784
//csd3354 Section 2
//Assignment 2
// march 6,2019

namespace DelegatesAndEvents
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }

    }
}