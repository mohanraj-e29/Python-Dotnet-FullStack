<%@ Page Title="" Language="C#" MasterPageFile="~/view/admin/Site1.Master" AutoEventWireup="true" CodeBehind="rents.aspx.cs" Inherits="aspproject.view.admin.rents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

<div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                        <h2 class="text-danger pl-4">Manage Rented Cars</h2> 
                        <img src="../../asserts/img/pic3.jpg"  alt="no image here.." /></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form>
                            <div class="form-group">
                                <label for="exampleInputEmail">Customer Name</label>
                                <input type="text" class="form-control" id="CusnameTb"  placeholder="Enter Customer's Name" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail">Custoer Address</label>
                                <input type="text" class="form-control" id="AddTb"  placeholder="Enter Customer's Address"  runat="server"/>
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail">Customer Phno</label>
                                <input type="text" class="form-control" id="PhoneTb"  placeholder="Enter the phno" runat="server" />
                            </div>

                             <div class="form-group">
                                <label for="exampleInputEmail">Customer Password</label>
                                <input type="password" class="form-control" id="Text1"  placeholder="Enter the Password" runat="server" />
                            </div>
                            
                            
                            <br />
                            <button type="submit" class="btn btn-danger">EDIT</button>
                            <button type="submit" class="btn btn-danger">ADD</button>
                            <button type="submit" class="btn btn-danger">DELETE</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>






</asp:Content>
