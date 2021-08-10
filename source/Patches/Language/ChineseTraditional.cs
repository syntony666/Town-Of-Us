using System;
using System.Collections.Generic;
using System.Text;

namespace TownOfUs.Patches.Language
{
    class ChineseTraditional
    {
        private ChineseTraditional(string value)
        {
            Value = value;
        }
        public string Value { get; private set; }

        public static ChineseTraditional CrewmateRoles { get { return new ChineseTraditional("好人陣營"); } }
        public static ChineseTraditional Mayor { get { return new ChineseTraditional("市長"); } }
        public static ChineseTraditional Lovers { get { return new ChineseTraditional("戀人"); } }
        public static ChineseTraditional Sheriff { get { return new ChineseTraditional("警長"); } }
        public static ChineseTraditional Engineer { get { return new ChineseTraditional("工程師"); } }
        public static ChineseTraditional Swapper { get { return new ChineseTraditional("交換者"); } }
        public static ChineseTraditional Investigator { get { return new ChineseTraditional("研究者"); } }
        public static ChineseTraditional TimeLord { get { return new ChineseTraditional("奇異博士"); } }
        public static ChineseTraditional Medic { get { return new ChineseTraditional("軍醫"); } }
        public static ChineseTraditional Seer { get { return new ChineseTraditional("預言家"); } }
        public static ChineseTraditional Spy { get { return new ChineseTraditional("間諜"); } }
        public static ChineseTraditional Snitch { get { return new ChineseTraditional("告密者"); } }
        public static ChineseTraditional Altruist { get { return new ChineseTraditional("利他主義者"); } }
        
        public static ChineseTraditional NeutralRoles { get { return new ChineseTraditional("中立陣營"); } }
        public static ChineseTraditional Jester { get { return new ChineseTraditional("小丑"); } }
        public static ChineseTraditional Shifter { get { return new ChineseTraditional("身分小偷"); } }
        public static ChineseTraditional TheGlitch { get { return new ChineseTraditional("小故障"); } }
        public static ChineseTraditional Executioner { get { return new ChineseTraditional("暴民"); } }
        public static ChineseTraditional Arsonist { get { return new ChineseTraditional("縱火犯"); } }
        public static ChineseTraditional Phantom { get { return new ChineseTraditional("怨靈"); } }
        
        public static ChineseTraditional ImpostorRoles { get { return new ChineseTraditional("狼人陣營"); } }
        public static ChineseTraditional Assassin { get { return new ChineseTraditional("暗殺者"); } }
        public static ChineseTraditional Janitor { get { return new ChineseTraditional("看門人"); } }
        public static ChineseTraditional Morphling { get { return new ChineseTraditional("百變怪"); } }
        public static ChineseTraditional Camouflager { get { return new ChineseTraditional("魔術師"); } }
        public static ChineseTraditional Miner { get { return new ChineseTraditional("礦工"); } }
        public static ChineseTraditional Swooper { get { return new ChineseTraditional("隱鬼"); } }
        public static ChineseTraditional Undertaker { get { return new ChineseTraditional("送葬者"); } }
        public static ChineseTraditional Underdog { get { return new ChineseTraditional("快刀狗"); } }
        
        public static ChineseTraditional Modifiers { get { return new ChineseTraditional("附加技能"); } }
        public static ChineseTraditional Torch { get { return new ChineseTraditional("火把"); } }
        public static ChineseTraditional Diseased { get { return new ChineseTraditional("感染者"); } }
        public static ChineseTraditional Flash { get { return new ChineseTraditional("速行俠"); } }
        public static ChineseTraditional Tiebreaker { get { return new ChineseTraditional("決勝者"); } }
        public static ChineseTraditional Drunk { get { return new ChineseTraditional("醉漢"); } }
        public static ChineseTraditional Giant { get { return new ChineseTraditional("巨人"); } }
        public static ChineseTraditional ButtonBarry { get { return new ChineseTraditional("會議主持人"); } }

        public static ChineseTraditional CustomGameSettings { get { return new ChineseTraditional("自定義設定"); } }
        public static ChineseTraditional ColourblindComms { get { return new ChineseTraditional("通訊偽裝"); } }
        public static ChineseTraditional MeetingColourblind { get { return new ChineseTraditional("會議偽裝"); } }
        public static ChineseTraditional ImpostorSeeRoles { get { return new ChineseTraditional("狼人可以看到同隊成員角色"); } }
        public static ChineseTraditional DeadSeeRoles { get { return new ChineseTraditional("死亡後可以看到所有人的角色"); } }
        public static ChineseTraditional MaxImpostorRoles { get { return new ChineseTraditional("狼人角色最大生成數"); } }
        public static ChineseTraditional MaxNeutralRoles { get { return new ChineseTraditional("中立角色最大生成數"); } }
        public static ChineseTraditional RoleUnderName { get { return new ChineseTraditional("角色顯示在暱稱下方"); } }
        public static ChineseTraditional VanillaGame { get { return new ChineseTraditional("完全原版生成機率"); } }
        public static ChineseTraditional MayorVoteBank { get { return new ChineseTraditional("市長起始選票庫票數"); } }
        public static ChineseTraditional MayorAnonymous { get { return new ChineseTraditional("市長匿名投票"); } }
        public static ChineseTraditional BothLoversDie { get { return new ChineseTraditional("戀人雙死"); } }
        public static ChineseTraditional ShowSheriff { get { return new ChineseTraditional("顯示警長"); } }
        public static ChineseTraditional SheriffKillOther { get { return new ChineseTraditional("警長誤殺船員"); } }
        public static ChineseTraditional SheriffKillsJester { get { return new ChineseTraditional("警長擊殺小丑"); } }
        public static ChineseTraditional SheriffKillsGlitch { get { return new ChineseTraditional("警長擊殺小故障"); } }
        public static ChineseTraditional SheriffKillsArsonist { get { return new ChineseTraditional("警長擊殺縱火犯"); } }
        public static ChineseTraditional SheriffKillCd { get { return new ChineseTraditional("警長擊殺冷卻時間"); } }
        public static ChineseTraditional SheriffBodyReport { get { return new ChineseTraditional("警長能夠舉報所擊殺的目標"); } }
        public static ChineseTraditional EngineerPer { get { return new ChineseTraditional("修理次數"); } }
        public static ChineseTraditional FootprintSize { get { return new ChineseTraditional("足跡大小"); } }
        public static ChineseTraditional FootprintInterval { get { return new ChineseTraditional("足跡間隔"); } }
        public static ChineseTraditional FootprintDuration { get { return new ChineseTraditional("足跡持續時間"); } }
        public static ChineseTraditional AnonymousFootPrint { get { return new ChineseTraditional("匿名足跡"); } }
        public static ChineseTraditional VentFootprintVisible { get { return new ChineseTraditional("可見通風口足跡"); } }
        public static ChineseTraditional RewindRevive { get { return new ChineseTraditional("回溯時復活"); } }
        public static ChineseTraditional RewindDuration { get { return new ChineseTraditional("回溯秒數"); } }
        public static ChineseTraditional RewindCooldown { get { return new ChineseTraditional("回溯冷卻時間"); } }
        public static ChineseTraditional TimeLordVitals { get { return new ChineseTraditional("奇異博士能夠使用心電圖"); } }
        public static ChineseTraditional ShowShielded { get { return new ChineseTraditional("顯示被護盾保護的玩家"); } }
        public static ChineseTraditional MedicReportSwitch { get { return new ChineseTraditional("顯示驗屍報告"); } }
        public static ChineseTraditional MedicReportNameDuration { get { return new ChineseTraditional("限時內驗屍報告將顯示兇手名字"); } }
        public static ChineseTraditional MedicReportColorDuration { get { return new ChineseTraditional("限時內驗屍報告將顯示兇手顏色"); } }
        public static ChineseTraditional WhoGetsNotification { get { return new ChineseTraditional("誰會得到謀殺未遂的指示器"); } }
        public static ChineseTraditional ShieldBreaks { get { return new ChineseTraditional("謀殺未遂時護盾將破裂"); } }
        public static ChineseTraditional SeerCooldown { get { return new ChineseTraditional("查驗冷卻時間"); } }
        public static ChineseTraditional SeerInfo { get { return new ChineseTraditional("預言家所得資訊"); } }
        public static ChineseTraditional SeerInfoOption0 { get { return new ChineseTraditional("角色身分"); } }
        public static ChineseTraditional SeerInfoOption1 { get { return new ChineseTraditional("角色陣營"); } }
        public static ChineseTraditional SeeReveal { get { return new ChineseTraditional("誰可看見查驗資訊"); } }
        public static ChineseTraditional NeutralRed { get { return new ChineseTraditional("中立陣營顯示為狼人"); } }
        public static ChineseTraditional SnitchOnLaunch { get { return new ChineseTraditional("告密者遊戲開始時知道自己的身份"); } }
        public static ChineseTraditional SnitchSeesNeutrals { get { return new ChineseTraditional("告密者可知中立角色"); } }
        public static ChineseTraditional ReviveDuration { get { return new ChineseTraditional("復活所需時間"); } }
        public static ChineseTraditional AltruistTargetBody { get { return new ChineseTraditional("復活開始時目標遺體消失"); } }
        public static ChineseTraditional ShifterCd { get { return new ChineseTraditional("轉職冷卻時間"); } }
        public static ChineseTraditional WhoShifts { get { return new ChineseTraditional("被轉職後，誰能成為身份小偷"); } }
        public static ChineseTraditional MimicCooldownOption { get { return new ChineseTraditional("模仿冷卻時間"); } }
        public static ChineseTraditional MimicDurationOption { get { return new ChineseTraditional("模仿維持時間"); } }
        public static ChineseTraditional HackCooldownOption { get { return new ChineseTraditional("干擾冷卻時間"); } }
        public static ChineseTraditional HackDurationOption { get { return new ChineseTraditional("干擾維持時間"); } }
        public static ChineseTraditional GlitchKillCooldownOption { get { return new ChineseTraditional("小故障擊殺冷卻時間"); } }
        public static ChineseTraditional InitialGlitchKillCooldownOption { get { return new ChineseTraditional("開場時小故障擊殺冷卻時間"); } }
        public static ChineseTraditional GlitchHackDistanceOption { get { return new ChineseTraditional("小故障干擾距離"); } }
        public static ChineseTraditional OnTargetDead { get { return new ChineseTraditional("暴民目標死亡後轉職角色"); } }
        public static ChineseTraditional DouseCooldown { get { return new ChineseTraditional("潑油冷卻時間"); } }
        public static ChineseTraditional ArsonistGameEnd { get { return new ChineseTraditional("縱火犯死亡時遊戲是否繼續"); } }
        public static ChineseTraditional MorphlingCooldown { get { return new ChineseTraditional("變身冷卻時間"); } }
        public static ChineseTraditional MorphlingDuration { get { return new ChineseTraditional("變身維持時間"); } }
        public static ChineseTraditional CamouflagerCooldown { get { return new ChineseTraditional("偽裝冷卻時間"); } }
        public static ChineseTraditional CamouflagerDuration { get { return new ChineseTraditional("偽裝維持時間"); } }
        public static ChineseTraditional MineCooldown { get { return new ChineseTraditional("挖洞冷卻時間"); } }
        public static ChineseTraditional SwoopCooldown { get { return new ChineseTraditional("隱形冷卻時間"); } }
        public static ChineseTraditional SwoopDuration { get { return new ChineseTraditional("隱形維持時間"); } }
        public static ChineseTraditional DragCooldown { get { return new ChineseTraditional("拖屍冷卻時間"); } }
        public static ChineseTraditional AssassinKills { get { return new ChineseTraditional("刺客擊殺數"); } }
        public static ChineseTraditional AssassinCrewmateGuess { get { return new ChineseTraditional("刺客可以猜測船員"); } }
        public static ChineseTraditional AssassinGuessNeutrals { get { return new ChineseTraditional("刺客可以猜測中立職業"); } }
        public static ChineseTraditional AssassinMultiKill { get { return new ChineseTraditional("刺客可以在會議中殺多於一人"); } }



        public static ChineseTraditional PerRound { get { return new ChineseTraditional("每輪次"); } }
        public static ChineseTraditional PerGame { get { return new ChineseTraditional("每場遊戲"); } }
        public static ChineseTraditional Nobody { get { return new ChineseTraditional("沒有人"); } }
        public static ChineseTraditional Everyone { get { return new ChineseTraditional("所有人"); } }
        public static ChineseTraditional On { get { return new ChineseTraditional("開"); } }
        public static ChineseTraditional Off { get { return new ChineseTraditional("關"); } }
        public static ChineseTraditional Second { get { return new ChineseTraditional("秒"); } }


        public static ChineseTraditional Shielded { get { return new ChineseTraditional("有護盾的玩家"); } }
        public static ChineseTraditional ShieldedAndMedic { get { return new ChineseTraditional("有護盾的玩家與軍醫"); } }
        public static ChineseTraditional ImpAndNeu { get { return new ChineseTraditional("中立陣營及狼人陣營"); } }
        public static ChineseTraditional NoImps { get { return new ChineseTraditional("非狼人陣營"); } }
        public static ChineseTraditional RegCrew { get { return new ChineseTraditional("一般船員"); } }



    }
}
