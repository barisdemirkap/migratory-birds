using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds (List<int> arr)
    {   List <int> Counter = new List<int>{0 ,0 ,0 , 0 ,0} ;
        int max = 0 ;
        int Result = 0 ;
           // for (int i = 0; i < arr.Count() ; i++) {
           // // Track number of elements swapped during a single array traversal
           //int numberOfSwaps = 0;
             //
           //for (int j = 0; j < arr.Count() - 1; j++) {
           // // Swap adjacent elements if they are in decreasing order
           // if (arr[j] > arr[j + 1]) {
           // int a= arr[j] ;
           // int b = arr[j+1] ;
           // arr[j] = b ;
           // arr[j+1] = a ;
             //
           // numberOfSwaps++;
           // }
           // }
           //
          // If no elements were swapped during a traversal, array is sorted
          //if (numberOfSwaps == 0) {
           // break;
           //}


            //}

    
        for (int i = 0 ; i < arr.Count ; i++) 
            {  
                if(arr[i]== 1)
                {
                    Counter[0]++ ;
                }
                else if(arr[i]== 2)
                {
                    Counter[1]++ ;
                }
                 else if(arr[i]== 3)
                {
                    Counter[2]++ ;
                }
                 else if(arr[i]== 4)
                {
                    Counter[3]++ ;
                }
                 else if(arr[i]== 5)
                {
                   Counter[4]++ ;
            }}

            
    // Track number of elements swapped during a single array traversal
      for(int i =0 ; i < 5 ; i++ )
        {Console.WriteLine(Counter[i]) ;
        }
      
      max = Counter.IndexOf(Counter.Max()) + 1 ;

    
    return max ; }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        Console.WriteLine(result);

        
    }
}