using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = 9;
            var result = MaxBinaryGap(15);
            Console.ReadKey();
        }

        public static int MaxBinaryGap(int N){

            var binaryGapResult = new List<int>();

            var oneIndexStorage = new List<int>();

            var binaryRep = binaryRepresentation(N);

            for (int i = 0; i < binaryRep.Length; i++){
                if(binaryRep[i]=='1'){
                    oneIndexStorage.Add(i);
                }
            }

            //test invalid conditions
            if(oneIndexStorage.Count == 0 || oneIndexStorage.Count == 1){
                return 0;
            }

			//compute consecutive diffs
			//[0,3]
			for (int j = 0; j < oneIndexStorage.Count;j++) {

                if(j<oneIndexStorage.Count-1){
                    binaryGapResult.Add(oneIndexStorage[j+1] - oneIndexStorage[j] - 1);
                }

            }
            return binaryGapResult.Max();
        }

        static string binaryRepresentation(int number){
            var binaryRepresentationStr = Convert.ToString(number, 2);
            return binaryRepresentationStr;
        }
    }
}
