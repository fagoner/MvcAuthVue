using System;

namespace MvcAuthVue
{


    public static class EnvSupport
    {
        public static string GetEnv(this string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }
    }

}