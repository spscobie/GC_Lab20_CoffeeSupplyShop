console.log("Begin GSWELL!");

$(document).ready(function () {
    $('#regForm').bootstrapValidator({
        container: '#messages',
        feedbackIcons: {
            valid: 'glyphicon glyphicon-ok',
            invalid: 'glyphicon glyphicon-remove',
            validating: 'glyphicon glyphicon-refresh'
        },
        fields: {
            FirstName: {
                validators: {
                    notEmpty: {
                        message: 'First name is required and cannot be empty'
                    }
                }
            },
            LastName: {
                validators: {
                    notEmpty: {
                        message: 'Last name is required and cannot be empty'
                    }
                }
            },
            ShipToAddress: {
                validators: {
                    notEmpty: {
                        message: 'Address cannot be empty'
                    }
                }
            },
            ShipToZip: {
                validators: {
                    notEmpty: {
                        message: 'Zip Code cannot be empty'
                    }
                }
            },
            PhoneNum: {
                validators: {
                    notEmpty: {
                        message: 'Phone number cannot be empty'
                    }
                }
            },
            EmailAddress: {
                validators: {
                    notEmpty: {
                        message: 'The email address is required and cannot be empty'
                    },
                    emailAddress: {
                        message: 'The email address is not valid'
                    }
                }
            },
            Pw: {
                validators: {
                    notEmpty: {
                        message: 'A password is required and cannot be empty!'
                    },
                    stringLength: {
                        min: 8,
                        max: 20,
                        message: 'Password must have more than characters, but fewer than 20!'
                    }
                }
            },
            PwConfirm: {
                validators: {
                    notEmpty: {
                        message: 'A password is required and cannot be empty!'
                    },
                    stringLength: {
                        min: 8,
                        max: 20,
                        message: 'Password must have more than characters, but fewer than 20!'
                    },
                    identical: {
                        field: 'Pw',
                        message: 'Passwords do not match!'
                    }
                }
            }
        }
    });
});