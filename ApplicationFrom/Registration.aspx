<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ApplicationFrom.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WEB FROM</title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }

        .auto-style2 {
            height: 26px;
            width: 128px;
        }
    </style>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td class="auto-style1">First name</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Fname" runat="server" Width="118px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:CustomValidator
                            ID="CustomValidator1"
                            runat="server"
                            ErrorMessage="EnterTheNameStringFormate"
                            ForeColor="Red"
                            ControlToValidate="Fname"
                            OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>

                    </td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox runat="server" ID="Lname"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox runat="server" ID="Address"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox runat="server" ID="email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:TextBox runat="server" ID="city"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Educcation</td>
                    <td>
                        <asp:DropDownList ID="eduDetails" runat="server">
                            <asp:ListItem Selected="True" Value="0">Please Select</asp:ListItem>
                            <asp:ListItem Value="1">S.S.C</asp:ListItem>
                            <asp:ListItem Value="2">H.S.C</asp:ListItem>
                            <asp:ListItem Value="3">B.E</asp:ListItem>
                            <asp:ListItem Value="4">M.E</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Percantage(%)</td>
                    <td>
                        <asp:TextBox runat="server" ID="percantage" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Subject</td>
                    <td>
                        <asp:TextBox runat="server" ID="subjectName" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button Text="Submit" ID="btn" CssClass="btn btn-primary" runat="server" OnClick="Unnamed_Click" /></td>
                    <td>
                        <%--<asp:Button Text="Edit" ID ="editData" runat="server" OnClick="" />--%>
                        <%--<a href="editData.aspx"> <asp:Label CssClass="btn"> Edit</asp:Label></a>--%>
                    </td>
                </tr>

            </table>
        </div>
        <div>
            <div class="card col-lg-12 col-sm-12 col-sm-10 col-md-12   ">

                <table class="card-footer  " style="table-layout: fixed;" id="cus-table">
                    <thead class="">
                        <tr>
                            <th>Index</th>
                            <th>First name</th>
                            <th>last name</th>
                            <th>email</th>
                            <th>address</th>
                            <th>city</th>
                            <th>Cource</th>
                            <th>Percantage</th>
                            <th>subject</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <asp:Repeater runat="server" ID="repit1" OnItemCommand="repit1_ItemCommand">
                        <ItemTemplate>
                            <tbody>
                                <tr>
                                    <td><%# Container.ItemIndex+1 %></td>
                                    <td><%# Eval("Firstname") %></td>
                                    <td><%# Eval("Lastname") %></td>
                                    <td><%# Eval("email") %></td>
                                    <td><%# Eval("Address") %></td>
                                    <td><%# Eval("city") %></td>
                                    <td><%# Eval("eduName") %></td>
                                    <td><%# Eval("percantage") %></td>
                                    <td><%# Eval("subjectName") %></td>
                                        <td>
                                            <a href="editData.aspx?eid=<%# Eval("user_id") %>" class="btn btn-primary btn-sm">Edit</a>
                                            <asp:LinkButton ID="Button1" class="btn btn-primary btn-sm" runat="server" CommandArgument='<%# Eval("user_id") %>' Text="Delete"></asp:LinkButton>
                                        </td>
                                </tr>
                            </tbody>
                        </ItemTemplate>
                    </asp:Repeater>

                </table>
            </div>
        </div>
    </form>

</body>

<script type="text/javascript" language="javascript">
    //function check() {

    //    var mobile = document.getElementById('percantage');


    //    var message = document.getElementById('message');

    //    var goodColor = "#0C6";
    //    var badColor = "#FF9B37";

    //    if (typeof int) {

    //        mobile.style.backgroundColor = badColor;
    //        message.style.color = badColor;
    //        message.innerHTML = "required 10 digits, match requested format!"
    //    }
    //}
</script>
</html>
