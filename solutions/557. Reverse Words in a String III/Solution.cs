public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(' ');
        string ans = String.Empty;

        for (int i = 0; i < words.Length; i++)
        {
          for (int j = words[i].Length - 1; j >= 0; j--)
          {
            ans += words[i][j];
          }
          if (i + 1 < words.Length) ans += ' ';
        }

        return ans;
    }
}
/* Copy from forums
     public string ReverseWords(string s) {
        var arr = s
            .Split(" ")
            .Select(w => w.ToCharArray())
            .ToArray();

        foreach (var word in arr)
        {
            for (int i = 0, j = word.Length - 1; i < word.Length / 2; i++, j--)
            {
                (word[j], word[i]) = (word[i], word[j]);
            }
        }
        return string.Join(" ", arr.Select(word => new string(word)));
    }
}
*/
