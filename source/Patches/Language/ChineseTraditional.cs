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

        private ChineseTraditional() { }
        public static ChineseTraditional getInstance()
        {
            return new ChineseTraditional();
        }
        public new string Value { get; private set; }

        public new Language CrewmateRoles => new ChineseTraditional("好人陣營");
        public new Language Mayor => new ChineseTraditional("市長");
        public new Language Lovers => new ChineseTraditional("戀人");
        public new Language Sheriff => new ChineseTraditional("警長");
        public new Language Engineer => new ChineseTraditional("工程師");
        public new Language Swapper => new ChineseTraditional("交換者");
        public new Language Investigator => new ChineseTraditional("研究者");
        public new Language TimeLord => new ChineseTraditional("奇異博士");
        public new Language Medic => new ChineseTraditional("軍醫");
        public new Language Seer => new ChineseTraditional("預言家");
        public new Language Spy => new ChineseTraditional("間諜");
        public new Language Snitch => new ChineseTraditional("告密者");
        public new Language Altruist => new ChineseTraditional("利他主義者");

        public new Language NeutralRoles => new ChineseTraditional("中立陣營");
        public new Language Jester => new ChineseTraditional("小丑");
        public new Language Shifter => new ChineseTraditional("身分小偷");
        public new Language TheGlitch => new ChineseTraditional("小故障");
        public new Language Executioner => new ChineseTraditional("暴民");
        public new Language Arsonist => new ChineseTraditional("縱火犯");
        public new Language Phantom => new ChineseTraditional("怨靈");

        public new Language ImpostorRoles => new ChineseTraditional("狼人陣營");
        public new Language Assassin => new ChineseTraditional("暗殺者");
        public new Language Janitor => new ChineseTraditional("看門人");
        public new Language Morphling => new ChineseTraditional("百變怪");
        public new Language Camouflager => new ChineseTraditional("魔術師");
        public new Language Miner => new ChineseTraditional("礦工");
        public new Language Swooper => new ChineseTraditional("隱鬼");
        public new Language Undertaker => new ChineseTraditional("送葬者");
        public new Language Underdog => new ChineseTraditional("快刀狗");

        public new Language Modifiers => new ChineseTraditional("附加技能");
        public new Language Torch => new ChineseTraditional("火把");
        public new Language Diseased => new ChineseTraditional("感染者");
        public new Language Flash => new ChineseTraditional("速行俠");
        public new Language Tiebreaker => new ChineseTraditional("決勝者");
        public new Language Drunk => new ChineseTraditional("醉漢");
        public new Language Giant => new ChineseTraditional("巨人");
        public new Language ButtonBarry => new ChineseTraditional("會議主持人");

        public new Language CustomGameSettings => new ChineseTraditional("自定義設定");
        public new Language ColourblindComms => new ChineseTraditional("通訊偽裝");
        public new Language MeetingColourblind => new ChineseTraditional("會議偽裝");
        public new Language ImpostorSeeRoles => new ChineseTraditional("狼人可以看到同隊成員角色");
        public new Language DeadSeeRoles => new ChineseTraditional("死亡後可以看到所有人的角色");
        public new Language MaxImpostorRoles => new ChineseTraditional("狼人角色最大生成數");
        public new Language MaxNeutralRoles => new ChineseTraditional("中立角色最大生成數");
        public new Language RoleUnderName => new ChineseTraditional("角色顯示在暱稱下方");
        public new Language VanillaGame => new ChineseTraditional("完全原版生成機率");
        public new Language MayorVoteBank => new ChineseTraditional("市長起始選票庫票數");
        public new Language MayorAnonymous => new ChineseTraditional("市長匿名投票");
        public new Language BothLoversDie => new ChineseTraditional("戀人雙死");
        public new Language ShowSheriff => new ChineseTraditional("顯示警長");
        public new Language SheriffKillOther => new ChineseTraditional("警長誤殺船員");
        public new Language SheriffKillsJester => new ChineseTraditional("警長擊殺小丑");
        public new Language SheriffKillsGlitch => new ChineseTraditional("警長擊殺小故障");
        public new Language SheriffKillsArsonist => new ChineseTraditional("警長擊殺縱火犯");
        public new Language SheriffKillCd => new ChineseTraditional("警長擊殺冷卻時間");
        public new Language SheriffBodyReport => new ChineseTraditional("警長能夠舉報所擊殺的目標");
        public new Language EngineerPer => new ChineseTraditional("修理次數");
        public new Language FootprintSize => new ChineseTraditional("足跡大小");
        public new Language FootprintInterval => new ChineseTraditional("足跡間隔");
        public new Language FootprintDuration => new ChineseTraditional("足跡持續時間");
        public new Language AnonymousFootPrint => new ChineseTraditional("匿名足跡");
        public new Language VentFootprintVisible => new ChineseTraditional("可見通風口足跡");
        public new Language RewindRevive => new ChineseTraditional("回溯時復活");
        public new Language RewindDuration => new ChineseTraditional("回溯秒數");
        public new Language RewindCooldown => new ChineseTraditional("回溯冷卻時間");
        public new Language TimeLordVitals => new ChineseTraditional("奇異博士能夠使用心電圖");
        public new Language ShowShielded => new ChineseTraditional("顯示被護盾保護的玩家");
        public new Language MedicReportSwitch => new ChineseTraditional("顯示驗屍報告");
        public new Language MedicReportNameDuration => new ChineseTraditional("限時內驗屍報告將顯示兇手名字");
        public new Language MedicReportColorDuration => new ChineseTraditional("限時內驗屍報告將顯示兇手顏色");
        public new Language WhoGetsNotification => new ChineseTraditional("誰會得到謀殺未遂的指示器");
        public new Language ShieldBreaks => new ChineseTraditional("謀殺未遂時護盾將破裂");
        public new Language SeerCooldown => new ChineseTraditional("查驗冷卻時間");
        public new Language SeerInfo => new ChineseTraditional("預言家所得資訊");
        public new Language SeerInfoOption0 => new ChineseTraditional("角色身分");
        public new Language SeerInfoOption1 => new ChineseTraditional("角色陣營");
        public new Language SeeReveal => new ChineseTraditional("誰可看見查驗資訊");
        public new Language NeutralRed => new ChineseTraditional("中立陣營顯示為狼人");
        public new Language SnitchOnLaunch => new ChineseTraditional("告密者遊戲開始時知道自己的身份");
        public new Language SnitchSeesNeutrals => new ChineseTraditional("告密者可知中立角色");
        public new Language ReviveDuration => new ChineseTraditional("復活所需時間");
        public new Language AltruistTargetBody => new ChineseTraditional("復活開始時目標遺體消失");
        public new Language ShifterCd => new ChineseTraditional("轉職冷卻時間");
        public new Language WhoShifts => new ChineseTraditional("被轉職後，誰能成為身份小偷");
        public new Language MimicCooldownOption => new ChineseTraditional("模仿冷卻時間");
        public new Language MimicDurationOption => new ChineseTraditional("模仿維持時間");
        public new Language HackCooldownOption => new ChineseTraditional("干擾冷卻時間");
        public new Language HackDurationOption => new ChineseTraditional("干擾維持時間");
        public new Language GlitchKillCooldownOption => new ChineseTraditional("小故障擊殺冷卻時間");
        public new Language InitialGlitchKillCooldownOption => new ChineseTraditional("開場時小故障擊殺冷卻時間");
        public new Language GlitchHackDistanceOption => new ChineseTraditional("小故障干擾距離");
        public new Language OnTargetDead => new ChineseTraditional("暴民目標死亡後轉職角色");
        public new Language DouseCooldown => new ChineseTraditional("潑油冷卻時間");
        public new Language ArsonistGameEnd => new ChineseTraditional("縱火犯存活時遊戲是否繼續");
        public new Language MorphlingCooldown => new ChineseTraditional("變身冷卻時間");
        public new Language MorphlingDuration => new ChineseTraditional("變身維持時間");
        public new Language CamouflagerCooldown => new ChineseTraditional("偽裝冷卻時間");
        public new Language CamouflagerDuration => new ChineseTraditional("偽裝維持時間");
        public new Language MineCooldown => new ChineseTraditional("挖洞冷卻時間");
        public new Language SwoopCooldown => new ChineseTraditional("隱形冷卻時間");
        public new Language SwoopDuration => new ChineseTraditional("隱形維持時間");
        public new Language DragCooldown => new ChineseTraditional("拖屍冷卻時間");
        public new Language AssassinKills => new ChineseTraditional("刺客擊殺數");
        public new Language AssassinCrewmateGuess => new ChineseTraditional("刺客可以猜測船員");
        public new Language AssassinGuessNeutrals => new ChineseTraditional("刺客可以猜測中立職業");
        public new Language AssassinMultiKill => new ChineseTraditional("刺客可以在會議中殺多於一人");



        public new Language PerRound => new ChineseTraditional("每輪次");
        public new Language PerGame => new ChineseTraditional("每場遊戲");
        public new Language Nobody => new ChineseTraditional("沒有人");
        public new Language Everyone => new ChineseTraditional("所有人");
        public new Language On => new ChineseTraditional("開");
        public new Language Off => new ChineseTraditional("關");
        public new Language Second => new ChineseTraditional("秒");
        public new Language Short => new ChineseTraditional("短");
        public new Language Normal => new ChineseTraditional("標準");
        public new Language Long => new ChineseTraditional("長");


        public new Language Shielded => new ChineseTraditional("有護盾的玩家");
        public new Language ShieldedAndMedic => new ChineseTraditional("有護盾的玩家與軍醫");
        public new Language ImpAndNeu => new ChineseTraditional("中立陣營及狼人陣營");
        public new Language NoImps => new ChineseTraditional("非狼人陣營");
        public new Language RegCrew => new ChineseTraditional("一般船員");



    }
}
