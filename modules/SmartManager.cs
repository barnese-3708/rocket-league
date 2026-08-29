using System;

namespace App
{
    public class LiteScheduler
    {
        private int _state;

        public LiteScheduler(int seed) => _state = seed;

        public int decode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 8) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new LiteScheduler(8);
            Console.WriteLine(obj.decode(8));
        }
    }
}
