<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editData.aspx.cs" Inherits="ApplicationFrom.editData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
</head>
<body>
    <form class="needs-validation" novalidatec runat="server">
        <div class="form-row">
            <div class="col-md-4 mb-3">
                <%--<label for="validationCustom01">Registration Number</label>--%>
                <%--<asp:TextBox runat="server" type="text" class="form-control" ID="userId" placeholder="ID" ></asp:TextBox>--%>
                <asp:HiddenField runat="server" ID="userId" />
            </div>
        </div>
        <div class="form-row">
            <div class="col-md-4 mb-3">
                <label for="validationCustom01">First name</label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="name" placeholder="First name" required></asp:TextBox>
                <div class="valid-feedback">
                    Looks good!
                </div>
            </div>
            <div class="col-md-4 mb-3">
                <label for="validationCustom01">Last name</label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="Lname" placeholder="Last name" required></asp:TextBox>
                <div class="valid-feedback">
                    Looks good!
                </div>
            </div>
            <div class="col-md-4 mb-3">
                <label for="validationCustomUsername">Email</label>
                <div class="input-group">
                    <div class="input-group-prepend">
                        <span class="input-group-text" id="inputGroupPrepend">@</span>
                    </div>
                    <asp:TextBox runat="server" type="text" class="form-control" ID="Email" placeholder="Username" aria-describedby="inputGroupPrepend" required></asp:TextBox>
                    <asp:RegularExpressionValidator runat="server" ID="emailValidation" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email" ErrorMessage="RegularExpressionValidator" EnableClientScript="False">*</asp:RegularExpressionValidator>
                    <div class="invalid-feedback">
                        Please choose a username.
                    </div>
                </div>
            </div>
        </div>
        <div class="form-row">
            <div class="col-md-6 mb-3">
                <label for="validationCustom03">Address</label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="add" placeholder="Address" required></asp:TextBox>
                <div class="invalid-feedback">
                    Please provide a valid Address.
                </div>
            </div>
            <div class="col-md-3 mb-3">
                <label for="validationCustom04">City</label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="city" placeholder="City" required></asp:TextBox>
                <div class="invalid-feedback">
                    Please provide a valid City.
                </div>
            </div>

        </div>
        <div class="form-row">
            <div class="col-md-3 mb-3">
                <label for="validationCustom03">Education</label>
                <asp:DropDownList ID="eduDetails" runat="server">
                            <asp:ListItem Selected="True" Value="0">Please Select</asp:ListItem>
                            <asp:ListItem Value="1">S.S.C</asp:ListItem>
                            <asp:ListItem Value="2">H.S.C</asp:ListItem>
                            <asp:ListItem Value="3">B.E</asp:ListItem>
                            <asp:ListItem Value="4">M.E</asp:ListItem>
                        </asp:DropDownList>
            </div>
            <div="col-md-3 mb-3">
                 <label for="validationCustom03">Percantage</label>
                <asp:TextBox runat="server" ID="percantage"></asp:TextBox>
            </div>
            <div="col-md-3 mb-3">
                 <label for="validationCustom03">subject</label>
                <asp:TextBox runat="server" ID="subjectName"></asp:TextBox>
            </div>
        </div>
        <div class="form-row">
            <asp:Button class="btn btn-primary btn-sm" ID="submit" runat="server" Text="submit form" OnClick="submit_Click" />
        </div>
        
    </form>
</body>
</html>
