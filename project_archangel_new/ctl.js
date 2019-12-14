document.getElementById("mySidebar").style.border = "0px";



function openNav() {
    document.getElementById("mySidebar").style.width = "250px";
    document.getElementById("main").style.marginLeft = "250px";
    document.getElementById("obtn").style.display = "none"
    document.getElementById("mySidebar").style.border = "1px solid #2962FF";
}

function closeNav() {
    document.getElementById("mySidebar").style.width = "0";
    document.getElementById("main").style.marginLeft= "0";
    document.getElementById("obtn").style.display = "block"
    document.getElementById("mySidebar").style.border = "0px";
}

