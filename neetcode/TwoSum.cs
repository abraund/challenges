using System.Diagnostics;

namespace neetcode
{
    public class TwoSum
    {
        public int[] TwoSumImplm(int[] nums, int target)
        {
            var valuesToPosition = new Dictionary<int, int>();
            for (var currentPosition = 0; currentPosition < nums.Length; currentPosition++)
            {
                var currentValue = nums[currentPosition];
                if (valuesToPosition.TryGetValue(target - currentValue, out var otherPosition))
                {
                    return [otherPosition, currentPosition];
                }
                else
                {
                    valuesToPosition[currentValue] = currentPosition;
                }
            }

            throw new UnreachableException();
        }
        

        [Fact]
        public void TwoSumTest()
        {
            var result = TwoSumImplm([1, 2, 8, 4, 5, 10], 7);
            Assert.Equal(1, result[0]);
            Assert.Equal(4, result[1]);
        }
    }
}