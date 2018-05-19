namespace Q236810 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.myPivotGridControl1 = new DXSample.MyPivotGridControl();
            this.nwindDataSet = new Q236810.nwindDataSet();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new Q236810.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myPivotGridControl1
            // 
            this.myPivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.myPivotGridControl1.DataSource = this.salesPersonBindingSource;
            this.myPivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountry,
            this.fieldProductName,
            this.fieldCategoryName,
            this.fieldQuantity,
            this.fieldDiscount,
            this.fieldSalesPerson});
            this.myPivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myPivotGridControl1.Name = "myPivotGridControl1";
            this.myPivotGridControl1.OptionsCustomization.AllowFilter = false;
            this.myPivotGridControl1.Size = new System.Drawing.Size(402, 273);
            this.myPivotGridControl1.TabIndex = 0;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.nwindDataSet;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // fieldCountry
            // 
            this.fieldCountry.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            this.fieldCountry.FieldName = "Country";
            this.fieldCountry.Name = "fieldCountry";
            this.fieldCountry.Visible = false;
            // 
            // fieldProductName
            // 
            this.fieldProductName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 0;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDiscount.Caption = "Discount";
            this.fieldDiscount.FieldName = "Discount";
            this.fieldDiscount.Name = "fieldDiscount";
            this.fieldDiscount.Visible = false;
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea)
                        | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldSalesPerson.AreaIndex = 1;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 273);
            this.Controls.Add(this.myPivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyPivotGridControl myPivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private Q236810.nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiscount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson;


    }
}

