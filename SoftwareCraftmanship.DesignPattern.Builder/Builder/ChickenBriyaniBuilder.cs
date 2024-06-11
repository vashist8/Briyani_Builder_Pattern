namespace SoftwareCraftmanship.DesignPattern.Builder.Library.Builder
{
    public class ChickenBriyaniBuilder : BriyaniBuilder
    {
        public override void AddMainIngredient() => briyani.SetMainIngredient("Chicken");
    }
}
