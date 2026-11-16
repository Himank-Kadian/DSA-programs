public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> dc = new Dictionary<int,int>();
        for (int i=0; i<nums.Length; i++){
            if(dc.ContainsKey(nums[i])){
                return true;
            }
            dc[nums[i]] = 1;
        }
        return false;
    }
}