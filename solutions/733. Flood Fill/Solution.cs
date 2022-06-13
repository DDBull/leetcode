using System.Drawing;

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        int n = image.Length;
        int m = image[0].Length;
        
        int originalColor = image[sr][sc];
        image[sr][sc] = newColor;
        bool[,] state = new bool[n, m];
        state[sr, sc] = true;
        
        Queue <Point> q = new();
        
        q.Enqueue(new Point(sr, sc));
        
        while (q.Count > 0)
        {
            Point pt = q.Dequeue();
            
            if (pt.X - 1 >= 0 && image[pt.X - 1][pt.Y] == originalColor && !state[pt.X - 1, pt.Y])
            {
                q.Enqueue(new Point(pt.X - 1, pt.Y));
                image[pt.X - 1][pt.Y] = newColor;
                state[pt.X - 1, pt.Y] = true;
            }
            if (pt.X + 1 < n && image[pt.X + 1][pt.Y] == originalColor && !state[pt.X + 1, pt.Y])
            {
                q.Enqueue(new Point(pt.X + 1, pt.Y));
                image[pt.X + 1][pt.Y] = newColor;
                state[pt.X + 1, pt.Y] = true;
            }
            if (pt.Y - 1 >= 0 && image[pt.X][pt.Y - 1] == originalColor && !state[pt.X, pt.Y - 1])
            {
                q.Enqueue(new Point(pt.X, pt.Y - 1));
                image[pt.X][pt.Y - 1] = newColor;
                state[pt.X, pt.Y - 1] = true;
            }
            if (pt.Y + 1 < m && image[pt.X][pt.Y + 1] == originalColor && !state[pt.X, pt.Y + 1])
            {
                q.Enqueue(new Point(pt.X, pt.Y + 1));
                image[pt.X][pt.Y + 1] = newColor;
                state[pt.X, pt.Y + 1] = true;
            }
        }
        
        return image;
    }
}
