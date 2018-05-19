using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraPivotGrid.ViewInfo;
using DevExpress.XtraPivotGrid.Customization;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using DevExpress.XtraEditors.Customization;

namespace DXSample {
    public class MyPivotGridControl : PivotGridControl {
        public MyPivotGridControl() : base() { }
        public MyPivotGridControl(PivotGridViewInfoData viewInfoData) : base(viewInfoData) { }

        protected override PivotGridViewInfoData CreateData() {
            return new MyPivotGridViewInfoData(this);
        }
    }

    public class MyPivotGridViewInfoData : PivotGridViewInfoData {
        public MyPivotGridViewInfoData() : base() { }
        public MyPivotGridViewInfoData(IViewInfoControl control) : base(control) { }

        public new bool ShowCustomizationTree { get { return OptionsView.GroupFieldsInCustomizationWindow; } }

        protected override CustomizationForm CreateCustomizationForm(CustomizationFormStyle style) {
            return new MyCustomizationForm(this, style);
        }
    }

    public class MyCustomizationForm : CustomizationForm {
        public MyCustomizationForm(PivotGridViewInfoData data, CustomizationFormStyle style) : base(data, style) { }

        protected override CustomCustomizationListBoxBase CreateCustomizationListBox() {
            return new MyFieldCustomizationTreeBox(this);
        }
    }

    public class MyFieldCustomizationTreeBox : FieldCustomizationTreeBox {
        public MyFieldCustomizationTreeBox(CustomizationForm form) : base(form) { }

        protected override bool ShowAsTree { get { return Data.OptionsView.GroupFieldsInCustomizationWindow; } }

        public new MyPivotGridViewInfoData Data { get { return (MyPivotGridViewInfoData)base.Data; } }

        protected override PivotCustomizationFieldsTree CreateFieldsTree() {
            return new MyPivotCustomizationFieldsTree(CustomizationFields);
        }

        protected override PivotCustomizationTreeNodeViewInfo CreateItemViewInfo(PivotCustomizationTreeNode node) {
            if (Data.ShowCustomizationTree)
                return new PivotCustomizationTreeNodeViewInfoTreeItem(this, node, Data.ActiveLookAndFeel, Data.PaintAppearancePrint.FieldHeader);
            else return new PivotCustomizationTreeNodeViewInfoListItem(this, node, (PivotGridViewInfo)Data.ViewInfo);
        }
    }

    public class MyPivotCustomizationFieldsTree : PivotCustomizationFieldsTree {
        public MyPivotCustomizationFieldsTree(CustomizationFormFields fields) : base(fields) { }

        protected override List<PivotCustomizationTreeNodeBase> PopulateFields(IEnumerable fields) {
            List<PivotCustomizationTreeNodeBase> result = new List<PivotCustomizationTreeNodeBase>();
            foreach (PivotGridField field in fields)
                if (field.CanShowInCustomizationForm)
                    result.Add(new MyPivotCustomizationTreeNode(field));
            return result;
        }
    }

    public class MyPivotCustomizationTreeNode : PivotCustomizationTreeNode {
        private const string Measures = "[Data Fields]";

        public MyPivotCustomizationTreeNode(PivotGridField field) :base(field) {
            if (field.AllowedAreas == PivotGridAllowedAreas.DataArea) {
                InitializeNames(string.Format("{0}.{1}", Measures, field.FieldName));
            } else InitializeNames(string.Concat("[Attributes].", field.FieldName));
        }

        protected override PivotCustomizationTreeNodeType DefineNodeType(string[] AllNames) {
            if (FullName[0] == Measures) return PivotCustomizationTreeNodeType.Measure;
            return base.DefineNodeType(AllNames);
        }
    }
}