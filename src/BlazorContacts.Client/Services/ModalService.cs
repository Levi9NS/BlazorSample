using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorContacts.Client.Services
{
    public class ModalService
    {
        public void Show(string id)
        {
            RegisteredFunction.Invoke<object>("BlazorContacts.modal.show", id);
        }

        public void Hide(string id)
        {
            RegisteredFunction.Invoke<object>("BlazorContacts.modal.hide", id);
        }
    }
}
