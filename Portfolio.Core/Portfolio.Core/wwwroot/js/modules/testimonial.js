import { Utils } from "./utils.js"

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

