public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        
        int final = 0;
        int temp = 1;
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
                        temp++;
                        i++;
                    }
                    else {
                        checking = false;
                    }
                }
            if(temp > final) {
                final = temp;
            }







                temp = 1;
            }
        }

        return final;


    }
}
