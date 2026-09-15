public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        bool dupe = false;

        foreach(int num in nums) {
          
            if(numbers.ContainsKey(num)) {
                dupe = true;
                break;
            }
            else {
                numbers.Add(num, num);
            }

        }

        return dupe;
        
    }
}