namespace OTCLoader
{
    internal static class Extensions
    {
        internal static string Set(this string text, (string Variable, string Value)[] values)
        {
            var content = Properties.Resources.Content;
            foreach (var (variable, value) in values)
                content = content.Replace($"${variable}$", value);
            content = content.Replace("\\", "\\\\")
                             .Replace("\r", string.Empty)
                             .Replace("\n", "\\n")
                             .Replace("\"", "\\\"");
            return text.Replace("\"$\"", $"\"{content}\"");
        }
    }
}
