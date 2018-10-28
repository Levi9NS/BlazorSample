window.BlazorContacts = {};

window.BlazorContacts.log = function (obj) {
    console.log(obj);
};

window.BlazorContacts.modal = {};
window.BlazorContacts.modal.show = function (id) {
    if (id && id.length) {
        if (id.charAt(0) !== "#") {
            id = "#" + id;
        }
        $(id).modal('show');
    }
};
window.BlazorContacts.modal.hide = function (id) {
    if (id && id.length) {
        if (id.charAt(0) !== "#") {
            id = "#" + id;
        }
        $(id).modal('hide');
    }
};

window.BlazorContacts.alert = {};
window.BlazorContacts.alert.info = function (text) {
    toastr.info(text);
};
window.BlazorContacts.alert.warning = function (text) {
    toastr.warning(text);
};
