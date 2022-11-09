using System.Runtime.InteropServices;

public class JavascriptCalls
{
    [DllImport("__Internal")]
    public static extern void Hello();

    [DllImport("__Internal")]
    public static extern void HelloString(string str);

    [DllImport("__Internal")]
    public static extern void HelloConsole();

    [DllImport("__Internal")]
    public static extern void ConsoleString(string str);

    [DllImport("__Internal")]
    public static extern void Test();

    [DllImport("__Internal")]
    public static extern void LogonFromUnity();

    [DllImport("__Internal")]
    public static extern void LogonFromUnityTwo();
}