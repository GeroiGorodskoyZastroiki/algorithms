public class Decryptor
{
    public static string DeCrypt(string key, string message)
    {
        var numKey = key
            .Select((ch, index) => new { Char = ch, Index = index })
            .OrderBy(x => x.Char)
            .Select((x, index) => new { x.Index, Order = index })
            .OrderBy(x => x.Index)
            .Select(x => x.Order)
            .ToArray();

        string[] charsOnKey = new string[key.Length];
        for (int i = 0; i < key.Length; i++)
            charsOnKey[i] = string.Concat(message.Skip(i).Where((_, j) => j % key.Length == 0));

        string[] charsOnKeyOrdered = numKey.Select(order => charsOnKey[order]).ToArray();

        return string.Concat(Enumerable
            .Range(0, charsOnKeyOrdered.Max(s => s.Length))
            .SelectMany(i => charsOnKeyOrdered.Select(s => i < s.Length ? s[i] : '\0')))
                .Trim();
    }
}
