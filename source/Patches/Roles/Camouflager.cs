using System;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Camouflager : Role

    {
        public KillButtonManager _camouflageButton;
        public bool Enabled;
        public DateTime LastCamouflaged;
        public float TimeRemaining;
        private static LanguagePack languagePack = new LanguagePack();


        public Camouflager(PlayerControl player) : base(player)
        {
            Name = languagePack.Camouflager;
            ImpostorText = () => languagePack.CamouflagerImpostorText;
            TaskText = () => languagePack.CamouflagerTaskText;
            Color = Palette.ImpostorRed;
            RoleType = RoleEnum.Camouflager;
            Faction = Faction.Impostors;
        }

        public bool Camouflaged => TimeRemaining > 0f;

        public KillButtonManager CamouflageButton
        {
            get => _camouflageButton;
            set
            {
                _camouflageButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }

        public void Camouflage()
        {
            Enabled = true;
            TimeRemaining -= Time.deltaTime;
            Utils.Camouflage();
        }

        public void UnCamouflage()
        {
            Enabled = false;
            LastCamouflaged = DateTime.UtcNow;
            Utils.UnCamouflage();
        }

        public float CamouflageTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastCamouflaged;
            var num = CustomGameOptions.CamouflagerCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}