static int CountVowels(string word) {
    int count = 0;

    for (int i = 0; i < word.Length; i++) {
        char c = word[i];
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') count++;
    }

    return count;
}

// tests
Console.WriteLine(CountVowels("Celebration"));
Console.WriteLine(CountVowels("Palm"));
Console.WriteLine(CountVowels("Prediction"));