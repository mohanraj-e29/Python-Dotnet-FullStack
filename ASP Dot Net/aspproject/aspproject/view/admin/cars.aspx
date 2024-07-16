<%@ Page Title="" Language="C#" MasterPageFile="~/view/admin/Site1.Master" AutoEventWireup="true" CodeBehind="cars.aspx.cs" Inherits="aspproject.view.admin.cars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
   


</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                        <h2 class="text-danger pl-4">Manage cars</h2> 
                        <img src="../../asserts/img/pic1.jpg" alt="no image here.." /></div>
                    <div class="col"></div>
                </div>
                <div class="row">
                    <div class="col">
                        <form >
                            <div class="form-group">
                                <label for="exampleInputEmail">Licence Number</label>
                                <input type="text" class="form-control" id="LnumberTb"  placeholder="Enter Plate Number" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail">Brand</label>
                                <input type="text" class="form-control" id="BrandTb"  placeholder="Enter Car Brand"  runat="server"/>
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail">Model</label>
                                <input type="text" class="form-control" id="ModelTb"  placeholder="Enter the Model" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail">Price</label>
                                <input type="text" class="form-control" id="PriceTb"  placeholder="Enter the Price" runat="server" />
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail">Color</label>
                                <input type="text" class="form-control" id="ColorTb"  placeholder="Enter the Color"  runat="server"/>
                            </div>
                            <div class="form-group">
                                <label for="exampleInputEmail">Avilable</label>
                                <asp:DropDownList ID="AvilableCb" runat="server" class="form-control">
                                    <asp:ListItem>Avilable</asp:ListItem>
                                    <asp:ListItem>Booked</asp:ListItem>
                                </asp:DropDownList>
                                
                            </div>
                            <br />
                            <label id="errormsg" runat="server"></label>
                            <asp:Button type="submit" ID="EditBtn" class="btn btn-danger" Text="Edit" runat="server"/>
                            <asp:Button type="submit"  ID="saveBtn" class="btn btn-danger" Text="Save" runat="server" />
                            <asp:Button type="submit"  ID="deleteBtn" class="btn btn-danger" Text="Delete" runat="server"/>
                            <asp:Button type="submit"  ID="printbtn" class="btn btn-danger" Text="Print" runat="server" OnClick="printbtn_Click" />

                          
                            
                            <br />
                            <br />

                          
                            
                        </form>

                    </div>
                </div>
            </div>
       
    <div class="col-mid-8">
        <h1>Cars List<asp:GridView runat="server" ID="carlist" class="table table-hover" AutoGenerateSelectButton="True" Width="716px" Height="30px" >
            <AlternatingRowStyle BackColor="#FFCC00" ForeColor="White" />
        </asp:GridView>


          </div>
       </div>
   </div> 
</asp:Content>
