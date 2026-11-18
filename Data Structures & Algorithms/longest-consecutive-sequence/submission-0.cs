public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length < 1)
            return 0;
        if (nums.Length == 1)
            return 1;

        List<int> list = nums.OrderBy(x => x).ToList();
        int maxSeq = 1;
        int current = 1;
        //2,3,4,4,5,10,20
        for(int i=1; i<list.Count; i++){
            if(list[i] - 1 == list[i-1] ){
                current++;  
            }          
            else if (list[i] == list[i-1]){

            }
            else{
                current = 1;
            }
            maxSeq = Math.Max(maxSeq, current);
            }
        return maxSeq;
    }
}
