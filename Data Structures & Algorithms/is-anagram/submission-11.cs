public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> chars = new Dictionary<char, int>();
        bool ana = true;
        Dictionary<char, int> charss = new Dictionary<char, int>();

        if(s.Length != t.Length) {
            ana = false;
            return ana;
        }
        
        foreach(char a in s) {
            if(!chars.ContainsKey(a)) {
            chars.Add(a, 1);
            }
            else{
                chars[a]++;
            }
        }

        
        foreach(char b in t) {
            if(!charss.ContainsKey(b)) {
            charss.Add(b, 1);
            }
            else{
                charss[b]++;
            }
        }


        foreach(var (key, value) in chars) {
            if(charss.ContainsKey(key)) {
                if(chars[key] != charss[key]) 
                {
                ana = false;
                return ana;
                }
            }
            else{
            ana = false;
            return ana;
            }
            

        }

        
            

        

        return ana;
    }
}
