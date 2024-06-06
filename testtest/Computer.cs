class Computer
{
    public double Avg(int[] nums)
    {
        double avg = 0;

        foreach (double i in nums)
        {
            avg += i;
        }
        avg /= nums.Length;

        return avg;
    }
    public int Sum(int[] nums)
    {
        int sum = 0;
        foreach (int i in nums)
        {
            sum += i;
        }

        return sum;
    }

    public int Min(int[] nums)
    {
        int min = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }
        return min;

    }
    public int Max(int[] nums)
    {
        int max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        return max;
    }
}