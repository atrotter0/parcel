function validateFields() {
    if (isValid("#inputName") && isValid("#inputWeight") && isValid("#inputHeight") && isValid("#inputLength") && isValid("#inputWidth")) {
        //submit form
    } else {
        alert("Stop trying to break things...");
        location.reload();
    }
}

function isValid(element) {
    if ($(element).val() != "") return true;
}

$(document).ready(function() {
    $("#submit-form").click(function() {
        validateFields();
    });
});
