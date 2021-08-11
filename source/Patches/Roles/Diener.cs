using System;
using TownOfUs.Patches.Language;

namespace TownOfUs.Roles
{
    public class Undertaker : Role
    {
        public KillButtonManager _dragDropButton;

        private static LanguagePack languagePack = new LanguagePack();

        public Undertaker(PlayerControl player) : base(player)
        {
            Name = languagePack.Undertaker;
            ImpostorText = () => languagePack.UndertakerImpostorText;
            TaskText = () => languagePack.UndertakerTaskText;
            Color = Palette.ImpostorRed;
            RoleType = RoleEnum.Undertaker;
            Faction = Faction.Impostors;
        }

        public DateTime LastDragged { get; set; }
        public DeadBody CurrentTarget { get; set; }
        public DeadBody CurrentlyDragging { get; set; }

        public KillButtonManager DragDropButton
        {
            get => _dragDropButton;
            set
            {
                _dragDropButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }

        public float DragTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastDragged;
            var num = CustomGameOptions.DragCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}