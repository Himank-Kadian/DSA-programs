public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
            return false;
        int[] s1IntArray = new int[26];
        int[] s2IntArray = new int[26];
        for (int i = 0; i < s1.Length; i++){
            s1IntArray[s1[i] - 'a']++;
            s2IntArray[s2[i] - 'a']++;
        }

        string resultSet = String.Join(",", s1IntArray);

        for(int i=0; i<=s2.Length-s1.Length; i++){
            if(String.Join(",",s2IntArray) == resultSet){
                return true;
            }
            if(i < s2.Length-s1.Length){
                s2IntArray[s2[i] - 'a']--;
                s2IntArray[s2[i + s1.Length] - 'a']++;
            }
        }
        return false;
    }
}
