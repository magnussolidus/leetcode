namespace leetcode.top_interview_150;

public static class Extensions
{
    public static int[] MoveValueToEndOfArray(this int[] targetArray, int targetIndex)
    {
        int itemToMove = targetArray[targetIndex];
        for (int i = targetIndex; i < targetArray.Length-1; i++)
        {
            targetArray[i] = targetArray[i+1];
        }
        targetArray[targetArray.Length-1] = itemToMove;
        return targetArray;
    }
}