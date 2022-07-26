public class Solution {
    public string SimplifyPath(string path) {
        string modifiedPath = path + "/";
        StringBuilder currentPath = new();
        
        Stack<string> directories = new();
        
        foreach (char ch in modifiedPath)
        {
            if (ch == '/')
            {
                if (currentPath.Length == 0)
                {
                    continue;
                }
                else
                {
                    string directory = currentPath.ToString();
                    currentPath.Clear();
                    
                    if (directory.Equals(".."))
                    {
                        if (directories.Count > 0)
                        {
                            directories.Pop();
                        }
                    }
                    else if (directory.Equals("."))
                    {
                        continue;
                    }
                    else
                    {
                        directories.Push(directory);
                    }
                }                
            }
            else 
            {
                currentPath.Append(ch);
            }
        }
        
        string result = string.Empty;
        
        while (directories.Count > 0)
        {
            result = "/" + directories.Pop() + result;
        }
            
        return string.IsNullOrEmpty(result) ? "/" : result;
    }
}
