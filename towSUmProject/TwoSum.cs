namespace towSUmProject
{
    public class TwoSum
    {
        // Original implementation - O(n²) time, O(1) space
        public int[] TwoSumOriginal(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
            return Array.Empty<int>();
        }

        // Optimized implementation - O(n) time, O(n) space
        public int[] TwoSumOptimized(int[] nums, int target)
        {
            var numToIndex = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                
                if (numToIndex.TryGetValue(complement, out int index))
                {
                    return new[] { index, i };
                }
                
                // Store the current number and its index
                numToIndex[nums[i]] = i;
            }
            
            return Array.Empty<int>();
        }
    }
} 