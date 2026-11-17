public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dc = new();
        List<int>[] bucket = new List<int>[nums.Length+1];

        foreach(int num in nums){
            if(dc.ContainsKey(num)){
                dc[num]++;
            }else{
                dc[num] = 1;
            }
        }

        for(int i=0; i<bucket.Length; i++){
            bucket[i] = new List<int>();
        }

        foreach (var d in dc){
            bucket[d.Value].Add(d.Key);
        }
            
        int[] final = new int[k];
        for (int i = bucket.Length -1, j=0; i > 0; i--){
            foreach(var b in bucket[i]){
                final[j] = b;
                j++;
                if (j == k){
                    return final;
                }
            }
        }
        return final;
    }
}
