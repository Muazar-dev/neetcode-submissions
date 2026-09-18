public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        int?[][] scan = new int?[nums.Length + 1][];
        int[] final = new int[k];
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach(int x in nums) 
        {

            if(frequency.ContainsKey(x)) 
            {
            frequency[x]++;
            }
            else
            {
            frequency.Add(x, 1);
            }

        }

        foreach(var (key, value) in frequency) 
        {
            if(scan[value] == null) {
                int?[] temp = new int?[nums.Length];
                temp[0] = key;
                scan[value] = temp;
            }
            else
            {
                for(int i = 0; i < scan[value].Length; i++) {
                    if(scan[value][i] == null) {
                        scan[value][i] = key;
                        break;
                    }
                    else {
                        continue;
                    }
                }   
            }
        }

        int index = 0;
        
        for(int i = nums.Length; i >= 1; i--) {
             if(k == 0) {
                break;
             }
            if(scan[i] == null) {
                continue;
            }
            else{
                foreach(var x in scan[i] ) 
                {
                if(x == null) break;
                final[index] = (int)x;
                index++;
                k--;
                }
            }
        }

        return final;
    }
}
