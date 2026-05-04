namespace leetCode;

// Solution with Dictionary
public class SolutionRansomNoteDict
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var availableLetters = new Dictionary<char, int>();
        var match = false;


        foreach (var letter in magazine)
            if (availableLetters.ContainsKey(letter))
            {
                var currentValue = availableLetters[letter];
                currentValue += 1;
                availableLetters[letter] = currentValue;
            }
            else
            {
                availableLetters.Add(letter, 1);
            }

        foreach (var letter in ransomNote)
            if (availableLetters.ContainsKey(letter) && availableLetters[letter] > 0)
            {
                var currentVallue = availableLetters[letter];
                currentVallue -= 1;
                availableLetters[letter] = currentVallue;
                match = true;
            }
            else
            {
                match = false;
                break;
            }

        return match;
    }
}

// Solution with a string

public class SolutionRansomNoteString
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        foreach (var letter in ransomNote)
        {
            var indexMatch = magazine.IndexOf(letter);

            if (indexMatch == -1) return false;
            magazine = magazine.Substring(0, indexMatch) + magazine.Substring(indexMatch + 1);
        }

        return true;
    }
}