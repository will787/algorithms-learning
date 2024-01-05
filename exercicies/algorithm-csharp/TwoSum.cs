public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int resultfinal = 0;
        int[] arrayfinal = new int[2];
        for(int i = 0; i < nums.Length - 1; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    arrayfinal[0] = i;
                    arrayfinal[1] = j;
                    return(arrayfinal);
                }
            }
        }
        return(new int[0]);
    }
}