namespace SqueakyClean;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        System.Text.StringBuilder builder = new();
        bool afterDash = false;
        foreach (var c in identifier)
        {
            builder.Append(c switch
            {
                _ when (c >= 'α' && c <= 'ω') => default,
                _ when afterDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default,
            });
            afterDash = c.Equals('-');
        }
        return builder.ToString();
    }
}
