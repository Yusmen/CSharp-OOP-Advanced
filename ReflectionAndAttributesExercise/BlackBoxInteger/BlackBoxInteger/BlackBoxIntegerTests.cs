namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;
    using System.Linq;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type classType = typeof(BlackBoxInteger);

            var classInstance = Activator.CreateInstance(classType,true);

            var methods = classType
               .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                var tokens = input.Split('_');
                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                var method = methods.FirstOrDefault(x => x.Name == methodName);

                method.Invoke(classInstance, new object[] { value});

                var field = classType.GetField ("innerValue",BindingFlags.Instance|BindingFlags.NonPublic);


                Console.WriteLine(field.GetValue(classInstance));

            }

           
      

                
        }
    }
}
