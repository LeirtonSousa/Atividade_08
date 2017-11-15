<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Atividade_08._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <h2>WEB API</h2>
            <p>
                <asp:GridView ID="grdInstituicao" runat="server" AutoGenerateColumns="false">
                    <Columns>

                        <asp:BoundField DataField="cepInstituicao" HeaderText="cepInstituicao" />
                        <asp:BoundField DataField="cidadeInstituicao" HeaderText="cidadeInstituicao" />
                        <asp:BoundField DataField="enderecoInstituicao" HeaderText="enderecoInstituicao" />
                        <asp:BoundField DataField="estadoInstituicao" HeaderText="estadoInstituicao" />
                        <asp:BoundField DataField="idInstituicao" HeaderText="idInstituicao" />
                        <asp:BoundField DataField="idStatusInstituicao" HeaderText="idStatusInstituicao" />
                        <asp:BoundField DataField="nomeInstituicao" HeaderText="nomeInstituicao" />
                        <asp:BoundField DataField="telefoneInstituicao" HeaderText="telefoneInstituicao" />

                    </Columns>
                </asp:GridView>
            </p>
        </div>
    </div>

</asp:Content>
