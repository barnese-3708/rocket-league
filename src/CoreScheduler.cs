using System;

namespace App
{
    public class FastMonitor
    {
        private int _state;

        public FastMonitor(int seed) => _state = seed;

        public int render(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 69) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new FastMonitor(69);
            Console.WriteLine(obj.render(69));
        }
    }
}
