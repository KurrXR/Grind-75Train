public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                int profit = price - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }

        return maxProfit;
    }
}
/*
1.宣告 minPrice = int.MaxValue（目前觀察到的最低價格）
   宣告 maxProfit = 0（目前最大獲利）

2. 對於每一個價格 price in prices：
   a. 如果 price < minPrice：
        → 更新 minPrice = price（找到新的買入點）
   b. 否則：
        → 計算 profit = price - minPrice（以當前價當賣出點，計算獲利）
        → 如果 profit > maxProfit，就更新 maxProfit
*/

/*public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {   //這邊為買入點
            for (int j = i + 1; j < prices.Length; j++)
            {  //這邊是賣出點 為了不要讓值先買後賣 而做+1 初始要從第0天後的第1天開始算
                int profit = prices[j] - prices[i];
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }
        return maxProfit;

    }
}

//暴力解 會Time Limit Exceeded
/*1. 初始化 maxProfit = 0
2. 遍歷所有買入點 i（0 到 n-1）
   a. 遍歷所有賣出點 j（i+1 到 n-1）
      i.   profit = prices[j] - prices[i]
      ii.  如果 profit > maxProfit，更新 maxProfit
3. 回傳 maxProfit*/
