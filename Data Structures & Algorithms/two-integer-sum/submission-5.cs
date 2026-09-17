public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> mydict = new Dictionary<int, int>();

        
        int[] num = new int[2];

        for(int i = 0; i < nums.Length; i++) 
        {
            if(mydict.ContainsKey(target - nums[i])) 
            {
            num[0] = mydict[target - nums[i]];
            num[1] = i;
            return num;
            }

            if(!mydict.ContainsKey(nums[i])) {
            mydict.Add(nums[i], i);
            }

        }

        return num;
    }
}
