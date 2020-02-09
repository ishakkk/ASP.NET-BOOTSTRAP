using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

namespace YazokuluDerler
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;
           if(Page.IsPostBack==false)
            { 
            List<EntityOgrenci> OgrList = BLLOgrenci.BLLLDetay(x);
            TxtAd.Text = OgrList[0].Ad.ToString();
            TxtSoyad.Text = OgrList[0].Soyad.ToString();
            TxtNumara.Text = OgrList[0].Numara.ToString();
            TxtFoto.Text = OgrList[0].FOTO.ToString();
            TxtSifre.Text = OgrList[0].SIFRE.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.SIFRE = TxtSifre.Text;
            ent.FOTO = TxtFoto.Text;
            ent.Numara = TxtNumara.Text;
            ent.Id = Convert.ToInt32(TxtId.Text);
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListele.aspx");
        }
    }
}