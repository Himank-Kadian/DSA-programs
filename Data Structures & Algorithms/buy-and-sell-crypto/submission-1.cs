public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length < 2)
            return 0;

        int left = 0;
        int right = 1;
        int maxProfit = 0;
        while(right < prices.Length){
            if (prices[left] > prices[right]){
                left = right;
                right++;
            }else{
                maxProfit = Math.Max(maxProfit, (prices[right] - prices[left]));
                right++;
            }
        }
        return maxProfit;
    }
}
