using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var result = MaxBinaryGap(15);
            Console.ReadKey();
        }

        public static int MaxBinaryGap(int N){

            const int ZERO_GAPS = 0;

            var binaryRep = binaryStringRepresentation(N);

            var indexStore = GetIndexStoreGivenBinaryRep(binaryRep);

            if(!ResultIsValid(indexStore)){
                return ZERO_GAPS;
            }

            var binaryGaps = computeBinaryGapsGivenIndexStore(indexStore);

            return binaryGaps.Max();
        }

        static string binaryStringRepresentation(int number){
            return Convert.ToString(number, 2);
        }

		static List<int> GetIndexStoreGivenBinaryRep(string binaryRep)
		{
			var indexStore = new List<int>();

			for (int i = 0; i < binaryRep.Length; i++)
			{
				if (binaryRep[i] == '1')
				{
					indexStore.Add(i);
				}
			}
			return indexStore;
		}

		static bool ResultIsValid(List<int> indexStore)
		{
			return (indexStore.Count == 0 || indexStore.Count == 1) ? false : true;
		}

		static List<int> computeBinaryGapsGivenIndexStore(List<int> indexStore)
		{
			var binaryGaps = new List<int>();
			for (int j = 0; j < indexStore.Count; j++)
			{
				if (j < indexStore.Count - 1)
				{
					binaryGaps.Add(indexStore[j + 1] - indexStore[j] - 1);
				}
			}
			return binaryGaps;
		}
    }
}
