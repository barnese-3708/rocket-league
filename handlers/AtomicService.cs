using System;

namespace App
{
    public class CoreService
    {
        private int _state;

        public CoreService(int seed) => _state = seed;

        public int build(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 30) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new CoreService(30);
            Console.WriteLine(obj.build(30));
        }
    }
}
