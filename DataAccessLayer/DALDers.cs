using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
namespace DataAccessLayer
{
  public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand cmd = new SqlCommand("select *from TBLDERSLER", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.ID = Convert.ToInt32(dr["DERSID"].ToString());
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.MIN =Convert.ToInt32(dr["DERSMINKONT"].ToString());
                ent.MAX =Convert.ToInt32(dr["DERSMAKSKONT"].ToString());  
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBASVURUFORM(OGRENCIID,DERSIS) values(@p1,@p2)");
            komut.Parameters.AddWithValue("@p1",parametre.BASOGRID);
            komut.Parameters.AddWithValue("@p2",parametre.BASDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
