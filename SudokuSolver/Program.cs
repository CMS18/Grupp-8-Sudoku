using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] boardArray = new int[9, 9];
            char[] sudokuString = "619030040270061008000047621486302079000014580031009060005720806320106057160400030".ToCharArray();
            FillBoard(boardArray, sudokuString); //Fyller boardArray med strängen
            //solveboard 1 metod för hitta rad, column och block siffror. 1 metod för o jämföra alla siffror med "gissningen"
            //Lägg till metoder här, över printboard
            PrintBoard(boardArray); //Skriver ut brädet, kanske flytta till solveboard metod?
            //Console.ReadKey();
        }//Main

        static void PrintBoard(int[,] boardArray)
        {
            for (int col = 0; col < 9; col++) {
                for (int row = 0; row < 9; row++) {
                    Console.Write(boardArray[col, row] + " ");
                }
                Console.WriteLine();
            }
        }//PrintBoard

        static void FillBoard(int[,] boardArray, char[] sudokuString)
        {
            if (sudokuString.Length == 81) {
                int col = 0;
                int row = 0;
                foreach (var item in sudokuString) {
                    int charConverter = int.Parse(item.ToString());
                    boardArray[col, row] = charConverter;
                    row++;
                    if (row == 9) {
                        col++;
                        row = 0;
                    }
                }
            }
            else Console.WriteLine("Strängen innehåller inte 81 siffror :(");
        }//FillBoard

    }//class
}//namespace
