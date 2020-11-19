 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulaire.aspx.cs" Inherits="RealMeForm.Formulaire" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>RealMe</title>
</head>
<body style="background-color: #32A3FC ">
    <form id="form2" runat="server">
        <div style="margin-left:350px;padding-bottom:80px;position:relative;margin-top:60px;margin-right:350px;border-radius:20px;background-color:rgb(255,255,255,0.6)  ">
            <div style="margin:auto;background-color:rgb(0,0,0,0.4);padding-top:20px;border-radius:20px"  > 
                <h1 style="margin:auto;padding-left:200px;color:#FAFBFC"  > 
                    <label  ">Evaluation Form</label>
                </h1>
            </div>
            <h3 style="color:orangered;margin-left: 10px" > 
                <label >WELCOME, please rate your friend from 0 to 5 in the Note field</label>   
            </h3>
            <table style=" margin:auto; ">
                <tr>
                    <td style="color:black"> 
                        <h4>ID of Transmitter:</h4> 
                    </td>
                    <td colspan="2"><asp:Label ID="idEmetteur" runat="server"></asp:Label></td>
                </tr>  
                <tr>
                    <td> <h4>Mirror</h4></td>
                    <td ><asp:Label ID="mirror"  runat="server"  ></asp:Label></td><td ><h4>First Name</h4></td>
                     <td><asp:TextBox ID="firstName" runat="server" ForeColor="Black" ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstName" 
                             ErrorMessage="First Name is Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                     </td>
                </tr>
                 <tr>
                    <td > <h4>Group</h4></td>
                <td class="auto-style7"><asp:Label ID="group" runat="server"  ></asp:Label></td><td > <h4>Last Name</h4></td>
                     <td><asp:TextBox ID="lastName" runat="server" ForeColor="Black" ></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastName" 
                             ErrorMessage="First Name is Empty" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                     </td></tr>
                 <tr>
                    <td ><h4>Critaria</h4></td>
                    <td><asp:Label ID="critere" runat="server" ForeColor="Black" ></asp:Label></td><td ><h4>Note</h4></td>
                     <td > <asp:TextBox ID="note" runat="server" ForeColor="Black" ></asp:TextBox><asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Invalid Fild" ControlToValidate="note" Display="Dynamic" MaximumValue="5" MinimumValue="0"></asp:RangeValidator>
                            </td>
                  </tr>
              
                    
       
               
            </table>
           
             <br />
             <div  >
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save" style="margin-left: 245px;margin-top: 45px;border-radius:20px" Width="102px" />
             </div>
           
            <br />
           
        </div>
    </form>
</body>
</html>
