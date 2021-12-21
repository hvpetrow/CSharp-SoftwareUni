using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
   public class Lake : IEnumerable<int>
    {
        int[] stones;

        public Lake(int[] stones)
        {
            this.stones = stones;   
        }

       public IEnumerator<int> GetEnumerator()
       {
            for (int i = 0; i < stones.Length; i+=2)
            {            
                    yield return stones[i];
            }

            int backwards = stones.Length % 2 == 0 ? stones.Length - 1 : stones.Length - 2;

            for (int i = backwards; i >= 0; i-=2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
