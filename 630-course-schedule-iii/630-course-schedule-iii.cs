public class Solution {
    public int ScheduleCourse(int[][] courses) {
        courses =  courses.OrderBy(x => x[1]).ToArray();
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
        int time = 0;
        
        foreach (int[] course in courses) {
            if (course[0] <= course[1]) {
                if (time + course[0] <= course[1]) {
                    time += course[0];
                    pq.Enqueue(course[0], course[0]);
                }
                else if (pq.Peek() > course[0]) {
                    time -= pq.Dequeue();
                    time += course[0];
                    pq.Enqueue(course[0], course[0]);
                }
            }
        }
        
        return pq.Count;
    }
}