function validateFields() {
    if (isValid("#inputName") && isValid("#inputWeight") && isValid("#inputHeight") && isValid("#inputLength") && isValid("#inputWidth")) {
        enableBtn("#submit-form");
    } else {
        disableBtn("#submit-form");
    }
}

function isValid(element) {
    if ($(element).val() != " " && $(element).val() != "") return true;
}

function enableBtn(element) {
    $(element).prop("disabled", false);
}

function disableBtn(element) {
    $(element).attr("disabled", "true");
}

$(document).ready(function() {
    disableBtn("#submit-form");

    $("input:text").keyup(function() {
        validateFields();
    });

    $("#submit-form").click(function() {
        validateFields();
    });
});
