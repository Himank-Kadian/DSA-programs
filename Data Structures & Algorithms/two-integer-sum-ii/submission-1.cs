public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length -1;
        while(left < right){
            int t2 = (numbers[left] + numbers[right]) - target;
            if(t2 == 0){
                return [left+1, right+1];
            }
            if(t2 > 0){
                right--;
            }
            if(t2 < 0){
                left++;
            }
        }
        return [];
    }
}
