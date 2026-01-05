array = [1,3,4,6,7,8,9];
var searchInsert = function(nums, target) {
    let arr1 = [];
    for ( let i=0; i<nums.length; i++){
        if(nums[i] === target){
            return i;
        }
        else{  
            nums.push(target);
            arr1 = nums.sort((a,b) => a - b);
            var tgt = arr1.indexOf(target)
;
            return tgt;
        }

    }
    
};