<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Produit.aspx.cs" Inherits="EvaEcommerce.Produit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div id="ProduitsAff" runat="server"></div>

 <div class="modal fade" tabindex="-1" role="dialog" id="myModal" >
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title">Mon Panier</h4>
      </div>
      <div class="modal-body">
          <div class="form-horizontal">
              <div class="form-group">
                  <p><label for="NomUtilisateur" id="Nom">Votre nom </label><input type="text" id="NomUtilisateur"/></p>
                  <p><label>Vous ajouté à votre panier la référence <span id="NomProduit"></span></label></p>
                  <p><label for="Nombre">Sélectionner le nombre </label><input type="number" id="number"  min="1" max="100" /></p>
              </div>
          </div>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary" onclick='LireForm()'>Ok</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal -->




    <script src="AppelFullDescriptions.js"></script>
</asp:Content>
