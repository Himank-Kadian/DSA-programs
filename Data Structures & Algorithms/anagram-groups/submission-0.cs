public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dc = new();

        for(int i=0; i<strs.Length; i++){
            var str = strs[i];
            int[] intArray = new int[26];
            foreach(char c in str){
                intArray[c - 'a']++;
            }
            
            string key = string.Join(",", intArray);

            if (dc.ContainsKey(key)){
                dc[key].Add(str);
            }else{
                dc[key] = new List<string> {str};
            }
        }

        return dc.Values.ToList();
    }
}
