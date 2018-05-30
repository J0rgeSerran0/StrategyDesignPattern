using StrategyDesignPattern;
using System;

namespace ConsoleDemoApp
{

    public class Foo : StrategySolution
    {
        private int state = 1;

        public override void Start()
        {
            Console.WriteLine("Start");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop");
        }

        public override bool NextTry()
        {
            Console.WriteLine("NextTry-" + this.state++ + "  ");
            return true;
        }

        public override bool IsSolution()
        {
            Console.WriteLine("IsSolution-" + (this.state == 3) + "  ");
            return (this.state == 3);
        }
    }

}