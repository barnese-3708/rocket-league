using System;

namespace App
{
    public class FastManager
    {
        private int _state;

        public FastManager(int seed) => _state = seed;

        public int encode(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 83) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new FastManager(83);
            Console.WriteLine(obj.encode(83));
        }
    }
}
