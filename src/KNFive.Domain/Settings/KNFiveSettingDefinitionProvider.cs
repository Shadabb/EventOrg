using Volo.Abp.Settings;

namespace KNFive.Settings
{
    public class KNFiveSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(KNFiveSettings.MySetting1));
        }
    }
}
