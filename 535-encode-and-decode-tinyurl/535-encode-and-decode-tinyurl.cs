public class Codec {

    static string alph = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    Dictionary<string, string> dict = new  Dictionary<string, string>();
    static Random rand = new Random();
    string key = GetNewKey();
    private static string GetNewKey()
    {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < 6; i++)
        {
            sb.Append(alph[rand.Next(62)]);
        }
        return sb.ToString();
    }
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        while(dict.ContainsKey(key))
        {
            key = GetNewKey();
        }
        dict[key] = longUrl;
        return "http://tinyurl.com/" + key;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        string prevKey = shortUrl.Replace("http://tinyurl.com/", "");
        return dict[prevKey];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));