namespace alqoritm_sualii_20;
class Program
{
    static void Main(string[] args)
    { 
        int[] numbers = { 1, 2, 3, 4, 5,};
        bool silsiledir = true;

        int d=0;
        for (var i = 1; i < numbers.Length; i++)
        {
            if (i == 1)
            {
                d = numbers[i] - numbers[i - 1];
            }

            if ((numbers[i] - numbers[i - 1]) != d)
            {
                silsiledir = false;
                break;
            }




        }
        if (silsiledir)
            Console.WriteLine("ededi silsiledir");
        else
            Console.WriteLine("ededi silsile deyil");


    }
}

