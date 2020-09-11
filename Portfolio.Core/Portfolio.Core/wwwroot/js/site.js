// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function IsIE() {
    if (navigator.userAgent.indexOf('MSIE') !== -1 || navigator.appVersion.indexOf('Trident/') > -1) {
    /* Microsoft Internet Explorer detected in. */
        return true;
    }
    
    else  // If another browser, return 0
    {
       //console.log(ua)
       return false
    }

    //return false;
}

//dont wait for page to load  run function to sniff browswe
if (IsIE()){
    window.location.href = "/UnsupportedBrowser";
}
