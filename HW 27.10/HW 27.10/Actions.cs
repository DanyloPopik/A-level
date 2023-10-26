using HW_27._10;

public class Actions
{
    private static readonly string[] methodNames = { "Method1", "Method2", "Method3" };
    private Random random = new Random();
    public Result StartMethod()
    {
        string methodName = "StartMethod";
        Logger.Instance.Log("Info", $"Start method: {methodName}");
        return new Result { Status = true };
    }
    public Result SkipLogicInMethod()
    {
        string methodName = "SkipLogicInMethod";
        Logger.Instance.Log("Warning", $"Skipped logic in method: {methodName}");
        return new Result { Status = true };
    }
    public Result BreakLogic()
    {
        Logger.Instance.Log("Error", "Action failed by a reason: I broke a logic");
        return new Result { Status = false, Error = "I broke a logic" };
    }
    public void PerformRandomAction()
    {
        int randomIndex = random.Next(methodNames.Length);
        string methodName = methodNames[randomIndex];
        switch (randomIndex)
        {
            case 0: StartMethod(); break;
            case 1: SkipLogicInMethod(); break;
            case 2: BreakLogic(); break; 
        }
    }
}   



