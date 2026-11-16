public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dc = new();

        foreach(string str in strs){
            var charArray = str.ToCharArray();
            Array.Sort(charArray);

            string key = String.Join(",", charArray);

            if(dc.ContainsKey(key)){
                dc[key].Add(str);
            }else{
                dc[key] = new List<string>{str};
            }
        }
        return dc.Values.ToList();
    }
}
