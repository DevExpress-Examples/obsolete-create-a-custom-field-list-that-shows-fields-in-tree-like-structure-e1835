<!-- default file list -->
*Files to look at*:

* [MyPivotGridControl.cs](./CS/Q236810/MyPivotGridControl.cs) (VB: [MyPivotGridControl.vb](./VB/Q236810/MyPivotGridControl.vb))
<!-- default file list end -->
# OBSOLETE: Create a custom Field List that shows fields in tree-like structure
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1835)**
<!-- run online end -->


<p><strong>Starting with version 12.1 the XtraPivotGrid control provides the required functionality by default. Use the </strong><a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_DisplayFoldertopic"><strong><u>PivotGridFieldBase.DisplayFolder</u></strong></a><strong> property to group fields in the customization form. Please refer to the corresponding help topic for additional details.</strong><strong> </strong><strong>In addition, it is possible to customize node creation logic as it is described in the </strong><a href="https://www.devexpress.com/Support/Center/p/E4235">How to change the field grouping and sort order in the Field List</a><strong> </strong><strong>example.</strong></p><p>When the PivotGridControl is bound to the OLAP cube, the Field List can group fields by measures and dimensions and represent them in tree-like structure. This example demonstrates how to create your own Field List that can display data in this manner for the standard data source.</p><p>For basic information on how to create the custom Field List for the PivotGridControl, please refer to the <a href="https://www.devexpress.com/Support/Center/p/S19641">S19641</a> suggestion. To enable the required functionality, create the FieldCustomizationTreeBox descendant and override its ShowAsTree property, to return true even if the PivotGridControl is bound to the standard (not OLAP) data source. Also, hide the PivotGridViewInfoData.ShowCustomizationTree property and implement your own in the same manner as the FieldCustomizationTreeBox.ShowAsTree property, and override the FieldCustomizationTreeBox.CreateItemViewInfo method to return an appropriate ViewInfo type.</p><p>Finally, inherit from the PivotCustomizationTreeNode class. Within the constructor, call the InitializeNames method. If you need the processed field to be in the Measures group, add the "[Measures]." prefix to the field's FieldName (you can override the DefineNodeType method, and use your own prefix), and pass the result as a parameter to the InitializeNames method. If you need the processed field to be Attribute, add the "[GroupName]." prefix to the field's name, where GroupName is any string. Nodes with identical group names will be grouped together. If you need the field to be the Dimension, simply do nothing in the constructor.</p>

<br/>


