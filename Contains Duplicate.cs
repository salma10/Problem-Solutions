public bool ContainsDuplicate(int[] nums) {
        
        var groups = nums.GroupBy(v => v);
foreach(var group in groups)
{
    if(group.Count() > 1)
    return true;
}
 
    return false;
    }
