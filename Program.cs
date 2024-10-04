//Main won't work, but standalone code will
int[] numbers = GenerateNumbers();
Reverse(numbers);
PrintNumbers(numbers);

static int[] GenerateNumbers() {
    int[] result = new int[10];
    Random gen = new Random();

    for (int i = 0; i < 10; ++i) {
        result[i] = gen.Next(10)+1;
    }

    return result;
}

static void Reverse(int[] nums) {
    Stack<int> stack = new Stack<int>();
    for (int i = 0; i < nums.Length; ++i) {
        stack.Push(nums[i]);
    }
    for (int i = 0; i < nums.Length; ++i) {
        nums[i] = stack.Pop();
    }
}

static void PrintNumbers(int[] nums) {
    Console.Write("["); 
    for (int i = 0; i < nums.Length; ++i) {
        if (i < nums.Length - 1)
        {
            Console.Write(nums[i] + ", ");
        }
        else {
            Console.Write(nums[i]);
        }
    }
    Console.Write("]\n");
}