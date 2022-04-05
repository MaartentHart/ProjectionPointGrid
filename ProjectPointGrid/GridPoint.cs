using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPointGrid
{
	public class GridPoint
	{
		private Vector3D point;
		public Vector3D Point => point ?? (point = CalculatePoint());
    public GridParameters Parameters => Index.Parameters;
    public PointIndex Index { get; }
    public int Generation { get; }
    public GridPoint(int generation, long index)
		{
      Generation = generation;
      Index = new PointIndex(generation, index); 
    }

    private Vector3D CalculatePoint()
    {
      if (Index.IsPole1)
        point = Icosahedron.Pole1;
      else if (Index.IsPole2)
        point = Icosahedron.Pole2;
      else
      {
        PointIndex index = Index;

        double width = Parameters.Width;
        double sliceColumn = index.Column / width;
        double sliceRow = index.Row / width;

        double sliceFromB;
        double sliceFromC;
        long baseTriangle = index.Tile * 2;

        if (index.Row > index.Column)
        {
          baseTriangle += 1;
          sliceFromB = 1 - sliceColumn;
          sliceFromC = sliceRow;
        }
        else
        {
          sliceFromB = sliceColumn;
          sliceFromC = 1 - sliceRow;
        }

        Vector3D fromB = Paper.GetCutPoint(sliceFromB);
        Vector3D fromC = Paper.GetCutPoint(sliceFromC);

        Plane bPlane = new Plane(Paper.p, Paper.p + new Vector3D(0, 1, 0), fromB);
        Plane cPlane = new Plane(Paper.p, Paper.p + new Vector3D(0, 1, 0), fromC);

        bPlane = bPlane.RotateTop240;
        cPlane = cPlane.RotateTop120;

        Vector3D baseGridPoint = bPlane.Intersection(cPlane).UnitSphereIntersectionPositiveZ;
        Vector3D projectionPointGridPoint = Icosahedron.Triangles[baseTriangle].ToWorld(baseGridPoint);
        point = projectionPointGridPoint;
      }
      return point; 
    }
	}
}
