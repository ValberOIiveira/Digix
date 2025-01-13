using System.Security.Cryptography.X509Certificates;

namespace Aula_25_OO_Struct
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        //Constructor é obrigatório para todos os campos e ter parametros nele
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }


        public double Distancia(Point p)
        {
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }
    }


    public struct Player
    {

        public string Name { get; set; }
        public Point Position { get; set; }

        public Player(string name, Point position)
        {
            Name = name;
            Position = position;

        }

        public void Move(Point newPosition)
        {
            Position = newPosition;
        }
    }
}