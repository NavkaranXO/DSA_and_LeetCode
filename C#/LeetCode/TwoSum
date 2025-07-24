public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        Dictionary<int, int> dt = new Dictionary<int, int>();
        int idx = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if(i > 0 && dt.ContainsKey(target - nums[i]))
            {
                result[0] = dt[target - nums[i]];
                result[1] = i;
                break;
            }

            dt.TryAdd(nums[i], idx);
            idx++;
        }
        return result;
    }
}
