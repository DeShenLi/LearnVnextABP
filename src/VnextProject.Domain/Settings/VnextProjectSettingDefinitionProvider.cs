using Volo.Abp.Settings;

namespace VnextProject.Settings
{
    public class VnextProjectSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(VnextProjectSettings.MySetting1));
        }
    }
}
