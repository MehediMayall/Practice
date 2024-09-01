using static System.Console;

int[] nums = [1,3,4,6,8,10,20,25,26,38,45,68,78,88,96];


// Non Generic way
bool BinarySearch(int[] nums, int itemToSearch)
{
    int left = 0, right = nums.Count()-1;

    while (left <= right)
    {
        int mid = (left + right) / 2;

        if (nums[mid] == itemToSearch)
            return true;
        else if (nums[mid] > itemToSearch)
            right = mid-1;
        else
            left = mid + 1;
    } 

    return false;
}

int BinarySearch2<T>(IList<T> nums, T itemToSearch) where T: IComparable<T>
{
    int left = 0, right = nums.Count()-1;

    while (left <= right)
    {
        int mid = (left + right) / 2;
        int comparison = nums[mid].CompareTo(itemToSearch);

        if (comparison == 0)
            return mid;
        else if ( comparison > 0 )
            right = mid - 1;
        else
            left = mid + 1;
    } 

    return -1;
}



// var result = BinarySearch(nums, 18);
// WriteLine($"is the number in the array? {result}");

// var result = BinarySearch2<int>(nums, 8);
// WriteLine($"Search item found at {result}");

List<string> words = new List<string> { "apple", "banana", "cherry", "date", "fig", "grape" };
int wordIndex = BinarySearch2<string>(words, "cherry");
WriteLine(wordIndex != -1 ? $"Item found at index {wordIndex}" : "Item not found");
