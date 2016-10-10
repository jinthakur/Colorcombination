Imports System
Imports System.Collections.Generic

Imports System.Drawing

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Class colorcomponent

        Dim r As Integer
        Dim g As Integer
        Dim b As Integer
        Dim a As Integer

        Public Sub setcolor(C As Color)
            Me.r = C.R
            Me.g = C.G
            Me.b = C.B
        End Sub

        Public Function getcolor(colorcomponent1 As colorcomponent) As Color
            getcolor = Color.FromArgb(colorcomponent1.r Mod 256, colorcomponent1.g Mod 256, colorcomponent1.b Mod 256)

        End Function
        Public Function getcolorwithalpha(colorcomponent1 As colorcomponent, alpha As Byte) As Color
            getcolorwithalpha = Color.FromArgb(alpha, CByte(colorcomponent1.r Mod 256), CByte(colorcomponent1.g Mod 256), CByte(colorcomponent1.b Mod 256))

        End Function

        Public Function getcolorarray(colorcomponent1 As colorcomponent, colorcomponent2 As colorcomponent, numberofcolorsneededinbetween As Double) As Color()

            Dim outcolorcomponent As New colorcomponent()
            Dim outColor(numberofcolorsneededinbetween) As Color
            outColor(0) = getcolor(colorcomponent1)
            If numberofcolorsneededinbetween > 0 Then
                For i As Double = 1 To numberofcolorsneededinbetween - 1
                    If (colorcomponent1.r - colorcomponent2.r <> 0) Then
                        outcolorcomponent.r = (colorcomponent1.r) + (((-colorcomponent1.r + colorcomponent2.r) * i / (numberofcolorsneededinbetween)))
                    Else
                        outcolorcomponent.r = (colorcomponent1.r)
                    End If


                    If (colorcomponent1.g - colorcomponent2.g <> 0) Then
                        outcolorcomponent.g = (colorcomponent1.g) + (((-colorcomponent1.g + colorcomponent2.g) * i / (numberofcolorsneededinbetween)))
                    Else
                        outcolorcomponent.g = (colorcomponent1.g)
                    End If
                    If (colorcomponent1.b - colorcomponent2.b <> 0) Then
                        outcolorcomponent.b = (colorcomponent1.b) + (((-colorcomponent1.b + colorcomponent2.b) * i / (numberofcolorsneededinbetween)))
                    Else
                        outcolorcomponent.b = (colorcomponent1.b)
                    End If
                    outColor(i) = getcolor(outcolorcomponent)
                Next
            End If
            outColor(numberofcolorsneededinbetween) = getcolor(colorcomponent2)

            Return outColor
        End Function
    End Class

    Public Sub getallcolors()

        Dim mincolor = ColorTranslator.ToHtml(RadColorPickerMin.SelectedColor)
        Dim maxcolor = ColorTranslator.ToHtml(RadColorPickerMax.SelectedColor)

        Dim numberofcolor = 4
        Dim outColor(numberofcolor + 1) As Color
        generatecolor(outColor, RadColorPickerMin.SelectedColor, RadColorPickerMax.SelectedColor, numberofcolor)
        Dim ListBoxcolor As New List(Of String)
        For Each genfcolor As Color In outColor
            ListBoxcolor.Add(ColorTranslator.ToHtml(genfcolor))
            ListBox1.Items.Add(ColorTranslator.ToHtml(genfcolor))
            Dim p_tag As New HtmlGenericControl("P")
            p_tag.InnerHtml = " <div  style='color:" + ColorTranslator.ToHtml(genfcolor) + "' >" + ColorTranslator.ToHtml(genfcolor) + "</div>"

            Panel1.Controls.Add(p_tag)

        Next
        'Input = String.Format("{{ 'chart': {{ 'useRoundEdges' : '1', 'labelFontColor': '0075c2', 'placeXAxisLabelsOnTop' : '1','valueBorderRadius' : '6' , 'theme': 'fint', 'logoAlpha': '40', 'showborder': '0', 'logoScale': '110', 'logoPosition': 'TL', 'caption': '  {0} ' ,  'yaxisname': 'Hour of Day', 'showplotborder': '1', 'xaxislabelsontop': '1', 'plottooltext': '<div>$columnLabel at  $rowLabel :</div><div> Sensor {1} Value : $dataValue </div>', 'basefontcolor': '333333', 'basefont': 'Helvetica Neue,Arial', 'captionfontsize': '14', 'subcaptionfontsize': '14', 'xAxisNameFontSize' : '14', 'yAxisNameFontSize' : '14', 'subcaptionfontbold': '0', 'showborder': '0', 'bgcolor': 'ffffff', 'valuefontcolor': '000000', 'showshadow': '1', 'useplotgradientcolor': '0', 'canvasbgcolor': 'ffffff', 'canvasborderalpha': '0', 'legendbgalpha': '0', 'legendborderalpha': '0', 'legendshadow': '0', 'legenditemfontsize': '10', 'legenditemfontcolor': '666666', 'tooltipcolor': 'ffffff', 'tooltipborderthickness': '0', 'showValues': '0', 'showBorder': '0', 'showPlotBorder': '1', 'tooltipbgcolor': '000000', 'tooltipbgalpha': '80', 'tooltipborderradius': '2', 'tooltippadding': '5' }}, 'dataset': [ {{ 'data': [ #rowdata ] }} ],'colorRange': {{'gradient': '1', 'minValue': '0', 'code': 'ffffff', 'startLabel': ', 'endLabel': ',   'color': [  {{  'code': 'ffffff',  'minValue': '0',  'maxValue': '{4}',  'label': '         }},  {{  'code': '{2}',  'minValue': '{4}',  'maxValue': '{5}',  'label': '  }},  {{  'code': '{3}',  'minValue': '{5}',  'maxValue': '{6}',  'label': '  }}, {{  'code': '92DADB',  'minValue': '{6}',  'maxValue': '{7}',  'label': '  }},                                                                                   {{  'code': '6495ED',  'minValue': '{8}',  'maxValue': '{9}',  'label': '  }} ] }} }}", sensorname, Sensordatatype, mincolor, maxcolor, totalvalues / 6, totalvalues * 2 / 6, totalvalues * 3 / 6, totalvalues * 4 / 6, totalvalues * 5 / 6, totalvalues)

        Dim column As String = String.Empty
        Dim createchart As Boolean = True





    End Sub


    Private Sub generatecolor(ByRef outColor As Color(), colora As Color, colorb As Color, numberofcolorinbetween As Integer)
        'Dim colora As Color
        'colora = Color.Red
        'Dim colorb As Color
        'colorb = Color.Blue
        Dim coloracomponent As New colorcomponent()
        Dim colorbcomponent As New colorcomponent()
        coloracomponent.setcolor(colora)
        colorbcomponent.setcolor(colorb)

        ReDim outColor(numberofcolorinbetween + 1)
        outColor = coloracomponent.getcolorarray(coloracomponent, colorbcomponent, numberofcolorinbetween + 1)


    End Sub





    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs)




    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getallcolors()
    End Sub
End Class