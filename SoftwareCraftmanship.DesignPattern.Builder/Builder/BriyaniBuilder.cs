using SoftwareCraftmanship.DesignPattern.Builder.Library.Enum;
using SoftwareCraftmanship.DesignPattern.Builder.Library.Model;

namespace SoftwareCraftmanship.DesignPattern.Builder.Library.Builder
{
    public abstract class BriyaniBuilder
    {
        protected Briyani briyani;

        public BriyaniBuilder() => briyani = new Briyani();

        public void AddRice(decimal rice) => briyani.SetRice(rice);

        public abstract void AddMainIngredient();

        public virtual void AddVegetables(List<Vegetable> vegetables) => briyani.SetVegetables(vegetables);

        public void AddSpices(List<Spice> spices) => briyani.SetSpices(spices);

        public void Reset() => briyani = new Briyani();

        public Briyani GetResult()
        {
            var briyani = this.briyani;
            Reset();
            return briyani;
        }
    }
}
