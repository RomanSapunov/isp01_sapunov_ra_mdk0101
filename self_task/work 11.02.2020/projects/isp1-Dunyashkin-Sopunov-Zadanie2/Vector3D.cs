using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp1_Dunyashkin_Sopunov_Zadanie2
{
    class Vector3D
    {
        public double X;
        public double Y;
        public double Z;

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Length() // ДЛИНА ВЕКТОРА
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public double ScalarProduct(Vector3D Vector) // СКАЛЯРНОЕ ПРОИЗВЕДЕНИЕ
        {
            return (X * Vector.X + Y * Vector.Y + Z * Vector.Z);
        }

        public Vector3D VectorProduct(Vector3D Vector) // ВЕКТОРНОЕ ПРОИЗВЕДЕНИЕ
        {
            Vector3D res = new Vector3D(0.0, 0.0, 0.0);
            res.X = Y * Vector.Z - Z * Vector.Y;
            res.Y = Z * Vector.X - X * Vector.Z;
            res.Z = X * Vector.Y - Y * Vector.X;

            return res;
        }

        public override string ToString()
        {
            return $"vec(X: {X}, Y: {Y}, Z: {Z})";
        }
    }
}
