namespace TownOfUs.Patches.Language
{
    class ChineseTraditional : Language
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
        public Language LoverImpostor => new ChineseTraditional("殺手戀人");

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
        public Language SeeReveal => new ChineseTraditional("誰能夠知道他們被查驗");
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
        public Language ArsonistGameEnd => new ChineseTraditional("縱火犯存活時遊戲是否繼續");
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
        public Language Crewmate => new ChineseTraditional("船員");
        public Language Impostor => new ChineseTraditional("狼人");
        public Language Role => new ChineseTraditional("角色");


        public Language GiantTaskText => new ChineseTraditional("超級慢！");
        public Language ButtonBarryTaskText => new ChineseTraditional("從任何地方召集緊急會議");
        public Language DiseasedTaskText => new ChineseTraditional("殺手殺死你時有更長的冷卻時間");
        public Language DrunkTaskText => new ChineseTraditional("顛.....倒倒倒倒 控制制制制");
        public Language FlashTaskText => new ChineseTraditional("超高速！");
        public Language TiebreakerTaskText => new ChineseTraditional("你的投票打破僵局了");
        public Language TorchTaskText => new ChineseTraditional("你能在黑暗中看清楚");

        public Language AltruistImpostorText => new ChineseTraditional("犧牲自己拯救他人");

        public Language AltruistTaskText => new ChineseTraditional("犧牲自己生命作為代價復活一個遺體");

        public Language ArsonistImpostorText => new ChineseTraditional("潑油並點燃玩家們");

        public Language ArsonistTaskText => new ChineseTraditional("潑油並點燃去殺死所有人\n假任務:");

        public Language AssassinImpostorText => new ChineseTraditional("猜對角色並在會議時刺殺");

        public Language AssassinTaskText => new ChineseTraditional("猜測人們的角色並在會議時殺死他們");

        public Language CamouflagerImpostorText => new ChineseTraditional("偽裝並使所有人變灰色");

        public Language CamouflagerTaskText => new ChineseTraditional("偽裝並暗殺");

        public Language UndertakerImpostorText => new ChineseTraditional("拖著屍體並隱藏它們");

        public Language UndertakerTaskText => new ChineseTraditional("拖著屍體四處隱藏它們避免被舉報");

        public Language EngineerImpostorText => new ChineseTraditional("維護地圖中重要的系統");

        public Language EngineerTaskText => new ChineseTraditional("能跳地洞並在任何地方修復破壞");

        public Language ExecutionerImpostorTextNull => new ChineseTraditional("奇怪...由於某些原因 你沒有目標...");
        public Language ExecutionerImpostorText => new ChineseTraditional("把 {0} 票出去吧");

        public Language ExecutionerTaskTextNull => new ChineseTraditional("奇怪... 由於某些原因 你沒有目標...");
        public Language ExecutionerTaskText => new ChineseTraditional("把 {0} 票出去吧\n假任務");

        public Language TheGlitchImpostorText => new ChineseTraditional("你是小故障");

        public Language TheGlitchTaskText => new ChineseTraditional("作為故障般的存在殺人吧");

        public Language InvestigatorImpostorText => new ChineseTraditional("檢視足跡並找到所有狼人");

        public Language InvestigatorTaskText => new ChineseTraditional("你可以看到所有人的足跡");

        public Language JanitorImpostorText => new ChineseTraditional("清理屍體");

        public Language JanitorTaskText => new ChineseTraditional("清理屍體避免被船員們發現");

        public Language JesterImpostorText => new ChineseTraditional("被票出去");

        public Language JesterTaskText => new ChineseTraditional("被票出去吧!\n假任務:");

        public Language LoverImpostorText => new ChineseTraditional("你跟 {0}{1}</color> 墮入愛河了");

        public Language LoverTaskText => new ChineseTraditional("與你的伴侶 {0} 一同存活\n 並贏得勝利");

        public Language MayorImpostorText => new ChineseTraditional("保存你的票來去複數投票");

        public Language MayorTaskText => new ChineseTraditional("保存你的票數來多次投票");

        public Language MedicImpostorText => new ChineseTraditional("創造一個護盾保護船員");

        public Language MedicTaskText => new ChineseTraditional("使用護盾保護一名船員");

        public Language MinerImpostorText => new ChineseTraditional("現在從頂部開始, 挖下去 ,這裏就是一個新通風口");

        public Language MinerTaskText => new ChineseTraditional("現在從頂部開始, 挖下去 ,這裏就是一個新通風口");

        public Language MorphlingImpostorText => new ChineseTraditional("變身成為船員");

        public Language MorphlingTaskText => new ChineseTraditional("變身成為船員進行偽裝");

        public Language PhantomImpostorText => new ChineseTraditional("");

        public Language PhantomTaskText => new ChineseTraditional("完成你所有的任務而不被發現!");

        public Language SeerImpostorText => new ChineseTraditional("調查其他人的身份");

        public Language SeerTaskText => new ChineseTraditional("調查其他人的身份找出誰是狼人");

        public Language SheriffImpostorText => new ChineseTraditional("射殺<color=#FF0000FF>狼人</color>");

        public Language SheriffTaskText => new ChineseTraditional("殺死狼人但不要誤殺船員");

        public Language ShifterImpostorText => new ChineseTraditional("在不同身份之間轉換");

        public Language ShifterTaskText => new ChineseTraditional("偷走其他人的身份\n假任務:");

        public Language SnitchImpostorText => new ChineseTraditional("完成所有任務來揭發狼人");

        public Language SnitchTaskTextDone => new ChineseTraditional("找到指向狼人的箭頭!");
        public Language SnitchTaskText => new ChineseTraditional("完成所有任務來揭發狼人!");

        public Language SpyImpostorText => new ChineseTraditional("四處窺探並尋找線索");

        public Language SpyTaskText => new ChineseTraditional("監視其他人並找出誰是狼人");

        public Language SwapperImpostorText => new ChineseTraditional("交換兩人所得的票數");

        public Language SwapperTaskText => new ChineseTraditional("交換兩人所得的票數,大肆破壞！");

        public Language SwooperImpostorText => new ChineseTraditional("短暫地進行隱身");

        public Language SwooperTaskText => new ChineseTraditional("隱身並偷偷地殺人");

        public Language TimeLordImpostorText => new ChineseTraditional("回溯時間");

        public Language TimeLordTaskText => new ChineseTraditional("回溯時間!");

        public Language UnderdogImpostorText => new ChineseTraditional("使用你翻盤的能力獲勝");

        public Language UnderdogTaskText => new ChineseTraditional("兩位狼人在場時擊殺冷卻時間較長\n只剩下一位狼人時冷卻時間較短");

        public Language Win => new ChineseTraditional("{0} 獲勝");

        public Language ExeToJesText => new ChineseTraditional("你的目標被殺死了. 現在你必須被票出去!\n假任務:[]");
    }
}
