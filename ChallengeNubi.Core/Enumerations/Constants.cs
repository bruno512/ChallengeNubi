
namespace ChallengeNubi.Core.Enumerations
{
    /// <summary>
    /// This Class is used to define all the constants at the entire solution
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// This Class is used to define all the constants in the Country SubModule
        /// </summary>
        public class Country
        {
            
            public const string Argentina = "AR";

            public const string Brasil = "BR";

            public const string Colombia = "CO";                        
        }             
        
        public class CountryRepository
        {
            public const string BaseAdress = "https://api.mercadolibre.com/";
            public const string Request = "classified_locations/countries/";
        }
    }
}
