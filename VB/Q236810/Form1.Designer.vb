Imports Microsoft.VisualBasic
Imports System
Namespace Q236810
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.myPivotGridControl1 = New DXSample.MyPivotGridControl()
			Me.nwindDataSet = New Q236810.nwindDataSet()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.salesPersonTableAdapter = New Q236810.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myPivotGridControl1
			' 
			Me.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.myPivotGridControl1.DataSource = Me.salesPersonBindingSource
			Me.myPivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myPivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry, Me.fieldProductName, Me.fieldCategoryName, Me.fieldQuantity, Me.fieldDiscount, Me.fieldSalesPerson})
			Me.myPivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myPivotGridControl1.Name = "myPivotGridControl1"
			Me.myPivotGridControl1.OptionsCustomization.AllowFilter = False
			Me.myPivotGridControl1.Size = New System.Drawing.Size(402, 273)
			Me.myPivotGridControl1.TabIndex = 0
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' salesPersonBindingSource
			' 
			Me.salesPersonBindingSource.DataMember = "SalesPerson"
			Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' fieldCountry
			' 
			Me.fieldCountry.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.Caption = "Country"
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			Me.fieldCountry.Visible = False
			' 
			' fieldProductName
			' 
			Me.fieldProductName.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldDiscount
			' 
			Me.fieldDiscount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
			Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldDiscount.Caption = "Discount"
			Me.fieldDiscount.FieldName = "Discount"
			Me.fieldDiscount.Name = "fieldDiscount"
			Me.fieldDiscount.Visible = False
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.AllowedAreas = (CType(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
			Me.fieldSalesPerson.AreaIndex = 1
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			Me.fieldSalesPerson.Visible = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(402, 273)
			Me.Controls.Add(Me.myPivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myPivotGridControl1 As DXSample.MyPivotGridControl
		Private nwindDataSet As nwindDataSet
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private salesPersonTableAdapter As Q236810.nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDiscount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField


	End Class
End Namespace

