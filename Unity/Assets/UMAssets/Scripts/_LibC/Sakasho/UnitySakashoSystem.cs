
namespace ExternLib
{
    public static partial class LibSakasho
    {
        static string UnityCallbackObject = "";

        public static bool UnitySakashoSystemInitialize(string sdkType, string sdkVersionNumber, int serverMode, string gameId, string commonKey, int paymentType)
        {
            TodoLogger.Log(TodoLogger.SakashoSystem, "LibSakasho.UnitySakashoSystemInitialize");
            return true;
        }
        public static void UnitySetCallbackReceiverName(string callbackReceiverName)
        {
            UnityCallbackObject = callbackReceiverName;
        }
    }
}
