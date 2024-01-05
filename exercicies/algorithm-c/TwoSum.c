/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* twoSum(int* nums, int numsSize, int target, int* returnSize){

    int* result = (int*)malloc(3 * sizeof(int)); 

    for(int i = 0; i < numsSize - 1; i++){
        for(int j = i + 1; j < numsSize; j++){
            int comp = nums[i] + nums[j];
            if(comp == target){
                result[0] = i;
                result[1] = j;
                result[2] = 0;
                *returnSize = 2;
                return(result);
            }
            comp = 0;
        }
    }
    *returnSize = 0;
    return(NULL);
}