

//Charger les categories principale dans le menu

//window.onload = function RequetePrincipales()
//{
//    xhttp = new XMLHttpRequest;
//    xhttp.onreadystatechange = function () {
//        if (xhttp.readyState == 4 && xhttp.status == 200) {
//            LireCategoryPrincipale(xhttp.responseText);
//        }
//    };

//    xhttp.open("POST", "RemplirDOMelements", true);
//    xhttp.setRequestHeader("Content-Type", "application/JSON");
//    xhttp.send();

//}

////Mettre les categories principales dans les li

//function LireCategoryPrincipale(donnees)
//{
//    var cat = new Array();
//    cat = JSON.parse(donnees);
//    var zoneText = document.getElementById("catPrin");
//    zoneText.innerHTML = "";

//    for (var i = 0; i < cat.length; i++) {

//        var li = document.createElement("li");
//        li.textContent = cat[i];
//        zoneText.appendChild(li);

//    }



//}