Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TempConv

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Celsius")
        ComboBox1.Items.Add("Fahrenheit")
        ComboBox1.Items.Add("Kelvin")
        ComboBox1.Items.Add("Reamur")

        ComboBox2.Items.Add("Celsius")
        ComboBox2.Items.Add("Fahrenheit")
        ComboBox2.Items.Add("Kelvin")
        ComboBox2.Items.Add("Reamur")

        ' Set default values
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 1
    End Sub


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConv As New TempConv.TempConvComp
        Dim c As Double
        Dim f As Double
        Dim k As Double
        Dim r As Double
        If Double.TryParse(TextBox1.Text, Nothing) Then
            Dim inputValue As Double = CDbl(TextBox1.Text)
            Dim outputValue As Double
            Select Case ComboBox1.SelectedItem.ToString()
                Case "Celsius"
                    c = CDbl(TextBox1.Text)
                    Select Case ComboBox2.SelectedItem.ToString()
                        Case "Celsius"
                            outputValue = inputValue
                        Case "Fahrenheit"
                            outputValue = objConv.cToF(c)
                        Case "Kelvin"
                            outputValue = objConv.cToK(c)
                        Case "Reamur"
                            outputValue = objConv.cToR(c)
                    End Select
                Case "Fahrenheit"
                    f = CDbl(TextBox1.Text)
                    Select Case ComboBox2.SelectedItem.ToString()
                        Case "Celsius"
                            outputValue = objConv.fToC(f)
                        Case "Fahrenheit"
                            outputValue = inputValue
                        Case "Kelvin"
                            outputValue = objConv.fToK(f)
                        Case "Reamur"
                            outputValue = objConv.fToR(f)
                    End Select
                Case "Kelvin"
                    k = CDbl(TextBox1.Text)
                    Select Case ComboBox2.SelectedItem.ToString()
                        Case "Celsius"
                            outputValue = objConv.kToC(k)
                        Case "Fahrenheit"
                            outputValue = objConv.kToF(k)
                        Case "Kelvin"
                            outputValue = inputValue
                        Case "Reamur"
                            outputValue = objConv.kToR(k)
                    End Select
                Case "Reamur"
                    r = CDbl(TextBox1.Text)
                    Select Case ComboBox2.SelectedItem.ToString()
                        Case "Celsius"
                            outputValue = objConv.rToC(r)
                        Case "Fahrenheit"
                            outputValue = objConv.rToF(r)
                        Case "Kelvin"
                            outputValue = objConv.rToK(r)
                        Case "Reamur"
                            outputValue = inputValue
                    End Select
            End Select
            Label2.Text = $"{outputValue}"
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    ' Dim c As Double
    ' Dim f As Double
    ' Dim k As Double
    ' Dim r As Double
    ' c = CDbl(TextBox1.Text)
    ' Label2.Text = objConv.cToF(c)

End Class
