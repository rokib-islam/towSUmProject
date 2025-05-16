namespace towSUmProject
{
    public class TwoSumTests
    {
        private readonly TwoSum _twoSum = new TwoSum();

        [Fact]
        public void NormalCase_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };

            // Act
            int[] resultOriginal = _twoSum.TwoSumOriginal(nums, target);
            int[] resultOptimized = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(expected, resultOriginal);
            Assert.Equal(expected, resultOptimized);
        }

        [Fact]
        public void EdgeCase_TwoElementArray_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 3, 3 };
            int target = 6;
            int[] expected = { 0, 1 };

            // Act
            int[] resultOriginal = _twoSum.TwoSumOriginal(nums, target);
            int[] resultOptimized = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(expected, resultOriginal);
            Assert.Equal(expected, resultOptimized);
        }

        [Fact]
        public void DuplicateNumbers_ReturnsCorrectIndices()
        {
            // Arrange
            int[] nums = { 3, 2, 4, 3 };
            int target = 6;
            int[] expected = { 0, 3 }; // First 3 and last 3

            // Act
            int[] resultOriginal = _twoSum.TwoSumOriginal(nums, target);
            int[] resultOptimized = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            // Note: For this test, the optimized algorithm might return different but valid indices
            // since it depends on the order of insertion into the dictionary
            Assert.Equal(target, nums[resultOriginal[0]] + nums[resultOriginal[1]]);
            Assert.Equal(target, nums[resultOptimized[0]] + nums[resultOptimized[1]]);
        }

        [Fact]
        public void NoSolution_ReturnsEmptyArray()
        {
            // Arrange
            int[] nums = { 1, 2, 3, 4 };
            int target = 10;
            int[] expected = Array.Empty<int>();

            // Act
            int[] resultOriginal = _twoSum.TwoSumOriginal(nums, target);
            int[] resultOptimized = _twoSum.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(expected, resultOriginal);
            Assert.Equal(expected, resultOptimized);
        }
    }
}