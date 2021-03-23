class Solution {
    public int distributeCandies(int[] candyType) {
        Set<Integer> confet = new HashSet<>();

        for (int candy : candyType) {
            confet.add(candy);
        }

        return Math.min(confet.size(), candyType.length / 2);
    }
}