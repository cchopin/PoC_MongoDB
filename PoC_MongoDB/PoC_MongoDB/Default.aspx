<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PoC_MongoDB.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphbody" runat="server">
    <div class="container-contact100">
        <div class="wrap-contact100">
            <form class="contact100-form validate-form" runat="server">
                <span class="contact100-form-title">Inscription
                </span>

                <div class="wrap-input100 validate-input bg1" data-validate="Entrez votre nom">
                    <span class="label-input100">Nom *</span>
                    <input class="input100" type="text" name="name" placeholder="Entrez votre nom">
                </div>

                <div class="wrap-input100 validate-input bg1 rs1-wrap-input100" data-validate="Entrez votre email (e@a.x)">
                    <span class="label-input100">Email *</span>
                    <input class="input100" type="text" name="email" placeholder="Entrez votre email ">
                </div>

                <div class="wrap-input100 bg1 rs1-wrap-input100">
                    <span class="label-input100">Téléphone</span>
                    <input class="input100" type="text" name="phone" placeholder="Entrez votre numéro de téléphone">
                </div>

                <div class="wrap-input100 input100-select bg1">
                    <span class="label-input100">Objet à assurer *</span>
                    <div>

                        <asp:DropDownList ID="ddlcategorie" AutoPostBack="true" runat="server" class="js-select2" name="service" OnSelectedIndexChanged="ddlcategorie_SelectedIndexChanged">
                        </asp:DropDownList>

                     <div class="dropDownSelect2"></div>
                    </div>
                </div>

                <div class="wrap-input100 input100-select bg1">
                    <span class="label-input100">Valeur de l'objet :</span>
                    <div>


                        <asp:TextBox runat="server" ID="txtTest" Text="test"/>
                      
                    </div>
                </div>
                <div class="container-contact100-form-btn">
                    <button class="contact100-form-btn">
                        <span>Envoyer
                            <i class="fa fa-long-arrow-right m-l-7" aria-hidden="true"></i>
                        </span>
                    </button>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
