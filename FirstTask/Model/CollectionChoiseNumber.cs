using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstTask.Model
{
    public static class CollectionChoiseNumber
    {
        public static void ChooseOddMember(List<int> numberList)
        {
            var selectedMember = from m in numberList where m % 2 != 0 select m;

            foreach (var member in selectedMember)
            {
                Console.WriteLine(member);
            }
        }

        public static void ChooseEvenMember(List<int> numberList)
        {
            var selectedMember = from m in numberList where m % 2 == 0 select m;

            foreach (var member in selectedMember)
            {
                Console.WriteLine(member);
            }
        }
    }
}
