namespace CodeSamples.SOLID.S04_InversionOfControl_IoC
{
    public class Duck
    {
        private IDuckQuack _quack;
        private IDuckFly _fly;

        public Duck(IDuckQuack quack, IDuckFly fly)
        {
            this._quack = quack;
            this._fly = fly;
        }

        public void Quack()
        {
            _quack.Quack();
        }

        public void Fly()
        {
            _fly.Fly();
        }
    }
}
