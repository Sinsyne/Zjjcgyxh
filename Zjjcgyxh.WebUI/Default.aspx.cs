using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zjjcgyxh.WebUI.DataClasses;

namespace Zjjcgyxh.WebUI
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dc = new dcCategoryDataContext();
            //dc.t_Category.InsertOnSubmit(new t_Category
            //{
                
            //});
            //dc.SubmitChanges();
            var lst = dc.t_Category;
            this.GridView1.DataSource = lst;
            this.GridView1.DataBind();
        }
    }
}