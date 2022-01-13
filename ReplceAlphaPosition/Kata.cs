public static class Kata
{
  public static string AlphabetPosition(string text) => string.Join(" ", text.ToUpper().Where(c => char.IsLetter(c)).Select(c => c-64));
  
}