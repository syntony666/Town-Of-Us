using BepInEx.Configuration;
using BepInEx.IL2CPP;
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
            language = ChineseTraditional.getInstance();

            //if (TownOfUs.ModLanguage == "zh-TW")
            //{
            //    language = ChineseTraditional.getInstance();
            //}
            //else
            //{
            //    language = English.getInstance();
            //}
        }
        public Language CrewmateRoles => language.CrewmateRoles;
        public string Mayor => language.Mayor.Value;
        public string Lovers => language.Lovers.Value;
        public string Sheriff => language.Sheriff.Value;
        public string Engineer => language.Engineer.Value;
        public string Swapper => language.Swapper.Value;
        public string Investigator => language.Investigator.Value;
        public string TimeLord => language.TimeLord.Value;
        public string Medic => language.Medic.Value;
        public string Seer => language.Seer.Value;
        public string Spy => language.Spy.Value;
        public string Snitch => language.Snitch.Value;
        public string Altruist => language.Altruist.Value;

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
        public string LoverImpostor => language.LoverImpostor.Value;

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
        public string Crewmate => language.Crewmate.Value;
        public string Impostor => language.Impostor.Value;
        public string Role => language.Role.Value;
        public string Modifier => language.Modifier.Value;

        public string GiantTaskText => language.GiantTaskText.Value;
        public string ButtonBarryTaskText => language.ButtonBarryTaskText.Value;
        public string DiseasedTaskText => language.DiseasedTaskText.Value;
        public string DrunkTaskText => language.DrunkTaskText.Value;
        public string FlashTaskText => language.FlashTaskText.Value;
        public string TiebreakerTaskText => language.TiebreakerTaskText.Value;
        public string TorchTaskText => language.TorchTaskText.Value;

        public string AltruistImpostorText => language.AltruistImpostorText.Value;
        public string AltruistTaskText => language.AltruistTaskText.Value;
        public string ArsonistImpostorText => language.ArsonistImpostorText.Value;
        public string ArsonistTaskText => language.ArsonistTaskText.Value;
        public string AssassinImpostorText => language.AssassinImpostorText.Value;
        public string AssassinTaskText => language.AssassinTaskText.Value;
        public string CamouflagerImpostorText => language.CamouflagerImpostorText.Value;
        public string CamouflagerTaskText => language.CamouflagerTaskText.Value;
        public string UndertakerImpostorText => language.UndertakerImpostorText.Value;
        public string UndertakerTaskText => language.UndertakerTaskText.Value;
        public string EngineerImpostorText => language.EngineerImpostorText.Value;
        public string EngineerTaskText => language.EngineerTaskText.Value;
        public string ExecutionerImpostorTextNull => language.ExecutionerImpostorTextNull.Value;
        public string ExecutionerImpostorText => language.ExecutionerImpostorText.Value;
        public string ExecutionerTaskTextNull => language.ExecutionerTaskTextNull.Value;
        public string ExecutionerTaskText => language.ExecutionerTaskText.Value;
        public string TheGlitchImpostorText => language.TheGlitchImpostorText.Value;
        public string TheGlitchTaskText => language.TheGlitchTaskText.Value;
        public string InvestigatorImpostorText => language.InvestigatorImpostorText.Value;
        public string InvestigatorTaskText => language.InvestigatorTaskText.Value;
        public string JanitorImpostorText => language.JanitorImpostorText.Value;
        public string JanitorTaskText => language.JanitorTaskText.Value;
        public string JesterImpostorText => language.JesterImpostorText.Value;
        public string JesterTaskText => language.JesterTaskText.Value;
        public string LoverImpostorText => language.LoverImpostorText.Value;
        public string LoverTaskText => language.LoverTaskText.Value;
        public string MayorImpostorText => language.MayorImpostorText.Value;
        public string MayorTaskText => language.MayorTaskText.Value;
        public string MedicImpostorText => language.MedicImpostorText.Value;
        public string MedicTaskText => language.MedicTaskText.Value;
        public string MinerImpostorText => language.MinerImpostorText.Value;
        public string MinerTaskText => language.MinerTaskText.Value;
        public string MorphlingImpostorText => language.MorphlingImpostorText.Value;
        public string MorphlingTaskText => language.MorphlingTaskText.Value;
        public string PhantomImpostorText => language.PhantomImpostorText.Value;
        public string PhantomTaskText => language.PhantomTaskText.Value;
        public string SeerImpostorText => language.SeerImpostorText.Value;
        public string SeerTaskText => language.SeerTaskText.Value;
        public string SheriffImpostorText => language.SheriffImpostorText.Value;
        public string SheriffTaskText => language.SheriffTaskText.Value;
        public string ShifterImpostorText => language.ShifterImpostorText.Value;
        public string ShifterTaskText => language.ShifterTaskText.Value;
        public string SnitchImpostorText => language.SnitchImpostorText.Value;
        public string SnitchTaskTextDone => language.SnitchTaskTextDone.Value;
        public string SnitchTaskText => language.SnitchTaskText.Value;
        public string SpyImpostorText => language.SpyImpostorText.Value;
        public string SpyTaskText => language.SpyTaskText.Value;
        public string SwapperImpostorText => language.SwapperImpostorText.Value;
        public string SwapperTaskText => language.SwapperTaskText.Value;
        public string SwooperImpostorText => language.SwooperImpostorText.Value;
        public string SwooperTaskText => language.SwooperTaskText.Value;
        public string TimeLordImpostorText => language.TimeLordImpostorText.Value;
        public string TimeLordTaskText => language.TimeLordTaskText.Value;
        public string UnderdogImpostorText => language.UnderdogImpostorText.Value;
        public string UnderdogTaskText => language.UnderdogTaskText.Value;

        public string Win => language.Win.Value;
        public string ExeToJesText => language.ExeToJesText.Value;
    }

    interface Language
    {
        string Value {get; }
        Language CrewmateRoles { get; }
        Language Mayor { get; }
        Language Lovers { get; }
        Language Sheriff { get; }
        Language Engineer { get; }
        Language Swapper { get; }
        Language Investigator { get; }
        Language TimeLord { get; }
        Language Medic { get; }
        Language Seer { get; }
        Language Spy { get; }
        Language Snitch { get; }
        Language Altruist { get; }

        Language NeutralRoles { get; }
        Language Jester { get; }
        Language Shifter { get; }
        Language TheGlitch { get; }
        Language Executioner { get; }
        Language Arsonist { get; }
        Language Phantom { get; }

        Language ImpostorRoles { get; }
        Language Assassin { get; }
        Language Janitor { get; }
        Language Morphling { get; }
        Language Camouflager { get; }
        Language Miner { get; }
        Language Swooper { get; }
        Language Undertaker { get; }
        Language Underdog { get; }
        Language LoverImpostor { get; }

        Language Modifiers { get; }
        Language Torch { get; }
        Language Diseased { get; }
        Language Flash { get; }
        Language Tiebreaker { get; }
        Language Drunk { get; }
        Language Giant { get; }
        Language ButtonBarry { get; }

        Language CustomGameSettings { get; }
        Language ColourblindComms { get; }
        Language MeetingColourblind { get; }
        Language ImpostorSeeRoles { get; }
        Language DeadSeeRoles { get; }
        Language MaxImpostorRoles { get; }
        Language MaxNeutralRoles { get; }
        Language RoleUnderName { get; }
        Language VanillaGame { get; }
        Language MayorVoteBank { get; }
        Language MayorAnonymous { get; }
        Language BothLoversDie { get; }
        Language ShowSheriff { get; }
        Language SheriffKillOther { get; }
        Language SheriffKillsJester { get; }
        Language SheriffKillsGlitch { get; }
        Language SheriffKillsArsonist { get; }
        Language SheriffKillCd { get; }
        Language SheriffBodyReport { get; }
        Language EngineerPer { get; }
        Language FootprintSize { get; }
        Language FootprintInterval { get; }
        Language FootprintDuration { get; }
        Language AnonymousFootPrint { get; }
        Language VentFootprintVisible { get; }
        Language RewindRevive { get; }
        Language RewindDuration { get; }
        Language RewindCooldown { get; }
        Language TimeLordVitals { get; }
        Language ShowShielded { get; }
        Language MedicReportSwitch { get; }
        Language MedicReportNameDuration  { get; }
        Language MedicReportColorDuration { get; }
        Language WhoGetsNotification { get; }
        Language ShieldBreaks { get; }
        Language SeerCooldown { get; }
        Language SeerInfo { get; }
        Language SeerInfoOption0 { get; }
        Language SeerInfoOption1 { get; }
        Language SeeReveal { get; }
        Language NeutralRed { get; }
        Language SnitchOnLaunch  { get; }
        Language SnitchSeesNeutrals { get; }
        Language ReviveDuration { get; }
        Language AltruistTargetBody  { get; }
        Language ShifterCd { get; }
        Language WhoShifts { get; }
        Language MimicCooldownOption { get; }
        Language MimicDurationOption { get; }
        Language HackCooldownOption { get; }
        Language HackDurationOption { get; }
        Language GlitchKillCooldownOption { get; }
        Language InitialGlitchKillCooldownOption { get; }
        Language GlitchHackDistanceOption { get; }
        Language OnTargetDead { get; }
        Language DouseCooldown { get; }
        Language ArsonistGameEnd { get; }
        Language MorphlingCooldown { get; }
        Language MorphlingDuration { get; }
        Language CamouflagerCooldown  { get; }
        Language CamouflagerDuration  { get; }
        Language MineCooldown { get; }
        Language SwoopCooldown { get; }
        Language SwoopDuration  { get; }
        Language DragCooldown { get; }
        Language AssassinKills { get; }
        Language AssassinCrewmateGuess { get; }
        Language AssassinGuessNeutrals { get; }
        Language AssassinMultiKill { get; }


        Language PerRound { get; }
        Language PerGame  { get; }
        Language Nobody { get; }
        Language Everyone { get; }
        Language On { get; }
        Language Off { get; }
        Language Second { get; }
        Language Short { get; }
        Language Normal { get; }
        Language Long { get; }

        Language Shielded { get; }
        Language ShieldedAndMedic { get; }
        Language ImpAndNeu { get; }
        Language NoImps { get; }
        Language RegCrew { get; }
        Language Crewmate { get; }
        Language Impostor { get; }
        Language Role { get; }
        Language Modifier { get; }

        Language GiantTaskText { get; }
        Language ButtonBarryTaskText { get; }
        Language DiseasedTaskText { get; }
        Language DrunkTaskText { get; }
        Language FlashTaskText { get; }
        Language TiebreakerTaskText { get; }
        Language TorchTaskText { get; }

        Language AltruistImpostorText { get; }
        Language AltruistTaskText { get; }
        Language ArsonistImpostorText { get; }
        Language ArsonistTaskText { get; }
        Language AssassinImpostorText { get; }
        Language AssassinTaskText { get; }
        Language CamouflagerImpostorText { get; }
        Language CamouflagerTaskText { get; }
        Language UndertakerImpostorText { get; }
        Language UndertakerTaskText { get; }
        Language EngineerImpostorText { get; }
        Language EngineerTaskText { get; }
        Language ExecutionerImpostorTextNull { get; }
        Language ExecutionerImpostorText { get; }
        Language ExecutionerTaskTextNull { get; }
        Language ExecutionerTaskText { get; }
        Language TheGlitchImpostorText { get; }
        Language TheGlitchTaskText { get; }
        Language InvestigatorImpostorText { get; }
        Language InvestigatorTaskText { get; }
        Language JanitorImpostorText { get; }
        Language JanitorTaskText { get; }
        Language JesterImpostorText { get; }
        Language JesterTaskText { get; }
        Language LoverImpostorText { get; }
        Language LoverTaskText { get; }
        Language MayorImpostorText { get; }
        Language MayorTaskText { get; }
        Language MedicImpostorText { get; }
        Language MedicTaskText { get; }
        Language MinerImpostorText { get; }
        Language MinerTaskText { get; }
        Language MorphlingImpostorText { get; }
        Language MorphlingTaskText { get; }
        Language PhantomImpostorText { get; }
        Language PhantomTaskText { get; }
        Language SeerImpostorText { get; }
        Language SeerTaskText { get; }
        Language SheriffImpostorText { get; }
        Language SheriffTaskText { get; }
        Language ShifterImpostorText { get; }
        Language ShifterTaskText { get; }
        Language SnitchImpostorText { get; }
        Language SnitchTaskTextDone { get; }
        Language SnitchTaskText { get; }
        Language SpyImpostorText { get; }
        Language SpyTaskText { get; }
        Language SwapperImpostorText { get; }
        Language SwapperTaskText { get; }
        Language SwooperImpostorText { get; }
        Language SwooperTaskText { get; }
        Language TimeLordImpostorText { get; }
        Language TimeLordTaskText { get; }
        Language UnderdogImpostorText { get; }
        Language UnderdogTaskText { get; }

        Language Win { get; }
        Language ExeToJesText { get; }

    }
}
