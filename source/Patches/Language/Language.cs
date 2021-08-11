using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TownOfUs.Patches.Language
{
    class LanguagePack
    {
        private static Language language;
        public LanguagePack()
        {
            string Lang = TownOfUs.Lang.Value;
            if (Lang == "zh-TW")
                language = ChineseTraditional.getInstance();
            else
                language = English.getInstance();
        }
        public string Value { get; }
        public string CrewmateRoles => language.CrewmateRoles.Value;
        public string Mayor => language.Mayor.Value;
        public string Lovers => language.Lovers.Lovers.Value;
        public string Sheriff => language.Sheriff.Sheriff.Value;
        public string Engineer => language.Engineer.Engineer.Value;
        public string Swapper => language.Swapper.Swapper.Value;
        public string Investigator => language.Investigator.Investigator.Value;
        public string TimeLord => language.TimeLord.TimeLord.Value;
        public string Medic => language.Medic.Medic.Value;
        public string Seer => language.Seer.Seer.Value;
        public string Spy => language.Spy.Spy.Value;
        public string Snitch => language.Snitch.Snitch.Value;
        public string Altruist => language.Altruist.Altruist.Value;

        public string NeutralRoles => language.NeutralRoles.Value;
        public string Jester => language.Jester.Value;
        public string Shifter => language.Shifter.Value;
        public string TheGlitch => language.TheGlitch.Value;
        public string Executioner => language.Executioner.Value;
        public string Arsonist => language.Arsonist.Value;
        public string Phantom => language.Phantom.Value;

        public string ImpostorRoles => language.ImpostorRoles.Value;
        public string Assassin => language.Assassin.Value;
        public string Janitor => language.Janitor.Value;
        public string Morphling => language.Morphling.Value;
        public string Camouflager => language.Camouflager.Value;
        public string Miner => language.Miner.Value;
        public string Swooper => language.Swooper.Value;
        public string Undertaker => language.Undertaker.Value;
        public string Underdog => language.Underdog.Value;

        public string Modifiers => language.Modifiers.Value;
        public string Torch => language.Torch.Value;
        public string Diseased => language.Diseased.Value;
        public string Flash => language.Flash.Value;
        public string Tiebreaker => language.Tiebreaker.Value;
        public string Drunk => language.Drunk.Value;
        public string Giant => language.Giant.Value;
        public string ButtonBarry => language.ButtonBarry.Value;

        public string CustomGameSettings => language.CustomGameSettings.Value;
        public string ColourblindComms => language.ColourblindComms.Value;
        public string MeetingColourblind => language.MeetingColourblind.Value;
        public string ImpostorSeeRoles => language.ImpostorSeeRoles.Value;
        public string DeadSeeRoles => language.DeadSeeRoles.Value;
        public string MaxImpostorRoles => language.MaxImpostorRoles.Value;
        public string MaxNeutralRoles => language.MaxNeutralRoles.Value;
        public string RoleUnderName => language.RoleUnderName.Value;
        public string VanillaGame => language.VanillaGame.Value;
        public string MayorVoteBank => language.MayorVoteBank.Value;
        public string MayorAnonymous => language.MayorAnonymous.Value;
        public string BothLoversDie => language.BothLoversDie.Value;
        public string ShowSheriff => language.ShowSheriff.Value;
        public string SheriffKillOther => language.SheriffKillOther.Value;
        public string SheriffKillsJester => language.SheriffKillsJester.Value;
        public string SheriffKillsGlitch => language.SheriffKillsGlitch.Value;
        public string SheriffKillsArsonist => language.SheriffKillsArsonist.Value;
        public string SheriffKillCd => language.SheriffKillCd.Value;
        public string SheriffBodyReport => language.SheriffBodyReport.Value;
        public string EngineerPer => language.EngineerPer.Value;
        public string FootprintSize => language.FootprintSize.Value;
        public string FootprintInterval => language.FootprintInterval.Value;
        public string FootprintDuration => language.FootprintDuration.Value;
        public string AnonymousFootPrint => language.AnonymousFootPrint.Value;
        public string VentFootprintVisible => language.VentFootprintVisible.Value;
        public string RewindRevive => language.RewindRevive.Value;
        public string RewindDuration => language.RewindDuration.Value;
        public string RewindCooldown => language.RewindCooldown.Value;
        public string TimeLordVitals => language.TimeLordVitals.Value;
        public string ShowShielded => language.ShowShielded.Value;
        public string MedicReportSwitch => language.MedicReportSwitch.Value;
        public string MedicReportNameDuration  => language.MedicReportNameDuration .Value;
        public string MedicReportColorDuration => language.MedicReportColorDuration.Value;
        public string WhoGetsNotification => language.WhoGetsNotification.Value;
        public string ShieldBreaks => language.ShieldBreaks.Value;
        public string SeerCooldown => language.SeerCooldown.Value;
        public string SeerInfo => language.SeerInfo.Value;
        public string SeerInfoOption0 => language.SeerInfoOption0.Value;
        public string SeerInfoOption1 => language.SeerInfoOption1.Value;
        public string SeeReveal => language.SeeReveal.Value;
        public string NeutralRed => language.NeutralRed.Value;
        public string SnitchOnLaunch  => language.SnitchOnLaunch .Value;
        public string SnitchSeesNeutrals => language.SnitchSeesNeutrals.Value;
        public string ReviveDuration => language.ReviveDuration.Value;
        public string AltruistTargetBody  => language.AltruistTargetBody .Value;
        public string ShifterCd => language.ShifterCd.Value;
        public string WhoShifts => language.WhoShifts.Value;
        public string MimicCooldownOption => language.MimicCooldownOption.Value;
        public string MimicDurationOption => language.MimicDurationOption.Value;
        public string HackCooldownOption => language.HackCooldownOption.Value;
        public string HackDurationOption => language.HackDurationOption.Value;
        public string GlitchKillCooldownOption => language.GlitchKillCooldownOption.Value;
        public string InitialGlitchKillCooldownOption => language.InitialGlitchKillCooldownOption.Value;
        public string GlitchHackDistanceOption => language.GlitchHackDistanceOption.Value;
        public string OnTargetDead => language.OnTargetDead.Value;
        public string DouseCooldown => language.DouseCooldown.Value;
        public string ArsonistGameEnd => language.ArsonistGameEnd.Value;
        public string MorphlingCooldown => language.MorphlingCooldown.Value;
        public string MorphlingDuration => language.MorphlingDuration.Value;
        public string CamouflagerCooldown => language.CamouflagerCooldown .Value;
        public string CamouflagerDuration => language.CamouflagerDuration .Value;
        public string MineCooldown => language.MineCooldown.Value;
        public string SwoopCooldown => language.SwoopCooldown.Value;
        public string SwoopDuration => language.SwoopDuration .Value;
        public string DragCooldown => language.DragCooldown.Value;
        public string AssassinKills => language.AssassinKills.Value;
        public string AssassinCrewmateGuess => language.AssassinCrewmateGuess.Value;
        public string AssassinGuessNeutrals => language.AssassinGuessNeutrals.Value;
        public string AssassinMultiKill => language.AssassinMultiKill.Value;



        public string PerRound => language.PerRound.Value;
        public string PerGame  => language.PerGame .Value;
        public string Nobody => language.Nobody.Value;
        public string Everyone => language.Everyone.Value;
        public string On => language.On.Value;
        public string Off => language.Off.Value;
        public string Second => language.Second.Value;
        public string Short => language.Short.Value;
        public string Normal => language.Normal.Value;
        public string Long => language.Long.Value;

        public string Shielded => language.Shielded.Value;
        public string ShieldedAndMedic => language.ShieldedAndMedic.Value;
        public string ImpAndNeu => language.ImpAndNeu.Value;
        public string NoImps => language.NoImps.Value;
        public string RegCrew => language.RegCrew.Value;
    }

    abstract class Language
    {
        public string Value;
        public Language CrewmateRoles;
        public Language Mayor;
        public Language Lovers;
        public Language Sheriff;
        public Language Engineer;
        public Language Swapper;
        public Language Investigator;
        public Language TimeLord;
        public Language Medic;
        public Language Seer;
        public Language Spy;
        public Language Snitch;
        public Language Altruist;

        public Language NeutralRoles;
        public Language Jester;
        public Language Shifter;
        public Language TheGlitch;
        public Language Executioner;
        public Language Arsonist;
        public Language Phantom;

        public Language ImpostorRoles;
        public Language Assassin;
        public Language Janitor;
        public Language Morphling;
        public Language Camouflager;
        public Language Miner;
        public Language Swooper;
        public Language Undertaker;
        public Language Underdog;

        public Language Modifiers;
        public Language Torch;
        public Language Diseased;
        public Language Flash;
        public Language Tiebreaker;
        public Language Drunk;
        public Language Giant;
        public Language ButtonBarry;

        public Language CustomGameSettings;
        public Language ColourblindComms;
        public Language MeetingColourblind;
        public Language ImpostorSeeRoles;
        public Language DeadSeeRoles;
        public Language MaxImpostorRoles;
        public Language MaxNeutralRoles;
        public Language RoleUnderName;
        public Language VanillaGame;
        public Language MayorVoteBank;
        public Language MayorAnonymous;
        public Language BothLoversDie;
        public Language ShowSheriff;
        public Language SheriffKillOther;
        public Language SheriffKillsJester;
        public Language SheriffKillsGlitch;
        public Language SheriffKillsArsonist;
        public Language SheriffKillCd;
        public Language SheriffBodyReport;
        public Language EngineerPer;
        public Language FootprintSize;
        public Language FootprintInterval;
        public Language FootprintDuration;
        public Language AnonymousFootPrint;
        public Language VentFootprintVisible;
        public Language RewindRevive;
        public Language RewindDuration;
        public Language RewindCooldown;
        public Language TimeLordVitals;
        public Language ShowShielded;
        public Language MedicReportSwitch;
        public Language MedicReportNameDuration ;
        public Language MedicReportColorDuration;
        public Language WhoGetsNotification;
        public Language ShieldBreaks;
        public Language SeerCooldown;
        public Language SeerInfo;
        public Language SeerInfoOption0;
        public Language SeerInfoOption1;
        public Language SeeReveal;
        public Language NeutralRed;
        public Language SnitchOnLaunch ;
        public Language SnitchSeesNeutrals;
        public Language ReviveDuration;
        public Language AltruistTargetBody ;
        public Language ShifterCd;
        public Language WhoShifts;
        public Language MimicCooldownOption;
        public Language MimicDurationOption;
        public Language HackCooldownOption;
        public Language HackDurationOption;
        public Language GlitchKillCooldownOption;
        public Language InitialGlitchKillCooldownOption;
        public Language GlitchHackDistanceOption;
        public Language OnTargetDead;
        public Language DouseCooldown;
        public Language ArsonistGameEnd;
        public Language MorphlingCooldown;
        public Language MorphlingDuration;
        public Language CamouflagerCooldown ;
        public Language CamouflagerDuration ;
        public Language MineCooldown;
        public Language SwoopCooldown;
        public Language SwoopDuration ;
        public Language DragCooldown;
        public Language AssassinKills;
        public Language AssassinCrewmateGuess;
        public Language AssassinGuessNeutrals;
        public Language AssassinMultiKill;


        public Language PerRound;
        public Language PerGame ;
        public Language Nobody;
        public Language Everyone;
        public Language On;
        public Language Off;
        public Language Second;
        public Language Short;
        public Language Normal;
        public Language Long;

        public Language Shielded;
        public Language ShieldedAndMedic;
        public Language ImpAndNeu;
        public Language NoImps;
        public Language RegCrew;
    }
}
