Imports System.IO
Imports System.Net


''' <summary>
''' A quick and dirty app to grab the 'Web Exclusives' from the 89.7 phone a thon.  The items change in price, and what is added and I needed a quick way to skim what is there.
''' </summary>
''' <remarks></remarks>
Public Class WebExclusive_Main
    Dim lNew As Int32 = 0
    Dim lDiff As Int32 = 0
    Dim sFileConst As String = "_897river_"

    ''' <summary>
    ''' Try and load any saved xml files saved from a past run.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles Me.Load
        '-- grab all the files in the save location.
        Dim sFiles() As String = Directory.GetFiles(txtSaveLocation.Text)

        Dim sNewest As String = String.Empty

        '-- find newest saved file that has the sFileConst name and is .XML
        For Each temp As String In sFiles
            If Path.GetExtension(temp).ToLower = ".xml" Then
                If (temp.Contains(sFileConst)) Then

                    If sNewest = String.Empty Then
                        sNewest = temp
                        Continue For
                    Else
                        If File.GetCreationTime(sNewest) < File.GetCreationTime(temp) Then
                            sNewest = temp
                            Continue For
                        End If
                    End If

                End If
            End If
        Next

        '-- if something is found then load it up.
        If sNewest <> String.Empty Then
            dsData.ReadXml(sNewest)
            lblTotal.Text = "Total: " + dsData.DataTable1.Rows.Count.ToString
        End If



    End Sub

    ''' <summary>
    ''' Take in a raw string of the website to parse apart and add to the dataset.
    ''' </summary>
    ''' <param name="incoming"></param>
    ''' <remarks></remarks>
    Private Sub LoadData(ByVal incoming As String, ByVal dt As DateTime)
        Dim dsTemp As New dsForm12
        Dim sListNamePriceholder As New List(Of String)
        Dim sArrayHTMLLines() As String = incoming.Split(CChar(Environment.NewLine))

        Dim sName As String = String.Empty
        Dim sPrice As String = String.Empty
        Dim sDATE_ENTERED As String = dt.ToString        '--DateTime.Now.ToString

        '-- scan the HTML for two key anchor points..
        For i As Int32 = 0 To sArrayHTMLLines.Length - 1

            '-- if found strip the rest of the line cruft out and add the data to the holder list.
            If (sArrayHTMLLines(i).ToLower().Contains("tdtitle")) Then
                sListNamePriceholder.Add(sArrayHTMLLines(i + 1).Trim().Replace("</td>", String.Empty))
            End If

            If (sArrayHTMLLines(i).ToLower().Contains("price")) Then
                sListNamePriceholder.Add(sArrayHTMLLines(i).Trim().Replace("&nbsp;", String.Empty).Replace("</td>", String.Empty))
            End If
        Next


        '-- in theory we should have nothing but n = name, and n+1= price.  Add them to a temp dataset to be sent in for merging.
        For i As Int32 = 0 To sListNamePriceholder.Count - 1 Step 2
            sName = sListNamePriceholder(i)
            If i + 1 < sListNamePriceholder.Count Then
                sPrice = sListNamePriceholder(i + 1)
            Else
                sPrice = String.Empty
            End If

            sPrice = sPrice.Replace("Price: $", String.Empty)

            dsTemp.DataTable1.AddDataTable1Row(sName.Trim, sPrice.Trim, String.Empty, sDATE_ENTERED, String.Empty)
        Next

        '-- if existing data is tehre merge.. so new items are added, and existing items that have had a price change or been sold are updated.
        Merge(dsTemp)

        '-- total up everything
        lblTotal.Text = "Total: " + dsData.DataTable1.Rows.Count.ToString
        lblNew.Text = "New: " + lNew.ToString
        lblDifferent.Text = "Different: " + lDiff.ToString
    End Sub

    ''' <summary>
    ''' A barebones compare of the data coming in (by name) and if matching their price.  
    ''' If the name match isn't found then just add the row.  
    ''' If the name match is found check the price and either update it or do nothing.  Keep a record of old prices.
    ''' </summary>
    ''' <param name="dsIncoming"></param>
    ''' <remarks></remarks>
    Private Sub Merge(ByRef dsIncoming As dsForm12)
        Dim bFound As Boolean = False

        If dsData Is Nothing Then
            dsData = New dsForm12
        End If

        lNew = 0
        lDiff = 0

        If dsData.DataTable1.Rows.Count = 0 Then
            '-- if no data then by all means just merge it all.
            dsData.Merge(dsIncoming)
            lNew = dsIncoming.DataTable1.Rows.Count
            lDiff = 0
        Else

            For Each tempIncoming As dsForm12.DataTable1Row In dsIncoming.DataTable1.Rows
                bFound = False
                For Each a As dsForm12.DataTable1Row In dsData.DataTable1.Rows

                    If tempIncoming.Name.Trim.ToLower = a.Name.Trim.ToLower Then
                        If tempIncoming.Price.ToLower <> a.Price.ToLower Then
                            a.OldPrices += a.Price + ","
                            a.Price = tempIncoming.Price
                            a.DATE_UPDATED = tempIncoming.DATE_ENTERED
                            lDiff += 1
                        End If
                        bFound = True
                        Exit For
                    End If
                Next

                If Not bFound Then
                    dsData.DataTable1.AddDataTable1Row(tempIncoming.Name, tempIncoming.Price, String.Empty, tempIncoming.DATE_ENTERED, String.Empty)
                    lNew += 1
                End If


            Next


        End If

    End Sub

    ''' <summary>
    ''' Mostly used for testing saved pages on the merge and load.. won't be needing when done.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click

        If txtLocation.Text.Trim = String.Empty Then
            Exit Sub
        End If

        Dim sr As StreamReader
        Dim temp As String = String.Empty

        Try
            sr = New StreamReader(txtLocation.Text.Trim)
            temp = sr.ReadToEnd
        Catch ex As Exception
            MsgBox("btnLoadFile Error: " + ex.Message)
        Finally
            If sr IsNot Nothing Then
                sr.Dispose()
            End If

        End Try



        LoadData(temp, CType("05/06/2014 12:00", DateTime))
    End Sub

    ''' <summary>
    ''' Keep historical data going... so I can tell new items and new prices.  Rips XML from the dataset.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSaveXML.Click
        If txtSaveLocation.Text.Trim = String.Empty Then
            Exit Sub
        End If

        If Not Directory.Exists(txtSaveLocation.Text.Trim) Then
            Directory.CreateDirectory(txtSaveLocation.Text.Trim)
        End If

        Dim sFileNAme As String = String.Format("{0}{1}{2}{6}{3}{4}{5}.xml", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, sFileConst)

        If txtSaveLocation.Text.Substring(txtSaveLocation.Text.Length - 1) <> "\" Then
            txtSaveLocation.Text += "\"
        End If

        dsData.DataTable1.WriteXml(txtSaveLocation.Text + sFileNAme, XmlWriteMode.WriteSchema)
    End Sub

    ''' <summary>
    ''' Quick jump to a web request for the site's address on the web exclusives.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLoadWeb.Click
        Dim oWebRequest As System.Net.HttpWebRequest
        Dim oWebResponse As HttpWebResponse
        Dim sr As StreamReader

        Dim responseData As String

        Try
            oWebRequest = CType(WebRequest.Create(txtUrl.Text.Trim), HttpWebRequest)
            oWebResponse = CType(oWebRequest.GetResponse(), HttpWebResponse)
            sr = New StreamReader(oWebResponse.GetResponseStream())
            responseData = sr.ReadToEnd()
            '-- send in the unformated html to be parsed.
            LoadData(responseData, DateTime.Now)
        Catch ex As Exception
            MsgBox("btnLoadWeb Error: " + ex.Message)

        Finally
            If sr IsNot Nothing Then
                sr.Dispose()
            End If
        End Try


    End Sub

    ''' <summary>
    ''' Clears the dataset in the grid.. mostly used for testing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnClearGrid.Click
        dsData.DataTable1.Clear()
        lblTotal.Text = "Total: 0"
        lblNew.Text = "New: 0"
        lblDifferent.Text = "Different: 0"
    End Sub
End Class