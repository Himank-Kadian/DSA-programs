public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int maxWater = 0;
        while(left < right){
            int currentWater = 0;
            if (heights[left] <= heights[right]){
                currentWater = heights[left] * (right-left);
                left++;
            }else{
                currentWater = heights[right] * (right-left);
                right--;
            }
            maxWater = Math.Max(maxWater, currentWater);
        }
        return maxWater;
    }
}
