public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numbers = new HashSet<int>(nums.Length);
        bool dupe = false;

        foreach(int num in nums) {
          
            if(numbers.Contains(num)) {
                dupe = true;
                break;
            }
            else {
                numbers.Add(num);
            }

        }

        return dupe;
        
    }
}