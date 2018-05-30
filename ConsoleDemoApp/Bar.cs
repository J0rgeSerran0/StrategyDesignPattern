using StrategyDesignPattern;
using System;

namespace ConsoleDemoApp
{
    public class Bar : StrategySearch
    {
        private int state = 1;

        public override void PreProcess()
        {
            Console.WriteLine("PreProcess  ");
        }

        public override void PostProcess()
        {
            Console.WriteLine("PostProcess  ");
        }

        public override bool Search()
        {
            Console.WriteLine("Search-" + this.state++ + "  ");
            return this.state == 3 ? true : false;
        }
    }

}