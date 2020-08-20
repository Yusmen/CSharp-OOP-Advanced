namespace _03BarracksFactory.Core.Factories
{
    using Contracts;
    using System;
    using System.Reflection;
    using System.Linq;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Assembly assembly = typeof(AppEntryPoint).Assembly;

            Type type = assembly
                .GetTypes()
                .FirstOrDefault(x => x.Name == unitType);

            return (IUnit)Activator.CreateInstance(type);
        }
    }
}
