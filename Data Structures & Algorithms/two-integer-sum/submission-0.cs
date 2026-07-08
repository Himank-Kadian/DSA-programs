public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> dc = new();
        for(int i=0; i<nums.Length; i++){
            int num2 = target - nums[i];

            if(dc.ContainsKey(num2)){
                return[dc[num2], i];
            }

            dc.Add(nums[i], i);
        }

        return[];
    }
}
