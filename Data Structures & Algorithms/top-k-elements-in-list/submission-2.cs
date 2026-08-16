public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dc = new();
        List<int>[] bucket = new List<int>[nums.Length + 1];

        foreach (int num in nums){
            if(dc.ContainsKey(num)){
                dc[num]++;
            }else{
                dc[num] = 1;
            }
        }

        foreach(var(key, value) in dc){
            if(bucket[value] is null){
                bucket[value] = new List<int>();
            }
            bucket[value].Add(key);
        }

        int[] result = new int[k];
        for(int i=bucket.Length-1, index=0; i>0; i--){
            if (bucket[i] is null)
                continue;
            foreach(var val in bucket[i]){
                result[index] = val;
                index++;
                if(index == k){
                    return result;
                }
            }
        }
        return result;
    }
}
