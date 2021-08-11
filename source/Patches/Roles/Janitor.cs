using TownOfUs.Patches.Language;

namespace TownOfUs.Roles
{
    public class Janitor : Role
    {
        private static LanguagePack languagePack = new LanguagePack();
        public KillButtonManager _cleanButton;

        public Janitor(PlayerControl player) : base(player)
        {

            Name = languagePack.Janitor;
            ImpostorText = () => "Clean up bodies";
            TaskText = () => "Clean bodies to prevent Crewmates from discovering them.";
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