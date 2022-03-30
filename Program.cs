using System;

namespace SingletonExampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10; i++)
            {
                Singleton singleton = Singleton.GetSingleton();//burada singleton class olduğu için sadce bir kere ekran "ben çalıştım" yazar.
            }
        }
    }
}
