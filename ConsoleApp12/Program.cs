using System;
using System.Collections.Generic;
using System.Linq;

namespace ds
{
    class Program
    {
        

        //Amazon Fulfilment Center

        
            

        

       

       


        public static void Main(string[] args)
        {
            //Prime Air Route
            //int[][] arr1 = new int[2][] { new int[]{ 1, 1000 }, new int[]{ 2, 2000 } };
            //int[][] arr2 = new int[3][] { new int[] { 4, 1000 }, new int[] { 5, 2000 }, new int[] { 6, 3000 } };
            //int target = 7000;
            //int[][] result = TwoSumClosest(arr1, arr2, target);
            //Console.WriteLine($"{{{result[0][0]},{result[0][1]}}}");

            //Amazon Fulfilment Center
            //int[] arr3 = new int[6] { 2, 7, 9, 11, 13, 16 };
            //int res1 = FindClosestMatch(arr3, 1);
            //Console.WriteLine(res1.ToString());
            //res1 = FindClosestMatch(arr3, 9);
            //Console.WriteLine(res1.ToString());
            //res1 = FindClosestMatch(arr3, 12);
            //Console.WriteLine(res1.ToString());
            //res1 = FindClosestMatch(arr3, 17);
            //Console.WriteLine(res1.ToString());

            //
            //NumPairsDivisibleBy60
            // https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/

            //Items in Container

            //var s = "*|**|*|*";
            //Console.WriteLine(s);
            //var si = new int[] { 1, 1 };
            //var ei = new int[] { 5, 6 };
            //var result = numberOfItems(s, si, ei);
            //foreach(var i in result)
            //{
            //    Console.Write(i);

            //}
            Console.WriteLine("-------------");

            //s = "*|**|*|****|";
            //Console.WriteLine(s);
            //si = new int[] { 1, 1 };
            //ei = new int[] { 5, 10 };
            //result = numberOfItems(s, si, ei);
            //foreach (var i in result)
            //{
            //    Console.Write(i);

            //}
            //Console.WriteLine("-------------");
            //var s = "*****|**|*|****|****|****";
            //Console.WriteLine(s);
            //var si = new int[] {  1 };
            //var ei = new int[] {  22 };
            //var result = numberOfItems(s, si, ei);
            //foreach (var i in result)
            //{
            //    Console.Write(i);

            //}


            //findCompetitors
            //int numCompetitors = 6;
            //int topNCompetitors = 2;
            //List<string> competitors = new List<string>() { "newshop", "shopnow", "afashion", "fashionbeats", "mymarket", "tcellular" };
            //int numReviews = 6;

            //List<string> reviews = new List<string>() {"newshop is providing good services in the city; everyone should use newshop",
            // "best services by newshop",
            // "fashionbeats has great services in the city",
            //  "I am proud to have fashionbeats",
            //  "mymarket has awesome services",
            //  "Thanks Newshop for the quick delivery" };
            //List<string> resultComp = findCompetitors(numCompetitors, topNCompetitors, competitors, numReviews, reviews);

            //foreach (var i in resultComp)
            //{
            //    Console.WriteLine(i);

            //}

            //Fresh Amazon Promotion


            //String[][] codeList1 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart1 = new string[] { "orange", "apple", "apple", "banana", "orange", "banana" };
            //  String[][] codeList2 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart2 = new string[] { "banana", "orange", "banana", "apple", "apple" };
            //  String[][] codeList3 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart3 = new string[] { "apple", "banana", "apple", "banana", "orange", "banana" };
            //  String[][] codeList4 = new string[][] { new string[] { "apple", "apple" }, new string[] { "apple", "apple", "banana" } };
            //  String[] shoppingCart4 = new string[] { "apple", "apple", "apple", "banana" };
            //  String[][] codeList5 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart5 = new string[] { "orange", "apple", "apple", "banana", "orange", "banana" };
            //  String[][] codeList6 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart6 = new string[] { "apple", "apple", "orange", "orange", "banana", "apple", "banana", "banana" };
            //  String[][] codeList7 = new string[][] { new string[] { "anything", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart7 = new string[] { "orange", "grapes", "apple", "orange", "orange", "banana", "apple", "banana", "banana" };
            //  String[][] codeList8 = new string[][] { new string[] { "apple", "orange" }, new string[] { "orange", "banana", "orange" } };
            //  String[] shoppingCart8 = new string[] { "apple", "orange", "banana", "orange", "orange", "banana", "orange", "grape" };
            //  String[][] codeList9 = new string[][] { new string[] { "anything", "anything", "anything", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  String[] shoppingCart9 = new string[] { "orange", "apple", "banana", "orange", "apple", "orange", "orange", "banana", "apple", "banana" };
            //  // test
            //  Console.WriteLine(AmazonFreshPromotion(codeList1, shoppingCart1)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList2, shoppingCart2)); //0
            //  Console.WriteLine(AmazonFreshPromotion(codeList3, shoppingCart3)); //0
            //  Console.WriteLine(AmazonFreshPromotion(codeList4, shoppingCart4)); //0
            //  Console.WriteLine(AmazonFreshPromotion(codeList5, shoppingCart5)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList6, shoppingCart6)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList7, shoppingCart7)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList8, shoppingCart8)); //1
            //  Console.WriteLine(AmazonFreshPromotion(codeList9, shoppingCart9)); //1
            // string[][] codeList10 = new string[][] {new string[] { "apple", "apple" },new string[]{ "banana", "anything", "banana" } };
            //  string[] shoppingCart10 = new string[] { "orange", "apple", "apple", "banana", "orange", "banana" };
            //  bool result10 = AmazonFreshPromotion(codeList1, shoppingCart1);
            //  string[][] codeList11 = new string[][] { new string[] { "apple", "apple" }, new string[] { "banana", "anything", "banana" } };
            //  string[] shoppingCart11 = new string[] { "banana", "orange", "banana", "apple", "apple" };
            //  bool result11 = AmazonFreshPromotion(codeList2, shoppingCart2);

            //var arr = new int[] { 14, 1, 160, 8, 210 };
            //var tree = MinimuDistanceInBST.BuildTree(arr);
            //Console.WriteLine(MinimuDistanceInBST.getMinimumDIstance(tree));

            //var ratings = new int[][] { new int[] { 4, 4 }, new int[] { 1, 2 }, new int[] { 3, 6 } };
            //int threshold = 77;
            //int result = FiveStarSeller.GetMinimumReviewsNeeded(ratings, threshold);
            //Console.WriteLine(result);

            //var a = new int[][] { new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 } };
            //var b = new int[][] { new int[] { 1, 2 } };

            //var a = new int[][] { new int[] { 4, 10 }, new int[] { 1, 3 }, new int[] { 2, 5 }, new int[] { 3, 7 } };
            //var b = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3,4 }, new int[] { 4,5 } };

            ////var target = 7;
            //var target = 10;
            //var resultarray = OptimalUtilization.GetOptimalUtilization(a, b, target);

            //foreach (var item1 in resultarray)
            //{
            //    Console.WriteLine($"{item1[0]}:{item1[1]}");
            //}
            //Array.Sort(a, (int[] o1, int[] o2) => o1[1] - o1[1]);
            //foreach (var item1 in a)
            //{
            //    Console.WriteLine($"{item1[0]}:{item1[1]}");
            //}

            //var str = "abccdeefge";
            //int length = 3;
            ////var subs = SubstringSizeKDistinctChars.GetSubstringSizeKDistinctChars(str, length);
            //var subs = SubstringSizeKDistinctChars.SlidingWindowTechnique(str, length);
            //foreach (var item1 in subs)
            //{
            //    Console.WriteLine($"{item1}");
            //}

            //var items = new List<PairString>() { new PairString("Item1", "Item2"), new PairString("Item3", "Item4"), new PairString("Item4", "Item5") };
            //var resultAssociation = LargestAssociation.LargestItemAssociation(items);
            //foreach (var item1 in resultAssociation)
            //{
            //    Console.WriteLine($"{item1}");
            //}


            var scores = new int[] { 20, 40, 40, 40, 40, 100 };
            var cutoffRank = 3;
            Console.WriteLine(CutOffRank.GetCutOffRank(scores, cutoffRank));

        }




    }

   
  
  
 
}
