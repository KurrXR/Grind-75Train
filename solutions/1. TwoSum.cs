/*public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int [] result = new  int[2];
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for (int i=0 ; i<nums.Length;i++)
        {
            if(dic.ContainsKey(target- nums[i]))
            {
                result[0] = dic[target - nums [i]];
                result[1] = i;
                break;
            }
            dic[nums[i]]=i;
        }
        return result;
    }
}
*/
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }

            if (!numToIndex.ContainsKey(nums[i]))
            {
                numToIndex.Add(nums[i], i);
            }
        }

        return new int[] { };
    }
}