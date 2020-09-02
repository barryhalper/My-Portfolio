import { Utils } from "./utils.js"

export class Project {
    constructor() {

        console.log("dsads");
        this.bindVideoToModal();
    }


    bindVideoToModal() {//modal pop up listener
        document.getElementById("project-body").querySelectorAll("a.video").forEach(a => {
            a.addEventListener('click', (event) => {
                event.preventDefault();
               
                Utils.showModal({ title:"MYB Public Spend", html:"HE" });
            });

        });
     }

}