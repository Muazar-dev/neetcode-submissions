public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] front = new int[nums.Length];
        int[] back = new int[nums.Length];
        int [] final = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++) {
            if (i == 0) {
                front[i] = nums[i];
            }
            else {
                front[i] = nums[i] * front[i - 1];
            }
        }


        
        for (int i = nums.Length - 1; i >= 0; i--) 
        {
            if(i == nums.Length - 1) {
                back[i] = nums[i];
                

            }
            else {
                back[i] = nums[i] * back[i + 1];
            }
                

        }

        for(int i = 0; i < final.Length; i++) {
            if(i == 0) {
                final[i] = back[1];
            }
            else if (i == final.Length - 1) {
                final[i] = front[nums.Length - 2];
            }
            else {
                final[i] = back[i + 1] * front[i - 1];
            }

        }

        return final;

    }
}
