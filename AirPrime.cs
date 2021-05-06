public class Solution {
    public int TwoSumClosest(int[][] arr1, int[][] arr2, int target) {
        // find length of array and assign it to 
        // naive solution would putting in 2 loops.
        // check each combination and maintain min distance
        int n = arr1.Length;
        int m = arr2.Length;
        int minDistance = -1;
        Tuple<int,int> minDistValue;
        for(int i=0; i<n;i++){
            for(int j=0; j<n; j++){
                if(arr1[i][1]+arr2[j][1] <= target){
                    if(arr1[i][1]+arr2[j][1] > minDistance)
                    minDistance = target - (arr1[i][1] + arr2[j][1]);
                    minDistValue = new Tuple<int, int>(arr1[i][0],arr2[j][1]);
                }
            }
        }
        Console.Writeline(minDistValue.item1,minDistValue.item2);
        
        
    }
    public static void main(){

        int[][] arr1 = new int[3][2]{ {1, 1000}, {2, 2000}, {3, 3000}} ;
        int[][] arr2 = new int[3][2]{ {4, 1000}, {5, 2000}, {6, 3000}} ;
        int target = 4000;
        TwoSumClosest(arr1,arr2, target);

    }
}
