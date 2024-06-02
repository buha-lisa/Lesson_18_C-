
namespace cs18
{
    public class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
    public static class Point3DExtensions
    {
        public static double DistanceTo(this Point3D point, Point3D other)
        {
            double dx = point.X - other.X;
            double dy = point.Y - other.Y;
            double dz = point.Z - other.Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }

        public static void FindMaxDistance(this Point3D[] points)
        {
            double maxDistance = 0;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                    }
                }
            }
            Console.WriteLine($"The maximum distance is {maxDistance}");
        }
    }
}
