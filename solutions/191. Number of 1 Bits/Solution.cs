public int HammingWeight(uint n)
	=> Convert.ToString(n, 2).Count(x => x == '1');

  public int HammingWeight(uint n)
{
	uint c = 0;

	while(n > 0)
	{
		c += n & 1; // or: c += n % 2;
		n >>= 1;    // or: n /= 2;
	}

	return (int) c;
}

public int HammingWeight(uint n)
	=> System.Numerics.BitOperations.PopCount(n);
  