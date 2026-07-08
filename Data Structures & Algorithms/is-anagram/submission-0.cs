public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }
        Dictionary<char, int> dc = new();

        for(int i=0; i<s.Length; i++){
            if(!dc.ContainsKey(s[i])){
                dc.Add(s[i], 0);
            }
            dc[s[i]]++;
        }

        for(int i=0; i<t.Length; i++){
            if(!dc.ContainsKey(t[i])){
                return false;
            }
            dc[t[i]]--;

            if(dc[t[i]] < 0){
                return false;
            }
        }
        return true;
    }
}
