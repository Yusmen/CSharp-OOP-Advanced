 namespace P01_HarvestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Harvest harvest = new Harvest();
            while (true)
            {
                string input = Console.ReadLine();

                if (input=="HARVEST")
                {
                    break;
                }

                if (input == "protected")
                {
                    Console.WriteLine(harvest.GetProtected("HarvestingFields"));
                }
                else if (input == "private")
                {
                    Console.WriteLine(harvest.GetPrivates("HarvestingFields"));
                }
                else if (input == "public")
                {
                    Console.WriteLine(harvest.GetPublic("HarvestingFields"));
                }
                else if (input == "all") 
                {
                    harvest.GetAll("HarvestingFields");
                }
            }

            

            
        }
    }
}
