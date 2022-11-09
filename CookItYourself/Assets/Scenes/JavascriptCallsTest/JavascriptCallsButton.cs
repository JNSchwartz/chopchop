using UnityEngine;

public class JavascriptCallsButton : MonoBehaviour
{
    private void Start()
    {
        JavascriptCalls.Test();
    }

    public void Button1()
    {
        JavascriptCalls.Hello();
    }
    public void Button2()
    {
        JavascriptCalls.HelloString("Button2 Pressed!");
    }
    public void Button3()
    {
        JavascriptCalls.HelloConsole();
    }
    public void Button4()
    {
        JavascriptCalls.ConsoleString("Button4 Pressed!");
    }
    public void Button5()
    {
        JavascriptCalls.LogonFromUnity();
    }
    public void Button6()
    {
        JavascriptCalls.LogonFromUnityTwo();
    }
}