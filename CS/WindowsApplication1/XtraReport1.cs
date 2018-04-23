using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace WindowsApplication1 {
    public partial class XtraReport1: DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        private void GroupCategoryCounter_GetValue(object sender,GetValueEventArgs e) {
            string cat = ((DataRowView)e.Row)["CategoryName"].ToString();
            int count = 0;
            if(!ht.ContainsKey(cat)) {
                count = nwindDataSet1.CategoryProducts.Select("CategoryName = '" + cat + "'").Length;
                ht.Add(cat,count);
            } else 
                count = Convert.ToInt32(ht[cat]);
            
            e.Value = count;
        }

    }
}
