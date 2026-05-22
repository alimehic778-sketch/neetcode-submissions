public class Solution {
       public int Search(int[] nums, int target)
    {
        int velicina=nums.Length;
        int brojac = 0;

        while (brojac < velicina)
        {
            if (nums[brojac]==target)
                return brojac;
            brojac++;
        }
        return -1;
    }
}
