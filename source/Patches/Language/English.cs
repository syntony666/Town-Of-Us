using System;
using System.Collections.Generic;
using System.Text;

namespace TownOfUs.Patches.Language
{
    class English: Language
    {
        private English(string value)
        {
            Value = value;
        }

        private English() { }
        public static English getInstance()
        {
            return new English();
        }
        public new string Value { get; private set; }

        public new Language CrewmateRoles => new English("Crewmate");
        public new Language Mayor => new English("市長");
        public new Language Lovers => new English("戀人");
        public new Language Sheriff => new English("警長");
        public new Language Engineer => new English("工程師");
        public new Language Swapper => new English("交換者");
        public new Language Investigator => new English("研究者");
        public new Language TimeLord => new English("奇異博士");
        public new Language Medic => new English("軍醫");
        public new Language Seer => new English("預言家");
        public new Language Spy => new English("間諜");
        public new Language Snitch => new English("告密者");
        public new Language Altruist => new English("利他主義者");

        public new Language NeutralRoles => new English("中立陣營");
        public new Language Jester => new English("小丑");
        public new Language Shifter => new English("身分小偷");
        public new Language TheGlitch => new English("小故障");
        public new Language Executioner => new English("暴民");
        public new Language Arsonist => new English("縱火犯");
        public new Language Phantom => new English("怨靈");

        public new Language ImpostorRoles => new English("狼人陣營");
        public new Language Assassin => new English("暗殺者");
        public new Language Janitor => new English("看門人");
        public new Language Morphling => new English("百變怪");
        public new Language Camouflager => new English("魔術師");
        public new Language Miner => new English("礦工");
        public new Language Swooper => new English("隱鬼");
        public new Language Undertaker => new English("送葬者");
        public new Language Underdog => new English("快刀狗");

        public new Language Modifiers => new English("附加技能");
        public new Language Torch => new English("火把");
        public new Language Diseased => new English("感染者");
        public new Language Flash => new English("速行俠");
        public new Language Tiebreaker => new English("決勝者");
        public new Language Drunk => new English("醉漢");
        public new Language Giant => new English("巨人");
        public new Language ButtonBarry => new English("會議主持人");

        public new Language CustomGameSettings => new English("自定義設定");
        public new Language ColourblindComms => new English("通訊偽裝");
        public new Language MeetingColourblind => new English("會議偽裝");
        public new Language ImpostorSeeRoles => new English("狼人可以看到同隊成員角色");
        public new Language DeadSeeRoles => new English("死亡後可以看到所有人的角色");
        public new Language MaxImpostorRoles => new English("狼人角色最大生成數");
        public new Language MaxNeutralRoles => new English("中立角色最大生成數");
        public new Language RoleUnderName => new English("角色顯示在暱稱下方");
        public new Language VanillaGame => new English("完全原版生成機率");
        public new Language MayorVoteBank => new English("市長起始選票庫票數");
        public new Language MayorAnonymous => new English("市長匿名投票");
        public new Language BothLoversDie => new English("戀人雙死");
        public new Language ShowSheriff => new English("顯示警長");
        public new Language SheriffKillOther => new English("警長誤殺船員");
        public new Language SheriffKillsJester => new English("警長擊殺小丑");
        public new Language SheriffKillsGlitch => new English("警長擊殺小故障");
        public new Language SheriffKillsArsonist => new English("警長擊殺縱火犯");
        public new Language SheriffKillCd => new English("警長擊殺冷卻時間");
        public new Language SheriffBodyReport => new English("警長能夠舉報所擊殺的目標");
        public new Language EngineerPer => new English("修理次數");
        public new Language FootprintSize => new English("足跡大小");
        public new Language FootprintInterval => new English("足跡間隔");
        public new Language FootprintDuration => new English("足跡持續時間");
        public new Language AnonymousFootPrint => new English("匿名足跡");
        public new Language VentFootprintVisible => new English("可見通風口足跡");
        public new Language RewindRevive => new English("回溯時復活");
        public new Language RewindDuration => new English("回溯秒數");
        public new Language RewindCooldown => new English("回溯冷卻時間");
        public new Language TimeLordVitals => new English("奇異博士能夠使用心電圖");
        public new Language ShowShielded => new English("顯示被護盾保護的玩家");
        public new Language MedicReportSwitch => new English("顯示驗屍報告");
        public new Language MedicReportNameDuration => new English("限時內驗屍報告將顯示兇手名字");
        public new Language MedicReportColorDuration => new English("限時內驗屍報告將顯示兇手顏色");
        public new Language WhoGetsNotification => new English("誰會得到謀殺未遂的指示器");
        public new Language ShieldBreaks => new English("謀殺未遂時護盾將破裂");
        public new Language SeerCooldown => new English("查驗冷卻時間");
        public new Language SeerInfo => new English("預言家所得資訊");
        public new Language SeerInfoOption0 => new English("角色身分");
        public new Language SeerInfoOption1 => new English("角色陣營");
        public new Language SeeReveal => new English("誰可看見查驗資訊");
        public new Language NeutralRed => new English("中立陣營顯示為狼人");
        public new Language SnitchOnLaunch => new English("告密者遊戲開始時知道自己的身份");
        public new Language SnitchSeesNeutrals => new English("告密者可知中立角色");
        public new Language ReviveDuration => new English("復活所需時間");
        public new Language AltruistTargetBody => new English("復活開始時目標遺體消失");
        public new Language ShifterCd => new English("轉職冷卻時間");
        public new Language WhoShifts => new English("被轉職後，誰能成為身份小偷");
        public new Language MimicCooldownOption => new English("模仿冷卻時間");
        public new Language MimicDurationOption => new English("模仿維持時間");
        public new Language HackCooldownOption => new English("干擾冷卻時間");
        public new Language HackDurationOption => new English("干擾維持時間");
        public new Language GlitchKillCooldownOption => new English("小故障擊殺冷卻時間");
        public new Language InitialGlitchKillCooldownOption => new English("開場時小故障擊殺冷卻時間");
        public new Language GlitchHackDistanceOption => new English("小故障干擾距離");
        public new Language OnTargetDead => new English("暴民目標死亡後轉職角色");
        public new Language DouseCooldown => new English("潑油冷卻時間");
        public new Language ArsonistGameEnd => new English("縱火犯存活時遊戲是否繼續");
        public new Language MorphlingCooldown => new English("變身冷卻時間");
        public new Language MorphlingDuration => new English("變身維持時間");
        public new Language CamouflagerCooldown => new English("偽裝冷卻時間");
        public new Language CamouflagerDuration => new English("偽裝維持時間");
        public new Language MineCooldown => new English("挖洞冷卻時間");
        public new Language SwoopCooldown => new English("隱形冷卻時間");
        public new Language SwoopDuration => new English("隱形維持時間");
        public new Language DragCooldown => new English("拖屍冷卻時間");
        public new Language AssassinKills => new English("刺客擊殺數");
        public new Language AssassinCrewmateGuess => new English("刺客可以猜測船員");
        public new Language AssassinGuessNeutrals => new English("刺客可以猜測中立職業");
        public new Language AssassinMultiKill => new English("刺客可以在會議中殺多於一人");



        public new Language PerRound => new English("每輪次");
        public new Language PerGame => new English("每場遊戲");
        public new Language Nobody => new English("沒有人");
        public new Language Everyone => new English("所有人");
        public new Language On => new English("開");
        public new Language Off => new English("關");
        public new Language Second => new English("秒");
        public new Language Short => new English("短");
        public new Language Normal => new English("標準");
        public new Language Long => new English("長");


        public new Language Shielded => new English("有護盾的玩家");
        public new Language ShieldedAndMedic => new English("有護盾的玩家與軍醫");
        public new Language ImpAndNeu => new English("中立陣營及狼人陣營");
        public new Language NoImps => new English("非狼人陣營");
        public new Language RegCrew => new English("一般船員");

    }
}
