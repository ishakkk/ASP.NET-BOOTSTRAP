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
   public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI(OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) values(@p1,@p2,@p3,@p4,@p5) ",Baglanti.bgl);
            if(komut1.Connection.State!=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1",parametre.Ad);
            komut1.Parameters.AddWithValue("@p2",parametre.Soyad);

            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTO);

            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            return komut1.ExecuteNonQuery();
            
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd = new SqlCommand("select *from TBLOGRENCI", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OGRID"].ToString());
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.FOTO = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut = new SqlCommand("delete from TBLOGRENCI where OGRID=@p1",Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",parametre);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand cmd = new SqlCommand("select *from TBLOGRENCI where OGRID=@p1", Baglanti.bgl);
            cmd.Parameters.AddWithValue("@p1",id);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.FOTO = dr["OGRFOTO"].ToString();
                ent.SIFRE = dr["OGRSIFRE"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        } 
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("update TBLOGRENCI set OGRAD=@p1,OGRSOYAD=@p2" +
                ",OGRNUMARA=@p3,OGRFOTO=@p4,OGRSIFRE=@p5 where OGRID=@p6",Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1",deger.Ad);
            komut.Parameters.AddWithValue("@p2", deger.Soyad);
            komut.Parameters.AddWithValue("@p3", deger.Numara);
            komut.Parameters.AddWithValue("@p4", deger.FOTO);
            komut.Parameters.AddWithValue("@p5", deger.SIFRE);
            komut.Parameters.AddWithValue("@p6", deger.Id);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
