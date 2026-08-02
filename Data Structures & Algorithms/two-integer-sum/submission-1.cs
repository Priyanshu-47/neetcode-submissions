public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> lookup = new Dictionary<int,int>();

        for(int i=0; i<=nums.Length; i++){
            int compliment = target - nums[i];
            if(lookup.ContainsKey(compliment)){
                return new int[] {lookup[compliment], i};
            }
            lookup[nums[i]] = i;
        }
        return new int[0];
    }
}
