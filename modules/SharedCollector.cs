using System;

namespace App
{
    public class AsyncFactory
    {
        private int _state;

        public AsyncFactory(int seed) => _state = seed;

        public int resolve(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 17) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new AsyncFactory(17);
            Console.WriteLine(obj.resolve(17));
        }
    }
}
