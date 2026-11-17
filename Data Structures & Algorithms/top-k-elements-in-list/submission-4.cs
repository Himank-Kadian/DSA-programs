public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int,int> dc = new();
        foreach(int num in nums){
            if(!dc.ContainsKey(num)){
                dc[num] = 0;
            }
            dc[num]++;
        }

        var topKFreq = dc.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();

        return topKFreq;
        
    }
}
