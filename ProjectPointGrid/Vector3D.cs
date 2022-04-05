using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPointGrid
{
	public class Vector3D
	{
    private static readonly double R120 = Math.Sqrt(3.0 / 4.0);
    public double X { get; }
		public double Y { get; }
		public double Z { get; }


    public double MagnitudeSquared => X * X + Y * Y + Z * Z;
    public double Magnitude => Math.Sqrt(MagnitudeSquared);
    public Vector3D UnitVector => this / Magnitude;

    public Vector3D RotateTop120 => new Vector3D(Y * R120 - X / 2, -X * R120 - Y / 2, Z);
    public Vector3D RotateTop240 => new Vector3D(-Y * R120 - X / 2, X * R120 - Y / 2, Z);

    public Vector3D(double x = 0, double y = 0, double z = 0)
		{
			X = x;
			Y = y;
			Z = z;
		}

    public static Vector3D operator +(Vector3D a, Vector3D b)
    {
      return new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    }

    public static Vector3D operator -(Vector3D a, Vector3D b)
    {
      return new Vector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
    }

    public static Vector3D operator *(Vector3D a, double b)
    {
      return new Vector3D(a.X * b, a.Y * b, a.Z * b);
    }

    public static Vector3D operator *(Vector3D a, Vector3D b)
    {
      return new Vector3D(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    public static Vector3D operator /(Vector3D a, double b)
    {
      return new Vector3D(a.X / b, a.Y / b, a.Z / b);
    }

    public static Vector3D operator -(Vector3D a)
    {
      return new Vector3D(-a.X, -a.Y, -a.Z);
    }

    public Vector3D Cross(Vector3D other)
    {
      return new Vector3D(
        Y * other.Z - Z * other.Y,
        Z * other.X - X * other.Z,
        X * other.Y - Y * other.X
        );
    }

    public double Dot(Vector3D other)
    {
      return X * other.X + Y * other.Y + Z * other.Z;
    }

    public override string ToString()
    {
      return X.ToString() + ", " + Y.ToString() + ", " + Z.ToString();
    }

  }
}
