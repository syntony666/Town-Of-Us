using System;
using System.Collections.Generic;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{

    public class Miner : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public readonly List<Vent> Vents = new List<Vent>();

        public KillButtonManager _mineButton;
        public DateTime LastMined;


        public Miner(PlayerControl player) : base(player)
        {
            Name = languagePack.Miner;
            ImpostorText = () => languagePack.MinerImpostorText;
            TaskText = () => languagePack.MinerTaskText;
            Color = Palette.ImpostorRed;
            RoleType = RoleEnum.Miner;
            Faction = Faction.Impostors;
        }

        public bool CanPlace { get; set; }
        public Vector2 VentSize { get; set; }

        public KillButtonManager MineButton
        {
            get => _mineButton;
            set
            {
                _mineButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }

        public float MineTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastMined;
            var num = CustomGameOptions.MineCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}