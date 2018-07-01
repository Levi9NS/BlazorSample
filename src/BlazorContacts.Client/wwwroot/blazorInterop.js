Blazor.registerFunction('BlazorContacts.alert.info', function (text) {
    toastr.info(text);
});

Blazor.registerFunction('BlazorContacts.alert.warning', function (text) {
    toastr.warning(text);
});

Blazor.registerFunction('BlazorContacts.modal.show', function (id) {
    if (id && id.length) {
        if (id.charAt(0) != "#") {
            id = "#" + id;
        }
        $(id).modal('show');
    }
});

Blazor.registerFunction('BlazorContacts.modal.hide', function (id) {
    if (id && id.length) {
        if (id.charAt(0) != "#") {
            id = "#" + id;
        }
        $(id).modal('hide');
    }
});

Blazor.registerFunction('BlazorContacts.log', function (text) {
    console.log(text);
});