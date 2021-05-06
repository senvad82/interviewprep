using System;
using System.Collections.Generic;
using System.Text;

namespace ds
{
    
    public static class BaseBallGame
    {
        public class Solution
        {
            public int CalPoints1(string[] ops) {
                int count = ops.Length;
                int sum = 0;
                for(int i=0; i< count;i++){
                    if(ops[i]=="+"){
                        int nonZeroElements=0;
                        int tempSum =0;
                        int counter=1;                
                        while (nonZeroElements < 2){
                            if(ops[i-counter] != "0"){                        
                                tempSum = tempSum + Int32.Parse(ops[i-counter]);  
                                nonZeroElements++;
                            } 
                             counter++;
                        }
                        ops[i]= tempSum.ToString();

                    }
                    else if(ops[i]=="D"){
                        int nonZeroElements=1;
                        int counter=1;
                        while (nonZeroElements <= 1){
                            if(ops[i-counter] != "0"){                        
                                ops[i] = (2* Int32.Parse(ops[i-counter])).ToString();
                                nonZeroElements++;
                            }
                            counter++;
                        }                
                    }
                    else if(ops[i]=="C"){
                        sum = sum - Int32.Parse(ops[i-1]);
                        ops[i-1]="0";
                        ops[i]="0";
                    }
                    Console.WriteLine(ops[i]);
                    sum = sum + Int32.Parse(ops[i]);
                }

                return sum;
            }
            public int CalPoints2(string[] ops)
            {
                int sum = 0;
                Stack<string> st = new Stack<string>();

                for (int i = 0; i < ops.Length; i++)
                {

                    if (ops[i] == "C")
                    {
                        var temp = st.Pop();
                        sum = sum - Int32.Parse(temp);
                    }
                    else if (ops[i] == "D")
                    {
                        var temp = st.Peek();
                        var tempR = 2 * Int32.Parse(temp);
                        st.Push(tempR.ToString());
                        sum = sum + tempR;
                    }
                    else if (ops[i] == "+")
                    {
                        var temp1 = st.Peek();
                        var temp = st.Pop();
                        var temp2 = st.Peek();
                        var newtop = (Int32.Parse(temp1) + Int32.Parse(temp2)).ToString();
                        st.Push(temp);
                        st.Push(newtop);
                        sum = sum + Int32.Parse(temp1) + Int32.Parse(temp2);
                    }
                    else
                    {
                        st.Push(ops[i]);
                        sum = sum + Int32.Parse(ops[i]);
                    }

                }
                return sum;

            }
        }



    }
}
