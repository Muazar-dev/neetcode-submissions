public class Solution {
    public bool IsPalindrome(string s) {
        int index = s.Length - 1;
        int index2 = 0;
        while(index > index2)
        {   
            if(!char.IsLetterOrDigit(s[index])) {
                index--;
                continue;
            }
            if(!char.IsLetterOrDigit(s[index2])) {
                index2++;
                continue;
            }

            char a = char.ToLowerInvariant(s[index]);
            char b = char.ToLowerInvariant(s[index2]);

            
                if(a == b) {
                    index--;
                    index2++;
                    continue;
                }
                else {
                    return false;
                }
        }
        
        return true;
    }
}
