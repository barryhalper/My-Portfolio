﻿
export class Utils {

    static fadeIn(elem, ms) {
        if (!elem)
            return;

        elem.style.opacity = 0;
        elem.style.filter = "alpha(opacity=0)";
        elem.style.display = "inline-block";
        elem.style.visibility = "visible";

        if (ms) {
            var opacity = 0;
            var timer = setInterval(function () {
                opacity += 50 / ms;
                if (opacity >= 1) {
                    clearInterval(timer);
                    opacity = 1;
                }
                elem.style.opacity = opacity;
                elem.style.filter = "alpha(opacity=" + opacity * 100 + ")";
            }, 50);
        }
        else {
            elem.style.opacity = 1;
            elem.style.filter = "alpha(opacity=1)";
        }
    }

    static fadeOut(elem, ms) {
        if (!elem)
            return;

        if (ms) {
            var opacity = 1;
            var timer = setInterval(function () {
                opacity -= 50 / ms;
                if (opacity <= 0) {
                    clearInterval(timer);
                    opacity = 0;
                    elem.style.display = "none";
                    elem.style.visibility = "hidden";
                }
                elem.style.opacity = opacity;
                elem.style.filter = "alpha(opacity=" + opacity * 100 + ")";
            }, 50);
        }
        else {
            elem.style.opacity = 0;
            elem.style.filter = "alpha(opacity=0)";
            elem.style.display = "none";
            elem.style.visibility = "hidden";
        }
    }

    static getHost() {
        let host = window.location.host;
        return `${window.location.protocol}//${host.replace(":80", "")}`;
    }

    static getSitePath() {
        const host = Utils.getHost();
        return window.location.href.replace(host, "");
    }
}