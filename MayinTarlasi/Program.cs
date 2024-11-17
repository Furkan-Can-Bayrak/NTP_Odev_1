using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinTarlasi
{
    class Program
    {
        // Oyun boyutları
        const int SIZE = 20; // 20x20 boyutlarında oyun
        const int MINE_COUNT = 50; // Toplam 50 mayın olacak
        static char[,] board = new char[SIZE, SIZE]; // Oyuncuya gösterilecek tablo
        static bool[,] mines = new bool[SIZE, SIZE]; // Mayınların yerlerini tutan tablo

        static void Main(string[] args)
        {
            // Oyunu başlat
            InitializeBoard();
            PlaceMines();
            PlayGame();
            Console.Read();

        }

        // Oyun tahtasını başlatma
        static void InitializeBoard()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    board[i, j] = '-'; // Tüm hücreler başlangıçta kapalı ('-')
                }
            }
        }

        // Rastgele mayın yerleştirme
        static void PlaceMines()
        {
            Random rand = new Random();
            int placedMines = 0;

            while (placedMines < MINE_COUNT)
            {
                int row = rand.Next(SIZE); // Rastgele satır seç
                int col = rand.Next(SIZE); // Rastgele sütun seç

                // Eğer bu hücrede daha önce mayın yoksa, mayın yerleştir
                if (!mines[row, col])
                {
                    mines[row, col] = true;
                    placedMines++;
                }
            }
        }

        // Oyunu oynama fonksiyonu
        static void PlayGame()
        {
            bool gameOver = false;
            int cellsRevealed = 0;
            int totalSafeCells = (SIZE * SIZE) - MINE_COUNT; // Toplam açılması gereken güvenli hücre sayısı

            // Oyun devam ettiği sürece döngü
            while (!gameOver)
            {
                Console.Clear();
                PrintBoard();

                // Kullanıcıdan hücre seçmesini iste
                Console.WriteLine("\nBir hücre seçin (Satır ve Sütun girin, örneğin: 5 7):");
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                // Geçerli bir hücre seçildi mi kontrol et
                if (row < 0 || row >= SIZE || col < 0 || col >= SIZE)
                {
                    Console.WriteLine("Geçersiz seçim! Tekrar deneyin.");
                    continue;
                }

                // Hücre zaten açılmışsa kullanıcıya bildir
                if (board[row, col] != '-')
                {
                    Console.WriteLine("Bu hücre zaten açılmış. Başka bir hücre seçin.");
                    continue;
                }

                // Seçilen hücrede mayın var mı kontrol et
                if (mines[row, col])
                {
                    Console.Clear();
                    Console.WriteLine("BOOOM! Mayına bastınız. Oyun bitti!");
                    gameOver = true;
                }
                else
                {
                    // Güvenli hücreyi aç
                    int adjacentMines = CountAdjacentMines(row, col);
                    board[row, col] = adjacentMines > 0 ? adjacentMines.ToString()[0] : ' ';

                    // Güvenli hücre sayısını artır
                    cellsRevealed++;

                    // Tüm güvenli hücreler açıldıysa oyunu kazandınız
                    if (cellsRevealed == totalSafeCells)
                    {
                        Console.Clear();
                        PrintBoard();
                        Console.WriteLine("\nTebrikler! Tüm güvenli hücreleri açtınız. Oyunu kazandınız!");
                        gameOver = true;
                    }
                }
            }
        }

        // Komşu mayınları sayma fonksiyonu
        static int CountAdjacentMines(int row, int col)
        {
            int mineCount = 0;

            // Komşu hücrelerin kontrol edilmesi
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newRow = row + i;
                    int newCol = col + j;

                    // Sınırların dışında değilse ve mayın varsa sayacı artır
                    if (newRow >= 0 && newRow < SIZE && newCol >= 0 && newCol < SIZE && mines[newRow, newCol])
                    {
                        mineCount++;
                    }
                }
            }

            return mineCount;
        }

        // Tahtayı ekrana yazdırma fonksiyonu
        static void PrintBoard()
        {
            Console.WriteLine("   " + string.Join(" ", new string(' ', SIZE).Select((_, i) => i % 10))); // Sütun numaraları
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(i.ToString("D2") + " "); // Satır numaraları
                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
