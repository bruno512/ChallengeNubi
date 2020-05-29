
namespace ChallengeNubi.Core.Enumerations
{
    /// <summary>
    /// This Class is used to define all the constants at the entire solution
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// This class is used for country constants
        /// </summary>
        public class Countries
        {            
            public const string Argentina = "AR";
            public const string Brasil = "BR";
            public const string Colombia = "CO";                        
        }

        /// <summary>
        /// This Class is used to define all the constants in the Country SubModule
        /// </summary>
        public class Country
        {                        
            public const string RequestCountry = "classified_locations/countries/";
        }

        /// <summary>
        /// This Class is used to define all the constants in the Currency SubModule
        /// </summary>
        public class Currency
        {
            public const string RequestCurrencies = "currencies/";
            public const string RequestCurrency_Conversions = "currency_conversions/search?from={0}&to=USD";
            public const string MessageSuccess = "Los archivos json y CSV fueron guardados correctamente en: {0}";
        }

        /// <summary>
        /// This class is used to store the BaseAdress
        /// </summary>
        public class BaseAdress
        {
            public const string MercadoLibre = "https://api.mercadolibre.com/";
        }

        /// <summary>
        /// This class is used to save errors
        /// </summary>
        public class Errors
        {
            public const string ErrorEmpty = "No se obtuvieron resultados.";            
        }
    }
}
