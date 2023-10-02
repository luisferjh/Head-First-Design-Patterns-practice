using SimUDuckApp.Classes;
using SimUDuckApp.Subtypes;

namespace SimUDuckApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();

            Duck model = new ModelDuck();
            model.performFly();
            model.performQuack();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}