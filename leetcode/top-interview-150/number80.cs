namespace leetcode.top_interview_150;

public class Number80
{
    public int Solution(int[] nums)
    {
        int curNumber = nums[0];
        int curNumberCount = 0;
        int validElementsCount = 0;
        int movedElementsCount = 0;

        for (int i = 0; i < nums.Length-movedElementsCount; i++)
        {
            if (curNumber == nums[i]) // compara se é o mesmo elemento
            {
                if(curNumberCount < 2)
                {
                    curNumberCount++;
                    validElementsCount++;
                    continue;
                }

                // remover elemento
                nums.MoveValueToEndOfArray(i);
                movedElementsCount++;
                i--;
                continue;
            }

            curNumber = nums[i];
            curNumberCount = 1;
            validElementsCount++;
        }
        return validElementsCount;
    }

}