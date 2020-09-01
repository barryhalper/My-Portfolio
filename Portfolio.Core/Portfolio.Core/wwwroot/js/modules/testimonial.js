import { Utils } from "./utils.js"

export class Testimonial {
    constructor() {
        // this.bindNavigation();
        this.page = document.getElementById("testimonial");
        this.pullQuouteArray = Array.from(this.page.querySelectorAll(".pullquote"));
        console.log(this.pullQuouteArray)
        Utils.fadeIn(this.pullQuouteArray[0], 2500);
        //get data items from DOM
        
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
                this.links.forEach(a => a.classList.remove("active"));
                a.classList.add("active");
                //use JQUERY to utilise delegate
                $(".pullquote").fadeOut(1500).promise().done(function () {
                    $(`#testimonial-${a.getAttribute("data-id")}`).fadeIn(1500);
                    
                })
                //this.update(a)
            });
        });

    }

    
    
}