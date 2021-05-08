using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class AmazonFreshPromotion
    {

        public static bool GetAmazonFreshPromotion(string[][] codeList, string[] shoppingCart)
        {
            //get each codelist an match pattern with shopping cart
            // codelist = [apple,apple][orange,anything,orange]
            //shopping cart = [orange,apple, apple, orange,banana, orange]
            int codeListCount = codeList.Length; //2
            int shpListCount = shoppingCart.Length; //5
            int currentCodeIndex = 0;
            int currentShoppingCartIndex = 0;
            int count = 0;
            Console.WriteLine($"------------------");
            while (currentCodeIndex < codeListCount && currentShoppingCartIndex < shpListCount)
            {
                string[] currentCode = codeList[currentCodeIndex];// [apple,apple]
                int currentCodeLength = currentCode.Length; //2
                int index = 0;

                while (index < currentCodeLength && currentShoppingCartIndex < shpListCount)
                {
                    Console.WriteLine($"{index},{currentCode[index]}:{currentShoppingCartIndex},{shoppingCart[currentShoppingCartIndex]}");
                    if (currentCode[index] == "anything" || shoppingCart[currentShoppingCartIndex] == currentCode[index])
                    {


                        index++;
                        currentShoppingCartIndex++;

                    }
                    else
                    {
                        currentShoppingCartIndex++;
                        if (index > 0) break;
                    }
                }

                Console.WriteLine($"{index},{count}");
                if (index == currentCodeLength)
                {
                    currentCodeIndex++;
                    count++;
                }

            }

            return (count == codeListCount) ? true : false;

        }



    }
}
