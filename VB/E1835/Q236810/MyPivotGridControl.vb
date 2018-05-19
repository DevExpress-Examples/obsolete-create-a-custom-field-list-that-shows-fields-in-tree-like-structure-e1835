Imports Microsoft.VisualBasic
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraPivotGrid.ViewInfo
Imports DevExpress.XtraPivotGrid.Customization
Imports System.Collections.Generic
Imports System.Collections
Imports System.Reflection
Imports DevExpress.XtraEditors.Customization
Imports DevExpress.XtraPivotGrid.Customization.ViewInfo

Namespace DXSample
	Public Class MyPivotGridControl
		Inherits PivotGridControl
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal viewInfoData As PivotGridViewInfoData)
			MyBase.New(viewInfoData)
		End Sub

		Protected Overrides Function CreateData() As PivotGridViewInfoData
			Return New MyPivotGridViewInfoData(Me)
		End Function
	End Class

	Public Class MyPivotGridViewInfoData
		Inherits PivotGridViewInfoData
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal control As IViewInfoControl)
			MyBase.New(control)
		End Sub

		Public Shadows ReadOnly Property ShowCustomizationTree() As Boolean
			Get
				Return OptionsView.GroupFieldsInCustomizationWindow
			End Get
		End Property

		Protected Overrides Function CreateCustomizationForm(ByVal style As CustomizationFormStyle) As CustomizationForm
			Return New MyCustomizationForm(Me, style)
		End Function
	End Class

	Public Class MyCustomizationForm
		Inherits CustomizationForm
		Public Sub New(ByVal data As PivotGridViewInfoData, ByVal style As CustomizationFormStyle)
			MyBase.New(data, style)
		End Sub

		Protected Overrides Function CreateCustomizationListBox() As CustomizationListBoxBase
			Return New MyFieldCustomizationTreeBox(Me)
		End Function
	End Class

	Public Class MyFieldCustomizationTreeBox
		Inherits PivotCustomizationTreeBox
		Public Sub New(ByVal form As CustomizationForm)
			MyBase.New(form)
		End Sub

		Protected Overrides ReadOnly Property ShowAsTree() As Boolean
			Get
				Return Data.OptionsView.GroupFieldsInCustomizationWindow
			End Get
		End Property

		Public Shadows ReadOnly Property Data() As MyPivotGridViewInfoData
			Get
				Return CType(MyBase.Data, MyPivotGridViewInfoData)
			End Get
		End Property

		Protected Overrides Function CreateFieldsTree() As PivotCustomizationFieldsTree
			Return New MyPivotCustomizationFieldsTree(CustomizationFields)
		End Function

		Protected Overrides Function CreateItemViewInfo(ByVal node As ICustomizationTreeItem) As CustomizationItemViewInfo
			If Data.ShowCustomizationTree Then
				Return New CustomizationTreeItemViewInfo(Me, node)
			Else
				Return New PivotCustomizationListItemViewInfo(Me, CType(node, PivotCustomizationTreeNode), CType(Data.ViewInfo, PivotGridViewInfo))
			End If
		End Function
	End Class

	Public Class MyPivotCustomizationFieldsTree
		Inherits PivotCustomizationFieldsTree
		Public Sub New(ByVal fields As CustomizationFormFields)
			MyBase.New(fields)
		End Sub

		Protected Overrides Function PopulateFields(ByVal _fields As IEnumerable) As List(Of PivotCustomizationTreeNodeBase)
			Dim result As New List(Of PivotCustomizationTreeNodeBase)()
			For Each field As PivotFieldItemBase In _fields
				If field.CanShowInCustomizationForm Then
					result.Add(New MyPivotCustomizationTreeNode(Fields.FieldItems, field.Index))
				End If
			Next field
			Return result
		End Function
	End Class

	Public Class MyPivotCustomizationTreeNode
		Inherits PivotCustomizationTreeNode
		Private Const Measures As String = "[Data Fields]"

		Public Sub New(ByVal fields As PivotFieldItemCollection, ByVal fieldItemIndex As Integer)
			MyBase.New(fields, fieldItemIndex)
			Dim field As PivotFieldItemBase = fields(fieldItemIndex)
			If field.AllowedAreas = PivotGridAllowedAreas.DataArea Then
				InitializeNames(String.Format("{0}.{1}", Measures, field.FieldName))
			Else
				InitializeNames(String.Concat("[Attributes].", field.FieldName))
			End If
		End Sub

		Protected Overrides Function DefineNodeType(ByVal AllNames() As String) As PivotCustomizationTreeNodeType
			If FullName(0) = Measures Then
				Return PivotCustomizationTreeNodeType.Measure
			End If
			Return MyBase.DefineNodeType(AllNames)
		End Function
	End Class
End Namespace