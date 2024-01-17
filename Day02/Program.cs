namespace Day02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Quiz Time
            // No 1
            /*QuizTime.RemoveDuplicate("bananas");
            QuizTime.RemoveDuplicate("lalalamama");
            QuizTime.RemoveDuplicate("romairama");*/

            // No 2
            /*QuizTime.Capitalize("codeid bootcamp");
            QuizTime.Capitalize("black pink venom");*/

            // No 3
            /*string[] input1 = { "code", "java", "cool" };
            string[] input2 = { "black", "pink", "venom" };
            QuizTime.CapitalizeExcept(input1, "java");
            QuizTime.CapitalizeExcept(input2, "venom");*/

            // No 4
            /*QuizTime.isBraces("(())");
            QuizTime.isBraces("()()");
            QuizTime.isBraces("((()");*/

            // No 5
            /*int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 1, 10 };
            QuizTime.FindMinMax(numbers);*/

            // No 6
            /*int[] arr1 = { 5, 3, 4, 2, 6, 7, 8, 9, 1, 10 };
            int[] arr2 = { 1, 22, 3, 4, 5, 10, 7, 8, 9, 49 };
            QuizTime.FindMinRange(arr1,0, 10 );
            QuizTime.FindMinRange(arr1, 0, 7);
            QuizTime.FindMaxRange(arr2, 0, 10);
            QuizTime.FindMaxRange(arr2, 2, 7);*/

            // No 7
            /*int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 2, 4, 6, 1, 8 };
            QuizTime.EvenOddOrder(arr1);
            QuizTime.EvenOddOrder(arr2);*/

            // No 8
            /*int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 3, 2, 1 };
            int[] arr3 = { 9 };
            int[] arr4 = { 1, 2, 3, 9 };
            QuizTime.PlusOne(arr1);
            QuizTime.PlusOne(arr2);
            QuizTime.PlusOne(arr3);
            QuizTime.PlusOne(arr4);*/

            // No 9
            /*int[] inputArr = { 12, 15, 1, 5, 20 };
            QuizTime.RotateArray(inputArr, 3);*/


            // Quiz Time Matrix
            // No 1
            int n = 7;
            /*int[,] matrix1 = QuizTime.MatrixNo1(n);
            QuizTime.ShowMatrix(matrix1);*/

            // No 2
            /*int[,] matrix2 = QuizTime.MatrixNo2(n);
            QuizTime.ShowMatrix(matrix2);*/

            // No 3
            /*int[,] matrix3 = QuizTime.MatrixNo3(n);
            QuizTime.ShowMatrix(matrix3);*/


            // No 4
            int[,] matrix4 = QuizTime.MatrixNo4(n);
            QuizTime.ShowMatrix(matrix4);

            // No 5
            //QuizTime.MatrixNo5();


            // Matrix
            /*var matrix = Matrix.FillRandomMatrix(5, 5);
            Matrix.DisplayMatrix(matrix);*/

            /*var matrixDiag = Matrix.MatrixDiagonal(7, 7);
            Matrix.DisplayMatrix(matrixDiag);*/

            // Array
            /*var numbers = Array.InitArrayInteger(7);
            Array.DisplayArrayInt(numbers);

            var sum = Array.SumTotalArray(numbers);
            Console.WriteLine(sum);

            Console.WriteLine();

            var max = Array.FindMaxElement(numbers);
            Console.WriteLine(max);
            Console.WriteLine(numbers.Max());

            var indexOfMax = Array.FindMaxIndex(numbers);
            Console.WriteLine(indexOfMax);

            Console.WriteLine();

            var targetArr = Array.CopyArray(numbers);
            Array.DisplayArrayInt(targetArr);

            Console.WriteLine();

            var targetArr2 = Array.CopyArray(numbers);
            Array.DisplayArrayInt(targetArr2);*/

            //Array.InitArrayInteger(7);
            //Array.IntroArray();
        }
    }
}
