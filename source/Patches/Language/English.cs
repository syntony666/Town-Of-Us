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

        public English()
        {
        }

        public string Value { get; private set; }

        internal static Language getInstance()
        {
            return new English();
        }

        public Language CrewmateRoles => new English("Crewmate");
        public Language Mayor => new English("市長");
        public Language Lovers => new English("戀人");
        public Language Sheriff => new English("警長");
        public Language Engineer => new English("工程師");
        public Language Swapper => new English("交換者");
        public Language Investigator => new English("研究者");
        public Language TimeLord => new English("奇異博士");
        public Language Medic => new English("軍醫");
        public Language Seer => new English("預言家");
        public Language Spy => new English("間諜");
        public Language Snitch => new English("告密者");
        public Language Altruist => new English("利他主義者");

        public Language NeutralRoles => new English("中立陣營");
        public Language Jester => new English("小丑");
        public Language Shifter => new English("身分小偷");
        public Language TheGlitch => new English("小故障");
        public Language Executioner => new English("暴民");
        public Language Arsonist => new English("縱火犯");
        public Language Phantom => new English("怨靈");

        public Language ImpostorRoles => new English("狼人陣營");
        public Language Assassin => new English("暗殺者");
        public Language Janitor => new English("看門人");
        public Language Morphling => new English("百變怪");
        public Language Camouflager => new English("魔術師");
        public Language Miner => new English("礦工");
        public Language Swooper => new English("隱鬼");
        public Language Undertaker => new English("送葬者");
        public Language Underdog => new English("快刀狗");

        public Language Modifiers => new English("附加技能");
        public Language Torch => new English("火把");
        public Language Diseased => new English("感染者");
        public Language Flash => new English("速行俠");
        public Language Tiebreaker => new English("決勝者");
        public Language Drunk => new English("醉漢");
        public Language Giant => new English("巨人");
        public Language ButtonBarry => new English("會議主持人");

        public Language CustomGameSettings => new English("自定義設定");
        public Language ColourblindComms => new English("通訊偽裝");
        public Language MeetingColourblind => new English("會議偽裝");
        public Language ImpostorSeeRoles => new English("狼人可以看到同隊成員角色");
        public Language DeadSeeRoles => new English("死亡後可以看到所有人的角色");
        public Language MaxImpostorRoles => new English("狼人角色最大生成數");
        public Language MaxNeutralRoles => new English("中立角色最大生成數");
        public Language RoleUnderName => new English("角色顯示在暱稱下方");
        public Language VanillaGame => new English("完全原版生成機率");
        public Language MayorVoteBank => new English("市長起始選票庫票數");
        public Language MayorAnonymous => new English("市長匿名投票");
        public Language BothLoversDie => new English("戀人雙死");
        public Language ShowSheriff => new English("顯示警長");
        public Language SheriffKillOther => new English("警長誤殺船員");
        public Language SheriffKillsJester => new English("警長擊殺小丑");
        public Language SheriffKillsGlitch => new English("警長擊殺小故障");
        public Language SheriffKillsArsonist => new English("警長擊殺縱火犯");
        public Language SheriffKillCd => new English("警長擊殺冷卻時間");
        public Language SheriffBodyReport => new English("警長能夠舉報所擊殺的目標");
        public Language EngineerPer => new English("修理次數");
        public Language FootprintSize => new English("足跡大小");
        public Language FootprintInterval => new English("足跡間隔");
        public Language FootprintDuration => new English("足跡持續時間");
        public Language AnonymousFootPrint => new English("匿名足跡");
        public Language VentFootprintVisible => new English("可見通風口足跡");
        public Language RewindRevive => new English("回溯時復活");
        public Language RewindDuration => new English("回溯秒數");
        public Language RewindCooldown => new English("回溯冷卻時間");
        public Language TimeLordVitals => new English("奇異博士能夠使用心電圖");
        public Language ShowShielded => new English("顯示被護盾保護的玩家");
        public Language MedicReportSwitch => new English("顯示驗屍報告");
        public Language MedicReportNameDuration => new English("限時內驗屍報告將顯示兇手名字");
        public Language MedicReportColorDuration => new English("限時內驗屍報告將顯示兇手顏色");
        public Language WhoGetsNotification => new English("誰會得到謀殺未遂的指示器");
        public Language ShieldBreaks => new English("謀殺未遂時護盾將破裂");
        public Language SeerCooldown => new English("查驗冷卻時間");
        public Language SeerInfo => new English("預言家所得資訊");
        public Language SeerInfoOption0 => new English("角色身分");
        public Language SeerInfoOption1 => new English("角色陣營");
        public Language SeeReveal => new English("誰可看見查驗資訊");
        public Language NeutralRed => new English("中立陣營顯示為狼人");
        public Language SnitchOnLaunch => new English("告密者遊戲開始時知道自己的身份");
        public Language SnitchSeesNeutrals => new English("告密者可知中立角色");
        public Language ReviveDuration => new English("復活所需時間");
        public Language AltruistTargetBody => new English("復活開始時目標遺體消失");
        public Language ShifterCd => new English("轉職冷卻時間");
        public Language WhoShifts => new English("被轉職後，誰能成為身份小偷");
        public Language MimicCooldownOption => new English("模仿冷卻時間");
        public Language MimicDurationOption => new English("模仿維持時間");
        public Language HackCooldownOption => new English("干擾冷卻時間");
        public Language HackDurationOption => new English("干擾維持時間");
        public Language GlitchKillCooldownOption => new English("小故障擊殺冷卻時間");
        public Language InitialGlitchKillCooldownOption => new English("開場時小故障擊殺冷卻時間");
        public Language GlitchHackDistanceOption => new English("小故障干擾距離");
        public Language OnTargetDead => new English("暴民目標死亡後轉職角色");
        public Language DouseCooldown => new English("潑油冷卻時間");
        public Language ArsonistGameEnd => new English("縱火犯死亡時遊戲是否繼續");
        public Language MorphlingCooldown => new English("變身冷卻時間");
        public Language MorphlingDuration => new English("變身維持時間");
        public Language CamouflagerCooldown => new English("偽裝冷卻時間");
        public Language CamouflagerDuration => new English("偽裝維持時間");
        public Language MineCooldown => new English("挖洞冷卻時間");
        public Language SwoopCooldown => new English("隱形冷卻時間");
        public Language SwoopDuration => new English("隱形維持時間");
        public Language DragCooldown => new English("拖屍冷卻時間");
        public Language AssassinKills => new English("刺客擊殺數");
        public Language AssassinCrewmateGuess => new English("刺客可以猜測船員");
        public Language AssassinGuessNeutrals => new English("刺客可以猜測中立職業");
        public Language AssassinMultiKill => new English("刺客可以在會議中殺多於一人");



        public Language PerRound => new English("每輪次");
        public Language PerGame => new English("每場遊戲");
        public Language Nobody => new English("沒有人");
        public Language Everyone => new English("所有人");
        public Language On => new English("開");
        public Language Off => new English("關");
        public Language Second => new English("秒"); 
        public Language Short => new English("短");
        public Language Normal => new English("標準");
        public Language Long => new English("長");


        public Language Shielded => new English("有護盾的玩家");
        public Language ShieldedAndMedic => new English("有護盾的玩家與軍醫");
        public Language ImpAndNeu => new English("中立陣營及狼人陣營");
        public Language NoImps => new English("非狼人陣營");
        public Language RegCrew => new English("一般船員");

        public Language GiantTaskText => new English("Super slow!");
        public Language ButtonBarryTaskText => new English("Call a button from anywhere!");
        public Language DiseasedTaskText => new English("Killing you gives Impostors a high cooldown");
        public Language DrunkTaskText => new English("Inverrrrrted contrrrrols");
        public Language FlashTaskText => new English("Superspeed!");
        public Language TiebreakerTaskText => new English("Your vote breaks ties");
        public Language TorchTaskText => new English("You can see in the dark.");

        public Language AltruistImpostorText => new English("");

        public Language AltruistTaskText => new English("");

        public Language ArsonistImpostorText => new English("");

        public Language ArsonistTaskText => new English("");

        public Language AssassinImpostorText => new English("");

        public Language AssassinTaskText => new English("");

        public Language CamouflagerImpostorText => new English("");

        public Language CamouflagerTaskText => new English("");

        public Language UndertakerImpostorText => new English("");

        public Language UndertakerTaskText => new English("");

        public Language EngineerImpostorText => new English("");

        public Language EngineerTaskText => new English("");

        public Language ExecutionerImpostorText => new English("");

        public Language ExecutionerTaskText => new English("");

        public Language TheGlitchImpostorText => new English("");

        public Language TheGlitchTaskText => new English("");

        public Language InvestigatorImpostorText => new English("");

        public Language InvestigatorTaskText => new English("");

        public Language JanitorImpostorText => new English("");

        public Language JanitorTaskText => new English("");

        public Language JesterImpostorText => new English("");

        public Language JesterTaskText => new English("");

        public Language LoverImpostorText => new English("");

        public Language LoverTaskText => new English("");

        public Language MayorImpostorText => new English("");

        public Language MayorTaskText => new English("");

        public Language MedicImpostorText => new English("");

        public Language MedicTaskText => new English("");

        public Language MinerImpostorText => new English("");

        public Language MinerTaskText => new English("");

        public Language MorphlingImpostorText => new English("");

        public Language MorphlingTaskText => new English("");

        public Language PhantomImpostorText => new English("");

        public Language PhantomTaskText => new English("");

        public Language SeerImpostorText => new English("");

        public Language SeerTaskText => new English("");

        public Language SheriffImpostorText => new English("");

        public Language SheriffTaskText => new English("");

        public Language ShifterImpostorText => new English("");

        public Language ShifterTaskText => new English("");

        public Language SnitchImpostorText => new English("");

        public Language SnitchTaskText => new English("");

        public Language SpyImpostorText => new English("");

        public Language SpyTaskText => new English("");

        public Language SwapperImpostorText => new English("");

        public Language SwapperTaskText => new English("");

        public Language SwooperImpostorText => new English("");

        public Language SwooperTaskText => new English("");

        public Language TimeLordImpostorText => new English("");

        public Language TimeLordTaskText => new English("");

        public Language UnderdogImpostorText => new English("");

        public Language UnderdogTaskText => new English("");

        public Language LoverImpostor => throw new NotImplementedException();

        public Language ExecutionerImpostorTextNull => throw new NotImplementedException();

        public Language ExecutionerTaskTextNull => throw new NotImplementedException();

        public Language SnitchTaskTextDone => throw new NotImplementedException();
    }
}
