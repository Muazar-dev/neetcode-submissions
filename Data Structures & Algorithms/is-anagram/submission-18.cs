public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] arr = new int[26];

        if(s.Length != t.Length) {
            return false;
        }

    
        foreach(char c in s) {
            var index = c - 97;
            arr[index]++;
        }

        foreach (char c in t) {
            var index = c - 97;
            if(arr[index] == 0) {
                return false;
            }
            arr[index]--;
        }

        return true;

    }
}
