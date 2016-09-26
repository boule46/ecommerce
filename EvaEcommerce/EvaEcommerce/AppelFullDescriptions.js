
function RequeteAjax(id)
{
    xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        lireDonnees(xhttp.responseText);
    };
    xhttp.open("POST", "FullDescription1.aspx", true);
    xhttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    xhttp.send("id=" + id);
}

function lireDonnees(donnees)
{
    var nom = donnees;

    document.getElementById("fullDescriptionProduit").innerHTML = nom;


}

function RequeteAjaxPanier(id)
{
    xhttpanier = new XMLHttpRequest();
    xhttpanier.onreadystatechange = function () {
        if (xhttpanier.readyState == 4 && (xhttpanier.status == 200)) {
            lirePanier(xhttpanier.responseText);
        }
    };
    xhttpanier.open("GET", "PanierTemp2.aspx?idPN=" + encodeURIComponent(id), true);
    xhttpanier.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    xhttpanier.send(null);
}

function lirePanier(donnees)
{
    

    document.getElementById("NomProduit").innerHTML = donnees;

    $('#myModal').modal();



}

function LireForm()
{
    var nomUtilis = document.getElementById("NomUtilisateur").value;
    var IdProduit = document.getElementById("NomProduit").firstChild.data;
    var nombre = document.getElementById("number").value;

    nhttp = new XMLHttpRequest();
    nhttp.open("GET", "EcrireCookkie.aspx?NomUtilisateur=" + encodeURIComponent(nomUtilis) + "&NomProduit=" + encodeURIComponent(IdProduit) + "&number=" + encodeURIComponent(nombre));
    nhttp.send(null);

    $('#myModal').modal('hide')
}
