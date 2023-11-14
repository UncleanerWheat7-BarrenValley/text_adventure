namespace OOPAdventure;

using System;
using System.Collections.Generic;

public static class Text
{
    private static Language s_language;

    private static Dictionary<Languages, Language> s_languageDictionary = new()
    {
        { Languages.English, new English() },
        { Languages.French, new French() },
        { Languages.Spanish, new Spanish() }
    };

    public enum Languages
    {
        English = 1,
        French = 2,
        Spanish = 3
    }

    public static Language Language
    {
        get
        {
            if (s_language == null)
            {
                throw new Exception("No Language was loaded");
            }

            return s_language;
        }
    }

    public static void LanguageSelect()
    {
        string languageInput;
        Languages selectedLanguage = Languages.English;
        bool inputAccepted = false;

        while (!inputAccepted)
        {
            foreach (var lang in Enum.GetValues(typeof(Languages)))
            {
                Console.WriteLine((int)lang + " = " + lang + "\n");
            }

            languageInput = Console.ReadLine();

            if (int.TryParse(languageInput, out int languageNumber) &&
                languageNumber >= 0 &&
                languageNumber <= s_languageDictionary.Count)
            {
                inputAccepted = true;
                selectedLanguage = (Languages)languageNumber;
            }
        }
        LoadLanguage(selectedLanguage);
    }
    
    public static void LoadLanguage(Languages languageInput)
    {
        Console.WriteLine(languageInput);
        s_language = s_languageDictionary[languageInput];
    }
}