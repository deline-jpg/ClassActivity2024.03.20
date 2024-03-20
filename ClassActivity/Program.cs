class Program
{
    static void Main(string[] args)
    {
        //Declare arrays
        string[] studentName = new string[4];
        string[] studentGender = new string[4];
        string[] studentDOB = new string[4];

        //display student info
        Console.WriteLine("Student Information:");
        for (int i = 0; i < studentName.Length; i++)
        {
            Console.WriteLine($"Student {i + 1}: ");

            //prompts user to enter their name
            Console.Write($"Name: ");
            studentName[i] = Console.ReadLine();

            //prompts user to enter their gendder
            Console.Write($"Gender: ");
            studentGender[i] = Console.ReadLine();

            //promps user to enter their date of birth
            Console.Write($"DOB: ");
            studentDOB[i] = Console.ReadLine();

        }


    }
}