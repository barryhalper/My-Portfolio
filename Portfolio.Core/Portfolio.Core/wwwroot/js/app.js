
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
        return window.location.href.replace(host, "").replace("#", "");
    }

    //as modal-pop up uses JQuery, use notation
    static showModal(args) {
        $("#Modal").on('shown.bs.modal', function () {
        })


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
            $(".modal-content").addClass("modal-wide")
        }

        if ('showFooter' in args) {
            $(".modal-footer").style.display = "block";
        }

        //add listener to empty close modal when
        $("#Modal").on('hiden.bs.modal', function () {
            $(".modal-header h5").html("");
            $(".modal-body").html("");
        })


    }

}

class App {
    constructor() {
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


    setActiveMenuItem() {
        //get path minus host
        const path = Utils.getSitePath();
        //get array of  links in menu
        const menu = Array.from(document.querySelectorAll(".nav a"));
        //filter array based on current path

        const item = menu.find(i => i.getAttribute("href") == path);
        //active class to active item
        if (item) {
            item.classList.add("active");
        }


    }


    bindFooterAboutMe() {
        let anchor = document.getElementById("footer-show-more");
        anchor.addEventListener("click", (event) => {

            event.preventDefault();

            let i = anchor.querySelector("i");

            //check which state button is
            let aboutMe = document.getElementById("about-me");
            let span = anchor.querySelector("span");



            if (aboutMe.style.display === "inline-block") {
                Utils.fadeOut(aboutMe, 1500);
                aboutMe.style.display == "";
                i.setAttribute("class", "fad fa-info-circle");
                span.innerHTML = "more";

            }
            else {


                Utils.fadeIn(aboutMe, 1500);

                i.setAttribute("class", "fad fa-times-square");
                span.innerHTML = "";
                //document.querySelector("footer").setAttribute("style", "height:300px;bottom:0;position:fixed");
            }

            window.scrollTo({ left: 0, top: document.body.scrollHeight, behavior: "smooth" })


        })
    }


}

export class Testimonial {
    constructor() {
        // this.bindNavigation();
        this.page = document.getElementById("testimonial");
        this.pullQuouteArray = Array.from(this.page.querySelectorAll(".pullquote"));

        Utils.fadeIn(this.pullQuouteArray[0], 1000);
        //get data items from DOM

        //read all more links 
        this.links = document.querySelectorAll(".testimonial-more a");
        this.addListener();
        //set first element to be active
        Array.from(this.links)[0].classList.add("active");
    }




    addListener() {
        const _this = this;
        //bind listener to all tesimonial links
        this.links.forEach(a => {
            a.addEventListener('click', (event) => {
                event.preventDefault();
                this.links.forEach(a => a.classList.remove("active"));
                a.classList.add("active");
                //use JQUERY to utilise delegate
                $(".pullquote").fadeOut(500).promise().done(function () {
                    $(`#testimonial-${a.getAttribute("data-id")}`).fadeIn(500);

                })
                //this.update(a)
            });
        });

    }
}


export class Project {
    constructor() {
        this.bindCarouselToModal();
        this.bindVideoToModal();
       
    }

    bindVideoToModal() {//modal pop up listener
        document.getElementById("project-body").querySelectorAll("a.video").forEach(a => {
            a.addEventListener('click', (event) => {
                event.preventDefault();
                const src = event.target.getAttribute("data-src");
                const title = event.target.getAttribute("data-title");
                //as modal-pop up uses JQuery, use notation
                const html = `<video controls autoplay><source src="/video/${src}" type="video/mp4"/></video>`;
                Utils.showModal({ html: html });
                this.bindStopVideoOnModalClose();


            });

        });
    }

    bindCarouselToModal() {
        //modal pop up listener
        document.getElementById("project-body").querySelectorAll("a.gallery").forEach(a => {
            a.addEventListener('click', (event) => {
                event.preventDefault();
                const id = event.target.getAttribute("data-id");


                const title = event.target.getAttribute("data-title");
                // console.log(document.getElementById(`carousel-${id}`).parentNode[0]);
                //select all images in div
                document.getElementById(`carousel-${id}`).querySelectorAll(".carousel-inner img").forEach(img => {
                    //set img source from data attribute for lazy loading
                    img.setAttribute("src", `/image/projects${img.getAttribute("data-src")}`)
                });

                Utils.showModal({ title: "", html: "" });
                //bind parent node DOM Object to model body
                //clone node
                let node = document.getElementById(`carousel-${id}`).parentNode.cloneNode(true);
                //update id to be unqiue
                //set new node id to be diffent from the one cloned
                const newId = `carousel-${id}-modal`;
                node.setAttribute("id", newId);
                document.querySelector("#Modal .modal-body").appendChild(node);
                $(newId).carousel();
                //rebind buttons
                $(newId).bind('slid', function (e) {

                });
                //get DOM object
                //document.getElementById(newId).closest(".modal").classList.add("transparent-modal")

                //make Modal transparent

            });

        });
    }

    //
    bindStopVideoOnModalClose() {
        //Modal is closed
        $("#Modal .close").on("click", function (e) {
            const video = document.querySelector("video");
            //console.log(video);
            //stop video playing
            video.pause();
            video.currentTime = 0;
        });
    }

}

export class Blog{
    constructor() {
        this.makeImagesResponsive();
    }

    makeImagesResponsive() {
        var images = document.querySelectorAll("article img");

        images.forEach((img) => {
            img.classList.add("img-fluid");
        });

    }
}

document.addEventListener("DOMContentLoaded", function () {
    let app = new App();
    //console.log(factory.utils);   
})
