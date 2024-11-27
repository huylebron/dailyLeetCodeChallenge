namespace dailyLeetCodeChallenge.day1.array ;

public class thePivotIndex
{
    public int PivotIdex ( int [ ] nums ) {

        int total  = 0 ;

        foreach ( var x in nums )
        {
            total += x ;
            
        }
        
        
        int leftSum = 0 ;
        for ( int i = 0 ; i < nums . Length ; i ++ )
        {

            int rightsum = total - leftSum - nums [ i ] ;
           
            if ( leftSum == rightsum )
            {
                return i ;
                
            }
            
            leftSum += nums [ i ] ;
            
            
        }
        
        return -1 ;
        
    }

    public static void Main1 ( string [ ] args ) {
        thePivotIndex obj = new thePivotIndex ( ) ;
        int [ ] nums = { 1 , 7 , 3 , 6 , 5 , 6 } ;
        Console . WriteLine ( obj . PivotIdex ( nums ) ) ;
        Console . ReadKey ( ) ;
    }
    
}