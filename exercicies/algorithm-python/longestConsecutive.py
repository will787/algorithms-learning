class Solution:

    def longestConsecutive(self, nums: List[int]) -> int:
        if not nums:
            return 0

        nums.sort()
        count = 1
        max_count = 1
        for i in range(1, len(nums)):
            if nums[i] == nums[i - 1]:
                continue
            elif nums[i] == nums[i - 1] + 1:
                count += 1
            else:
                max_count = max(max_count, count)
                count = 1

        return max(max_count, count)


# class Solution:
#     def longestConsecutive(self, nums: List[int]) -> int:
#         num_set = set(nums)
#         sequencia_longa = 0


#         for num in nums:

#             if num - 1  not in num_set:
#                 current_num = num
#                 current_streak = 1

#                 while current_num + 1 in num_set:
#                     current_num += 1
#                     current_streak += 1

#                     sequencia_longa = max(sequencia_longa, current_streak)

#         return sequencia_longa

