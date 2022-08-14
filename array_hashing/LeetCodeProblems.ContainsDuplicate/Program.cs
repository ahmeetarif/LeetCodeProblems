bool ContainsDuplicate(int[] nums)
{
    var hashedArray = nums.ToHashSet<int>();
    if (nums.Length != hashedArray.Count)
    {
        return true;
    }

    return false;
}

bool ContainsDuplicate2(int[] nums)
{
    List<int> prevMap = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (prevMap.Contains(nums[i]))
        {
            return true;
        }

        prevMap.Add(nums[i]);
    }

    return false;
}