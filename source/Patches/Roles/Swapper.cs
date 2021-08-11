using System.Collections.Generic;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Swapper : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public readonly List<GameObject> Buttons = new List<GameObject>();

        public readonly List<bool> ListOfActives = new List<bool>();


        public Swapper(PlayerControl player) : base(player)
        {
            Name = languagePack.Swapper;
            ImpostorText = () => languagePack.SwapperImpostorText;
            TaskText = () => languagePack.SwapperTaskText;
            Color = new Color(0.4f, 0.9f, 0.4f, 1f);
            RoleType = RoleEnum.Swapper;
        }
    }
}