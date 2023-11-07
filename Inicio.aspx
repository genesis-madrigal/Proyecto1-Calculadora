<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto1Calculadora.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>

    <link href="CSS/Botones.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 249px;
        }
        .auto-style2 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style10 {
            height: 44px;
            text-align: center;
            font-size: large;
            width: 240px;
        }
        .auto-style11 {
            text-align: center;
            width: 240px;
        }
        .auto-style12 {
            height: 44px;
            text-align: center;
            width: 240px;
        }
        .auto-style13 {
            font-size: large;
            text-align: center;
            width: 240px;
        }
        .auto-style14 {
            text-align: right;
        }
        .auto-style15 {
            text-align: center;
        }
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h2 class="auto-style15"><strong class="newStyle1">CALCULADORA WEB
          </strong></h2>

            <div class="auto-style2 white-bg">

                <p class="auto-style3">
                    &nbsp;</p>
                <p class="auto-style14">
                    <asp:Label ID="lblCalculadora" runat="server" Text=""></asp:Label>
                </p>
                <p class="auto-style14">
                    <asp:Label ID="lblResultado" runat="server"></asp:Label>
                </p>
                <p class="auto-style3">
                    &nbsp;</p>
            </div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style13"><strong>
                        <asp:Button ID="btnSQR" CSSClass="button button-hover" runat="server" Text="√x" />
                        </strong></td>
                    <td class="auto-style11">
                        <asp:Button ID="btnClear" CSSClass="button button-hover" runat="server"  Text="C" OnClick="btnClear_Click" />
                    </td>
                    <td class="auto-style11"><strong>
                        <asp:Button ID="btnDelete" runat="server" CSSClass="button button-hover" Height="50px" Text="←" Width="82px" />
                        </strong></td>
                    <td class="auto-style11"><strong>
                        <asp:Button ID="btnFact" runat="server" CSSClass="button button-hover" Text="n!" />
                        </strong></td>
                    <td class="auto-style11"><strong>
                        <asp:Button ID="btnDivision" runat="server" CSSClass="button button-hover" Text="÷" OnClick="btnDivision_Click" />
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style10"><strong>
                        <asp:Button ID="btnXtotheY" runat="server" CSSClass="button button-hover" Text="x^y" />
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
                        <asp:Button ID="btn10totheX" runat="server" CSSClass="button button-hover" Text="10^x" />
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
                        <asp:Button ID="btnSquare" runat="server" CSSClass="button button-hover" Text="x² " />
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
        <asp:Label ID="lblTest1" runat="server"></asp:Label>
    </form>
</body>
</html>
