using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_problems.Problems
{
    public class AntonAndPolyhedrons
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine()!);
            int totalFaces = 0;
            for (int i = 0; i < n; i++)
            {
                string polyhedron = Console.ReadLine()!;
                switch (polyhedron)
                {
                    case "Tetrahedron":
                        totalFaces += 4;
                        break;
                    case "Cube":
                        totalFaces += 6;
                        break;
                    case "Octahedron":
                        totalFaces += 8;
                        break;
                    case "Dodecahedron":
                        totalFaces += 12;
                        break;
                    case "Icosahedron":
                        totalFaces += 20;
                        break;
                }
            }
            Console.WriteLine(totalFaces);
        }
    }
}
