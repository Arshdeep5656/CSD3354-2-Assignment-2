using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateAndEvents
{
    public class DelegateExercises
    {
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegeate();
        }

        
    }


    class Program
    {
        static void Main(string[] args)
        {

        }
     {
        public class DelegateExercises
        {
            public delegate void MyDelegate();
            void Method1()
            {
                Console.WriteLine("Method1");
                Console.ReadLine();
            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate(50);
            }
        }
    }
}


  class Program
{
    static void Main(string[] args)
    {
        // TO DO: Call Method2 from the DelegateExercises Class
    }
}

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

    public class DelegateExercises
    {
        public delegate int MyDelegate(int intValue);

        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }

        public class Program
        {
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
            }
        }

        public class DelegateExercises
        {
            public delegate int MyDelegate();

            void Method1()
            {
                System.Console.WriteLine("MyDelegate");
            }
             public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }

        }
        public class Program
        {
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
                Console.ReadLine();
            }
        }

        public class DelegateExercises
        {
            public delegate int MyDelegate(int intValue);

            int Method1(int intMethod1)
            {
                return intMethod1 * 2;
            }

            int Method2(int intMethod1)
            {
                return intMethod1 * 10;
            }

            public void Method4(MyDelegate myDelegate)
            {
                int result = myDelegate(10);
                Console.WriteLine(result);
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                Method4(myDelegate);
                myDelegate = new MyDelegate(Method2);
                Method4(myDelegate);
            }
        }
        public class Program
        {
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
                Console.ReadLine();
            }
        }

        public class DelegateExercises
        {
            public delegate int MyDelegate(int intValue);

            int Method1(int intMethod1)
            {
                return intMethod1 * 4;
            }

            int Method2(int intMethod1)
            {
                return intMethod1 * 20;
            }

            public void Method4(MyDelegate myDelegate)
            {
                for (int i = 1; i <= 5; i++)
                    System.Console.Write(myDelegate(i) + " ");
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                Method4(myDelegate);
                myDelegate = new MyDelegate(Method2);
                Method4(myDelegate);
            }
        }
        public class Program
        {
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
                Console.ReadLine();
            }

        }
        public delegate void MyDelegate();

        public class DelegateExercises
        {
            void Method1()
            {
                System.Console.WriteLine("Method1");
            }
            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }

    }


