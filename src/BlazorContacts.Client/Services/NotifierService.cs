using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorContacts.Client.Services
{
    public static class NotifierService
    {
        public static void Info(string text)
        {
            RegisteredFunction.Invoke<object>("BlazorContacts.alert.info", text);
        }

        public static void Warning(string text)
        {
            RegisteredFunction.Invoke<object>("BlazorContacts.alert.warning", text);
        }

        public static void Log(string text)
        {
            RegisteredFunction.Invoke<object>("BlazorContacts.log", text);
        }
    }
}
