namespace Leetcode.Tasks;

internal class SuccessfulPairsTask
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        for (int i = 0; i < spells.Length; i++)
        {
            int spellPower = spells[i];
            spells[i] = 0;

            for (int j = 0; j < potions.Length; j++)
            {
                long power = (long)spellPower * (long)potions[j];

                if (power >= success)
                    spells[i]++;
            }
        }

        return spells;
    }
}