using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Tiebreaker : Modifier
    {
        private static LanguagePack languagePack = new LanguagePack();
        public Tiebreaker(PlayerControl player) : base(player)
        {
            Name = languagePack.Tiebreaker;
            TaskText = () => "Your vote breaks ties";
            Color = new Color(0.6f, 0.9f, 0.6f);
            ModifierType = ModifierEnum.Tiebreaker;
        }
    }
}