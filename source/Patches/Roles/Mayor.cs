using System.Collections.Generic;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Mayor : Role
    {
        public List<byte> ExtraVotes = new List<byte>();
        private static LanguagePack languagePack = new LanguagePack();

        public Mayor(PlayerControl player) : base(player)
        {
            Name = languagePack.Mayor;
            ImpostorText = () => "Save your votes to double vote";
            TaskText = () => "Save your votes to vote multiple times";
            Color = new Color(0.44f, 0.31f, 0.66f, 1f);
            RoleType = RoleEnum.Mayor;
            VoteBank = CustomGameOptions.MayorVoteBank;
        }

        public int VoteBank { get; set; }
        public bool SelfVote { get; set; }

        public bool VotedOnce { get; set; }

        public PlayerVoteArea Abstain { get; set; }

        public bool CanVote => VoteBank > 0 && !SelfVote;
    }
}