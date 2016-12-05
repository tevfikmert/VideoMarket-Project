using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarketProjesi
{
    class cFilm
    {
        private int _filmNo;
        private string _filmAd;
        private int _filmTurNo;
        private string _yonetmen;
        private string _oyuncular;
        private string _ozet;
        private int _miktar;

        #region Properties
        public int FilmNo
        {
            get
            {
                return _filmNo;
            }

            set
            {
                _filmNo = value;
            }
        }

        public string FilmAd
        {
            get
            {
                return _filmAd;
            }

            set
            {
                _filmAd = value;
            }
        }

        public int FilmTurNo
        {
            get
            {
                return _filmTurNo;
            }

            set
            {
                _filmTurNo = value;
            }
        }

        public string Yonetmen
        {
            get
            {
                return _yonetmen;
            }

            set
            {
                _yonetmen = value;
            }
        }

        public string Oyuncular
        {
            get
            {
                return _oyuncular;
            }

            set
            {
                _oyuncular = value;
            }
        }

        public string Ozet
        {
            get
            {
                return _ozet;
            }

            set
            {
                _ozet = value;
            }
        }

        public int Miktar
        {
            get
            {
                return _miktar;
            }

            set
            {
                _miktar = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(cGenel.connStr);

        public void FilmleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select FilmNo, FilmAd, Filmler.FilmTurNo,TurAd,  Yonetmen, Oyuncular, Ozet, Miktar from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo where Varmi=1", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public void FilmleriGetirByAdaGore(string AdaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select FilmNo, FilmAd, Filmler.FilmTurNo,TurAd,  Yonetmen, Oyuncular, Ozet, Miktar from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo where Varmi=1 and FilmAd like @AdaGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }

        public bool StokGuncelleBySatisEkle(int FilmNo, int Adet)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Filmler set Miktar=Miktar - @Adet where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); 
            }
            catch (SqlException ex)  
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }

        public bool StokGuncelleBySatisIptal(int FilmNo, int Adet)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Filmler set Miktar=Miktar + @Adet where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); 
            }
            catch (SqlException ex)  
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public bool StokGuncelleBySatisDegistir(int FilmNo, int Adet,int ilkAdet)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Filmler set Miktar=Miktar + @ilkAdet - @Adet where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            comm.Parameters.Add("@ilkAdet", SqlDbType.Int).Value = ilkAdet;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); 
            }
            catch (SqlException ex)  
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public void FilmleriGetirBySorgulama(string AdaGore, string TureGore, string YonetmeneGore, string OyuncularaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select FilmNo, FilmAd, Filmler.FilmTurNo,TurAd, Yonetmen, Oyuncular, Ozet, Miktar from Filmler inner join FilmTurleri on Filmler.FilmTurNo = FilmTurleri.FilmTurNo where Varmi=1 and FilmAd like @AdaGore + '%' and TurAd like @TureGore + '%' and Yonetmen like @YonetmeneGore + '%' and Oyuncular like '%' + @OyuncularaGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@TureGore", SqlDbType.VarChar).Value = TureGore;
            comm.Parameters.Add("@YonetmeneGore", SqlDbType.VarChar).Value = YonetmeneGore;
            comm.Parameters.Add("@OyuncularaGore", SqlDbType.VarChar).Value = OyuncularaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public bool FilmKontrol(string Film, string Yonetmen)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from Filmler where FilmAd = @FilmAd and Yonetmen=@Yonetmen", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = Film;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = Yonetmen;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;
            dr.Close();
            conn.Close();
            return Varmi;
        }
        public bool FilmKontrol(string Film, string Yonetmen, int FilmNo)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from Filmler where FilmAd = @FilmAd and Yonetmen=@Yonetmen and FilmNo != @FilmNo", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = Film;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = Yonetmen;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
                Varmi = true;
            dr.Close();
            conn.Close();
            return Varmi;
        }
        public bool FilmEkle(cFilm f)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Filmler (FilmAd, FilmTurNo, Yonetmen, Oyuncular, Ozet, Miktar) values(@FilmAd, @FilmTurNo, @Yonetmen, @Oyuncular, @Ozet, @Miktar)", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = f._miktar;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); 
            }
            catch (SqlException ex)  
            {
                string hata = ex.Message;            
            }
            finally { conn.Close();}    
            return Sonuc;
        }
        public bool FilmGuncelle(cFilm f)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Filmler set FilmAd=@FilmAd, FilmTurNo=@FilmTurNo, Yonetmen=@Yonetmen, Oyuncular=@Oyuncular, Ozet=@Ozet, Miktar=@Miktar where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = f._miktar;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = f._filmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); 
            }
            catch (SqlException ex)  
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }    
            return Sonuc;
        }
        public bool FilmSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Filmler set Varmi=0 where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); 
            }
            catch (SqlException ex)  
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }    
            return Sonuc;
        }
    }
}
