(
    function () {
        let btn = document.querySelector("#myBtn");
        let divContainer = document.querySelector("#container");
        let myTemt = document.querySelector("#myTemplate");

        btn.addEventListener("click", function () {
            let folderName = prompt("Enter folder name");
            let folder = myTemt.content.querySelector(".folder");
            let divCopy = document.importNode(folder, true);
            divCopy.innerHTML = folderName;
            divContainer.appendChild(divCopy);





        });
    }
)();