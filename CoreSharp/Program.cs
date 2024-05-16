namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;

            while (true)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                string operatorName;
                int size;
                string color;
                string brandName,category;
                decimal price;
                int count;

                #region Operator name validaiton

                while (true)
                {
                    Console.Write("Operator's name : ");
                    operatorName = Console.ReadLine();

                    if (operatorName.Length >= 3 && operatorName.Length <= 15)
                        break;
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Size validation

                while (true)
                {
                    Console.Write("Size : ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50)
                        break;
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Color validation

                while (true)
                {
                    Console.Write("Color : ");
                    color = Console.ReadLine();

                    if (color == "Red" || color == "Black" || color == "Blue")
                        break;
                    else
                        Console.WriteLine("Color dugun daxil edilmeyib");
                }

                #endregion

                #region brand validation
                while (true)
                {
                    Console.Write("Brand : ");
                    brandName = Console.ReadLine();

                    if (brandName == "Gucci" || brandName == "Tommy" || brandName == "Nike")
                        break;
                    else
                        Console.WriteLine("Brand daxil edilmeyib");
                }
                #endregion

                #region Category validation
                while (true)
                {
                    Console.Write("Category : ");
                    category = Console.ReadLine();

                    if (category == "classic" ||category == "sport")
                        break;
                    else
                        Console.WriteLine("Brand daxil edilmeyib");
                }
                #endregion

                #region Price validation
                while (true)
                {
                    Console.Write("Price : ");
                    price =decimal.Parse( Console.ReadLine());

                    if (price>=0 && price<=200)
                        break;
                    else
                        Console.WriteLine("Price duzgun deyil");
                }
                #endregion

                #region count validation
                while (true)
                {
                    Console.Write("Count : ");
                   count = int.Parse(Console.ReadLine());

                    if (count >= 0 && count <= 1000)
                        break;
                    else
                        Console.WriteLine("count duzgun deyil");
                }
                #endregion
                //Short cut to replace all : Ctrl + RR



               

                decimal individualTotal = count * price;
                resultTotal = resultTotal + individualTotal;

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");

                Console.WriteLine("Yeni ayaqqabi elave olunsumu? (Yes, No) (Y, N) ");
                string loopTerminationResult = Console.ReadLine();

                if (loopTerminationResult == "No" || loopTerminationResult == "N")
                {
                    //break based loop control
                    break;

                }
            }


            Console.WriteLine("Result Total : " + resultTotal);

        }
    }
}