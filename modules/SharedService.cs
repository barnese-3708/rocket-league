using System;

namespace App
{
    public class SecureService
    {
        private int _state;

        public SecureService(int seed) => _state = seed;

        public int decode(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 21) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SecureService(21);
            Console.WriteLine(obj.decode(21));
        }
    }
}
