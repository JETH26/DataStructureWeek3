using System;

namespace Week3
{


    static class SimpleArrayExercises
    {
         public static void Main() {

     string myName;
      int i, len, vowel_count;

      myName = "Ako si Jetro General Bagasala";

      vowel_count = 0;
      
      len = myName.Length;

      for(i=0; i<len; i++) {
         if(myName[i] =='a' || myName[i]=='e' || myName[i]=='i' || myName[i]=='o' || myName[i]=='u' || myName[i]=='A'
            || myName[i]=='E' || myName[i]=='I' || myName[i]=='O' || myName [i]=='U') 
            vowel_count++;          
   
      }

      Console.Write("\nVowels in the Text: {0}\n", vowel_count);  

      }
        
    static void CountEvenNumbers()
    {
        int[] numbers = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13};
        int even = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
        {
         
            even++;

        }

        Console.WriteLine("\nCount Even Numbers: {0}\n", even);
   
        }

    }
     
    static void ReverseArrayOrder(int[] numberArray)
    {
         int[] num = new int[] {20,21,22,23,24,25,26,27,28,29,30};
         
         int length = num.Length;

         for (int i = 0; i < num.Length; i++)
         {
             Console.WriteLine(num[length-1]);
               length = length - 1;
         }

    }
                 

   }
}