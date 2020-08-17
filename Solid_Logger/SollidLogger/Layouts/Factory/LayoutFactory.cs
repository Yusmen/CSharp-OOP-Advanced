using SollidLogger.Layouts.Contracts;
using SollidLogger.Layouts.Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SollidLogger.Layouts.Factory
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            string typeLowerCase = type.ToLower();

            switch (typeLowerCase)
            {
                case "simplelayout":return new SimpleLayout();
                case "xmllayout":return new XmlLayout();
                default:
                    throw new ArgumentException("Invalid layout type");
            }
        }
    }
}
