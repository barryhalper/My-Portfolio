import { Utils } from "./utils.js"
import { Testimonial } from "./testimonial.js"
import { Project } from "./project.js"

class App {
    constructor() {
       // this.bindNavigation();
        this.bindFooterAboutMe();
        this.setActiveMenuItem();

        if (document.getElementById("testimonial")) {
            const testimonial = new Testimonial(); 
        }

        if (document.getElementById("project")) {
            const project = new Project();
        }

       

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

document.addEventListener("DOMContentLoaded", function () {
    var app = new App();
    //console.log(factory.utils);   
})

