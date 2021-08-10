using System;
using TownOfUs.Patches.Language;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewmateRoles;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption InvestigatorOn;
        public static CustomNumberOption TimeLordOn;
        public static CustomNumberOption MedicOn;
        public static CustomNumberOption SeerOn;
        public static CustomNumberOption SpyOn;
        public static CustomNumberOption SnitchOn;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption ButtonBarryOn;


        public static CustomHeaderOption NeutralRoles;
        public static CustomNumberOption JesterOn;
        public static CustomNumberOption ShifterOn;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption ArsonistOn;
        public static CustomNumberOption PhantomOn;


        public static CustomHeaderOption ImpostorRoles;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption CamouflagerOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption UndertakerOn;
        public static CustomNumberOption AssassinOn;
        public static CustomNumberOption UnderdogOn;


        /*
        public static CustomNumberOption SecurityGuardOn ;
            */

        public static CustomHeaderOption Modifiers;
        public static CustomNumberOption TorchOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption TiebreakerOn;
        public static CustomNumberOption DrunkOn;
        public static CustomNumberOption BigBoiOn;


        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption MeetingColourblind;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomNumberOption MaxImpostorRoles;
        public static CustomNumberOption MaxNeutralRoles;
        public static CustomToggleOption RoleUnderName;
        public static CustomNumberOption VanillaGame;

        public static CustomHeaderOption Mayor;
        public static CustomNumberOption MayorVoteBank;
        public static CustomToggleOption MayorAnonymous;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption ShowSheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsJester;
        public static CustomToggleOption SheriffKillsGlitch;
        public static CustomToggleOption SheriffKillsArsonist;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;


        public static CustomHeaderOption Shifter;
        public static CustomNumberOption ShifterCd;
        public static CustomStringOption WhoShifts;


        public static CustomHeaderOption Engineer;
        public static CustomStringOption EngineerPer;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;

        public static CustomHeaderOption TimeLord;
        public static CustomToggleOption RewindRevive;
        public static CustomNumberOption RewindDuration;
        public static CustomNumberOption RewindCooldown;
        public static CustomToggleOption TimeLordVitals;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomStringOption SeerInfo;
        public static CustomStringOption SeeReveal;
        public static CustomToggleOption NeutralRed;


        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomNumberOption InitialGlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;


        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;

        public static CustomHeaderOption Camouflager;
        public static CustomNumberOption CamouflagerCooldown;
        public static CustomNumberOption CamouflagerDuration;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchOnLaunch;
        public static CustomToggleOption SnitchSeesNeutrals;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomToggleOption ArsonistGameEnd;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;

        public static CustomHeaderOption Assassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinGuessNeutrals;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinMultiKill;
        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}" + ChineseTraditional.Second.Value;

        private static string wordFormat(string color, string str) => "<color=" + color + ">" + str +"</color>";


        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);


            CrewmateRoles = new CustomHeaderOption(num++, ChineseTraditional.CrewmateRoles.Value);
            MayorOn =
                new CustomNumberOption(true, num++, wordFormat("#704FA8FF", ChineseTraditional.Mayor.Value), 0f, 0f, 100f, 10f, PercentFormat);
            LoversOn =
                new CustomNumberOption(true, num++, wordFormat("#FF66CCFF", ChineseTraditional.Lovers.Value), 0f, 0f, 100f, 10f, PercentFormat);
            SheriffOn =
                new CustomNumberOption(true, num++, wordFormat("#FFFF00FF", ChineseTraditional.Sheriff.Value), 0f, 0f, 100f, 10f, PercentFormat);
            EngineerOn =
                new CustomNumberOption(true, num++, wordFormat("#FFA60AFF", ChineseTraditional.Engineer.Value), 0f, 0f, 100f, 10f, PercentFormat);
            SwapperOn =
                new CustomNumberOption(true, num++, wordFormat("#66E666FF", ChineseTraditional.Swapper.Value), 0f, 0f, 100f, 10f, PercentFormat);
            InvestigatorOn =
                new CustomNumberOption(true, num++, wordFormat("#00B3B3FF", ChineseTraditional.Investigator.Value), 0f, 0f, 100f, 10f, PercentFormat);
            TimeLordOn =
                new CustomNumberOption(true, num++, wordFormat("#0000FFFF", ChineseTraditional.TimeLord.Value), 0f, 0f, 100f, 10f, PercentFormat);
            MedicOn =
                new CustomNumberOption(true, num++, wordFormat("#006600FF", ChineseTraditional.Medic.Value), 0f, 0f, 100f, 10f, PercentFormat);
            SeerOn =
                new CustomNumberOption(true, num++, wordFormat("#FFCC80FF", ChineseTraditional.Seer.Value), 0f, 0f, 100f, 10f, PercentFormat);
            SpyOn =
                new CustomNumberOption(true, num++, wordFormat("#CCA3CCFF", ChineseTraditional.Spy.Value), 0f, 0f, 100f, 10f, PercentFormat);
            SnitchOn =
                new CustomNumberOption(true, num++, wordFormat("#D4AF37FF", ChineseTraditional.Snitch.Value), 0f, 0f, 100f, 10f, PercentFormat);
            AltruistOn =
                new CustomNumberOption(true, num++, wordFormat("#660000FF", ChineseTraditional.Altruist.Value), 0f, 0f, 100f, 10f, PercentFormat);

            NeutralRoles = new CustomHeaderOption(num++, ChineseTraditional.NeutralRoles.Value);
            JesterOn =
                new CustomNumberOption(true, num++, wordFormat("#FFBFCCFF", ChineseTraditional.Jester.Value), 0f, 0f, 100f, 10f, PercentFormat);
            ShifterOn =
                new CustomNumberOption(true, num++, wordFormat("#999999FF", ChineseTraditional.Shifter.Value), 0f, 0f, 100f, 10f, PercentFormat);
            GlitchOn =
                new CustomNumberOption(true, num++, wordFormat("#00FF00FF", ChineseTraditional.TheGlitch.Value), 0f, 0f, 100f, 10f, PercentFormat);
            ExecutionerOn =
                new CustomNumberOption(true, num++, wordFormat("#8C4005FF", ChineseTraditional.Executioner.Value), 0f, 0f, 100f, 10f, PercentFormat);
            ArsonistOn =
                new CustomNumberOption(true, num++, wordFormat("#FF4D00FF", ChineseTraditional.Arsonist.Value), 0f, 0f, 100f, 10f, PercentFormat);
            PhantomOn =
                new CustomNumberOption(true, num++, wordFormat("#662962FF", ChineseTraditional.Phantom.Value), 0f, 0f, 100f, 10f, PercentFormat);

            ImpostorRoles =
                new CustomHeaderOption(num++, ChineseTraditional.ImpostorRoles.Value);
            AssassinOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", ChineseTraditional.Assassin.Value), 0f, 0f, 100f, 10f, PercentFormat);
            JanitorOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", ChineseTraditional.Janitor.Value), 0f, 0f, 100f, 10f, PercentFormat);
            MorphlingOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", ChineseTraditional.Morphling.Value), 0f, 0f, 100f, 10f, PercentFormat);
            CamouflagerOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", ChineseTraditional.Camouflager.Value), 0f, 0f, 100f, 10f, PercentFormat);
            MinerOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", ChineseTraditional.Miner.Value), 0f, 0f, 100f, 10f, PercentFormat);
            SwooperOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", ChineseTraditional.Swooper.Value), 0f, 0f, 100f, 10f, PercentFormat);
            UndertakerOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", ChineseTraditional.Undertaker.Value), 0f, 0f, 100f, 10f, PercentFormat);
            UnderdogOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", ChineseTraditional.Underdog.Value), 0f, 0f, 100f, 10f, PercentFormat);

            Modifiers = new CustomHeaderOption(num++, ChineseTraditional.Modifiers.Value);
            TorchOn =
                new CustomNumberOption(true, num++, wordFormat("#FFFF99FF", ChineseTraditional.Torch.Value), 0f, 0f, 100f, 10f, PercentFormat);
            DiseasedOn =
                new CustomNumberOption(true, num++, wordFormat("#808080FF", ChineseTraditional.Diseased.Value), 0f, 0f, 100f, 10f, PercentFormat);
            FlashOn =
                new CustomNumberOption(true, num++, wordFormat("#FF8080FF", ChineseTraditional.Flash.Value), 0f, 0f, 100f, 10f, PercentFormat);
            TiebreakerOn =
                new CustomNumberOption(true, num++, wordFormat("#99E699FF", ChineseTraditional.Tiebreaker.Value), 0f, 0f, 100f, 10f, PercentFormat);
            DrunkOn =
                new CustomNumberOption(true, num++, wordFormat("#758000FF", ChineseTraditional.Drunk.Value), 0f, 0f, 100f, 10f, PercentFormat);
            BigBoiOn =
                new CustomNumberOption(true, num++, wordFormat("#FF8080FF", ChineseTraditional.Giant.Value), 0f, 0f, 100f, 10f, PercentFormat);
            ButtonBarryOn =
                new CustomNumberOption(true, num++, wordFormat("#E600FFFF", ChineseTraditional.ButtonBarry.Value), 0f, 0f, 100f, 10f, PercentFormat);


            CustomGameSettings =
                new CustomHeaderOption(num++, ChineseTraditional.CustomGameSettings.Value);
            ColourblindComms = 
                new CustomToggleOption(num++, ChineseTraditional.ColourblindComms.Value, false);
            MeetingColourblind = 
                new CustomToggleOption(num++, ChineseTraditional.MeetingColourblind.Value, false);
            ImpostorSeeRoles = 
                new CustomToggleOption(num++, ChineseTraditional.ImpostorSeeRoles.Value, false);
            DeadSeeRoles =
                new CustomToggleOption(num++, ChineseTraditional.DeadSeeRoles.Value, false);
            MaxImpostorRoles =
                new CustomNumberOption(num++, ChineseTraditional.MaxImpostorRoles.Value, 1f, 1f, 3f, 1f);
            MaxNeutralRoles =
                new CustomNumberOption(num++, ChineseTraditional.MaxNeutralRoles.Value, 1f, 1f, 5f, 1f);
            RoleUnderName = 
                new CustomToggleOption(num++, ChineseTraditional.RoleUnderName.Value);
            VanillaGame = 
                new CustomNumberOption(num++, ChineseTraditional.VanillaGame.Value, 0f, 0f, 100f, 5f, PercentFormat);

            Mayor =
                new CustomHeaderOption(num++, wordFormat("#704FA8FF", ChineseTraditional.Mayor.Value));
            MayorVoteBank =
                new CustomNumberOption(num++, ChineseTraditional.MayorVoteBank.Value, 1, 1, 5, 1);
            MayorAnonymous =
                new CustomToggleOption(num++, ChineseTraditional.MayorAnonymous.Value, false);

            Lovers =
                new CustomHeaderOption(num++, wordFormat("#FF66CCFF", ChineseTraditional.Lovers.Value));
            BothLoversDie = 
                new CustomToggleOption(num++, ChineseTraditional.BothLoversDie.Value);

            Sheriff =
                new CustomHeaderOption(num++, wordFormat("#FFFF00FF",ChineseTraditional.Sheriff.Value));
            ShowSheriff = 
                new CustomToggleOption(num++, ChineseTraditional.ShowSheriff.Value, false);
            SheriffKillOther =
                new CustomToggleOption(num++, ChineseTraditional.SheriffKillOther.Value, false);
            SheriffKillsJester =
                new CustomToggleOption(num++, ChineseTraditional.SheriffKillsJester.Value, false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, ChineseTraditional.SheriffKillsGlitch.Value, false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, ChineseTraditional.SheriffKillsArsonist.Value, false);
            SheriffKillCd =
                new CustomNumberOption(num++, ChineseTraditional.SheriffKillCd.Value, 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = 
                new CustomToggleOption(num++, ChineseTraditional.SheriffBodyReport.Value);

            Engineer =
                new CustomHeaderOption(num++, wordFormat("#FFA60AFF",ChineseTraditional.Engineer.Value));
            EngineerPer =
                new CustomStringOption(num++, ChineseTraditional.EngineerPer.Value, 
                            new[]{ChineseTraditional.PerRound.Value, ChineseTraditional.PerGame.Value});

            Investigator =
                new CustomHeaderOption(num++, wordFormat("#00B3B3FF", ChineseTraditional.Investigator.Value));
            FootprintSize = 
                new CustomNumberOption(num++, ChineseTraditional.FootprintSize.Value, 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, ChineseTraditional.FootprintInterval.Value, 1f, 0.25f, 5f, 0.25f, CooldownFormat);
            FootprintDuration = 
                new CustomNumberOption(num++, ChineseTraditional.FootprintDuration.Value, 10f, 1f, 10f, 0.5f, CooldownFormat);
            AnonymousFootPrint = 
                new CustomToggleOption(num++, ChineseTraditional.AnonymousFootPrint.Value, false);
            VentFootprintVisible = 
                new CustomToggleOption(num++, ChineseTraditional.VentFootprintVisible.Value, false);

            TimeLord =
                new CustomHeaderOption(num++, wordFormat("#0000FFFF", ChineseTraditional.TimeLord.Value));
            RewindRevive = 
                new CustomToggleOption(num++, ChineseTraditional.RewindRevive.Value, false);
            RewindDuration = 
                new CustomNumberOption(num++, ChineseTraditional.RewindDuration.Value, 3f, 3f, 15f, 0.5f, CooldownFormat);
            RewindCooldown = 
                new CustomNumberOption(num++, ChineseTraditional.RewindCooldown.Value, 25f, 10f, 40f, 2.5f, CooldownFormat);
            TimeLordVitals =
                new CustomToggleOption(num++, ChineseTraditional.TimeLordVitals.Value, false);

            Medic =
                new CustomHeaderOption(num++, wordFormat("#006600FF", ChineseTraditional.Medic.Value));
            ShowShielded =
                new CustomStringOption(num++, ChineseTraditional.ShowShielded.Value,
                    new[] { ChineseTraditional.Medic.Value, ChineseTraditional.Shielded.Value,
                            ChineseTraditional.ShieldedAndMedic.Value, ChineseTraditional.Nobody.Value});
            MedicReportSwitch = 
                new CustomToggleOption(num++, ChineseTraditional.MedicReportSwitch.Value);
            MedicReportNameDuration =
                new CustomNumberOption(num++, ChineseTraditional.MedicReportNameDuration.Value, 0, 0, 60, 2.5f, CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, ChineseTraditional.MedicReportColorDuration.Value, 15, 0, 120, 2.5f, CooldownFormat);
            WhoGetsNotification =
                new CustomStringOption(num++, ChineseTraditional.WhoGetsNotification.Value,
                    new[] { ChineseTraditional.Medic.Value, ChineseTraditional.Shielded.Value,
                            ChineseTraditional.Everyone.Value, ChineseTraditional.Nobody.Value});
            ShieldBreaks = new CustomToggleOption(num++, ChineseTraditional.ShieldBreaks.Value, false);

            Seer =
                new CustomHeaderOption(num++, wordFormat("#FFCC80FF", ChineseTraditional.Seer.Value));
            SeerCooldown =
                new CustomNumberOption(num++, ChineseTraditional.SeerCooldown.Value, 25f, 10f, 100f, 2.5f, CooldownFormat);
            SeerInfo =
                new CustomStringOption(num++, ChineseTraditional.SeerInfo.Value, 
                    new[] {ChineseTraditional.SeerInfoOption0.Value, ChineseTraditional.SeerInfoOption1.Value});
            SeeReveal =
                new CustomStringOption(num++, ChineseTraditional.SeeReveal.Value,
                    new[] { ChineseTraditional.CrewmateRoles.Value, ChineseTraditional.ImpAndNeu.Value,
                            ChineseTraditional.Everyone.Value, ChineseTraditional.Nobody.Value});
            NeutralRed =
                new CustomToggleOption(num++, ChineseTraditional.NeutralRed.Value, false);

            Snitch = 
                new CustomHeaderOption(num++, wordFormat("#D4AF37FF", ChineseTraditional.Snitch.Value));
            SnitchOnLaunch =
                new CustomToggleOption(num++, ChineseTraditional.SnitchOnLaunch.Value, false);
            SnitchSeesNeutrals = 
                new CustomToggleOption(num++, ChineseTraditional.SnitchSeesNeutrals.Value, false);

            Altruist = 
                new CustomHeaderOption(num++, wordFormat("#660000FF", ChineseTraditional.Altruist.Value));
            ReviveDuration =
                new CustomNumberOption(num++, ChineseTraditional.ReviveDuration.Value, 10, 1, 30, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, ChineseTraditional.AltruistTargetBody.Value, false);

            Shifter =
                new CustomHeaderOption(num++, wordFormat("#999999FF", ChineseTraditional.Shifter.Value));
            ShifterCd =
                new CustomNumberOption(num++, ChineseTraditional.ShifterCd.Value, 30f, 10f, 60f, 2.5f, CooldownFormat);
            WhoShifts = 
                new CustomStringOption(num++, ChineseTraditional.WhoShifts.Value, 
                    new[] { ChineseTraditional.NoImps.Value, ChineseTraditional.RegCrew.Value,
                            ChineseTraditional.Nobody.Value});

            TheGlitch =
                new CustomHeaderOption(num++, wordFormat("#00FF00FF", ChineseTraditional.TheGlitch.Value));
            MimicCooldownOption = 
                new CustomNumberOption(num++, ChineseTraditional.MimicCooldownOption.Value, 30, 10, 120, 2.5f, CooldownFormat);
            MimicDurationOption = 
                new CustomNumberOption(num++, ChineseTraditional.MimicDurationOption.Value, 10, 1, 30, 1f, CooldownFormat);
            HackCooldownOption = 
                new CustomNumberOption(num++, ChineseTraditional.HackCooldownOption.Value, 30, 10, 120, 2.5f, CooldownFormat);
            HackDurationOption = 
                new CustomNumberOption(num++, ChineseTraditional.HackDurationOption.Value, 10, 1, 30, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, ChineseTraditional.GlitchKillCooldownOption.Value, 30, 10, 120, 2.5f, CooldownFormat);
            InitialGlitchKillCooldownOption =
                new CustomNumberOption(num++, ChineseTraditional.InitialGlitchKillCooldownOption.Value, 10, 10, 120, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, ChineseTraditional.GlitchHackDistanceOption.Value, new[] {"Short", "Normal", "Long"});

            Executioner =
                new CustomHeaderOption(num++, wordFormat("#8C4005FF", ChineseTraditional.Executioner.Value));
            OnTargetDead = 
                new CustomStringOption(num++, ChineseTraditional.OnTargetDead.Value,
                    new[] {ChineseTraditional.RegCrew.Value, ChineseTraditional.Jester.Value});

            Arsonist = 
                new CustomHeaderOption(num++, wordFormat("#FF4D00FF", ChineseTraditional.Arsonist.Value));
            DouseCooldown =
                new CustomNumberOption(num++, ChineseTraditional.DouseCooldown.Value, 25, 10, 40, 2.5f, CooldownFormat);
            ArsonistGameEnd = 
                new CustomToggleOption(num++, ChineseTraditional.ArsonistGameEnd.Value, false);

            Morphling =
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", ChineseTraditional.Morphling.Value));
            MorphlingCooldown =
                new CustomNumberOption(num++, ChineseTraditional.MorphlingCooldown.Value, 25, 10, 40, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, ChineseTraditional.MorphlingDuration.Value, 10, 5, 15, 1f, CooldownFormat);

            Camouflager =
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", ChineseTraditional.Camouflager.Value));
            CamouflagerCooldown =
                new CustomNumberOption(num++, ChineseTraditional.CamouflagerCooldown.Value, 25, 10, 40, 2.5f, CooldownFormat);
            CamouflagerDuration =
                new CustomNumberOption(num++, ChineseTraditional.CamouflagerDuration.Value, 10, 5, 15, 1f, CooldownFormat);

            Miner = 
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", ChineseTraditional.Miner.Value));
            MineCooldown =
                new CustomNumberOption(num++, ChineseTraditional.MineCooldown.Value, 25, 10, 40, 2.5f, CooldownFormat);

            Swooper = 
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", ChineseTraditional.Swooper.Value));
            SwoopCooldown =
                new CustomNumberOption(num++, ChineseTraditional.SwoopCooldown.Value, 25, 10, 40, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, ChineseTraditional.SwoopDuration.Value, 10, 5, 15, 1f, CooldownFormat);

            Undertaker = 
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", ChineseTraditional.Undertaker.Value));
            DragCooldown = 
                new CustomNumberOption(num++, ChineseTraditional.DragCooldown.Value, 25, 10, 40, 2.5f, CooldownFormat);

            Assassin = 
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", ChineseTraditional.Assassin.Value));
            AssassinKills = 
                new CustomNumberOption(num++, ChineseTraditional.AssassinKills.Value, 1, 1, 5, 1);
            AssassinCrewmateGuess = 
                new CustomToggleOption(num++, ChineseTraditional.AssassinCrewmateGuess.Value, false);
            AssassinGuessNeutrals = 
                new CustomToggleOption(num++, ChineseTraditional.AssassinGuessNeutrals.Value, false);
            AssassinMultiKill = 
                new CustomToggleOption(num++, ChineseTraditional.AssassinMultiKill.Value);
        }
    }
}