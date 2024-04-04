using System.ComponentModel.DataAnnotations;

namespace Mycloth_website.Models
{
    public class CompositeViewModel
    {
        public IndexViewModel IndexViewModel { get; set; }
        public MenCategory MenCategory { get; set; }

        public ShoesCategory ShoesCategory { get; set; }

        public ElectronicsCategory ElectronicsCategory { get; set; }

        public FrunitureCategory FrunitureCategory { get; set;}

        public CleaningCategory CleaningCategory { get; set; }

        public tvCategory tvCategory { get; set; }
        public ToysCategory ToysCategory { get; set; }
        public MobileCategory MobileCategory { get; set; }
    }
}
