using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_BarraksWars.Core.InputCommands
{
    public abstract class Command : IExecutable
    {

        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;


        protected Command(string[] data,IRepository repository,IUnitFactory unitFactory)
        {
            Data = data;
            Repository = repository;
            UnitFactory = unitFactory;
        }

        public IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            set { unitFactory = value; }
        }


        public string[] Data
        {
            get { return data; }
            set { data = value; }
        }

       

        public IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }



        public abstract string Execute();
        
    }
}
