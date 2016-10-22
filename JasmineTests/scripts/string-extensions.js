String.prototype.capitalise = function() {
    var input = this;
    var capitalisedString = input.replace(input, input.charAt(0).toUpperCase() + input.substr(1).toLowerCase());
    return capitalisedString;
}

String.prototype.camelCaseToSpineCase = function() {
    var input = this;
   
    var newInput = input.replace(/\s/g, "-").replace(/([A-Z])/g, "-$1").toLowerCase();
    var inputNoRepeats = newInput.replace(/([-])\1*/g, "-"); // remove consecutive -
    return inputNoRepeats;
}

String.prototype.spineCaseToCamelCase = function() {
    var input = this;
    var output = "";

    var trimmedInput = input.trim();
    var firstLetter = trimmedInput.substring(0, 1).toLowerCase();
    var afterFirstLetter = trimmedInput.substring(1);

    var camelCased = afterFirstLetter.replace(/-([a-z])/g, function (g) { return g[1].toUpperCase(); }).replace(/ ([a-z])/g, function (g) { return g[1].toUpperCase(); });
    var camelNoExtraDashesOrWhite = camelCased.replace(/[-]/g, "").replace(/\s/g, "");
    
    output = firstLetter + camelNoExtraDashesOrWhite;
 
    return output;
}

String.prototype.format = function() {
    var input = this;
    return input;
}