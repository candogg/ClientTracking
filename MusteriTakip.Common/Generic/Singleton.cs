using System;

namespace MusteriTakip.Common.Generic
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public class Singleton<T> where T : class, new()
    {
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                    instance = Activator.CreateInstance<T>();

                return instance;
            }
        }
    }
}
