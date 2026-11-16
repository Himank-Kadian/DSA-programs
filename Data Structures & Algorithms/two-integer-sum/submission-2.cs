public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dc = new ();

        for(int i=0; i<nums.Length; i++){
            int otherNum = target - nums[i];
            if(!dc.ContainsKey(otherNum)){
                dc[nums[i]] = i; 
            }else{
                return [dc[otherNum], i];
            }
        }
        return [];
    }
}
