Console.WriteLine("=== PROGRAM HITUNG LUAS PERSEGI PANJANG ===");

// 1. Input Data
Console.Write("Masukkan Panjang: ");
int panjang = Convert.ToInt32(Console.ReadLine());

Console.Write("Masukkan Lebar: ");
int lebar = Convert.ToInt32(Console.ReadLine());

// 2. Proses Perhitungan
int luas = panjang * lebar;

// 3. Tampilkan Hasil
Console.WriteLine("------------------------------------------");
Console.WriteLine("Luas Persegi Panjang adalah: " + luas);