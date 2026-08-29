using System;

namespace App
{
    public class LiteBuilder
    {
        private int _state;

        public LiteBuilder(int seed) => _state = seed;

        public int load(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 84) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new LiteBuilder(84);
            Console.WriteLine(obj.load(84));
        }
    }
}
