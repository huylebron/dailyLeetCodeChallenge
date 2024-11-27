﻿namespace dailyLeetCodeChallenge.day1.array ;

/// <summary>
/// 485. Max Consecutive Ones
/// 
/// </summary>
public class FindMaxConsecutiveOnes
{
    public int findMaxConsecutiveOnes ( int[] nums) {
        
        int max = 0;
        int count = 0;

        foreach ( var n in  nums)
        {
            if ( n == 1 )
            {
                count ++ ;

                max = Math . Max ( max , count ) ;
                
            }
            else  

            {
                count = 0 ; 
            }
            
            
        }

        return max  ;

    }

    public static void Main ( string [ ] args ) {
        
        FindMaxConsecutiveOnes obj = new FindMaxConsecutiveOnes ( ) ;
        int [ ] nums = { 1 , 1 , 0 , 1 , 1 , 1 } ;
        Console . WriteLine ( obj . findMaxConsecutiveOnes ( nums ) ) ;
        Console . ReadKey ( ) ;
        
        
    }
}