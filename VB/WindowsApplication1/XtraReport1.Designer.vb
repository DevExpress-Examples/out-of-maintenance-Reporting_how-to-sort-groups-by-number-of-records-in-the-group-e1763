Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.nwindDataSet1 = New WindowsApplication1.nwindDataSet()
			Me.categoryProductsTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.CategoryProductsTableAdapter()
			Me.GroupCategoryCounter = New DevExpress.XtraReports.UI.CalculatedField()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
			Me.Detail.Height = 25
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' categoryProductsTableAdapter
			' 
			Me.categoryProductsTableAdapter.ClearBeforeFill = True
			' 
			' GroupCategoryCounter
			' 
			Me.GroupCategoryCounter.DataMember = "CategoryProducts"
			Me.GroupCategoryCounter.DataSource = Me.nwindDataSet1
			Me.GroupCategoryCounter.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
			Me.GroupCategoryCounter.Name = "GroupCategoryCounter"
'			Me.GroupCategoryCounter.GetValue += New DevExpress.XtraReports.UI.GetValueEventHandler(Me.GroupCategoryCounter_GetValue);
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("GroupCategoryCounter", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending), New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.Height = 25
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.Turquoise
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.CategoryName", "")})
			Me.xrLabel1.Location = New System.Drawing.Point(33,0)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,96F)
			Me.xrLabel1.Size = New System.Drawing.Size(425,25)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BackColor = System.Drawing.Color.Turquoise
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.GroupCategoryCounter", "")})
			Me.xrLabel2.Location = New System.Drawing.Point(550,0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,96F)
			Me.xrLabel2.Size = New System.Drawing.Size(100,25)
			Me.xrLabel2.StylePriority.UseBackColor = False
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryProducts.ProductName", "")})
			Me.xrLabel3.Location = New System.Drawing.Point(0,0)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,96F)
			Me.xrLabel3.Size = New System.Drawing.Size(317,25)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.GroupCategoryCounter})
			Me.DataAdapter = Me.categoryProductsTableAdapter
			Me.DataMember = "CategoryProducts"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "9.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private nwindDataSet1 As nwindDataSet
		Private categoryProductsTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.CategoryProductsTableAdapter
		Private WithEvents GroupCategoryCounter As DevExpress.XtraReports.UI.CalculatedField
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
