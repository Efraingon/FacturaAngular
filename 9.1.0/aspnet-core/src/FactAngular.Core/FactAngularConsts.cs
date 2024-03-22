using FactAngular.Debugging;

namespace FactAngular
{
    public class FactAngularConsts
    {
        public const string LocalizationSourceName = "FactAngular";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e76f55944bde40678ef1651730c88cd4";
    }
}
