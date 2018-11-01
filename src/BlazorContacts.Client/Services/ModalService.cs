using Microsoft.JSInterop;

namespace BlazorContacts.Client.Services
{
    public class ModalService
    {
        public void Show(string id)
        {
            JSRuntime.Current.InvokeAsync<object>("BlazorContacts.modal.show", id);
        }

        public void Hide(string id)
        {
            JSRuntime.Current.InvokeAsync<object>("BlazorContacts.modal.hide", id);
        }
    }
}
