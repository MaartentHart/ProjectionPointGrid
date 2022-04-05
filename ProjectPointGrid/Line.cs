using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPointGrid
{
	public class Line
	{
    private Vector3D unitSphereIntersection1;
    private Vector3D unitSphereIntersection2;
    public Vector3D Point { get; }
    public Vector3D UnitVector { get; }

    public Vector3D UnitSphereIntersection1 => unitSphereIntersection1 ??
    (unitSphereIntersection1 = Point + UnitVector * Math.Sqrt(1 - Point.MagnitudeSquared));

    public Vector3D UnitSphereIntersection2 => unitSphereIntersection2 ??
      (unitSphereIntersection2 = Point - UnitVector * Math.Sqrt(1 - Point.MagnitudeSquared));
      
    public Vector3D UnitSphereIntersectionPositiveZ => UnitSphereIntersection1.Z >= 0 ? UnitSphereIntersection1 : UnitSphereIntersection2;

    public Line(Vector3D point, Vector3D unitVector)
    {
      UnitVector = unitVector;
      double distance = unitVector.Dot(point);
      Vector3D shift = unitVector * distance;
      Point = point - shift;
    }

    /// <summary>
    /// Calculates the intersection between 2 lines. 
    /// There is no check for coplanarness and parallelness. That is your responsibility. 
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public Vector3D Intersect(Line other)
    {
      //https://math.stackexchange.com/questions/270767/find-intersection-of-two-3d-lines/271366

      if (DistanceTo(other.Point) == 0)
        return other.Point;
      if (other.DistanceTo(Point) == 0)
        return Point;

      Vector3D e = UnitVector;
      Vector3D f = other.UnitVector;
      Vector3D c = Point;
      Vector3D d = other.Point;

      Vector3D offset = e * f.Cross(d - c).Magnitude / f.Cross(e).Magnitude;

      Vector3D a = c + offset;
      Vector3D b = c - offset;


      double aDist = DistanceTo(a) + other.DistanceTo(a);
      double bDist = DistanceTo(b) + other.DistanceTo(b);

      return aDist < bDist ? a : b;
    }

    public double DistanceTo(Vector3D point)
    {
      if (point == Point)
        return 0;
      Vector3D dif = Point - point;
      double dot = Math.Abs(dif.UnitVector.Dot(UnitVector));

      if (dot > 1)
        if (dot > 1.01)
          throw new Exception("Error in calculating distance.");
        else
          return 0;

      return dif.Magnitude * Math.Sqrt(1 - dot * dot);
    }
  }
}
