public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        
        int final = 0;
        
        foreach(int num in nums) {
            
            hash.Add(num);

        }

        foreach(int num in nums) {
            if(hash.Contains(num - 1)) {
                continue;
            }
            else {
                bool checking = true;
                int i = 1;
                while(checking) {
                    if(hash.Contains(num + i)) {
                        
                        i++;
                    }
                    else {
                        checking = false;
                    }
                }
            if(i > final) {
                final = i;
            }







                
            }
        }

        return final;


    }
}
