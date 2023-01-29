using MusteriTakip.Common.Extensions;
using MusteriTakip.Common.Generic;
using MusteriTakip.Common.Models;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;

namespace MusteriTakip.Common.Helpers
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public class FileHelper : Singleton<FileHelper>
    {
        /// <summary>
        /// Reads JSON settings file as given generic type scope
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public (T, string) ReadSettingSection<T>()
        {
            try
            {
                var t = Activator.CreateInstance<T>();

                var classScope = t.GetType().GetField(Constants.Scope).GetRawConstantValue().ToString();

                var fileContent = File.ReadAllText("Settings.json").Trim();

                if (fileContent.IsNullOrEmpty()) return (default(T), Constants.SettingsFileError);

                var jsonObject = JObject.Parse(fileContent);

                if (jsonObject == null || jsonObject.Children().Count() <= 0) return (default(T), Constants.SettingsFileEmptyOrIncorrect);

                var childObject = jsonObject.Children().FirstOrDefault(x => x.Path == classScope).First;

                if (childObject == null || childObject.Children().Count() <= 0) return (default(T), Constants.SettingsFileEmptyOrIncorrect);

                return (childObject.ToObject<T>(), string.Empty);
            }
            catch (Exception ex)
            {
                return (default(T), ex.Message);
            }
        }
    }
}
