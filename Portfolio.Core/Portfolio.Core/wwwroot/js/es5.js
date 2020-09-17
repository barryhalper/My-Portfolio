"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.Blog = exports.Project = exports.Testimonial = exports.Utils = void 0;

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

var Utils = /*#__PURE__*/function () {
  function Utils() {
    _classCallCheck(this, Utils);
  }

  _createClass(Utils, null, [{
    key: "fadeIn",
    value: function fadeIn(elem, ms) {
      if (!elem) return;
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
      } else {
        elem.style.opacity = 1;
        elem.style.filter = "alpha(opacity=1)";
      }
    }
  }, {
    key: "fadeOut",
    value: function fadeOut(elem, ms) {
      if (!elem) return;

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
      } else {
        elem.style.opacity = 0;
        elem.style.filter = "alpha(opacity=0)";
        elem.style.display = "none";
        elem.style.visibility = "hidden";
      }
    }
  }, {
    key: "getHost",
    value: function getHost() {
      var host = window.location.host;
      return "".concat(window.location.protocol, "//").concat(host.replace(":80", ""));
    }
  }, {
    key: "getSitePath",
    value: function getSitePath() {
      var host = Utils.getHost();
      return window.location.href.replace(host, "").replace("#", "");
    } //as modal-pop up uses JQuery, use notation

  }, {
    key: "showModal",
    value: function showModal(args) {
      $("#Modal").on('shown.bs.modal', function () {});
      $(function () {
        $("#Modal").modal("show");
      });

      if ('title' in args) {
        $(".modal-header h5").html(args.title);
      }

      if ('html' in args) {
        $(".modal-body").html(args.html);
      }

      if ('wide' in args) {
        $(".modal-content").addClass("modal-wide");
      }

      if ('showFooter' in args) {
        $(".modal-footer").style.display = "block";
      } //add listener to empty close modal when


      $("#Modal").on('hiden.bs.modal', function () {
        $(".modal-header h5").html("");
        $(".modal-body").html("");
      });
    }
  }]);

  return Utils;
}();

exports.Utils = Utils;

var App = /*#__PURE__*/function () {
  function App() {
    _classCallCheck(this, App);

    // this.bindNavigation();
    if (document.getElementById("testimonial")) {
      this.testimonial = new Testimonial();
    }

    if (document.getElementById("project")) {
      this.project = new Project();
    }

    if (document.getElementById("blog")) {
      this.blog = new Blog();
    }

    this.bindFooterAboutMe();
    this.setActiveMenuItem();
  }

  _createClass(App, [{
    key: "setActiveMenuItem",
    value: function setActiveMenuItem() {
      //get path minus host
      var path = Utils.getSitePath(); //get array of  links in menu

      var menu = Array.from(document.querySelectorAll(".nav a")); //filter array based on current path

      var item = menu.find(function (i) {
        return i.getAttribute("href") == path;
      }); //active class to active item

      if (item) {
        item.classList.add("active");
      }
    }
  }, {
    key: "bindFooterAboutMe",
    value: function bindFooterAboutMe() {
      var anchor = document.getElementById("footer-show-more");
      anchor.addEventListener("click", function (event) {
        event.preventDefault();
        var i = anchor.querySelector("i"); //check which state button is

        var aboutMe = document.getElementById("about-me");
        var span = anchor.querySelector("span");

        if (aboutMe.style.display === "inline-block") {
          Utils.fadeOut(aboutMe, 1500);
          aboutMe.style.display == "";
          i.setAttribute("class", "fad fa-info-circle");
          span.innerHTML = "more";
        } else {
          Utils.fadeIn(aboutMe, 1500);
          i.setAttribute("class", "fad fa-times-square");
          span.innerHTML = ""; //document.querySelector("footer").setAttribute("style", "height:300px;bottom:0;position:fixed");
        }

        window.scrollTo({
          left: 0,
          top: document.body.scrollHeight,
          behavior: "smooth"
        });
      });
    }
  }]);

  return App;
}();

var Testimonial = /*#__PURE__*/function () {
  function Testimonial() {
    _classCallCheck(this, Testimonial);

    // this.bindNavigation();
    this.page = document.getElementById("testimonial");
    this.pullQuouteArray = Array.from(this.page.querySelectorAll(".pullquote"));
    Utils.fadeIn(this.pullQuouteArray[0], 1000); //get data items from DOM
    //read all more links 

    this.links = document.querySelectorAll(".testimonial-more a");
    this.addListener(); //set first element to be active

    Array.from(this.links)[0].classList.add("active");
  }

  _createClass(Testimonial, [{
    key: "addListener",
    value: function addListener() {
      var _this2 = this;

      var _this = this; //bind listener to all tesimonial links


      this.links.forEach(function (a) {
        a.addEventListener('click', function (event) {
          event.preventDefault();

          _this2.links.forEach(function (a) {
            return a.classList.remove("active");
          });

          a.classList.add("active"); //use JQUERY to utilise delegate

          $(".pullquote").fadeOut(500).promise().done(function () {
            $("#testimonial-".concat(a.getAttribute("data-id"))).fadeIn(500);
          }); //this.update(a)
        });
      });
    }
  }]);

  return Testimonial;
}();

exports.Testimonial = Testimonial;

var Project = /*#__PURE__*/function () {
  function Project() {
    _classCallCheck(this, Project);

    this.bindCarouselToModal();
    this.bindVideoToModal();
  }

  _createClass(Project, [{
    key: "bindVideoToModal",
    value: function bindVideoToModal() {
      var _this3 = this;

      //modal pop up listener
      document.getElementById("project-body").querySelectorAll("a.video").forEach(function (a) {
        a.addEventListener('click', function (event) {
          event.preventDefault();
          var src = event.target.getAttribute("data-src");
          var title = event.target.getAttribute("data-title"); //as modal-pop up uses JQuery, use notation

          var html = "<video controls autoplay><source src=\"/video/".concat(src, "\" type=\"video/mp4\"/></video>");
          Utils.showModal({
            html: html
          });

          _this3.bindStopVideoOnModalClose();
        });
      });
    }
  }, {
    key: "bindCarouselToModal",
    value: function bindCarouselToModal() {
      //modal pop up listener
      document.getElementById("project-body").querySelectorAll("a.gallery").forEach(function (a) {
        a.addEventListener('click', function (event) {
          event.preventDefault();
          var id = event.target.getAttribute("data-id");
          var title = event.target.getAttribute("data-title"); // console.log(document.getElementById(`carousel-${id}`).parentNode[0]);
          //select all images in div

          document.getElementById("carousel-".concat(id)).querySelectorAll(".carousel-inner img").forEach(function (img) {
            //set img source from data attribute for lazy loading
            img.setAttribute("src", "/image/projects".concat(img.getAttribute("data-src")));
          });
          Utils.showModal({
            title: "",
            html: ""
          }); //bind parent node DOM Object to model body
          //clone node

          var node = document.getElementById("carousel-".concat(id)).parentNode.cloneNode(true); //update id to be unqiue
          //set new node id to be diffent from the one cloned

          var newId = "carousel-".concat(id, "-modal");
          node.setAttribute("id", newId);
          document.querySelector("#Modal .modal-body").appendChild(node);
          $(newId).carousel(); //rebind buttons

          $(newId).bind('slid', function (e) {}); //get DOM object
          //document.getElementById(newId).closest(".modal").classList.add("transparent-modal")
          //make Modal transparent
        });
      });
    } //

  }, {
    key: "bindStopVideoOnModalClose",
    value: function bindStopVideoOnModalClose() {
      //Modal is closed
      $("#Modal .close").on("click", function (e) {
        var video = document.querySelector("video"); //console.log(video);
        //stop video playing

        video.pause();
        video.currentTime = 0;
      });
    }
  }]);

  return Project;
}();

exports.Project = Project;

var Blog = /*#__PURE__*/function () {
  function Blog() {
    _classCallCheck(this, Blog);

    this.makeImagesResponsive();
  }

  _createClass(Blog, [{
    key: "makeImagesResponsive",
    value: function makeImagesResponsive() {
      var images = document.querySelectorAll("article img");
      images.forEach(function (img) {
        img.classList.add("img-fluid");
      });
    }
  }]);

  return Blog;
}();

exports.Blog = Blog;
document.addEventListener("DOMContentLoaded", function () {
  var app = new App(); //console.log(factory.utils);   
});
