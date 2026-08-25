public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length)
            return false;
        int[] s1Arr = new int[26];
        foreach (var c in s1){
            s1Arr[c - 'a']++;
        }

        string targetSet = String.Join(",", s1Arr);

        for(int i = 0; i <= s2.Length - s1.Length; i++){
            int[] s2Arr = new int[26];
            string str = s2.Substring(i, s1.Length);

            foreach (var c in str){
            s2Arr[c - 'a']++;
            }

            if (String.Join(",",s2Arr) == targetSet){
                return true;
            }
        }
        return false;
    }
}
