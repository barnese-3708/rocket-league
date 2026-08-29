using System;

namespace App
{
    public class FastProcessor
    {
        private int _state;

        public FastProcessor(int seed) => _state = seed;

        public int run(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 48) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new FastProcessor(48);
            Console.WriteLine(obj.run(48));
        }
    }
}
