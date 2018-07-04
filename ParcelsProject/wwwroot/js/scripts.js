const MAX_NAME_LENGTH = 20;
const MAX_NUMBER_LENGTH = 5;

function validatePackageFields() {
    return (isValid("#inputWeight") && isValid("#inputHeight") && isValid("#inputLength") && isValid("#inputWidth"));
}

function validateName() {
    return (isValidName("#inputName"));
}

function isValid(element) {
    return ($(element).val() != " " && $(element).val() != "" && $(element).val().length < MAX_NUMBER_LENGTH);
}

function isValidName(element) {
    return ($(element).val() != "" && $(element).val().length < MAX_NAME_LENGTH && !$(element).val().includes(" "));
}

function enableBtn(element) {
    $(element).prop("disabled", false);
}

function disableBtn(element) {
    $(element).attr("disabled", "true");
}

$(document).ready(function() {
    disableBtn("#submit-form");

    $("input[type='text'], input[type='number']").keyup(function() {
        if (validatePackageFields() && validateName()) {
            enableBtn("#submit-form");
        } else {
            disableBtn("#submit-form");
        }
    });
});
