using SoftwareCraftmanship.DesignPattern.Builder.Library.Enum;

namespace SoftwareCraftmanship.DesignPattern.Builder.Library.Builder
{
    public class VegetarianBriyaniBuilder : BriyaniBuilder
    {
        public override void AddMainIngredient() => briyani.SetMainIngredient("Soya Beans");

        public override void AddVegetables(List<Vegetable> vegetables)
        {
            vegetables.AddRange(
                new List<Vegetable>
                {
                    Vegetable.Peas,
                    Vegetable.Carrot,
                    Vegetable.GreenBeans
                }
            );

            briyani.SetVegetables(vegetables);
        }
    }
}
