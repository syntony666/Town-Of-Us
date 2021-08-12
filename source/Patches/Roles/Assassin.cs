using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Assassin : Role
    {
        public Dictionary<byte, (GameObject, GameObject, TMP_Text)> Buttons = new Dictionary<byte, (GameObject, GameObject, TMP_Text)>();


        public Dictionary<string, Color> ColorMapping = new Dictionary<string, Color>
        {
            { languagePack.Mayor, new Color(0.44f, 0.31f, 0.66f, 1f) },
            { languagePack.Sheriff, Color.yellow },
            { languagePack.Engineer, new Color(1f, 0.65f, 0.04f, 1f) },
            { languagePack.Swapper, new Color(0.4f, 0.9f, 0.4f, 1f) },
            { languagePack.Investigator, new Color(0f, 0.7f, 0.7f, 1f) },
            { languagePack.TimeLord, new Color(0f, 0f, 1f, 1f) },
            { languagePack.Lovers, new Color(1f, 0.4f, 0.8f, 1f) },
            { languagePack.Medic, new Color(0f, 0.4f, 0f, 1f) },
            { languagePack.Seer, new Color(1f, 0.8f, 0.5f, 1f) },
            { languagePack.Spy, new Color(0.8f, 0.64f, 0.8f, 1f) },
            { languagePack.Snitch, new Color(0.83f, 0.69f, 0.22f, 1f) },
            { languagePack.Altruist, new Color(0.4f, 0f, 0f, 1f) }
        };

        public Dictionary<byte, string> Guesses = new Dictionary<byte, string>();

        private static LanguagePack languagePack = new LanguagePack();

        public Assassin(PlayerControl player) : base(player)
        {
            Name = languagePack.Assassin;
            ImpostorText = () => languagePack.AssassinImpostorText;
            TaskText = () => languagePack.AssassinTaskText;
            Color = Palette.ImpostorRed;
            RoleType = RoleEnum.Assassin;
            Faction = Faction.Impostors;

            RemainingKills = CustomGameOptions.AssassinKills;

            if (CustomGameOptions.AssassinGuessNeutrals)
            {
                ColorMapping.Add(languagePack.Jester, new Color(1f, 0.75f, 0.8f, 1f));
                ColorMapping.Add(languagePack.Shifter, new Color(0.6f, 0.6f, 0.6f, 1f));
                ColorMapping.Add(languagePack.Executioner, new Color(0.55f, 0.25f, 0.02f, 1f));
                ColorMapping.Add(languagePack.TheGlitch, Color.green);
                ColorMapping.Add(languagePack.Arsonist, new Color(1f, 0.3f, 0f));
            }

            if (CustomGameOptions.AssassinCrewmateGuess) ColorMapping.Add(languagePack.Crewmate, Color.white);
        }

        public bool GuessedThisMeeting { get; set; } = false;

        public int RemainingKills { get; set; }

        public List<string> PossibleGuesses => ColorMapping.Keys.ToList();
    }
}
