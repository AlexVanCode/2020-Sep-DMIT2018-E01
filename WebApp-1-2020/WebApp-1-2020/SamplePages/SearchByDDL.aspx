<%@ Page Title="Filter Search!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchByDDL.aspx.cs" Inherits="WebApp_1_2020.SamplePages.SearchByDDL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Search Albums By Artist</h1>
    <div class="row">
        <asp:Label ID="Label1" runat="server" 
            Text="Select An artist"></asp:Label> &nbsp; &nbsp; 

        <asp:DropDownList ID="ArtistList" runat="server"></asp:DropDownList> &nbsp; &nbsp; 
        <asp:LinkButton ID="SearchAlbums" runat="server" OnClick="SearchAlbums_Click">Search For Albums!</asp:LinkButton>
    </div>
    <br /> <br />

        <div class="row">
            <asp:Label ID="MessageLabel" runat="server"></asp:Label>
     </div>
    <br/><br />
    <asp:GridView ID="AlbumArtistList" runat="server" AutoGenerateColumns="False"
        CssClass="table table-striped"
        GridLines="Horizontal" BorderStyle="Dotted" 
        OnSelectedIndexChanged="AlbumArtistList_SelectedIndexChanged">

        <Columns>
            <asp:CommandField SelectText="View" ShowSelectButton="True"></asp:CommandField>
            <asp:TemplateField Visible="False">
                <ItemTemplate>
                    <asp:Label ID="AlbumId" runat="server" 
                        Text='<%# Eval("AlbumId") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Right"></ItemStyle>              
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Title">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" 
                        Text='<%# Eval("Title") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Left"></ItemStyle>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Artist">
                <ItemTemplate>
                 
                    <asp:DropDownList ID="ArtistListGV" runat="server" 
                        DataSourceID="ArtistListGVODS" 
                        DataTextField="DisplayText" 
                        DataValueField="ValueId"
                        selectedvalue='<%# Eval("ArtistId") %>'
                        Enabled ="false">

                    </asp:DropDownList>


                </ItemTemplate>
               
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Year">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" 
                        Text='<%# Eval("ReleaseYear") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center"></ItemStyle>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Label">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" 
                        Text='<%# Eval("ReleaseLabel") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Left"></ItemStyle>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ArtistListGVODS" runat="server"
        OldValuesParameterFormatString="original_{0}"
        Selectmethod="Artists_List"
        TypeName="ChinookSystem.BLL.ArtistController">



    </asp:ObjectDataSource>

</asp:Content>
