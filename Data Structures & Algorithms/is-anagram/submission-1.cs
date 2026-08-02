public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach(char ch in s){
            if (count.ContainsKey(ch))
                count[ch]++;
            else
                count[ch] = 1;
        }

        foreach(char ch in t){
            if(!count.ContainsKey(ch))
                return false;
            
            count[ch]--;

            if (count[ch]<0)
                return false; 
        }
        return true;
    }
}
