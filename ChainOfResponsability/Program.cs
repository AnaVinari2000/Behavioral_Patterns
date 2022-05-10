using System;

namespace ChainOfResponsability
{
    class Program
    {
        public static void Main(string[] args)
        {
            Handler handler1 = new Handler1();
            Handler handler2 = new Handler2();
            Handler handler3 = new Handler3();
            Handler handler4 = new Handler4();
            Handler handler5 = new Handler5();
            handler1.SetSuccesor(handler2);
            handler2.SetSuccesor(handler3);
            handler3.SetSuccesor(handler4);
            handler4.SetSuccesor(handler5);


            int request = 2;
            handler1.HandleRequest(request);

            Console.ReadKey();

        }
    }
}
