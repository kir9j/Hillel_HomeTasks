﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;


namespace HomeTask_11
{
    public class RandomMessageBuilderModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IDateTimeGenerator>().To<DateTimeGenerator>();
            this.Bind<IGreetingsGenerator>().To<GreetingsGenerator>();
            this.Bind<INamesGenerator>().To<NamesGenerator>();
            this.Bind<IRandomMessageBuilder>().To<RandomMessageBuilder>();
            

        }
    }
}
