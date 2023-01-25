﻿using static System.Console;
Clear();

// Ввод размера массива.

WriteLine("Введите количество рядов : ");
int row = Convert.ToInt32(ReadLine());
WriteLine("Введите количество столбцов : ");
int column = Convert.ToInt32(ReadLine());
Clear();

// Словарь элементов.

string[,] word = new string[row, column];
var dict = new Dictionary<int, string>()
{
{1, "one"}, {2, "two"}, {3, "oops"},
{4, "cat"}, {5, "three"}, {6, "four"},
{7, "doctor"}, {8,"hi"}, {9, "six" },
{10, "my"}, {11, "away"}, {12, "day" },
{13, "apple"}, {14, "last"}, {15, "man" },
{16, "old"}, {17, "home"}, {18, "wo" },
{19, "car"}, {20, "work"}, {21, "-22"},
{22, "-5"}, {23, "computer science"}, {24, "44"},
{25, "word"}, {26, "333"}, {27, "hello"},
{28, "Russia"}, {29, "Denmark"}, {30, "Kazan"}
};


// Метод создания Двухмерного массива.

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"  {word[i, j]}  ");
        }
        WriteLine();
    }
}

// Метод Рандомного заполнения Двухмерного массива элементами из словаря.

void FileArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                int q = new Random().Next(1, 24);
                word[i, j] = dict[q];
            }
        }
    }
}