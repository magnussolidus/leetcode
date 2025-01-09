namespace leetcode.top_interview_150;

public class Number80
{
    /// <summary>
    /// O(N²) solution
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
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
    
    /// <summary>
    /// O(N) solution
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int ImprovedSolution(int[] nums) 
    {
        if (nums.Length == 0)
        {
            return 0;   
        }
        int curNumberCount = 1;
        int writterPointer = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[writterPointer])
            {
                if(curNumberCount < 2)
                {
                    writterPointer++;
                    nums[writterPointer] = nums[i];
                }

                curNumberCount++;
                continue;
            }

            writterPointer++;
            nums[writterPointer] = nums[i];
            curNumberCount = 1;
        }
        return writterPointer+1;
    }
}