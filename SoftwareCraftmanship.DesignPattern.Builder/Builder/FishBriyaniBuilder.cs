namespace SoftwareCraftmanship.DesignPattern.Builder.Library.Builder
{
    public class FishBriyaniBuilder : BriyaniBuilder
    {
        public override void AddMainIngredient() => briyani.SetMainIngredient("Fish");
    }
}
