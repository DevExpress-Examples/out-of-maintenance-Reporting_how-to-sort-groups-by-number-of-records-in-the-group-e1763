namespace WindowsApplication1 {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.nwindDataSet1 = new WindowsApplication1.nwindDataSet();
            this.categoryProductsTableAdapter = new WindowsApplication1.nwindDataSetTableAdapters.CategoryProductsTableAdapter();
            this.GroupCategoryCounter = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
            this.Detail.Height = 25;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 30;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 30;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F);
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryProductsTableAdapter
            // 
            this.categoryProductsTableAdapter.ClearBeforeFill = true;
            // 
            // GroupCategoryCounter
            // 
            this.GroupCategoryCounter.DataMember = "CategoryProducts";
            this.GroupCategoryCounter.DataSource = this.nwindDataSet1;
            this.GroupCategoryCounter.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.GroupCategoryCounter.Name = "GroupCategoryCounter";
            this.GroupCategoryCounter.GetValue += new DevExpress.XtraReports.UI.GetValueEventHandler(this.GroupCategoryCounter_GetValue);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("GroupCategoryCounter", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending),
            new DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.Height = 25;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.Turquoise;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CategoryProducts.CategoryName", "")});
            this.xrLabel1.Location = new System.Drawing.Point(33,0);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,96F);
            this.xrLabel1.Size = new System.Drawing.Size(425,25);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.Turquoise;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CategoryProducts.GroupCategoryCounter", "")});
            this.xrLabel2.Location = new System.Drawing.Point(550,0);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,96F);
            this.xrLabel2.Size = new System.Drawing.Size(100,25);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CategoryProducts.ProductName", "")});
            this.xrLabel3.Location = new System.Drawing.Point(0,0);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,96F);
            this.xrLabel3.Size = new System.Drawing.Size(317,25);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.GroupHeader1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.GroupCategoryCounter});
            this.DataAdapter = this.categoryProductsTableAdapter;
            this.DataMember = "CategoryProducts";
            this.DataSource = this.nwindDataSet1;
            this.Version = "9.1";
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private nwindDataSet nwindDataSet1;
        private WindowsApplication1.nwindDataSetTableAdapters.CategoryProductsTableAdapter categoryProductsTableAdapter;
        private DevExpress.XtraReports.UI.CalculatedField GroupCategoryCounter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
