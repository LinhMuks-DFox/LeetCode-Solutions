class Solution:
    def is_valid(self, s):
        stack = []
        if len(s) % 2 == 1:
            return False
        for i in s:
            if i == "(" or i == "[" or i == "{":
                stack.append(i)
            else:
                if len(stack) == 0:
                    return False
                ch = stack.pop()
                if i == ")" and ch != "(":
                    return False
                if i == "]" and ch != "[":
                    return False
                if i == "}" and ch != "{":
                    return False
        return len(stack) == 0

sol = Solution()

print(sol.is_valid("(())"))