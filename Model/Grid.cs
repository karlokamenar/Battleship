using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Grid
    {
        public Grid(int rows,int columns)
        {
            Rows = rows;
            Columns = columns;
            squares = new Square[rows, columns];
            for (int r =0; r< rows; ++r)
            {
                for(int c = 0; c < columns; ++c)
                {
                    squares[r, c] = new Square(r, c);
                }
            }
        }

        public IEnumerable<IEnumerable<Square>>GetAvailablePlacements(int shipLength)
        {
            List<IEnumerable<Square>> list = GetHorizontalPlacements(shipLength);
            list.AddRange(GetVerticalPlacements(shipLength));
            return list;
        }
        private List<IEnumerable<Square>>GetHorizontalPlacements(int length)
        {
            List<IEnumerable<Square>> result = new List<IEnumerable<Square>>();
            for (int r = 0; r < Rows; ++r)
            {
                int count = 0;
                for (int c = 0; c < Columns; ++c)
                {
                    if (squares[r, c] != null)
                    {
                        ++count;
                        if (count >= length)
                        {
                            List<Square> arr = new List<Square>();
                            for (int c1 = c - length + 1; c1 <= c; ++c1)
                            {
                                arr.Add(squares[r, c1]);
                            }
                            result.Add(arr);
                        }

                    }
                    else
                        count = 0;
                }
            }
            return result;
        }
        public void EliminateSquare(IEnumerable<Square> squares)
        {
            throw new NotImplementedException();
        }
        private List<IEnumerable<Square>> GetVerticalPlacements(int length)
        {
            List<IEnumerable<Square>> result = new List<IEnumerable<Square>>();
            for (int c = 0; c < Rows; ++c)
            {
                int count = 0;
                for (int r = 0; r < Columns; ++r)
                {
                    if (squares[r, c] != null)
                    {
                        ++count;
                        if (count >= length)
                        {
                            List<Square> arr = new List<Square>();
                            for (int r1 = r - length + 1; r1 <= r; ++r1)
                            {
                                arr.Add(squares[r1, c]);
                            }
                            result.Add(arr);
                        }

                    }
                    else
                        count = 0;
                }
            }
            return result;
        }
        public readonly int Rows;
        public readonly int Columns;

        private Square[,] squares;
    }
}
