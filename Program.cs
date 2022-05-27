using System;

namespace Ex3_Laborator4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 3 dificultate ridicata
            //Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile n m,
            //respectiv n, m. Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la
            //tastaura.Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
            //rezultatul.

            Console.WriteLine("Introduceti numarul de linii pentru fiecare matrice: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de coloane pentru fiecare matrice: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrice1 = new int[n, m];
            Console.WriteLine("Introduceti " + n * m + " numere pentru prima matrice:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrice1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] matrice2 = new int[n, m];
            Console.WriteLine("Introduceti " + n * m + " numere pentru a doua matrice:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrice2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int produs = ProdusElemente(matrice1, matrice2);
            Console.WriteLine("Produsul elementelor celor 2 matrici este: " + produs);

            InmultireElementeCuAceleasiCoordonate(matrice1, matrice2, n, m);
            Console.WriteLine("Matricea rezultata din inmulitirea elementelor cu aceleasi coordonate este: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrice2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int ProdusElemente(int[,] matrice1, int[,] matrice2)
        {
            int produs = 1;
            foreach (int numar in matrice1)
            {
                produs *= numar;
            }
            foreach (int numar in matrice2)
            {
                produs *= numar;
            }

            return produs;
        }
        static int[,] InmultireElementeCuAceleasiCoordonate(int[,] matrice1, int[,] matrice2, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrice2[i, j] = matrice1[i, j] * matrice2[i, j];
                }
            }

            return matrice2;
        }
    }
}
