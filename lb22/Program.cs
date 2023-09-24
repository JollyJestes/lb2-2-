//178
//Проверить, не является ли последовательность
//элементов массива а[0; n] перестановкой натуральных чисел 0, 1, 2, 3, ..., n.
class Program

{
    static bool IsPermutationOfNaturalNumbers(int[] a)
    {
        int n = a.Length;
        bool[] used = new bool[n];

        for (int i = 0; i < n; i++)
        {
            if (a[i] < 0 || a[i] >= n || used[a[i]])
            {
                return false;
            }
            used[a[i]] = true;
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Введите длину массива: ");
        if (int.TryParse(Console.ReadLine(), out int length) && length > 0)
        {
            int[] a = new int[length];

            // Заполняем массив случайными числами от 0 до length - 1
            for (int i = 0; i < length; i++)
            {
                a[i] = i;
            }

            // Перемешиваем массив
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int j = random.Next(i, length);
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }

            bool isPermutation = IsPermutationOfNaturalNumbers(a);

            Console.WriteLine("Массив:");
            foreach (int element in a)
            {
                Console.Write(element + " ");
            }

            if (isPermutation)
            {
                Console.WriteLine("\nДанная последовательность является перестановкой натуральных чисел.");
            }
            else
            {
                Console.WriteLine("\nДанная последовательность НЕ является перестановкой натуральных чисел.");
            }
        }
        else
        {
            Console.WriteLine("Некорректная длина массива.");
        }

        Console.ReadLine();
    }
}