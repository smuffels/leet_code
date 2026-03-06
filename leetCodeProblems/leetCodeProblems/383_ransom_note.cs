namespace _1480_running_sum_of_1d_array_2;


// Solution with Dictionary
public class SolutionRansomNoteDict {
    
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> availableLetters = new Dictionary<char, int>();
        bool match = false;


        foreach (var letter in magazine)
        {
            if (availableLetters.ContainsKey(letter))
            {
                int currentValue = availableLetters[letter];
                currentValue += 1;
                availableLetters[letter] = currentValue;
            }
            else
            {
                availableLetters.Add(letter,1);
            }
        }

        foreach (var letter in ransomNote)
        {
            if (availableLetters.ContainsKey(letter) && availableLetters[letter] > 0) 
            {
                int currentVallue = availableLetters[letter];
                currentVallue -= 1;
                availableLetters[letter] = currentVallue;
                match = true;
            }
            else
            {
                match = false;
                break;
            }
        }
        return match;
    }
    
}

// Solution with a string

public class SolutionRansomNoteString
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        foreach (char letter in ransomNote)
        {

            int indexMatch = magazine.IndexOf(letter);

            if (indexMatch == -1)
            {
                return false;
            }
            magazine = magazine.Substring(0, indexMatch) + magazine.Substring(indexMatch + 1);
            
        }
        return true;
    }
}