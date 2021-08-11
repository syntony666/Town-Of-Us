using TownOfUs.Patches.Language;

namespace TownOfUs.Roles
{
    public class Janitor : Role
    {
        public KillButtonManager _cleanButton;
        private static LanguagePack languagePack = new LanguagePack();


        public Janitor(PlayerControl player) : base(player)
        {
            Name = languagePack.Janitor;
            ImpostorText = () => languagePack.JanitorImpostorText;
            TaskText = () => languagePack.JanitorTaskText;
            Color = Palette.ImpostorRed;
            RoleType = RoleEnum.Janitor;
            Faction = Faction.Impostors;
        }

        public DeadBody CurrentTarget { get; set; }

        public KillButtonManager CleanButton
        {
            get => _cleanButton;
            set
            {
                _cleanButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
    }
}