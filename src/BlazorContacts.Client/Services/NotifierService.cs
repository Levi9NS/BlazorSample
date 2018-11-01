using Microsoft.JSInterop;

namespace BlazorContacts.Client.Services
{
    public static class NotifierService
    {
        public static void Info(string text)
        {
            JSRuntime.Current.InvokeAsync<object>("BlazorContacts.alert.info", text);
        }

        public static void Warning(string text)
        {
            JSRuntime.Current.InvokeAsync<object>("BlazorContacts.alert.warning", text);
        }
    }
}
