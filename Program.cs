using System.Text; 


string userChoice = string.Empty;
do
{
    Console.WriteLine("Bizning uyga vazifalarimiz: \nUyga vazifani kurish uchun darsni tanleng: 1-10:");
    string uyVazifa = Console.ReadLine();

    switch (uyVazifa)
    {
        case "1":
            {
                break;
            }
        case "10":
            {
                Console.WriteLine("Siz 10chi vazifani tanladingiz. \nBizda 10 ta misol bor edi kurish uchun tanleng: \n\t1.1D elementlarning yig‘indisini \n\t2. Eng katta va eng kichik qiymat \n\t3. Juft va toq sonlar \n\t4. O‘rtacha qiymat \n\t5. String teskari aylantirish \n\t6. Harflar sonini hisoblash \n\t7. Palindrom tekshirish \n\t8. StringBuilder bilan birlashtirish \n\t9. String ichidan belgilarni olib tashlash \n\t10. Array + String kombinatsiya");
                string misolRaqami = Console.ReadLine();

                switch (misolRaqami)
                {
                    case "1":
                        SumElements();
                        break;

                    case "2":
                        FindMinAndMax();
                        break;
                    case "3":
                        PrintEvenOdd();
                        break;
                    case "4":
                        CalculateAverage();
                        break;
                    case "5":
                        ReverseString();
                        break;
                    case "6":
                        CountLetters();
                        break;
                    case "7":
                        Console.WriteLine(IsPalindrom());
                        break;
                    case "8":
                        CombineWords();
                        break;
                    case "9":
                        RemoveSpaces();
                        break;
                    case "10":
                        CombineNames();
                        break;

                    default:
                        Console.WriteLine("Bunday misol mavhud emas");
                        break;
                }
                break;
            }

        default: 
            Console.WriteLine("Bunaqa uyga vazifa mavjud emas");
            break;
    }
    
    Console.WriteLine("\nDasturni davom ettirishni xoxlaysizmi: ha/yoq");
    userChoice = Console.ReadLine();

} while (userChoice.ToLower() == "ha"); 


static void SumElements()
{
    Console.WriteLine("Arrayni kiriting 10 ta son:");

    int [] nums = new int[10];
    int result = 0;

    for (int i=0; i< nums.Length; i++)
    {
        Console.Write($"{i + 1}-son: ");

        string strNum = Console.ReadLine();
        int num = Convert.ToInt32(strNum);

        nums[i] = num;
        result+=nums[i];
    }
    
    Console.WriteLine($"Berilgan array: {string.Join(", ", nums)}");
    Console.WriteLine($"Array elementlarining yigindisi: {result}");
}

static void FindMinAndMax()
{
    int[] nums = {1, 2, 5, 8, 4, 9, 7, 10, 6};
    int min = nums[0];
    int max = nums[0];

    for (int i = 1; i<nums.Length; i++)
    {
        if (nums[i] < min) 
            min = nums[i]; 

        if (nums[i] > max) 
            max = nums[i]; 
    }

    Console.WriteLine($"Berilgan array: {string.Join(", ", nums)}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Maximum: {max}");

}

static void PrintEvenOdd()
{
   int[] nums = {1, 2, 5, 8, 4, 9, 7, 10, 6};

   Console.WriteLine($"Berilgan array: {string.Join(", ", nums )}");
   Console.Write("Juft Sonlar: ");

   for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
            Console.Write(nums[i] + " ");
    }

    Console.WriteLine();
    Console.Write("Toq Sonlar:");

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 != 0)
            Console.Write(nums[i] + " ");
    }
}

static void CalculateAverage()
{
    int[] nums = {1, 2, 5, 8, 4, 9, 7, 10, 6};
    double sum = 0;
    
    Console.WriteLine($"Berilgan array: {string.Join(", ", nums )}");

    for (int i = 0; i < nums.Length; i++)
    {
        sum+=nums[i];
    }

    double middle = sum / nums.Length;
    Console.WriteLine($"Array elementlarining urtacha qiymati : {middle}"); 

}

static void ReverseString()
{
    Console.WriteLine("Stringni kiriting: ");

    string slova = Console.ReadLine();

    for (int i = slova.Length - 1; i >= 0; i--)
    {
        Console.Write(slova[i]);
    }
}

static void CountLetters()
{
    Console.WriteLine("Stringni kiriting: ");
    string slova = Console.ReadLine();
    
    string vowels = "aeiouAEIOU";
    int colUnli = 0;
    int colUndosh = 0;

    for(int i = 0; i < slova.Length; i++)
    {
        char letter = slova[i];

        if (vowels.Contains(letter))
            colUnli++;

        else if (char.IsLetter(letter))
            colUndosh++;

    }
    Console.WriteLine($"Unli sonlar : {colUnli}");
    Console.WriteLine($"Undosh sonlar : {colUndosh}");
    
}

static bool IsPalindrom()
{
    Console.WriteLine("Stringni kiriting: ");
    string word = Console.ReadLine();
    
    int boshQismi = 0;
    int oxirgiQismi = word.Length - 1;
    
    while (boshQismi < oxirgiQismi) 
    {
        char left = char.ToLower(word[boshQismi]);
        char right = char.ToLower(word[oxirgiQismi]);
        
        if (left != right) return false;
        
        boshQismi++;
        oxirgiQismi--;
    }
    return true; 
}

static void CombineWords()
{
    StringBuilder words = new StringBuilder();
    
    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"{i}-so'zni kiriting: ");
        string word = Console.ReadLine();

        words.Append(word);
        words.Append(" ");  // probel qo'shish
    }
    
    Console.WriteLine($"\nNatija: {words.ToString()}");
}

static void RemoveSpaces()
{
    Console.Write("Matnni kiriting: ");
    
    string text = Console.ReadLine();
    
    string result = text.Replace(" ", "");

    Console.WriteLine($"Nanija: \n{result}");
}

static void CombineNames()
{
    string[] names = new string[5];

    StringBuilder words = new StringBuilder();
    
    for (int i = 0; i < names.Length; i++)
    {
        Console.Write($"{i+1}-ismni kiriting: ");
        names[i] = Console.ReadLine();
    }
    
    
    for (int i = 0; i < names.Length; i++)
    {
        words.Append(names[i]);
        
        if (i < names.Length - 1)
        {
            words.Append(", ");
        }
    }
    
    Console.WriteLine($"\nNatija: {words.ToString()}");
}