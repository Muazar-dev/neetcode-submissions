public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> AnagramDataBase = new Dictionary<string, List<string>>();
        int index = new int();
        List<List<string>> final = new List<List<string>>();
        
        for(int i = 0; i < strs.Length; i++) {
            
            
            var currentstr = strs[i];
            
            int[] arr = new int[26];

            foreach(char c in strs[i]) {
                index = c - 'a';
                arr[index]++;
            }
            string temp = string.Join(",", arr);
            if(AnagramDataBase.ContainsKey(temp)) {
                AnagramDataBase[temp].Add(currentstr);
            }
            else{
                AnagramDataBase.Add(temp, new List<string>());
                AnagramDataBase[temp].Add(currentstr);
            }

           
            
        }

        
        foreach(var (key, value) in AnagramDataBase) {
        final.Add(value);    


            
        }
        
        return final;
    }
}
