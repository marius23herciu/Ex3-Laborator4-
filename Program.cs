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

            int[,] matrice1 = CitireMatrice();
            int[,] matrice2 = CitireMatrice();

            if (matrice1.GetLength(1) != matrice2.GetLength(0))
            {
                Console.WriteLine("Numarul de coloane al primei matrice trebuie sa fie egal cu numarul de linii al celei de a doua matrice");
                return;
            }

            int[,] rezultatInmultire = InmultireMatrice(matrice1, matrice2);
            Console.WriteLine("Matricea rezultata din inmulitire este: ");
            for (int i = 0; i < rezultatInmultire.GetLength(0); i++)
            {
                for (int j = 0; j < rezultatInmultire.GetLength(1); j++)
                {
                    Console.Write(rezultatInmultire[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] CitireMatrice()
        {
            Console.WriteLine("Introduceti numarul de linii pentru matrice: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de coloane pentru matrice: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrice = new int[n, m];
            Console.WriteLine("Introduceti " + n * m + " numere pentru matrice:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrice[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrice;
        }
        static int[,] InmultireMatrice(int[,] matrice1, int[,] matrice2)
        {
            int[,] rezultat = new int[matrice1.GetLength(0), matrice2.GetLength(1)];
            for (int i = 0; i < matrice1.GetLength(0); i++)
            {
                for (int j = 0; j < matrice2.GetLength(1); j++)
                {
                    int suma = 0;
                    for (int k = 0; k < matrice2.GetLength(0); k++)
                    {
                        suma += matrice1[i, k] * matrice2[k, j];
                    }
                    rezultat[i, j] = suma;
                }
            }

            return rezultat;
        }
    }
}
