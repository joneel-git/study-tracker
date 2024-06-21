// Configure Globalize with the desired culture
Globalize.culture('en-US');

// Extend jQuery Validation for Globalize support
$.validator.methods.number = function (value, element) {
    return this.optional(element) || !isNaN(Globalize.parseFloat(value));
};

// Optional: Extend jQuery Validation for date validation using Globalize
$.validator.methods.date = function (value, element) {
    return this.optional(element) || Globalize.parseDate(value);
};
