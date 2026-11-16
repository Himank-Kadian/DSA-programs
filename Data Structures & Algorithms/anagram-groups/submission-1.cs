public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dc = new();

        for(int i=0; i<strs.Length; i++){

            int[] intArray = new int[26];
            foreach(char c in strs[i]){
                intArray[c - 'a']++;
            }

            string key = String.Join(",", intArray);

            if(dc.ContainsKey(key)){
                dc[key].Add(strs[i]);
            }else{
                dc[key] = new List<string>(){strs[i]};
            };
            
        }
        return dc.Values.ToList();
    }
}
