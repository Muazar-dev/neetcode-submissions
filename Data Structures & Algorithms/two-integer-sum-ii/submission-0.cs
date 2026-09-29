public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int low = 0;
        int high = numbers.Length - 1;
        int[] arr = new int[2];

        while(low < high) {
            int final = numbers[low] + numbers[high];
            if(final == target) {
                arr[0] = low +1;
                arr[1] = high + 1;
                break;
            }

            if(final > target) {
                high--;
            }
            if(final < target) {
                low++;
            }
        }
        return arr;
    }
}
