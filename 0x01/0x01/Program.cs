using System;

public class Solution {
    public int[] TwoSum (int[] nums, int target) {
        System.Collections.Generic.Dictionary<int, int> map = new System.Collections.Generic.Dictionary<int, int> ();
        for (int i = 0; i < nums.Length; ++i) {
            if (map.ContainsKey (target - nums[i])) {
                return new int[] { map[target - nums[i]], i };
            }
            map[nums[i]] = i;
        }
        return new int[0];
    }

    public static void Main () {
        Solution s = new Solution ();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] res = s.TwoSum (nums, target);

        for (int i = 0; i < res.Length; ++i) {
            Console.WriteLine (res[i]);
        }
    }
}