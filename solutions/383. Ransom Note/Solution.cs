public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        bool[] cond = new bool[magazine.Length];
        int j = 0;
    
        for (int i = 0; i < ransomNote.Length; i++) {
            for (j = 0; j < magazine.Length; j++) {
                if (ransomNote[i] == magazine[j] && cond[j] == false) {
                    cond[j] = true;
                    break;
                }
            }
                
            if (j >= magazine.Length) {
                return false;
            }
        }
        
        return true;  
    }
                
}
            