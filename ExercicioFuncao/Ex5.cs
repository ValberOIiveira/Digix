namespace exfunc5{
    public class Ex5 {


        private static void RecebeGiraMatriz(int [,] matriz) {
            for (int i = 0; i < matriz.GetLength(0) / 2; i++) {
                for (int j = i; j < matriz.GetLength(1) - i - 1; j++) {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[matriz.GetLength(0) - 1 - j, i];
                    matriz[matriz.GetLength(0) - 1 - j, i] = matriz[matriz.GetLength(0) - 1 - i, matriz.GetLength(1) - 1 - j];
                    matriz[matriz.GetLength(0) - 1 - i, matriz.GetLength(1) - 1 - j] = matriz[j, matriz.GetLength(1) - 1 - i];
                    matriz[j, matriz.GetLength(1) - 1 - i] = temp;
                }
            }
        }

        public static void ExibeMatriz(int[,] matriz)
        {
            Console.WriteLine("Matriz rotacionada 90 graus no sentido horário:");
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }


        
        public static void Main() {
            int[,] matriz = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };


            RecebeGiraMatriz(matriz);
            ExibeMatriz(matriz);
        }
    }
}