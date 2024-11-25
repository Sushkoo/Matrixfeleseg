using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Hola : AbsMatrix, IMatrixOperations
    {

        public void Add(AbsMatrix addMatrix)
        {
            for(int rowIndex = 0; rowIndex<RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex<ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] += addMatrix[rowIndex, columnIndex];
                }
            }
        }

        public bool Equals(AbsMatrix other)
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = other[rowIndex, columnIndex];
                }
            }
            return true;
            
        }

        public void Fill(double value)
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for(int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = value;
                }
            }
        }

        public void FillRandomFloat(double start, double end)
        {
            Random random = new Random();


            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = (float)(random.NextDouble()*(end-start)+start);
                }
            }
        }

        public void FillRandomInt(int start, int end)
        {
            Random random = new Random();
            

            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = random.NextInt64(start,end);
                }
            }
        }

        public void RotateToDown()
        {
            for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
            {
                double temp = this[columnIndex, 0];
                for (int rowIndex = 1; rowIndex < RowCount; rowIndex++)
                {
                    this[columnIndex, rowIndex + 1] = this[columnIndex, rowIndex];
                }
                this[columnIndex, ColumnCount + 1] = temp;
            }
        }

        public void RotateToLeft()
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                double temp = this[rowIndex, 0];
                for (int columnIndex = 1; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex-1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, ColumnCount-1] = temp;
            }
        }

        public void RotateToTop()
        {

            for(int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
            {
                double temp = this[columnIndex, 0];
                for(int rowIndex = 1; rowIndex < RowCount; rowIndex++)
                {
                    this[columnIndex, rowIndex - 1] = this[columnIndex, rowIndex];
                }
                this[columnIndex, ColumnCount - 1] = temp;
            }


        }

        public void RotatetToRight()
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                double temp = this[rowIndex, 0];
                for (int columnIndex = 1; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex + 1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, ColumnCount + 1] = temp;
            }
        }

        public void Sub(AbsMatrix subMatrix)
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] -= subMatrix[rowIndex, columnIndex];
                }
            }
        }
    }
}
