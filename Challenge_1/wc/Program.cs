using System.Text;

string path = Path.Combine(Directory.GetCurrentDirectory(), "data", "example.txt");
int lines, words, bytes, chars;
lines = words = bytes = chars = 0;

foreach (string line in File.ReadLines(path))
{
    string[] parts = line.Split();
    foreach (string word in parts)
    {
        if (string.IsNullOrEmpty(word)) continue;
        foreach (char c in word)
        {
            bytes += Encoding.UTF8.GetByteCount(c.ToString());
            chars++;
        }
        words++;
    }
    bytes += parts.Length;
    chars += parts.Length;
    lines += 1;
}

Console.WriteLine($"lines: {lines}; words: {words}; chars: {chars}; bytes: {bytes}; for the file: example.txt");