using TownOfUs.Patches.Language;

namespace TownOfUs.CustomOption
{
    public class CustomToggleOption : CustomOption
    {
        private static LanguagePack languagePack = new LanguagePack();

        protected internal CustomToggleOption(int id, string name, bool value = true) : base(id, name,
            CustomOptionType.Toggle,
            value)
        {
            Format = val => (bool) val ? languagePack.On : languagePack.Off;
        }

        protected internal bool Get()
        {
            return (bool) Value;
        }

        protected internal void Toggle()
        {
            Set(!Get());
        }

        public override void OptionCreated()
        {
            base.OptionCreated();
            Setting.Cast<ToggleOption>().TitleText.text = Name;
            Setting.Cast<ToggleOption>().CheckMark.enabled = Get();
        }
    }
}