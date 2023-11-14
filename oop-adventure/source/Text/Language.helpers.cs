using System.Text;

namespace OOPAdventure;

public partial class Language
{
    private readonly StringBuilder m_stringBuilder = new();

    public virtual string JoinedWordList(string[] words, string conjunction)
    {
        m_stringBuilder.Clear();
        for (int i = 0; i < words.Length; i++)
        {
            if (i > 0)
            {
                m_stringBuilder.Append(words.Length > 2 ? Comma + Space : Space);
            }

            if (i == words.Length - 1 && words.Length > 1)
            {
                m_stringBuilder.Append(conjunction + Space);
            }

            m_stringBuilder.Append(words[i]);

        }
        return m_stringBuilder.ToString();
    }

    public virtual object ReturnLanguageObject(string languageInput)
    {
        Type classType = Type.GetType("OOPAdventure." + languageInput);
        if (classType != null)
        {
            var langObject = Activator.CreateInstance(classType);
            return langObject;
        }
        return null;
    }
}