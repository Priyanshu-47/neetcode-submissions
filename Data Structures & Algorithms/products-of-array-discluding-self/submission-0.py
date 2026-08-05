class Solution:
        def productExceptSelf(self, nums):

                n = len(nums)
# Result array initially filled with 1
                result = [1] * n

                                        # Build prefix products
                prefix = 1

                for i in range(n):
                    result[i] = prefix
                    prefix *= nums[i]
                suffix = 1                                                
                for i in range(n - 1, -1, -1):
                                                                        result[i] *= suffix
                                                                        suffix *= nums[i]
                return result