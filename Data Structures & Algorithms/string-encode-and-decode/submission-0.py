class Solution:

    def encode(self, strs):

        encoded = ""

        for s in strs:

            encoded += str(len(s)) + "#" + s

        return encoded


    def decode(self, s):

        result = []

        i = 0

        while i < len(s):

            j = i

            # Find the '#' separator
            while s[j] != "#":
                j += 1

            # Length of current string
            length = int(s[i:j])

            # Actual string starts after '#'
            word = s[j + 1 : j + 1 + length]

            result.append(word)

            # Move to next encoded string
            i = j + 1 + length

        return result