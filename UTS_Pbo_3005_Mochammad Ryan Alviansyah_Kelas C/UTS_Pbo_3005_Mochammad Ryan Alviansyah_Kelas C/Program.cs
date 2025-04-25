using System;


public interface PerpustakaanBuku
{
    void Info();
}

public abstract class Buku : PerpustakaanBuku

{
    protected string Judul; protected string Penulis; protected int TahunTerbit; private bool SedangDipinjam;

    public Buku(string judul, string penulis, int tahun)
    {
        Judul = judul;
        Penulis = penulis;
        TahunTerbit = tahun;
        SedangDipinjam = false;
    }

public class Fiksi : Buku
{
    public Fiksi(string judul, string penulis, int tahun) : base(judul, penulis, tahun) 
    { 
    }
}

public class NonFiksi : Buku
{
    public NonFiksi(string judul, string penulis, int tahun) : base(judul, penulis, tahun) 
    {
    }
}

public class Majalah : Buku
{
    public Majalah(string judul, string penulis, int tahun) : base(judul, penulis, tahun)
    { 
    }
}

public class Perpustakaan
{
    private Buku[] semuaBuku = new Buku[];
    private Buku[] bukuDipinjam = new Buku[];
    private int jumlahBuku = 0;
    private int jumlahPinjam = 0;


    public void TampilkanSemuaBuku()
    {
        if (jumlahBuku == 0)
        {
            Console.WriteLine("Belum ada buku.");
            return;
        }

        Console.WriteLine("Daftar Buku:");

    public void PinjamBuku(string judul)
    {
        if (jumlahPinjam >= 3)
        {
            Console.WriteLine("Maksimal 3 buku bisa dipinjam.");
            return;
        }

    public void TampilkanBukuDipinjam()
    {
        if (jumlahPinjam == 0)
        {
            Console.WriteLine("Tidak ada buku yang sedang dipinjam.");
            return;
        }
}

public class Program
{
    public static void Main()
    {
        Perpustakaan perpustakaan = new Perpustakaan();
                {
                    Console.WriteLine("\n=== MENU PERPUSTAKAAN ===");
                    Console.WriteLine("1. Tambah Buku");
                    Console.WriteLine("2. Ubah Judul Buku");
                    Console.WriteLine("3. Lihat Semua Buku");
                    Console.WriteLine("4. Pinjam Buku");
                    Console.WriteLine("5. Kembalikan Buku");
                    Console.WriteLine("6. Lihat Buku yang Dipinjam");
                    Console.WriteLine("0. Keluar");
                    Console.Write("Pilihan Anda: ");
                }



Console.WriteLine("CUMA WRITELINE DOANG HEHEHE")
Console.WriteLine("MENYALA NILAI PBO")