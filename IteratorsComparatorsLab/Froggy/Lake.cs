using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stoneValues;


        public Lake(params int[] values)
        {
            this.stoneValues = values.ToList();
        }



        public IEnumerator<int> GetEnumerator()
        {
            if (stoneValues.Count % 2 == 0)
            {
                for (int i = 0; i < stoneValues.Count; i += 2)
                {
                    yield return stoneValues[i];
                }

                for (int i = stoneValues.Count - 1; i >= 0; i -= 2)
                {
                    yield return stoneValues[i];
                }
            }
            else
            {
                for (int i = 0; i < stoneValues.Count; i += 2)
                {
                    yield return stoneValues[i];
                }

                for (int i = stoneValues.Count - 2; i >= 1; i -= 2)
                {
                    yield return stoneValues[i];
                }

            }

        }


        IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
    }
}
