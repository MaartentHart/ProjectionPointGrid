using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPointGrid
{
	public class GridParameters
	{
		public const int TileCount = 10; 
		public int Generation { get; }

    /// <summary>
    /// The amount of cell rows or cell columns per tile. 
    /// </summary>
    public readonly long Width;
    /// <summary>
    /// The amount of cells per tile (and the amount of subtriangles per base triangle). 
    /// </summary>
    public readonly long TileSize;

    /// <summary>
    /// The amount of cells in the entire grid. 
    /// </summary>
    public readonly long CellCount;
    public readonly long TriangleCount;
    public readonly long PointCount;

    public readonly long Pole1PointIndex;
    public readonly long Pole2PointIndex;

    private static readonly List<GridParameters> gridParameters = new List<GridParameters>(); 

    private GridParameters(int generation)
		{
			Generation = generation;
      Width = 1L << Generation;
      TileSize = 1L << (2 * Generation);
      CellCount = TileCount * TileSize;
      TriangleCount = CellCount * 2;
      PointCount = CellCount + 2;
      Pole1PointIndex = CellCount;
      Pole2PointIndex = CellCount + 1;
    }

    public static GridParameters GetGridParameters(int generation)
    {
      while (gridParameters.Count <= generation)
        gridParameters.Add(new GridParameters(gridParameters.Count));
      return gridParameters[generation]; 
    }
	}
}
