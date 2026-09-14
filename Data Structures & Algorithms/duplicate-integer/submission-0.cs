public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> numbers = new List<int>();
        bool dupe = false;

        foreach(int num in nums) {
            foreach(int number in numbers) {
                if(number == num) {
                    dupe = true;
                }
                
            }
            numbers.Add(num);

        }

        return dupe;
        
    }
}