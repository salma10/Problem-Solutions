public class Solution {
    public IList<IList<string>> FindDuplicate(string[] paths) {
        IDictionary<string, IList<string>> content2File = new Dictionary<string, IList<string>>();

            foreach (var path in paths)
            {
                var splitted = path.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var dir = splitted[0] + '/';

                for (int i = 1; i < splitted.Length; i++)
                {
                    var file = splitted[i];
                    int start = file.IndexOf('(');
                    string content = file.Substring(start, file.Length - start);

                    if (!content2File.ContainsKey(content))
                    {
                        content2File[content] = new List<string>();
                    }

                    content2File[content].Add($"{dir}{file.Substring(0, start)}");

                }
            }

            return content2File.Any() ? content2File.Values.Where(l => l.Count > 1).ToList() : new List<IList<string>>();
    }
}