class Solution:
    def twoSum(self, nums, target):
        lookup = {}

        for i, num in enumerate(nums):
            compliment = target - num

            if compliment in lookup:
                return [lookup[compliment],i]
            lookup[num] = i
        