class NumMatrix {

    int[][] matrix;

    public NumMatrix(int[][] matrix) {
        this.matrix = matrix;
        initMatrix();
    }

    public int sumRegion(int row1, int col1, int row2, int col2) {
        int sum = matrix[row2][col2];
        sum -= checkCoordinate(row1 - 1, col2) ? matrix[row1 - 1][col2] : 0;
        sum -= checkCoordinate(row2, col1 - 1) ? matrix[row2][col1 - 1] : 0;
        sum += checkCoordinate(row1 - 1, col1 - 1) ? matrix[row1 - 1][col1 - 1] : 0;

        return sum;
    }

    private void initMatrix() {
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                matrix[i][j] += checkCoordinate(i - 1, j) ? matrix[i - 1][j] : 0;
                matrix[i][j] += checkCoordinate(i, j - 1) ? matrix[i][j - 1] : 0;
                matrix[i][j] -= checkCoordinate(i - 1, j - 1) ? matrix[i - 1][j - 1] : 0;
            }
        }
    }

    private boolean checkCoordinate(int i, int j) {
        return i >= 0 && j >= 0 && i < matrix.length && j < matrix[i].length;
    }
}
