using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140018
{
    /// <summary>
    /// main class
    /// </summary>
    /// <remarks>class Matematika dapat membuat operasi pembagian (Bagi), perkalian (Kali), pengurangan (Kurang), penjumlahan (Tambah)</remarks>
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        /// <summary>
        /// operasi pembagian
        /// </summary>
        /// <param name="a">angka pertama dalam operasi pembagian</param>
        /// <param name="b">angka kedua yang akan dibagi dengan angka pertama</param>
        /// <returns>hasil dari pembagian angka pertama dan angka kedua</returns>
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Secara default 
                //Throw new Exception(ex.Message) Pesan error secara default 
                //Throw new FaultException("Pesan Salah"); Untuk meloloskan pesan eror yang dikirim ke client 

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        /// <summary>
        /// operasi perkalian
        /// </summary>
        /// <param name="a">angka pertama dalam operasi perkalian</param>
        /// <param name="b">angka kedua yang akan dikali dengan angka pertama</param>
        /// <returns>hasil dari perkalian angka pertama dan angka kedua</returns>
        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Secara default 
                //Throw new Exception(ex.Message) Pesan error secara default 
                //Throw new FaultException("Pesan Salah"); Untuk meloloskan pesan eror yang dikirim ke client 

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        /// <summary>
        /// operasi pengurangan
        /// </summary>
        /// <param name="a">angka pertama dalam operasi pengurangan</param>
        /// <param name="b">angka kedua yang akan dikurang dengan angka pertama</param>
        /// <returns>hasil dari pengurangan angka pertama dan angka kedua</returns>
        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Secara default 
                //Throw new Exception(ex.Message) Pesan error secara default 
                //Throw new FaultException("Pesan Salah"); Untuk meloloskan pesan eror yang dikirim ke client 

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }

        /// <summary>
        /// operasi penjumlahan
        /// </summary>
        /// <param name="a">angka pertama dalam operasi penjumlahan</param>
        /// <param name="b">angka kedua yang akan ditambah dengan angka pertama</param>
        /// <returns>hasil dari penjumlahan angka pertama dan angka kedua</returns>
        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Secara default 
                //Throw new Exception(ex.Message) Pesan error secara default 
                //Throw new FaultException("Pesan Salah"); Untuk meloloskan pesan eror yang dikirim ke client 

                MathFault mf = new MathFault();
                mf.Kode = "Inputan yang anda masukkan salah";
                mf.Pesan = "Masukkan input yang benar";
                throw new FaultException<MathFault>(mf);
            }
        }
        //TKoordinat:nama methodnya, a,b = input seperti int. 
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil 
        /// <summary>
        /// operasi Koordinat
        /// </summary>
        /// <param name="a">angka pertama ax dan bx dalam operasi koordinat</param>
        /// <param name="b">angka kedua ay dan by yang akan dijumlah dengan angka pertama ax dan bx</param>
        /// <returns>hasil dari koordinat angka pertama dan angka kedua </returns>
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            Koordinat hasil = new Koordinat();
            hasil.X = a.X + b.X;
            hasil.Y = a.Y + b.Y;
            return hasil;
        }

    }
}