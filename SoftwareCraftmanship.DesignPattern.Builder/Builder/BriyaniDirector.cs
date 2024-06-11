using SoftwareCraftmanship.DesignPattern.Builder.Library.Enum;

namespace SoftwareCraftmanship.DesignPattern.Builder.Library.Builder
{
    public class BriyaniDirector
    {
        private BriyaniBuilder BrianiBuilder;

        private readonly List<Vegetable> _vegetables = [Vegetable.FriedOnions, Vegetable.Potato];
        private readonly List<Spice> _spices = [Spice.Cloves, Spice.Cardamon, Spice.Masala, Spice.Cinammon, Spice.Chilli];

        public void ChangeBuilder(BriyaniBuilder builder) => BrianiBuilder = builder;

        public Model.Briyani CookBriani()
        {
            BrianiBuilder.AddRice(2);
            BrianiBuilder.AddVegetables(_vegetables);
            BrianiBuilder.AddSpices(_spices);
            BrianiBuilder.AddMainIngredient();
            var briyani = BrianiBuilder.GetResult();
            return briyani;
        }

        public Model.Briyani CookBrianiWithoutVegetables()
        {
            BrianiBuilder.AddRice(1);
            BrianiBuilder.AddSpices(_spices);
            BrianiBuilder.AddMainIngredient();
            var briyani = BrianiBuilder.GetResult();
            return briyani;
        }
    }
}
