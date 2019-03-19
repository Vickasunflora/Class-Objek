using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            // mengeset nilai properties objek saya dan kamu
            saya.Nim = "18.11.2342";
            saya.Nama = "Vicka Rizky Sunflora";
            saya.Ipk = 3.92f;

            kamu.Nim = "18.11.2372";
            kamu.Nama = "Dina Rahma";
            kamu.Ipk = 3.75f;

            // memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
