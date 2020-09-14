using System;

namespace C_
{
    class UsarSingleton
    {
        static void Main(string[] args)
        {
            Singleton objeto1 = Singleton.RetornatInstancia();
            Singleton objeto2 = Singleton.RetornatInstancia();
            
            if (objeto1 == objeto2)
            {
                Console.WriteLine("Os objetos sao a mesma instancia.");
            }
        }
    }
}
