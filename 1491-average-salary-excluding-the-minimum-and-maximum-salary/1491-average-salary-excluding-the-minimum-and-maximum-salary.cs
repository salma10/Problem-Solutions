public class Solution {
    public double Average(int[] salary) {
        int minSalary = Int32.MaxValue;
        int maxSalary = Int32.MinValue;
        int sum = 0;
        
        for(int index = 0; index < salary.Length; index++)
        {
            minSalary = Math.Min(minSalary, salary[index]);
            maxSalary = Math.Max(maxSalary, salary[index]);
            sum += salary[index];
        }
        
        return (double)(sum - minSalary - maxSalary) / (salary.Length - 2);
    }
}