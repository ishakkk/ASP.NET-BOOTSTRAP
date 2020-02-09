using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
namespace YazokuluDerler
{
    public partial class OgrenciListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrlist = BLLOgrenci.BLLListele();
            Repeater1.DataSource = ogrlist;
            Repeater1.DataBind();
        }
    }
} 