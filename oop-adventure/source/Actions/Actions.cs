namespace OOPAdventure;

public sealed class Actions
{
    private static Actions s_instance;
    private readonly Dictionary<string, Action> m_registeredActions = new();

    public static Actions Instance
    {
        get
        {
            if (s_instance == null)
            {
                s_instance = new Actions();
            }

            return s_instance;
        }
    }

    private Actions()
    {

    }

    public void Register(Action action)
    {
        var name = action.Name.ToLower();

        if (m_registeredActions.ContainsKey(name))
        {
            m_registeredActions[name] = action;
        }
        else
        {
            m_registeredActions.Add(name, action);
        }
    }

    public void Execute(string[] args)
    {
        var actionName = args[0];
        if (m_registeredActions.ContainsKey(actionName))
        {
            m_registeredActions[actionName].Execute(args);
        }
        else
        {
            Console.WriteLine(Text.Language.ActionError);
        }
    }
}
