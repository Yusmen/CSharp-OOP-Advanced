using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace P01_HarvestingFields
{
    public class Harvest
    {
        public string GetPrivates(string className)
        {
            var classType = Type.GetType($"{typeof(Harvest).Namespace}.{className}");

            var privateFields = classType.GetFields(BindingFlags.Instance|BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var field in privateFields)
            {
                if (field.IsPrivate)
                {
                    stringBuilder.AppendLine($"private {field.FieldType.Name} {field.Name}");
                }
                
            }

            return stringBuilder.ToString();

        }

        public string GetProtected(string className)
        {

            var classType = Type.GetType($"{typeof(Harvest).Namespace}.{className}");

            var privateFields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var field in privateFields)
            {
                if (!field.IsPrivate)
                {
                    stringBuilder.AppendLine($"protected {field.FieldType.Name} {field.Name}");
                }

            }

            return stringBuilder.ToString();

        }

        public string GetPublic(string className)
        {
            var classType = Type.GetType($"{typeof(Harvest).Namespace}.{className}");

            var privateFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var field in privateFields)
            {
                //if (!field.IsPrivate)
                {
                    stringBuilder.AppendLine($"public {field.FieldType.Name} {field.Name}");
                }

            }

            return stringBuilder.ToString();

        }
        public void GetAll(string className)
        {
            Console.WriteLine(GetPrivates(className));
            Console.WriteLine(GetProtected(className));
            Console.WriteLine(GetPublic(className));

        }


    }
}
