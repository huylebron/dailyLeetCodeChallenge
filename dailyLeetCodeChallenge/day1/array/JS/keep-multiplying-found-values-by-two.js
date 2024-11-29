var findFinalValue = function( nums  = [], original) {

    while(nums.includes(original)){

        original *= 2 ; 

    }
    return original;

   
    

};

let nums = [5,3,6,1,12];

console.log(findFinalValue( nums, 5 )); 
