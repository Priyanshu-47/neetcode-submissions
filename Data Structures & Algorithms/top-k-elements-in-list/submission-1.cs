public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (count.ContainsKey(num))
                count[num]++;
            else
                count[num] = 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        for (int i = 0; i < buckets.Length; i++)
            buckets[i] = new List<int>();

        foreach (var pair in count)
        {
            buckets[pair.Value].Add(pair.Key);
        }

        List<int> result = new List<int>();

        for (int freq = buckets.Length - 1; freq >= 0; freq--)
        {
            foreach (int num in buckets[freq])
            {
                result.Add(num);

                if (result.Count == k)
                    return result.ToArray();
            }
        }

        return result.ToArray();  
    }
}
