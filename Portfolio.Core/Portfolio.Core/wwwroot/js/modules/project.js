import { Utils } from "./utils.js"

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
                Utils.showModal({ html:html });
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

                Utils.showModal({ title: "", html:"" });
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