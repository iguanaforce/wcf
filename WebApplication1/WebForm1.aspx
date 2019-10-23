<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"> <head runat="server"> <title></title> </head> <body> <form id="form1" runat="server"> <div> <h2 > <strong>Customer  Form</strong></h2> </div>  
Estar_Appid  <asp:TextBox ID="txtESTAR_APPID" runat="server"></asp:TextBox> 
<br />  
<br />
ID_Task  <asp:TextBox ID="txtTASK_ID" runat="server"></asp:TextBox> 
<br />
<br />
Nama Customer  <asp:TextBox ID="txtCUSTOMER_NAME" runat="server"></asp:TextBox> 
<br />  
<br />
Field Note  <asp:TextBox ID="txtFIELD_NOTE" runat="server"></asp:TextBox> 
<br />
<br />
Tipe Produk<asp:TextBox ID="txtPRODUCT_TYPE" runat="server"></asp:TextBox> 
<br />  
<br />
Cabang  <asp:TextBox ID="txtBRANCH_NAME" runat="server"></asp:TextBox> 
<br />
<br />
Waktu Kirim<asp:TextBox ID="txtDTM_START_SEND" runat="server"></asp:TextBox> 
<br />  
<br />
Waktu Selesai Kirim  <asp:TextBox ID="txtDTM_END_SEND" runat="server"></asp:TextBox> 
<br />
<br />
Tanggal Disetujui  <asp:TextBox ID="txtDTM_APPROVED" runat="server"></asp:TextBox> 
<br />  
<br />
Nama Surveyor  <asp:TextBox ID="txtSURVEYOR_NAME" runat="server"></asp:TextBox> 
<br />
<br />
<asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" />  
<br />
<asp:Label ID="lblResult" runat="server"/> <br /> 
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br /> 
  </form> </body> </html>
