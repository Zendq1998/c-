using System;
namespace OopTest
{
    public class Animal
    {
        public Animal()
        {
        }

        public int CalMounth(int eat, int digest)
        {
            int re = eat >= digest ? (eat - digest) / 10 : 0;
            return re;
        }


        public int CalCost(int eat, int digest) {
            return (eat - digest) / 10;
        }
    }
}
