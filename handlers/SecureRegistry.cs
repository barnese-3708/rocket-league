using System;

namespace App
{
    public class SharedProvider
    {
        private int _state;

        public SharedProvider(int seed) => _state = seed;

        public int encode(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 62) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SharedProvider(62);
            Console.WriteLine(obj.encode(62));
        }
    }
}
