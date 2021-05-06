using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class CoinChange
    {


        private static int[] memo;
        private static int[] dp;
        public static int GetMinimumCoinChange(int[] coins, int amount)
        {
            //memo = new int[amount+1];
            dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            Array.Sort(coins);
            //Array.Fill(dp, amount+100);
            //return CoinRecursiveMemo(coins, amount);  
            return CoinRecursiveDP(coins, amount);

        }

        public static int CoinRecursiveMemo(int[] coins, int amount)
        {        

            if (amount == 0) return 0;        
            if (amount < 0) return -1;
            //if(memo[amount] < Int32.MaxValue) return memo[amount];
            var minValue = Int32.MaxValue;

            for(int i=0; i<coins.Length; i++){
                var res = CoinRecursiveMemo(coins, amount-coins[i]);
                if(res!=-1){
                    minValue = Math.Min(minValue, 1 + res);
                }

            }
            memo[amount] = (minValue==Int32.MaxValue)?-1:minValue;

           return (minValue==Int32.MaxValue)?-1:minValue;

        }

        public static int CoinRecursiveDP(int[] coins, int amount)
        {

            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] > i) break;
                    dp[i] = Math.Min(dp[i], 1 + dp[i - coins[j]]);
                    //Console.WriteLine($"i:{i}:j:{j}:dp[i]:{dp[i]}:coins[j]:{coins[j]}:i-conins[j]:{i-coins[j]} dp[i-conins[j]]:{dp[i-coins[j]]}");
                }
            }


            return (dp[amount] > amount) ? -1 : dp[amount];

        }



    }
}
