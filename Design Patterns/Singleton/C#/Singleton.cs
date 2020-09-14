using System;

namespace C_
{
    class Singleton
    {
        private Singleton()
        {
 
        }

        public static Singleton RetornatInstancia()
        { 
            return Nested.instancia; 
        }
        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly Singleton instancia = new Singleton();
        }
    }
}
