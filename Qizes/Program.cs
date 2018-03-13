using System;

class Furniture
{

    string type;
    int year;
    string material;

    public string TYPE
    {
        get { return type; }
        set { type = value; }
    }

    public int YEAR
    {
        get { return year; }
        set { year = value; }
    }

    public string MATERIAL
    {
        get { return material; }
        set { material = value ; }
    }

    public Furniture() {

        type = "small";
        year = 2017;
        material = "marble";
    }

    public string DETERMINING(string m) {

        if (material == "plastic")
            return "Big";

        else if (material == "wood")
            return "Large";

        else
            return "Not Furniture";
    }

    public bool isAvailable(int y) {

        if (year == y)
            return true;
        else
            return false;

    }

}


class Program
    {
        static void Main(string[] args)
        {

            int tempYear;
            string tempMaterial;

            Furniture furn = new Furniture();

            Console.WriteLine("Enter The Year: ");
            tempYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Material: ");
            tempMaterial = Console.ReadLine();


            furn.MATERIAL = tempMaterial;
            furn.YEAR = tempYear;

            string finalType = furn.DETERMINING(furn.MATERIAL);
            bool finalYear = furn.isAvailable(furn.YEAR);

            Console.WriteLine("\n====FURNITURE===\n");
           
            Console.WriteLine("\n\nYear = {0}", finalYear);
            Console.WriteLine("Material = {0}", tempMaterial);
            Console.WriteLine("Type = {0}", finalType);
            Console.ReadKey();



        }
   }

