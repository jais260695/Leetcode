public class Codec {
    
    public string domain = "https://tinyurl.com";
    public Dictionary<string,string> encodeDict = new Dictionary<string,string>();
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        string tinyUrl = domain+"/"+encodeDict.Count();
        encodeDict.Add(tinyUrl,longUrl);
        return tinyUrl;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return encodeDict[shortUrl];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));