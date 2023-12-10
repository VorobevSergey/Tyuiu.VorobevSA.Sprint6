using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.VorobevSA.Sprint6.Task7.V21.Lib
{
    public class DataService : ISprint6Task7V21

    {
        public int[,] GetMatrix(string path)
        {
            // Чтение матрицы из файла или другого источника данных

            // Пример чтения матрицы из CSV файла
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);

                    // Изменение значений в восьмом столбце не равных 5 на -1
                    if (j == 7 && matrix[i, j] != 5)
                    {
                        matrix[i, j] = -1;
                    }
                }
            }

            return matrix;
        }
    }
}
