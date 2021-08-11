using System;
using System.Collections.Generic;
using System.Text;

namespace TownOfUs.Patches.Language
{
    class ChineseTraditional: Language
    {
        private ChineseTraditional(string value)
        {
            Value = value;
        }

        public ChineseTraditional()
        {
        }

        public string Value { get; private set; }

        internal static Language getInstance()
        {
            return new ChineseTraditional();
        }

        public Language CrewmateRoles => new ChineseTraditional("好人陣營");
        public Language Mayor => new ChineseTraditional("市長");
        public Language Lovers => new ChineseTraditional("戀人");
        public Language Sheriff => new ChineseTraditional("警長");
        public Language Engineer => new ChineseTraditional("工程師");
        public Language Swapper => new ChineseTraditional("交換者");
        public Language Investigator => new ChineseTraditional("研究者");
        public Language TimeLord => new ChineseTraditional("奇異博士");
        public Language Medic => new ChineseTraditional("軍醫");
        public Language Seer => new ChineseTraditional("預言家");
        public Language Spy => new ChineseTraditional("間諜");
        public Language Snitch => new ChineseTraditional("告密者");
        public Language Altruist => new ChineseTraditional("利他主義者");

        public Language NeutralRoles => new ChineseTraditional("中立陣營");
        public Language Jester => new ChineseTraditional("小丑");
        public Language Shifter => new ChineseTraditional("身分小偷");
        public Language TheGlitch => new ChineseTraditional("小故障");
        public Language Executioner => new ChineseTraditional("暴民");
        public Language Arsonist => new ChineseTraditional("縱火犯");
        public Language Phantom => new ChineseTraditional("怨靈");

        public Language ImpostorRoles => new ChineseTraditional("狼人陣營");
        public Language Assassin => new ChineseTraditional("暗殺者");
        public Language Janitor => new ChineseTraditional("看門人");
        public Language Morphling => new ChineseTraditional("百變怪");
        public Language Camouflager => new ChineseTraditional("魔術師");
        public Language Miner => new ChineseTraditional("礦工");
        public Language Swooper => new ChineseTraditional("隱鬼");
        public Language Undertaker => new ChineseTraditional("送葬者");
        public Language Underdog => new ChineseTraditional("快刀狗");

        public Language Modifiers => new ChineseTraditional("附加技能");
        public Language Torch => new ChineseTraditional("火把");
        public Language Diseased => new ChineseTraditional("感染者");
        public Language Flash => new ChineseTraditional("速行俠");
        public Language Tiebreaker => new ChineseTraditional("決勝者");
        public Language Drunk => new ChineseTraditional("醉漢");
        public Language Giant => new ChineseTraditional("巨人");
        public Language ButtonBarry => new ChineseTraditional("會議主持人");

        public Language CustomGameSettings => new ChineseTraditional("自定義設定");
        public Language ColourblindComms => new ChineseTraditional("通訊偽裝");
        public Language MeetingColourblind => new ChineseTraditional("會議偽裝");
        public Language ImpostorSeeRoles => new ChineseTraditional("狼人可以看到同隊成員角色");
        public Language DeadSeeRoles => new ChineseTraditional("死亡後可以看到所有人的角色");
        public Language MaxImpostorRoles => new ChineseTraditional("狼人角色最大生成數");
        public Language MaxNeutralRoles => new ChineseTraditional("中立角色最大生成數");
        public Language RoleUnderName => new ChineseTraditional("角色顯示在暱稱下方");
        public Language VanillaGame => new ChineseTraditional("完全原版生成機率");
        public Language MayorVoteBank => new ChineseTraditional("市長起始選票庫票數");
        public Language MayorAnonymous => new ChineseTraditional("市長匿名投票");
        public Language BothLoversDie => new ChineseTraditional("戀人雙死");
        public Language ShowSheriff => new ChineseTraditional("顯示警長");
        public Language SheriffKillOther => new ChineseTraditional("警長誤殺船員");
        public Language SheriffKillsJester => new ChineseTraditional("警長擊殺小丑");
        public Language SheriffKillsGlitch => new ChineseTraditional("警長擊殺小故障");
        public Language SheriffKillsArsonist => new ChineseTraditional("警長擊殺縱火犯");
        public Language SheriffKillCd => new ChineseTraditional("警長擊殺冷卻時間");
        public Language SheriffBodyReport => new ChineseTraditional("警長能夠舉報所擊殺的目標");
        public Language EngineerPer => new ChineseTraditional("修理次數");
        public Language FootprintSize => new ChineseTraditional("足跡大小");
        public Language FootprintInterval => new ChineseTraditional("足跡間隔");
        public Language FootprintDuration => new ChineseTraditional("足跡持續時間");
        public Language AnonymousFootPrint => new ChineseTraditional("匿名足跡");
        public Language VentFootprintVisible => new ChineseTraditional("可見通風口足跡");
        public Language RewindRevive => new ChineseTraditional("回溯時復活");
        public Language RewindDuration => new ChineseTraditional("回溯秒數");
        public Language RewindCooldown => new ChineseTraditional("回溯冷卻時間");
        public Language TimeLordVitals => new ChineseTraditional("奇異博士能夠使用心電圖");
        public Language ShowShielded => new ChineseTraditional("顯示被護盾保護的玩家");
        public Language MedicReportSwitch => new ChineseTraditional("顯示驗屍報告");
        public Language MedicReportNameDuration => new ChineseTraditional("限時內驗屍報告將顯示兇手名字");
        public Language MedicReportColorDuration => new ChineseTraditional("限時內驗屍報告將顯示兇手顏色");
        public Language WhoGetsNotification => new ChineseTraditional("誰會得到謀殺未遂的指示器");
        public Language ShieldBreaks => new ChineseTraditional("謀殺未遂時護盾將破裂");
        public Language SeerCooldown => new ChineseTraditional("查驗冷卻時間");
        public Language SeerInfo => new ChineseTraditional("預言家所得資訊");
        public Language SeerInfoOption0 => new ChineseTraditional("角色身分");
        public Language SeerInfoOption1 => new ChineseTraditional("角色陣營");
        public Language SeeReveal => new ChineseTraditional("誰可看見查驗資訊");
        public Language NeutralRed => new ChineseTraditional("中立陣營顯示為狼人");
        public Language SnitchOnLaunch => new ChineseTraditional("告密者遊戲開始時知道自己的身份");
        public Language SnitchSeesNeutrals => new ChineseTraditional("告密者可知中立角色");
        public Language ReviveDuration => new ChineseTraditional("復活所需時間");
        public Language AltruistTargetBody => new ChineseTraditional("復活開始時目標遺體消失");
        public Language ShifterCd => new ChineseTraditional("轉職冷卻時間");
        public Language WhoShifts => new ChineseTraditional("被轉職後，誰能成為身份小偷");
        public Language MimicCooldownOption => new ChineseTraditional("模仿冷卻時間");
        public Language MimicDurationOption => new ChineseTraditional("模仿維持時間");
        public Language HackCooldownOption => new ChineseTraditional("干擾冷卻時間");
        public Language HackDurationOption => new ChineseTraditional("干擾維持時間");
        public Language GlitchKillCooldownOption => new ChineseTraditional("小故障擊殺冷卻時間");
        public Language InitialGlitchKillCooldownOption => new ChineseTraditional("開場時小故障擊殺冷卻時間");
        public Language GlitchHackDistanceOption => new ChineseTraditional("小故障干擾距離");
        public Language OnTargetDead => new ChineseTraditional("暴民目標死亡後轉職角色");
        public Language DouseCooldown => new ChineseTraditional("潑油冷卻時間");
        public Language ArsonistGameEnd => new ChineseTraditional("縱火犯死亡時遊戲是否繼續");
        public Language MorphlingCooldown => new ChineseTraditional("變身冷卻時間");
        public Language MorphlingDuration => new ChineseTraditional("變身維持時間");
        public Language CamouflagerCooldown => new ChineseTraditional("偽裝冷卻時間");
        public Language CamouflagerDuration => new ChineseTraditional("偽裝維持時間");
        public Language MineCooldown => new ChineseTraditional("挖洞冷卻時間");
        public Language SwoopCooldown => new ChineseTraditional("隱形冷卻時間");
        public Language SwoopDuration => new ChineseTraditional("隱形維持時間");
        public Language DragCooldown => new ChineseTraditional("拖屍冷卻時間");
        public Language AssassinKills => new ChineseTraditional("刺客擊殺數");
        public Language AssassinCrewmateGuess => new ChineseTraditional("刺客可以猜測船員");
        public Language AssassinGuessNeutrals => new ChineseTraditional("刺客可以猜測中立職業");
        public Language AssassinMultiKill => new ChineseTraditional("刺客可以在會議中殺多於一人");



        public Language PerRound => new ChineseTraditional("每輪次");
        public Language PerGame => new ChineseTraditional("每場遊戲");
        public Language Nobody => new ChineseTraditional("沒有人");
        public Language Everyone => new ChineseTraditional("所有人");
        public Language On => new ChineseTraditional("開");
        public Language Off => new ChineseTraditional("關");
        public Language Second => new ChineseTraditional("秒"); 
        public Language Short => new ChineseTraditional("短");
        public Language Normal => new ChineseTraditional("標準");
        public Language Long => new ChineseTraditional("長");


        public Language Shielded => new ChineseTraditional("有護盾的玩家");
        public Language ShieldedAndMedic => new ChineseTraditional("有護盾的玩家與軍醫");
        public Language ImpAndNeu => new ChineseTraditional("中立陣營及狼人陣營");
        public Language NoImps => new ChineseTraditional("非狼人陣營");
        public Language RegCrew => new ChineseTraditional("一般船員");



    }
}
