Blazor.registerFunction('BlazorContacts.alert.info', function (text) {
    toastr.info(text);
});

Blazor.registerFunction('BlazorContacts.alert.warning', function (text) {
    toastr.warning(text);
});

