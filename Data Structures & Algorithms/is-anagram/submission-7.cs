public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> chars = new Dictionary<char, int>();
        
        Dictionary<char, int> charss = new Dictionary<char, int>();

        if(s.Length != t.Length) {
            
            return false;
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
                return false;
                }
            }
            else{
            return false;
            }
            

        }

        foreach(var (key, value) in charss) {
            if(chars.ContainsKey(key)) {
                if(chars[key] != charss[key]) 
                {
                return false;
                }
            }
            else{
            return false;
            }
            

        }

        return true;
    }
}
