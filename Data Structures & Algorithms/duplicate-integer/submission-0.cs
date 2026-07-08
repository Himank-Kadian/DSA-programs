public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dc = new ();
        foreach(var num in nums){
            if (dc.ContainsKey(num)){
                return true;
            }
            else{
                dc.Add(num, num);
            }
        }
        return false;
    }
}