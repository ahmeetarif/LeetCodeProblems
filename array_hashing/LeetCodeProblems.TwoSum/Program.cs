// MARK : Case 1
int[] caseOneArray = new int[] { 2, 7, 11, 15, 2 };
int caseOneTarget = 9;
Console.WriteLine("CASE 1");
Console.WriteLine(String.Join(',', TwoSum(caseOneArray, caseOneTarget)));

// MARK : Case 2
int[] caseTwoArray = new int[] { 3, 2, 4 };
int caseTwoTarget = 6;
Console.WriteLine("CASE 2");
Console.WriteLine(String.Join(',', TwoSum(caseTwoArray, caseTwoTarget)));

// MARK : Case 3
int[] caseThreeArray = new int[] { 3, 3 };
int caseThreeTarget = 6;
Console.WriteLine("CASE 3");
Console.WriteLine(String.Join(',', TwoSum(caseThreeArray, caseThreeTarget)));

int[] TwoSum(int[] nums, int target)
{
    List<int> result = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        var searchTarget = target - nums[i];
        if (result.Contains(searchTarget))
        {
            return new int[] { result.IndexOf(searchTarget), i };
        }

        result.Add(nums[i]);
    }

    return Array.Empty<int>();
}