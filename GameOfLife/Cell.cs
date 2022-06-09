using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Cell
    {
        public Boolean isAlive =false;
        public readonly List<Cell> neighbors = new List<Cell>();

        private Boolean willBeAlive;

        public void DetermineState()
        {
            int numberLiveNeighbors = neighbors.Where(neighbor => neighbor.isAlive)
                                               .Count();
            if (isAlive)
                willBeAlive = numberLiveNeighbors == 2 || numberLiveNeighbors == 3;
            else
                willBeAlive = numberLiveNeighbors == 3;
        }

        public void Life() 
        {
            isAlive = willBeAlive;
        }
    }
}
