Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data

Namespace WindowsApplication1
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub
		Private ht As New Hashtable()
		Private Sub GroupCategoryCounter_GetValue(ByVal sender As Object, ByVal e As GetValueEventArgs) Handles GroupCategoryCounter.GetValue
			Dim cat As String = (CType(e.Row, DataRowView))("CategoryName").ToString()
			Dim count As Integer = 0
			If (Not ht.ContainsKey(cat)) Then
				count = nwindDataSet1.CategoryProducts.Select("CategoryName = '" & cat & "'").Length
				ht.Add(cat,count)
			Else
				count = Convert.ToInt32(ht(cat))
			End If

			e.Value = count
		End Sub

	End Class
End Namespace
