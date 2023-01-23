// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


void Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dis = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *1.0), 0.5);
    Console.Write(dis);

}


int getNum(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double x1 = getNum("Введите первую координату точки A");
double y1 = getNum("Введите вторую координату точки A");
double z1 = getNum("Введите третью  координату точки A");
double x2 = getNum("Введите третью  координату точки B");
double y2 = getNum("Введите третью  координату точки B");
double z2 = getNum("Введите третью  координату точки B");

Distance(x1,y1,z1,
        x2,y2,z2);