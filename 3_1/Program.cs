using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vänligen ange din ålder så vi vet om du kan delta");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age >= 19)
            {
                Console.WriteLine("Du är för gammal för att vara med.");
            }
            else if (age < 16)
            {
                Console.WriteLine("Du är för ung för att delta i denna tävlingen.");
            }
            else
            {
                Console.WriteLine("Du får vara med i tävlingen!");
            }
        }
        else
        {
            Console.WriteLine("det är en ogiltig ålder. Var god ange en giltig ålder.");
        }
    }
}