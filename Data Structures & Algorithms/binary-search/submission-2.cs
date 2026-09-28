public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;

        while(low <= high) {
            int index = low + (high - low) / 2;
            if(nums[index] == target ) return index;
            if(nums[index] < target) low = index + 1;
            if(nums[index] > target) high = index - 1; 
        }

        return -1;
    }
}
