<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PanierTemp2.aspx.cs" Inherits="EvaEcommerce.PanierTemp2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="modal fade" tabindex="-1" role="dialog" id="myModal">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title">Mon Panier</h4>
      </div>
      <div class="modal-body">
          <form class="form-horizontal">
              <div class="form-group">
                  <p><label for="NomUtilisateur">Votre nom : </label><input type="text" id="NomUtilisateur" /></p>
                  <p><label>Vous ajouté à votre panier : <span id="cookieID" runat="server"></span></label></p>
                  <p><label for="Nombre">Sélectionner le nombre : </label><input type="number" id="number"  min="1" max="100" /></p>
              </div>
          </form>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal -->

<button type="button" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#myModal">
  Launch demo modal
</button>

<script>$('#myModal').on('shown.bs.modal', function () {
    $('#myInput').focus()
})</script>
</asp:Content>
