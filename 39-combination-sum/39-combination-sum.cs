public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        List<IList<int>> result = new List<IList<int>>();
        List<int> combination = new List<int>();
        Array.Sort(candidates);
        CombinationSum(result, candidates, combination, target, 0);
        return result;
    }
    private void CombinationSum(IList<IList<int>> result, int[] candidates, IList<int> combination, int target, int start)
    {
        if (target == 0)
        {
            result.Add(new List<int>(combination));
            return;
        }

        for (int i = start; i != candidates.Length && target >= candidates[i]; ++i)
        {
            combination.Add(candidates[i]);
            CombinationSum(result, candidates, combination, target - candidates[i], i);
            combination.Remove(combination.Last());
        }
    }
}