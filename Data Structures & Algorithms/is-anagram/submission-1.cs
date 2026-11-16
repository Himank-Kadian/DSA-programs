public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
            
        Dictionary<char,int> dc = new();
        
        foreach (char c in s){
            if(dc.ContainsKey(c)){
                dc[c]++;
            }else{
                dc[c] = 1;
            }
        }

        foreach (char c in t){
            if(dc.ContainsKey(c)){
                dc[c]--;
            }else{
                return false;
            }
            if (dc[c] < 0){
                return false;
            }
        }

        return true;
    }
}
