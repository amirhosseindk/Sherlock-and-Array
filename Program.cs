int T = Convert.ToInt32(Console.ReadLine().Trim());

for (int TItr = 0; TItr < T; TItr++)
{
	int n = Convert.ToInt32(Console.ReadLine().Trim());

	List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

	string result = balancedSums(arr);

	Console.WriteLine(result);
}

static string balancedSums(List<int> numberArray)
{
	if (numberArray.Count == 1)
		return "YES";

	var leftSum = 0;
	var rightSum = numberArray.Skip(1).Sum();

	if (leftSum == rightSum)
		return "YES";

	for (int index = 0; index < numberArray.Count - 1; index++)
	{

		leftSum += numberArray[index];
		rightSum -= numberArray[index + 1];

		if (leftSum == rightSum)
			return "YES";
	}

	return "NO";
}