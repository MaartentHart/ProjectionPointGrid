using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPointGrid
{
	public class Plane
	{
		private Vector3D nearestToOrigin;
		public Vector3D NearestToOrigin => nearestToOrigin ?? (nearestToOrigin = UnitVector * D);
		public Plane RotateTop120 => new Plane(UnitVector.RotateTop120, D);
		public Plane RotateTop240 => new Plane(UnitVector.RotateTop240, D);
		public Vector3D UnitVector { get; }
		public double D { get; }

		public Plane(Vector3D unitVector, double distance)
		{
			UnitVector = unitVector;
			D = distance;
		}

		public Plane(Vector3D a, Vector3D b, Vector3D c)
		{
			UnitVector = (a - b).Cross(c - b).UnitVector;
			D = a.UnitVector.Dot(UnitVector) * a.Magnitude;
		}

		public Line Intersection(Plane other)
		{
			Vector3D sharedVector = UnitVector.Cross(other.UnitVector).UnitVector;
			Line line1 = new Line(NearestToOrigin, sharedVector.Cross(UnitVector).UnitVector);
			Line line2 = new Line(other.NearestToOrigin, sharedVector.Cross(other.UnitVector).UnitVector);
			Vector3D intersectionPoint = line1.Intersect(line2);
			return new Line(intersectionPoint, sharedVector);
		}
	}
}
