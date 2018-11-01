window.BlazorContacts = {};

window.BlazorContacts.alert = {};

window.BlazorContacts.alert.info = function (text) {
    toastr.info(text);
};

window.BlazorContacts.alert.warning = function (text) {
    toastr.warning(text);
};
