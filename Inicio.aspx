<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto1Calculadora.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>

    <link href="CSS/Botones.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous"/>
    
    <style type="text/css">
        .auto-style2 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style14 {
            text-align: right;
        }                
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container text-center">
                <div class="row">
                    <div class="col"></div>
                    <div class="col">
                        <h2><strong>CALCULADORA WEB</strong></h2>
                    </div>
                    <div class="col"></div>
                </div>                
            </div>   
            <div class="container">
                 <div class="row">
                    <div class="col"></div>
                    <div class="col fs-2 text-end">
                        <asp:Label ID="lblCalculadora" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="col"></div>
                </div>
                 <div style="height: 44px;">
                     <div class="row">
                        <div class="col"></div>
                        <div class="col fs-1 text-end">
                            <asp:Label ID="lblResultado" runat="server" ></asp:Label>
                        </div>
                        <div class="col"></div>
                    </div>
                </div>
            </div>

            <div class="container">
                <div class="row">
                    <div class="col-4"></div>
                    <div class="col-xl-5">   
                        
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btnSQR" CSSClass="button button-hover" runat="server" Text="√x" OnClick="btnSQR_Click" />
                                    </strong></td>
                                <td class="auto-style11">
                                    <asp:Button ID="btnClear" CSSClass="button button-hover" runat="server"  Text="C" OnClick="btnClear_Click" />
                                </td>
                                <td class="auto-style11"><strong>
                                    <asp:Button ID="btnDelete" runat="server" CSSClass="button button-hover" Height="50px" Text="←" Width="82px" OnClick="btnDelete_Click" />
                                    </strong></td>
                                <td class="auto-style11"><strong>
                                    <asp:Button ID="btnFact" runat="server" CSSClass="button button-hover" Text="n!" OnClick="btnFact_Click" />
                                    </strong></td>
                                <td class="auto-style11"><strong>
                                    <asp:Button ID="btnDivision" runat="server" CSSClass="button button-hover" Text="÷" OnClick="btnDivision_Click" />
                                    </strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style10"><strong>
                                    <asp:Button ID="btnXtotheY" runat="server" CSSClass="button button-hover" Text="x^y" OnClick="btnXtotheY_Click" />
                                    </strong></td>
                                <td class="auto-style12"><strong>
                                    <asp:Button ID="btn7" runat="server" CSSClass="button button-hover" Text="7" OnClick="btn7_Click" />
                                    </strong></td>
                                <td class="auto-style12"><strong>
                                    <asp:Button ID="btn8" runat="server" CSSClass="button button-hover" Text="8" OnClick="btn8_Click" />
                                    </strong></td>
                                <td class="auto-style12"><strong>
                                    <asp:Button ID="btn9" runat="server" CSSClass="button button-hover" Text="9" OnClick="btn9_Click" />
                                    </strong></td>
                                <td class="auto-style12"><strong>
                                    <asp:Button ID="btnMultiply" runat="server" CSSClass="button button-hover" Text="x" OnClick="btnMultiply_Click" />
                                    </strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btn10totheX" runat="server" CSSClass="button button-hover" Text="10^x" OnClick="btn10totheX_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btn4" runat="server" CSSClass="button button-hover" Text="4" OnClick="btn4_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btn5" runat="server" CSSClass="button button-hover" Text="5" OnClick="btn5_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btn6" runat="server" CSSClass="button button-hover" Text="6" OnClick="btn6_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btnMinus" runat="server" CSSClass="button button-hover" Text="-" OnClick="btnMinus_Click" />
                                    </strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btnLog" runat="server" CSSClass="button button-hover" Text="log(x)" OnClick="btnLog_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btn1" runat="server" CSSClass="button button-hover" Text="1" OnClick="btn1_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btn2" runat="server" CSSClass="button button-hover" Text="2" OnClick="btn2_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btn3" runat="server" CSSClass="button button-hover" Text="3" OnClick="btn3_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btnSum" runat="server" CSSClass="button button-hover" Text="+" OnClick="btnSum_Click" />
                                    </strong></td>
                            </tr>
                            <tr>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btnSquare" runat="server" CSSClass="button button-hover" Text="x² " OnClick="btnSquare_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btnNegate" runat="server" CSSClass="button button-hover" Text="+/-" OnClick="btnNegate_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btn0" runat="server" CSSClass="button button-hover" Text="0" OnClick="btn0_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btnComma" runat="server" CSSClass="button button-hover" Text="," OnClick="btnComma_Click" />
                                    </strong></td>
                                <td class="auto-style13"><strong>
                                    <asp:Button ID="btnEquals" runat="server" CSSClass="button steelblue-bg button-hover" Text="=" OnClick="btnEquals_Click" />
                                    </strong></td>
                            </tr>
                        </table>
                            
                    </div>
                    <div class="col"></div>
                </div>               
            </div>
             
          

            <div class="auto-style2 white-bg">

                <p class="auto-style3">
                    <strong>
                        
                        </strong>
                        
                    <strong>
                        
                        
                        
                        </strong></p>
                <p class="auto-style3">
                    <strong>
                        
                        
                        </strong></p>
                <p class="auto-style3">
                    <strong>
                        
                        </strong></p>
                <p class="auto-style3">
                    <strong>
                        
                        </strong></p>
                <p class="auto-style3">
                    <strong>
                        
                        </strong></p>
            </div>
        </div>
        <asp:Label ID="lblTest1" runat="server"></asp:Label>
    </form>
</body>
</html>
