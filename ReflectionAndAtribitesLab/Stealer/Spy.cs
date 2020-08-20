using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {


        public string StealFieldInfo(string investigatedClass, params string[] requestedFileds)
        {
            Type classType = Type.GetType($"{typeof(Spy).Namespace}.{investigatedClass}");

            var classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            StringBuilder stringBuilder = new StringBuilder();


            var classInstance = Activator.CreateInstance(classType);

            stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (var field in classFields.Where(x => requestedFileds.Contains(x.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return stringBuilder.ToString().Trim();


        }


        public string AnalyzeAcessModifiers(string investigatedClass)
        {
            var classType = Type.GetType($"{typeof(Spy).Namespace}.{investigatedClass}");

            FieldInfo[] classFields = classType
                .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classNonPublicMethods = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var field in classFields)
            {
                stringBuilder.AppendLine($"{field.Name} must be private!");
            }
            foreach (var method in classNonPublicMethods.Where(x => x.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be public!");
            }
            foreach (var method in classPublicMethods.Where(x => x.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be private!");
            }


            return stringBuilder.ToString().Trim();


        }

        public string RevealPrivateMethods(string investigatedClass)
        {

            Type classType = Type.GetType($"{typeof(Spy).Namespace}.{investigatedClass}");

            MethodInfo[] methods = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"All Private Methods of Class: {investigatedClass}");
            stringBuilder.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var method in methods)
            {
                stringBuilder.AppendLine(method.Name);

            }
            return stringBuilder.ToString();

        }

        public string CollectGettersAndSetters(string investigatedClass)
        {
            var classType = Type.GetType($"{typeof(Program).Namespace}.{investigatedClass}");

            MethodInfo[] methods = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var method in methods.Where(x => x.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (var method in methods.Where(x => x.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return stringBuilder.ToString();
        }


    }
}
