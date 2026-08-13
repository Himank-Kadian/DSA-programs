public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dc = new();
        foreach (int num in nums){
            if(!dc.ContainsKey(num)){
                dc[num] = 1;
            }
            else{
                dc[num]++;
            }
        }

        return dc.OrderByDescending(kvp => kvp.Value).Take(k).Select(kvp => kvp.Key).ToArray();
    }
}
