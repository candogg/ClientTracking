using MusteriTakip.Common.Helpers;
using MusteriTakip.Common.Items;

namespace MusteriTakip.Common.Models
{
    public static class Statics
    {
        public static (DbConnectionSettingsItem, string) SqlSetting => FileHelper.Instance.ReadSettingSection<DbConnectionSettingsItem>();
    }
}
