namespace StrategyDesignPattern
{

    public abstract class StrategySolution : IStrategy
    {

        public void Solve()
        {
            this.Start();
            while (this.NextTry() && !this.IsSolution()) { }
            this.Stop();
        }

        public abstract void Start();
        public abstract bool NextTry();
        public abstract bool IsSolution();
        public abstract void Stop();

    }
    
}