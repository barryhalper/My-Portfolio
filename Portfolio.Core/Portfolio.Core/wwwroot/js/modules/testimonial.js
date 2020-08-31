import { Utils } from "./utils.js"

export class Testimonial {
    constructor() {
        // this.bindNavigation();
        this.page = document.getElementById("testimonial");
        this.pullQuoute = this.page.querySelector(".pullquote");
        Utils.fadeIn(this.pullQuoute, 2500);
        //get data items from DOM
        //this.items = Array.from(document.getElementById("testimonial-more-content").querySelectorAll("div"));
        //read all more links 
        this.links = this.page.querySelectorAll(".more a");
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
                this.removeActive();
                //use JQUERY to utilise delegate
                $(".pullquote").fadeOut(1500).promise().done(function () {
                    _this.update(a);
                    
                })
                //this.update(a)
            });
        });

    }

    removeActive() {
        this.links.forEach(a => a.classList.remove("active"));
    }

     update(element) {
        //console.log(element);
         //make this element active
        element.classList.add("active");
        const id = element.getAttribute("data-id");
        
        //find correspondiong element in DOM
        const item = document.getElementById(`testimonial-${id}`);
        //set values from hidden element into jumbotron
      
        //fade out element
       
        this.pullQuoute.querySelector(".recommendation span").innerHTML = item.getAttribute("data-recommmendation");

        this.pullQuoute.querySelector("img").setAttribute("src", `image/testimonials/${item.getAttribute("data-img")}` );
        this.pullQuoute.querySelector(".author-name").innerHTML = item.getAttribute("data-author");
        this.pullQuoute.querySelector(".position").innerHTML = item.getAttribute("data-jobtitle");
         $(".pullquote").fadeIn(1500)
        //Utils.fadeIn(this.pullQuoute, 2500);
        //console.table(this.items)
    }
}