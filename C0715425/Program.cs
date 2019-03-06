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
        public delegate void MyDelegate();
        public class DelegateExercises : MyDelegate
        {
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
                System.Console.WriteLine(myDelegate.ToString());
            }
        }
        public class DelegateExercises
        {
            void Method3()
            {
                System.Console.WriteLine(MyDelegate.ToString());
            }

        }
        class Program
        {
            public static void Method1(string xyz)
            {
                Console.WriteLine(xyz + " Method1");
            }

            public static void Method2(string xyz)
            {
                Console.WriteLine(xyz + " Method2");
            }

            public static void Main()
            {
                ExampleDelegate ex1Delegate, ex2Delegate, ex3Delegate, myDelegate;

                ex1Delegate = new ExampleDelegate(Method1);
                ex2Delegate = new ExampleDelegate(Method2);
                ex3Delegate = ex1Delegate + ex2Delegate;
                myDelegate = ex1Delegate - ex2Delegate;
                ex1Delegate("AAA");
                ex2Delegate("BBB");
                ex3Delegate("CCC");
                myDelegate("DDD");
                myDelegate = ex3Delegate - ex1Delegate;
                myDelegate("EEE");
                myDelegate = ex3Delegate - ex2Delegate;
                myDelegate("FFF");
                Console.ReadLine();
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

        public delegate int MyDelegate(out int i);

        public class DelegateExercises
        {
            int Method1(out int i)
            {
                System.Console.WriteLine("Method1");
                i = 10;
                return 0;
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                MyDelegate myDelegate1 = new MyDelegate(Method1);
                MyDelegate myDelegate2 = myDelegate + myDelegate1;
                int intValue;
                myDelegate2(out intValue);

            }
        }


