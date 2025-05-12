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

public class Solution //Dictionary<補數,index>
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)  //一般迴圈迭代
        {              //7
            int comp = target - nums[i]; //定義補數comp
            if (dic.ContainsKey(comp)) //如果dic有補數就回傳
            {
                return new int[] { dic[comp], i };
                //加入dic[補數]和 i
            }

            dic[nums[i]] = i;
            //如果沒有就把nums[i]當key, i當value放進dic
        }
        return new int[] { };
    }
}
