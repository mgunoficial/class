internal class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        double num1, num2;
        Console.Write("Birinci ededi daxil edin: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
            Console.WriteLine("eded daxil edin.");

        Console.Write("İkinci ededi daxil edin: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
            Console.WriteLine("eded daxil edin.");

        char operation;
        Console.Write("emeliyyatı secin (+, -, *, /): ");
        operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;

        switch (operation)
        {
            case '+': result = calculator.Add(num1, num2); break;
            case '-': result = calculator.Subtract(num1, num2); break;
            case '*': result = calculator.Multiply(num1, num2); break;
            case '/': result = calculator.Divide(num1, num2); break;
            default:
                Console.WriteLine("Yanlıs emeliyyat! Yeniden cehd edin.");
                return;
        }
        Console.WriteLine("Netice: " + result);
    }
}


public class Animal
{
    public string name;
    public string breed;
    public string color;
    public string age;

    public Animal(string name, string breed, string color, string age)
    {
        this.name = name;
        this.breed = breed;
        this.color = color;
        this.age = age;

    }

    public void GetAnimalDetails()
    {
        Console.WriteLine($"The {name} is {breed} and {color} and also {age}");
    }
}
public class Building
{
    public string name;
    public int height;
    public int area;
    public string address;
    public int size;

    public Building(string name, int height, int area, string address)
    {
        this.name = name;
        this.height = height;
        this.area = area;
        this.address = address;
        this.size = height * area;
    }
    public void GetBuildingDetails()
    {
        Console.WriteLine($"The {name} height is {height}, area is {area}, and address is {address}");
    }
    public void GetBuildingSize()
    {
        Console.WriteLine($"The size is {size}");
    }
}
public class Student
{
    public string name;
    public string surname;
    public int age;
    public int[] homeworkGrades;
    public int[] projectGrades;
    public int[] quizGrades;
    public int finalGrade;
    public bool[] continuity;

    public Student(string name,
                   string surname,
                   int age,
                   int[] homeworkGrades,
                   int[] projectGrades,
                   int[] quizGrades,
                   int finalGrade,
                   bool[] continuity)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.homeworkGrades = homeworkGrades;
        this.projectGrades = projectGrades;
        this.quizGrades = quizGrades;
        this.finalGrade = finalGrade;
        this.continuity = continuity;
    }
    public int HomeworkGrade()
    {
        int sum = 0;
        foreach (int grade in homeworkGrades)
        {
            sum += grade;
        }
        return sum * 20 / (homeworkGrades.Length * 100);
    }
    public int ProjectGrade()
    {
        int sum = 0;
        foreach (int grade in projectGrades)
        {
            sum += grade;
        }
        return sum * 20 / (projectGrades.Length * 100);
    }
    public int QuizGrade()
    {
        int sum = 0;
        foreach (int grade in quizGrades)
        {
            sum += grade;
        }
        return sum * 20 / (quizGrades.Length * 100);
    }

    public int FinalGrade()
    {
        return finalGrade * 30 / 100;
    }
    public int Continuity()
    {
        int attendedClasses = 0;
        foreach (bool attendance in continuity)
        {
            if (attendance)
            {
                attendedClasses++;
            }
        }
        return attendedClasses * 10;
    }
    public string GraduationStatus(int totalGrade)
    {
        if (totalGrade >= 95)
        {
            return "HighHonour";
        }
        else if (totalGrade >= 85)
        {
            return "Honour";
        }
        else if (totalGrade >= 65)
        {
            return "Normal";
        }
        else
        {
            return "Fail";
        }
    }
    public int CalculateTotalGrade()
    {
        int totalGrade = HomeworkGrade() + ProjectGrade() + QuizGrade() + FinalGrade() + Continuity();
        return totalGrade;
    }
}
public class Gun
{
    public int MaxCapacity;
    public int CurrentBullet;
    public int TotalBullet;
    public string Type;

    public Gun(int maxCapacity, int currentBullet, int totalBullet, string type)
    {
        MaxCapacity = maxCapacity;
        if (currentBullet > maxCapacity)
        {
            Console.WriteLine("Current bullet count cannot be more then max capacity.");
            return;
        }
        CurrentBullet = currentBullet;
        TotalBullet = totalBullet;
        Type = type;
    }

    public void Fire()
    {
        if (Type == "assault")
        {
            Console.WriteLine("Bütün güllələr atılır!");
            CurrentBullet = 0;
        }
        else if (Type == "sniper")
        {
            if (CurrentBullet > 0)
            {
                Console.WriteLine("Bir güllə atılır!");
                CurrentBullet -= 1;
            }
            else
            {
                Console.WriteLine("Güllə yoxdur!");
            }
        }
        else
        {
            Console.WriteLine("Yanlış silah növü!");
        }
    }

    public void Reload()
    {
        if (TotalBullet > 0)
        {
            CurrentBullet = Math.Min(MaxCapacity, TotalBullet);
            TotalBullet -= CurrentBullet;
            Console.WriteLine("Silah reload edildi.");
        }
        else
        {
            Console.WriteLine("Yeterli güllə yoxdur.");
        }
    }

    public string GetStatus()
    {
        return $"Hal-hazırda güllə sayı: {CurrentBullet}, Qalan güllə sayı: {TotalBullet}, Növü: {Type}";
    }
}
public class Calculator
{
    public double Add(double x, double y)
    {
        return x + y;
    }

    public double Subtract(double x, double y)
    {
        return x - y;
    }

    public double Multiply(double x, double y)
    {
        return x * y;
    }

    public double Divide(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("Error");
            return 0;
        }
    }
}