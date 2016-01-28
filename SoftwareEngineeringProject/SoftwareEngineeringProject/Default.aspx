<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SoftwareEngineeringProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Software Enginerring Project </title>
    <link type="text/css" href="Style/Default.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> UCO Campus Guidence System </h1>
        </div>
        <div>
            <!-- Map goes here -->
            <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
            <div style="overflow:hidden;height:800px;width:900px; margin:0 auto;">
                <div id="gmap_canvas" style="height:800px;width:900px;"></div>
                <style>#gmap_canvas img{max-width:none!important;background:none!important}</style>
                <a class="google-map-code" href="http://premium-wordpress-themes.org" id="get-map-data">UCO</a>
            </div>
            <script type="text/javascript"> function init_map(){var myOptions = {zoom:16,center:new google.maps.LatLng(35.6584493,-97.47362670000001),mapTypeId: google.maps.MapTypeId.ROADMAP};map = new google.maps.Map(document.getElementById("gmap_canvas"), myOptions);marker = new google.maps.Marker({map: map,position: new google.maps.LatLng(35.6584493, -97.47362670000001)});infowindow = new google.maps.InfoWindow({content:"<b>UCO</b><br/>100 N University Dr<br/>73034 Edmond" });google.maps.event.addListener(marker, "click", function(){infowindow.open(map,marker);});infowindow.open(map,marker);}google.maps.event.addDomListener(window, 'load', init_map);</script>
        </div>
        <div>
            Enter the details of where you want to go on campus.
            <br />
            Starting Location:
            <asp:DropDownList ID="DropDownList_Starting_Location" runat="server">
                <asp:ListItem> TEST ONE </asp:ListItem>
            </asp:DropDownList>
            Ending Location:
            <asp:DropDownList ID="DropDownList_Ending_Location" runat="server">
                <asp:ListItem> TEST TWO</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="Button_Get_Directions" Text="Get Directions!" PostBackUrl="~/Default.aspx" runat="server" />
        <br />
        Then press the above button, and the directions will populate below.
        <div>
            <asp:TextBox ID="TextBox_Directions" runat="server" TextMode="MultiLine" ReadOnly="True" Placeholder="Directions here..."></asp:TextBox>
        </div>
    </form>
</body>
</html>
