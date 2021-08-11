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
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}" + languagePack.Second;

        private static string wordFormat(string color, string str) => "<color=" + color + ">" + str +"</color>";

        private static LanguagePack languagePack = new LanguagePack();


        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);


            CrewmateRoles = new CustomHeaderOption(num++, languagePack.CrewmateRoles);
            MayorOn =
                new CustomNumberOption(true, num++, wordFormat("#704FA8FF", languagePack.Mayor), 0f, 0f, 100f, 10f, PercentFormat);
            LoversOn =
                new CustomNumberOption(true, num++, wordFormat("#FF66CCFF", languagePack.Lovers), 0f, 0f, 100f, 10f, PercentFormat);
            SheriffOn =
                new CustomNumberOption(true, num++, wordFormat("#FFFF00FF", languagePack.Sheriff), 0f, 0f, 100f, 10f, PercentFormat);
            EngineerOn =
                new CustomNumberOption(true, num++, wordFormat("#FFA60AFF", languagePack.Engineer), 0f, 0f, 100f, 10f, PercentFormat);
            SwapperOn =
                new CustomNumberOption(true, num++, wordFormat("#66E666FF", languagePack.Swapper), 0f, 0f, 100f, 10f, PercentFormat);
            InvestigatorOn =
                new CustomNumberOption(true, num++, wordFormat("#00B3B3FF", languagePack.Investigator), 0f, 0f, 100f, 10f, PercentFormat);
            TimeLordOn =
                new CustomNumberOption(true, num++, wordFormat("#0000FFFF", languagePack.TimeLord), 0f, 0f, 100f, 10f, PercentFormat);
            MedicOn =
                new CustomNumberOption(true, num++, wordFormat("#006600FF", languagePack.Medic), 0f, 0f, 100f, 10f, PercentFormat);
            SeerOn =
                new CustomNumberOption(true, num++, wordFormat("#FFCC80FF", languagePack.Seer), 0f, 0f, 100f, 10f, PercentFormat);
            SpyOn =
                new CustomNumberOption(true, num++, wordFormat("#CCA3CCFF", languagePack.Spy), 0f, 0f, 100f, 10f, PercentFormat);
            SnitchOn =
                new CustomNumberOption(true, num++, wordFormat("#D4AF37FF", languagePack.Snitch), 0f, 0f, 100f, 10f, PercentFormat);
            AltruistOn =
                new CustomNumberOption(true, num++, wordFormat("#660000FF", languagePack.Altruist), 0f, 0f, 100f, 10f, PercentFormat);

            NeutralRoles = new CustomHeaderOption(num++, languagePack.NeutralRoles);
            JesterOn =
                new CustomNumberOption(true, num++, wordFormat("#FFBFCCFF", languagePack.Jester), 0f, 0f, 100f, 10f, PercentFormat);
            ShifterOn =
                new CustomNumberOption(true, num++, wordFormat("#999999FF", languagePack.Shifter), 0f, 0f, 100f, 10f, PercentFormat);
            GlitchOn =
                new CustomNumberOption(true, num++, wordFormat("#00FF00FF", languagePack.TheGlitch), 0f, 0f, 100f, 10f, PercentFormat);
            ExecutionerOn =
                new CustomNumberOption(true, num++, wordFormat("#8C4005FF", languagePack.Executioner), 0f, 0f, 100f, 10f, PercentFormat);
            ArsonistOn =
                new CustomNumberOption(true, num++, wordFormat("#FF4D00FF", languagePack.Arsonist), 0f, 0f, 100f, 10f, PercentFormat);
            PhantomOn =
                new CustomNumberOption(true, num++, wordFormat("#662962FF", languagePack.Phantom), 0f, 0f, 100f, 10f, PercentFormat);

            ImpostorRoles =
                new CustomHeaderOption(num++, languagePack.ImpostorRoles);
            AssassinOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", languagePack.Assassin), 0f, 0f, 100f, 10f, PercentFormat);
            JanitorOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", languagePack.Janitor), 0f, 0f, 100f, 10f, PercentFormat);
            MorphlingOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", languagePack.Morphling), 0f, 0f, 100f, 10f, PercentFormat);
            CamouflagerOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", languagePack.Camouflager), 0f, 0f, 100f, 10f, PercentFormat);
            MinerOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", languagePack.Miner), 0f, 0f, 100f, 10f, PercentFormat);
            SwooperOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", languagePack.Swooper), 0f, 0f, 100f, 10f, PercentFormat);
            UndertakerOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", languagePack.Undertaker), 0f, 0f, 100f, 10f, PercentFormat);
            UnderdogOn =
                new CustomNumberOption(true, num++, wordFormat("#FF0000FF", languagePack.Underdog), 0f, 0f, 100f, 10f, PercentFormat);

            Modifiers = new CustomHeaderOption(num++, languagePack.Modifiers);
            TorchOn =
                new CustomNumberOption(true, num++, wordFormat("#FFFF99FF", languagePack.Torch), 0f, 0f, 100f, 10f, PercentFormat);
            DiseasedOn =
                new CustomNumberOption(true, num++, wordFormat("#808080FF", languagePack.Diseased), 0f, 0f, 100f, 10f, PercentFormat);
            FlashOn =
                new CustomNumberOption(true, num++, wordFormat("#FF8080FF", languagePack.Flash), 0f, 0f, 100f, 10f, PercentFormat);
            TiebreakerOn =
                new CustomNumberOption(true, num++, wordFormat("#99E699FF", languagePack.Tiebreaker), 0f, 0f, 100f, 10f, PercentFormat);
            DrunkOn =
                new CustomNumberOption(true, num++, wordFormat("#758000FF", languagePack.Drunk), 0f, 0f, 100f, 10f, PercentFormat);
            BigBoiOn =
                new CustomNumberOption(true, num++, wordFormat("#FF8080FF", languagePack.Giant), 0f, 0f, 100f, 10f, PercentFormat);
            ButtonBarryOn =
                new CustomNumberOption(true, num++, wordFormat("#E600FFFF", languagePack.ButtonBarry), 0f, 0f, 100f, 10f, PercentFormat);


            CustomGameSettings =
                new CustomHeaderOption(num++, languagePack.CustomGameSettings);
            ColourblindComms = 
                new CustomToggleOption(num++, languagePack.ColourblindComms, false);
            MeetingColourblind = 
                new CustomToggleOption(num++, languagePack.MeetingColourblind, false);
            ImpostorSeeRoles = 
                new CustomToggleOption(num++, languagePack.ImpostorSeeRoles, false);
            DeadSeeRoles =
                new CustomToggleOption(num++, languagePack.DeadSeeRoles, false);
            MaxImpostorRoles =
                new CustomNumberOption(num++, languagePack.MaxImpostorRoles, 1f, 1f, 3f, 1f);
            MaxNeutralRoles =
                new CustomNumberOption(num++, languagePack.MaxNeutralRoles, 1f, 1f, 5f, 1f);
            RoleUnderName = 
                new CustomToggleOption(num++, languagePack.RoleUnderName);
            VanillaGame = 
                new CustomNumberOption(num++, languagePack.VanillaGame, 0f, 0f, 100f, 5f, PercentFormat);

            Mayor =
                new CustomHeaderOption(num++, wordFormat("#704FA8FF", languagePack.Mayor));
            MayorVoteBank =
                new CustomNumberOption(num++, languagePack.MayorVoteBank, 1, 1, 5, 1);
            MayorAnonymous =
                new CustomToggleOption(num++, languagePack.MayorAnonymous, false);

            Lovers =
                new CustomHeaderOption(num++, wordFormat("#FF66CCFF", languagePack.Lovers));
            BothLoversDie = 
                new CustomToggleOption(num++, languagePack.BothLoversDie);

            Sheriff =
                new CustomHeaderOption(num++, wordFormat("#FFFF00FF",languagePack.Sheriff));
            ShowSheriff = 
                new CustomToggleOption(num++, languagePack.ShowSheriff, false);
            SheriffKillOther =
                new CustomToggleOption(num++, languagePack.SheriffKillOther, false);
            SheriffKillsJester =
                new CustomToggleOption(num++, languagePack.SheriffKillsJester, false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, languagePack.SheriffKillsGlitch, false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, languagePack.SheriffKillsArsonist, false);
            SheriffKillCd =
                new CustomNumberOption(num++, languagePack.SheriffKillCd, 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = 
                new CustomToggleOption(num++, languagePack.SheriffBodyReport);

            Engineer =
                new CustomHeaderOption(num++, wordFormat("#FFA60AFF",languagePack.Engineer));
            EngineerPer =
                new CustomStringOption(num++, languagePack.EngineerPer, 
                            new[]{languagePack.PerRound, languagePack.PerGame});

            Investigator =
                new CustomHeaderOption(num++, wordFormat("#00B3B3FF", languagePack.Investigator));
            FootprintSize = 
                new CustomNumberOption(num++, languagePack.FootprintSize, 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, languagePack.FootprintInterval, 1f, 0.25f, 5f, 0.25f, CooldownFormat);
            FootprintDuration = 
                new CustomNumberOption(num++, languagePack.FootprintDuration, 10f, 1f, 10f, 0.5f, CooldownFormat);
            AnonymousFootPrint = 
                new CustomToggleOption(num++, languagePack.AnonymousFootPrint, false);
            VentFootprintVisible = 
                new CustomToggleOption(num++, languagePack.VentFootprintVisible, false);

            TimeLord =
                new CustomHeaderOption(num++, wordFormat("#0000FFFF", languagePack.TimeLord));
            RewindRevive = 
                new CustomToggleOption(num++, languagePack.RewindRevive, false);
            RewindDuration = 
                new CustomNumberOption(num++, languagePack.RewindDuration, 3f, 3f, 15f, 0.5f, CooldownFormat);
            RewindCooldown = 
                new CustomNumberOption(num++, languagePack.RewindCooldown, 25f, 10f, 40f, 2.5f, CooldownFormat);
            TimeLordVitals =
                new CustomToggleOption(num++, languagePack.TimeLordVitals, false);

            Medic =
                new CustomHeaderOption(num++, wordFormat("#006600FF", languagePack.Medic));
            ShowShielded =
                new CustomStringOption(num++, languagePack.ShowShielded,
                    new[] { languagePack.Medic, languagePack.Shielded,
                            languagePack.ShieldedAndMedic, languagePack.Nobody});
            MedicReportSwitch = 
                new CustomToggleOption(num++, languagePack.MedicReportSwitch);
            MedicReportNameDuration =
                new CustomNumberOption(num++, languagePack.MedicReportNameDuration, 0, 0, 60, 2.5f, CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, languagePack.MedicReportColorDuration, 15, 0, 120, 2.5f, CooldownFormat);
            WhoGetsNotification =
                new CustomStringOption(num++, languagePack.WhoGetsNotification,
                    new[] { languagePack.Medic, languagePack.Shielded,
                            languagePack.Everyone, languagePack.Nobody});
            ShieldBreaks = new CustomToggleOption(num++, languagePack.ShieldBreaks, false);

            Seer =
                new CustomHeaderOption(num++, wordFormat("#FFCC80FF", languagePack.Seer));
            SeerCooldown =
                new CustomNumberOption(num++, languagePack.SeerCooldown, 25f, 10f, 100f, 2.5f, CooldownFormat);
            SeerInfo =
                new CustomStringOption(num++, languagePack.SeerInfo, 
                    new[] {languagePack.SeerInfoOption0, languagePack.SeerInfoOption1});
            SeeReveal =
                new CustomStringOption(num++, languagePack.SeeReveal,
                    new[] { languagePack.CrewmateRoles, languagePack.ImpAndNeu,
                            languagePack.Everyone, languagePack.Nobody});
            NeutralRed =
                new CustomToggleOption(num++, languagePack.NeutralRed, false);

            Snitch = 
                new CustomHeaderOption(num++, wordFormat("#D4AF37FF", languagePack.Snitch));
            SnitchOnLaunch =
                new CustomToggleOption(num++, languagePack.SnitchOnLaunch, false);
            SnitchSeesNeutrals = 
                new CustomToggleOption(num++, languagePack.SnitchSeesNeutrals, false);

            Altruist = 
                new CustomHeaderOption(num++, wordFormat("#660000FF", languagePack.Altruist));
            ReviveDuration =
                new CustomNumberOption(num++, languagePack.ReviveDuration, 10, 1, 30, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, languagePack.AltruistTargetBody, false);

            Shifter =
                new CustomHeaderOption(num++, wordFormat("#999999FF", languagePack.Shifter));
            ShifterCd =
                new CustomNumberOption(num++, languagePack.ShifterCd, 30f, 10f, 60f, 2.5f, CooldownFormat);
            WhoShifts = 
                new CustomStringOption(num++, languagePack.WhoShifts, 
                    new[] { languagePack.NoImps, languagePack.RegCrew,
                            languagePack.Nobody});

            TheGlitch =
                new CustomHeaderOption(num++, wordFormat("#00FF00FF", languagePack.TheGlitch));
            MimicCooldownOption = 
                new CustomNumberOption(num++, languagePack.MimicCooldownOption, 30, 10, 120, 2.5f, CooldownFormat);
            MimicDurationOption = 
                new CustomNumberOption(num++, languagePack.MimicDurationOption, 10, 1, 30, 1f, CooldownFormat);
            HackCooldownOption = 
                new CustomNumberOption(num++, languagePack.HackCooldownOption, 30, 10, 120, 2.5f, CooldownFormat);
            HackDurationOption = 
                new CustomNumberOption(num++, languagePack.HackDurationOption, 10, 1, 30, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, languagePack.GlitchKillCooldownOption, 30, 10, 120, 2.5f, CooldownFormat);
            InitialGlitchKillCooldownOption =
                new CustomNumberOption(num++, languagePack.InitialGlitchKillCooldownOption, 10, 10, 120, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, languagePack.GlitchHackDistanceOption, 
                    new[] {languagePack.Short, languagePack.Normal, languagePack.Long});

            Executioner =
                new CustomHeaderOption(num++, wordFormat("#8C4005FF", languagePack.Executioner));
            OnTargetDead = 
                new CustomStringOption(num++, languagePack.OnTargetDead,
                    new[] {languagePack.RegCrew, languagePack.Jester});

            Arsonist = 
                new CustomHeaderOption(num++, wordFormat("#FF4D00FF", languagePack.Arsonist));
            DouseCooldown =
                new CustomNumberOption(num++, languagePack.DouseCooldown, 25, 10, 40, 2.5f, CooldownFormat);
            ArsonistGameEnd = 
                new CustomToggleOption(num++, languagePack.ArsonistGameEnd, false);

            Morphling =
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", languagePack.Morphling));
            MorphlingCooldown =
                new CustomNumberOption(num++, languagePack.MorphlingCooldown, 25, 10, 40, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, languagePack.MorphlingDuration, 10, 5, 15, 1f, CooldownFormat);

            Camouflager =
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", languagePack.Camouflager));
            CamouflagerCooldown =
                new CustomNumberOption(num++, languagePack.CamouflagerCooldown, 25, 10, 40, 2.5f, CooldownFormat);
            CamouflagerDuration =
                new CustomNumberOption(num++, languagePack.CamouflagerDuration, 10, 5, 15, 1f, CooldownFormat);

            Miner = 
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", languagePack.Miner));
            MineCooldown =
                new CustomNumberOption(num++, languagePack.MineCooldown, 25, 10, 40, 2.5f, CooldownFormat);

            Swooper = 
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", languagePack.Swooper));
            SwoopCooldown =
                new CustomNumberOption(num++, languagePack.SwoopCooldown, 25, 10, 40, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, languagePack.SwoopDuration, 10, 5, 15, 1f, CooldownFormat);

            Undertaker = 
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", languagePack.Undertaker));
            DragCooldown = 
                new CustomNumberOption(num++, languagePack.DragCooldown, 25, 10, 40, 2.5f, CooldownFormat);

            Assassin = 
                new CustomHeaderOption(num++, wordFormat("#FF0000FF", languagePack.Assassin));
            AssassinKills = 
                new CustomNumberOption(num++, languagePack.AssassinKills, 1, 1, 5, 1);
            AssassinCrewmateGuess = 
                new CustomToggleOption(num++, languagePack.AssassinCrewmateGuess, false);
            AssassinGuessNeutrals = 
                new CustomToggleOption(num++, languagePack.AssassinGuessNeutrals, false);
            AssassinMultiKill = 
                new CustomToggleOption(num++, languagePack.AssassinMultiKill);
        }
    }
}