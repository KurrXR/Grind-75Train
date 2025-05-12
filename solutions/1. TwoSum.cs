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
public class Solution // D: Dictionary<數值, 索引>
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>(); // 建立記錄過去數字與其索引的雜湊表

        for (int i = 0; i < nums.Length; i++)  // 遍歷陣列每個元素
        {
            int comp = target - nums[i]; // 計算補數：希望找一個之前出現過的數，使得 comp + nums[i] == target

            if (dic.ContainsKey(comp)) // 如果補數曾出現過（即 dic 中已有紀錄）
            {
                return new int[] { dic[comp], i }; // 回傳補數的位置（value）與目前位置（i）
            }

            dic[nums[i]] = i; // 紀錄目前的數字及其索引，供後續查找使用
        }

        return new int[] { }; // 理論上不會執行（題目保證一定有解），只是語法保險
    }
}

