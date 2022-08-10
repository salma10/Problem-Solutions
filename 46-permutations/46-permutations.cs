public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        
        List<int> s = nums.ToList();
        
        List<List<int>> result = GetPermutations(s, nums.Length);
        
        return ((IList<IList<int>>)result.Cast<IList<int>>().ToList());
    }
    
    private List<List<T>> GetPermutations<T>(List<T> list, int length)
    {
        if (length == 1) 
            return list.Select(t => new T[] { t }.ToList()).ToList();

        return GetPermutations(list, length - 1).SelectMany(t => list.Where(e =>                !t.Contains(e)),(t1, t2) => t1.Concat(new T[] { t2 }).ToList()).ToList();
    }
}