namespace StrategyDesignPattern
{

    public abstract class StrategySearch : IStrategy
    {

        public void Solve()
        {
            while (true)
            {
                this.PreProcess();
                if (this.Search())
                {
                    break;
                }
                this.PostProcess();
            }
        }

        public abstract void PreProcess();
        public abstract bool Search();
        public abstract void PostProcess();
    }

}