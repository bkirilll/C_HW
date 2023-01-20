int[] coords1 = new int[3];
Console.Write("Введите координаты x 1-ой точки: ");
coords1[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y 1-ой точки: ");
coords1[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z 1-ой точки: ");
coords1[2] = Convert.ToInt32(Console.ReadLine());

int[] coords2 = new int[3];
Console.Write("Введите координаты x 2-ой точки: ");
coords2[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y 2-ой точки: ");
coords2[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z 2-ой точки: ");
coords2[2] = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(coords2[0] - coords1[0], 2) + Math.Pow(coords2[1] - coords1[1], 2) + Math.Pow(coords2[2] - coords1[2], 2));
System.Console.WriteLine($"Расстояние между точками = {Math.Round(dist, 2)}");