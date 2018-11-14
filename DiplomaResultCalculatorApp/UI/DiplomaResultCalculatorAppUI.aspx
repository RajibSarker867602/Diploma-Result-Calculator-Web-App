<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DiplomaResultCalculatorAppUI.aspx.cs" Inherits="DiplomaResultCalculatorApp.UI.DiplomaResultCalculatorAppUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="text-right">
                First Semester GPA:
            </td>
            <td>
                <asp:TextBox ID="firstSemesterGpaTextBox" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="firstCgpaRange" runat="server" ForeColor="Red" ControlToValidate="firstSemesterGpaTextBox" ErrorMessage="Input Value Is Incorrect" MaximumValue="4.00" MinimumValue="2.00" SetFocusOnError="True"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="firstCgpaRequired" runat="server" ControlToValidate="firstSemesterGpaTextBox" ErrorMessage="First Semester GPA Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right">
                Second Semester GPA:
            </td>
            <td>
                <asp:TextBox ID="secondSemesterGpaTextBox" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ForeColor="Red" ControlToValidate="secondSemesterGpaTextBox" ErrorMessage="Input Value Is Incorrect" MaximumValue="4.00" MinimumValue="2.00" SetFocusOnError="True"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="secondSemesterGpaTextBox" ErrorMessage="Second Semester GPA Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right">
                Third Semester GPA:
            </td>
            <td>
                <asp:TextBox ID="thirdSemesterGpaTextBox" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator2" runat="server" ForeColor="Red" ControlToValidate="thirdSemesterGpaTextBox" ErrorMessage="Input Value Is Incorrect" MaximumValue="4.00" MinimumValue="2.00" SetFocusOnError="True"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="thirdSemesterGpaTextBox" ErrorMessage="Third Semester GPA Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right">
                Fourth Semester GPA:
            </td>
            <td>
                <asp:TextBox ID="fourthSemesterGpaTextBox" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator3" runat="server" ForeColor="Red" ControlToValidate="fourthSemesterGpaTextBox" ErrorMessage="Input Value Is Incorrect" MaximumValue="4.00" MinimumValue="2.00" SetFocusOnError="True"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="fourthSemesterGpaTextBox" ErrorMessage="Fourth Semester GPA Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right">
                Fifth Semester GPA:
            </td>
            <td>
                <asp:TextBox ID="fifthSemesterGpaTextBox" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator4" runat="server" ForeColor="Red" ControlToValidate="fifthSemesterGpaTextBox" ErrorMessage="Input Value Is Incorrect" MaximumValue="4.00" MinimumValue="2.00" SetFocusOnError="True"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="fifthSemesterGpaTextBox" ErrorMessage="Fifth Semester GPA Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right">
                Sixth Semester GPA:
            </td>
            <td>
                <asp:TextBox ID="sixthSemesterGpaTextBox" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator5" runat="server" ForeColor="Red" ControlToValidate="sixthSemesterGpaTextBox" ErrorMessage="Input Value Is Incorrect" MaximumValue="4.00" MinimumValue="2.00" SetFocusOnError="True"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="sixthSemesterGpaTextBox" ErrorMessage="Sixth Semester GPA Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right">
                Seventh Semester GPA:
            </td>
            <td>
                <asp:TextBox ID="seventhSemesterGpaTextBox" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator6" runat="server" ForeColor="Red" ControlToValidate="seventhSemesterGpaTextBox" ErrorMessage="Input Value Is Incorrect" MaximumValue="4.00" MinimumValue="2.00" SetFocusOnError="True"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="seventhSemesterGpaTextBox" ErrorMessage="Seventh Semester GPA Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right">
                Eight Semester GPA:
            </td>
            <td>
                <asp:TextBox ID="eightSemesterGpaTextBox" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator7" runat="server" ForeColor="Red" ControlToValidate="eightSemesterGpaTextBox" ErrorMessage="Input Value Is Incorrect" MaximumValue="4.00" MinimumValue="2.00" SetFocusOnError="True"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="eightSemesterGpaTextBox" ErrorMessage="Eight Semester GPA Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-right">
                Result:
            </td>
            <td>
                <asp:TextBox ID="cgpaResutlTextBox" runat="server" ReadOnly="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:TextBox ID="gradeResultTextBox" runat="server" ReadOnly="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>

            </td>
            <td>
                <asp:Button ID="cgpaButton" runat="server" Text="CGPA" OnClick="cgpaButton_Click" />
                <asp:Button ID="gradeButton" runat="server" Text="GRADE" OnClick="gradeButton_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
