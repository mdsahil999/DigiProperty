using xyz.Debugging;

namespace xyz
{
    public class xyzConsts
    {
        public const string LocalizationSourceName = "xyz";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "40f92dd1953449ef89d82aadf1184ee2";
    }
}
