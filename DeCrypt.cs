public class Decryptor
{
    public static string DeCrypt(string key, string message)
    {
        var keyOrder = key
            .Select((ch, index) => new { Char = ch, Index = index })
            .OrderBy(x => x.Char)
            .Select((x, index) => new { x.Index, Order = index })
            .OrderBy(x => x.Index)
            .Select(x => x.Order)
            .ToArray();

        string[] subStrings = new string[key.Length];
        Array.Fill(subStrings, string.Empty);

        for (int i = 0, j = 0; i < message.Length; i++, j = j == (key.Length - 1) ? 0 : j + 1)
            subStrings[j] += message[i];

        string[] sortedStrings = new string[key.Length];

        for (int i = 0; i < key.Length; i++)
            sortedStrings[i] = subStrings[keyOrder[i]];

        string decryptedMessage = string.Empty;

        for (int i = 0; i < sortedStrings.Max(s => s.Length); i++)
            foreach (string str in sortedStrings)
                if (i < str.Length)
                    decryptedMessage += str[i];

        return new string(decryptedMessage).Trim();
    }
}
