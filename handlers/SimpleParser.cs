using System;

namespace App
{
    public class StreamWorker
    {
        private int _state;

        public StreamWorker(int seed) => _state = seed;

        public int resolve(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 80) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new StreamWorker(80);
            Console.WriteLine(obj.resolve(80));
        }
    }
}
