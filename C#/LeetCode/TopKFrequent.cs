//Using HashMap and Sorting (Time Complexity: O(nlogn))
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) + 1;
        }

        return dict.OrderByDescending(key => key.Value).Take(k).Select(k => k.Key).ToArray();
    }
}
