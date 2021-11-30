namespace BlazorFramework.Client.Shared
{
    public static class JsInteropConstants
    {
        private const string FuncPrefix = "blazorFramework";

        public const string GetSessionStorage = $"{FuncPrefix}.getSessionStorage";

        public const string SetSessionStorage = $"{FuncPrefix}.setSessionStorage";
    }
}
