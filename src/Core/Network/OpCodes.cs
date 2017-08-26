﻿namespace Destiny.Core.Network
{
    public enum ClientOperationCode : short
    {
        AccountLogin = 1,
        GuestLogin = 2,
        AccountInfo = 3,
        WorldRelist = 4,
        WorldSelect = 5,
        WorldStatus = 6,
        EULA = 7,
        AccountGender = 8,
        PinCheck = 9,
        PinUpdate = 10,
        WorldList = 11,
        LeaveCharacterSelect = 12,
        ViewAllChar = 13,
        SelectCharacterByVAC = 14,
        VACFlagSet = 15,
        //16
        //17
        //18
        CharacterSelect = 19,
        CharacterLoad = 20,
        CharacterNameCheck = 21,
        CharacterCreate = 22,
        CharacterDelete = 23,
        //24
        ClientError = 25,
        Pong = 26,
        //27
        //28
        CharacterSelectRegisterPic = 29,
        CharacterSelectRequestPic = 30,
        RegisterPicFromVAC = 31,
        RequestPicFromVAC = 32,
        //32
        //33
        //34
        ClientStart = 35,
        //36
        //37
        MapChange = 38,
        ChannelChange = 39,
        CashShopMigration = 40,
        PlayerMovement = 41,
        Sit = 42,
        UseChair = 43,
        CloseRangeAttack = 44,
        RangedAttack = 45,
        MagicAttack = 46,
        EnergyOrbAttack = 47,
        TakeDamage = 48,
        PlayerChat = 49,
        CloseChalkboard = 50,
        FaceExpression = 51,
        UseItemEffect = 52,
        UseDeathItem = 53,
        //54
        //55
        //56
        //MonsterBookCover? = 57
        NpcConverse = 58,
        //RemoteStore? = 59
        NpcResult = 60,
        NpcShop = 61,
        Storage = 62,
        HiredMerchant = 0x3F,
        //DueyAction? FredrickAction? = 0x40,
        //65
        //66
        //67
        AdminShopAction = 68,
        InventorySort = 0x45,
        InventoryGather = 0x46,
        InventoryAction = 0x47,
        UseItem = 0x48,
        CancelItemEffect = 0x49,
        UseSummonBag = 0x4B,
        UsePetFood = 0x4C,
        UseMountFood = 0x4D,
        UseScriptedItem = 0x4E,
        UseCashItem = 0x4F,

        #region QUESTIONABLE
        UseCatchItem = 0x50,
        UseSkillBook = 0x51,
        //82
        //89
        #endregion QUESTIONABLE

        UseTeleportRock = 84,
        UseReturnScroll = 85,
        UseUpgradeScroll = 86,
        DistributeAP = 87,
        AutoDistributeAP = 88,
        HealOverTime = 89,
        DistributeSP = 0x5A,
        UseSkill = 0x5B,
        CancelBuff = 0x5C,
        SkillEffect = 0x5D,
        MesoDrop = 0x5E,
        GiveFame = 0x5F,
        PlayerInformation = 97,
        SpawnPet = 0x62,
        CancelDebuff = 0x63,
        ChangeMapSpecial = 100,
        UseInnerPortal = 101,
        TrockAction = 102,
        Report = 106,

        #region QUESTIONABLE
        //103
        //104
        //106
        QuestAction = 107,
        //108
        SkillMacro = 0x6D,
        SpouseChat = 0x6E,
        UseFishingItem = 0x6F,
        MakerSkill = 0x70,
        //113
        //114
        UseRemote = 0x73,
        PartyChat = 0x74,
        //115
        //117
        //119
        //120
        //121
        //122
        #endregion QUESTIONABLE

        MultiChat = 119,
        Command = 120,
        Messenger = 122,
        PlayerInteraction = 123,
        PartyOperation = 124,
        DenyPartyRequest = 125,
        GuildOperation = 126,
        DenyGuildRequest = 127,
        AdminCommand = 128,
        AdminLog = 129,
        BuddyListModify = 130,
        NoteAction = 131,
        UseDoor = 132,
        ChangeKeymap = 135,
        FamilyPedigree = 145,
        FamilyOpen = 146,
        BbsOperation = 155,
        MovePet = 167,
        MobAutomaticProvoke = 189,
        NpcMovement = 197,

        #region QUESTIONABLE
        RingAction = 136,
        OpenFamily = 0x90,
        AddFamily = 0x91,
        AcceptFamily = 0x94,
        UseFamily = 0x95,
        AllianceOperation = 0x96,
        MtsMigration = 0x9A,
        PetTalk = 0x9B,
        UseSolomonItem = 0x9C,
        PetChat = 0xA2,
        PetCommand = 0xA3,
        PetLoot = 0xA4,
        PetAutoPot = 0xA5,
        PetExcludeItems = 0xA6,
        MoveSummon = 0xA9,
        SummonAttack = 0xAA,
        DamageSummon = 0xAB,
        Beholder = 0xAC,
        MobMovement = 0xBC,
        MobDamageModFriendly = 0xB6,
        MonsterBomb = 0xB7,
        MobDamageMob = 0xB8,
        NpcAction = 0xBB,
        DropPickup = 0xCA,
        DamageReactor = 0xC3,
        ChangedMap = 0xC4,
        MonsterCarnival = 0xD0,
        PlayerUpdate = 0xD5,
        CashShopOperation = 0xDA,
        BuyCashItem = 0xDB,
        CouponCode = 0xDC,
        LeaveField = 0xDF,
        OpenItemInterface = 0xE1,
        CloseItemInterface = 0xE2,
        UseItemInterface = 0xE3,
        MtsOperation = 0xF1,
        UseMapleLife = 0xF4,
        UseHammer = 0xF8,
        MapleTV = 0x222,
        #endregion QUESTIONABLE

        HitReactor = 205,
        TouchReactor = 206,
        //207
        PartySearchStart = 222,
        PartySearchStop = 223,
    }

    public enum ServerOperationCode : short
    {
        /*CLogin::OnPacket*/
        CheckPasswordResult = 0,
        GuestIDLoginResult = 1,
        AccountInfoResult = 2,
        CheckUserLimitResult = 3,
        SetAccountResult = 4,
        ConfirmEULAResult = 5,
        CheckPinCodeResult = 6,
        UpdatePinCodeResult = 7,
        ViewAllCharResult = 8,
        SelectCharacterByVACResult = 9,
        WorldInformation = 10,
        SelectWorldResult = 11,
        SelectCharacterResult = 12,
        CheckDuplicatedIDResult = 13,
        CreateNewCharacterResult = 14,
        DeleteCharacterResult = 15,
        /*CClientSocket::ProcessPacket*/
        MigrateCommand = 16,
        Ping = 17,
        AuthenCodeChanged = 18,
        AuthenMessage = 19,
        ChannelSelected = 20,
        HackshieldRequest = 21,
        WorldCharacterCreationDisabled = 22,
        MapleEuropeRequired = 23,
        //24
        CheckCRCResult = 25,
        LastConnectedWorld = 26,
        RecommendedWorldMessage = 27,
        CheckSPWResult = 28,

        /*CWvsContext::OnPacket*/
        InventoryOperation = 29,
        InventoryGrow = 30,
        StatChanged = 31,
        TemporaryStatSet = 32,
        TemporaryStatReset = 33,
        ForcedStatSet = 34,
        ForcedStatReset = 35,
        ChangeSkillRecordResult = 36,
        SkillUseResult = 37,
        GivePopularityResult = 38,
        Message = 39,
        OpenFullClientDownloadLink = 40,
        MemoResult = 41,
        MapTransferResult = 42,
        AntiMacroResult = 43,
        //44
        ClaimResult = 45,
        SetClaimSvrAvailableTime = 46,
        ClaimSvrStatusChanged = 47,
        SetTaminbMobInfo = 48,
        QuestClear = 49,
        EntrustedShopCheckResult = 50,
        SkillLearnItemResult = 51,
        GatherItemResult = 52,
        SortItemResult = 53,
        //54
        SueCharacterResult = 55,
        //56
        TradeMoneyLimit = 57,
        SetGender = 58,
        GuildBBSPacket = 59,
        //60
        CharacterInformation = 61,
        PartyResult = 62,
        FriendResult = 63,
        //64
        GuildResult = 65,
        AllianceResult = 66,
        TownPortal = 67,
        BroadcastMsg = 68,
        IncubatorResult = 69,
        ShopScannerResult = 70,
        ShopLinkResult = 71,
        MarriageRequest = 72,
        MarriageResult = 73,
        WeddingGiftResult = 74,
        NotifyMarriedPartnerMapTransfer = 75,
        CashPetFoodResult = 76,
        SetWeekEventMessage = 77,
        SetPotionDiscountRate = 78,
        BridleMobCatchFail = 79,
        ImitatedNPCResult = 80,
        NpcImitateData = 81,
        NpcUpdateLimitedDisableInfo = 82,
        MonsterBookSetCard = 83,
        MonsteBookSetCover = 84,
        HourChanged = 85,
        MiniMapOnOff = 86,
        ConsultAuthkeyUpdate = 87,
        ClassCompetitionAuthkeyUpdate = 88,
        WebBoardAuthkeyUpdate = 89,
        SessionValue = 90,
        PartyValue = 91,
        FieldSetVariable = 92,
        BonusExpRateChanged = 93,
        FamilyChartResult = 94,
        FamilyInfoResult = 95,
        FamilyResult = 96,
        FamilyJoinRequest = 97,
        FamilyJoinRequestResult = 98,
        FamilyJoinAccepted = 99,
        FamilyPrivilegeList = 100,
        FamilyFamousPointIncResult = 101,
        FamilyNotifyLoginOrLogout = 102,
        FamilySetPrivilege = 103,
        FamilySummonRequest = 104,
        NotifyLevelUp = 105,
        NotifyWedding = 106,
        NotifyJobChange = 107,
        //108
        MapleTVUseRes = 109,
        AvatarMegaphoneRes = 110,
        SetAvatarMegaphone = 111,
        ClearAvatarMegaphone = 112,
        CancelNameChangeResult = 113,
        CancelTransferWorldResult = 114,
        DestroyShopResult = 115,
        FakeGMNotice = 116,
        SuccessInUsegachaponBox = 117,
        NewYearCardRes = 118,
        RandomMorphRes = 119,
        CancelNameChangebyOther = 120,
        SetBuyEquipExt = 121,
        ScriptProgressMessage = 122,
        DataCRCCheckFailed = 123,
        MacroSysDataInit = 124,

        /*CStage::OnPacket*/
        SetField = 125,
        SetITC = 126,
        SetCashShop = 127,

        /*CMapLoadable::OnPacket*/
        SetBackEffect = 128,
        SetMapObjectVisible = 129,
        ClearBackEffect = 130,

        /*CField::OnPacket*/
        TransferFieldReqInogred = 131,
        TransferChannelReqIgnored = 132,
        FieldSpecificData = 133,
        GroupMessage = 134,
        Whisper = 135,
        CoupleMessage = 136,
        SummonItemInavailable = 137,
        FieldEffect = 138,
        FieldObstacleOnOff = 139,
        FieldObstacleOnOffStatus = 140,
        FieldObstacleReset = 141,
        BlowWeather = 142,
        PlayJukebox = 143,
        AdminResult = 144,
        Quiz = 145,
        Desc = 146,
        Clock = 147,
        ContiMove = 148,
        ContiState = 149,
        SetQuestClear = 150,
        SetQuestTime = 151,
        WarnMessage = 152,
        SetObjectState = 153,
        DestroyClock = 154,
        AriantArenaShowResult = 155,
        StalkResult = 156,
        PyramidGauge = 157,
        PyramidScore = 158,
        //159
        /*CUserPool::OnPacket*/
        UserEnterField = 160,
        UserLeaveField = 161,
        /*CUserPool::OnUserCommonPacket*/
        UserChat = 162,
        //163
        Chalkboard = 164,
        AnnounceBox = 165,
        ShowConsumeEffect = 166,
        ShowScrollEffect = 167,

        /*CUser::OnPetPacket*/
        PetEnterField = 168,
        //169
        PetMove = 170,
        PetAction = 171,
        PetNameChanged = 172,
        PetLoadExceptionList = 173,
        PetActionCommand = 174,
        /*CSummonedPool::OnPacket*/
        SummonedCreated = 175,
        SummonedRemoved = 176,
        SummonedMove = 177,
        SummonedAttack = 178,
        SummonedHit = 179,
        SummonedSkill = 180,
        /*CUser::OnDragonPacket*/
        DragonEnterField = 181,
        DragonMove = 182,
        //183
        //184

        /*CUserPool::OnUserRemotePacket*/
        Move = 185,
        CloseRangeAttack = 186,
        RangedAttack = 187,
        MagicAttack = 188,
        EnergyAttack = 189,
        SkillPrepare = 190,
        SkillCancel = 191,
        Hit = 192,
        Emotion = 193,
        SetActiveEffectItem = 194,
        ShowUpgradeTombEffect = 195,
        SetActiveRemoteChair = 196,
        AvatarModified = 197,
        RemoteEffect = 198,
        SetTemporaryStat = 199,
        ResetTemporaryStat = 200,
        RecieveHP = 201,
        GuildNameChanged = 202,
        GuildMarkChanged = 203,
        ThrowGrenade = 204,

        /*CUserLocal::OnPacket*/
        Sit = 205,
        Effect = 206,
        Teleport = 207,
        //208
        MesoGiveSucceeded = 209,
        MesoGiveFailed = 210,
        QuestResult = 211,
        NotifyHPDecByField = 212,
        SkillCooltimeSet = 213,
        BalloonMsg = 214,
        PlayEventSound = 215,
        PlayMinigameSound = 216,
        MakerResult = 2176,
        //218
        OpenCLassCompetetionPage = 219,
        OpenUI = 220,
        OpenUIWithOption = 221,
        SetStandAloneMode = 222,
        HireTutor = 223,
        TutorMsg = 224,
        IncComboResponse = 225,
        //226
        //227
        //228
        RadioSchedule = 229,
        OpenSkillGuide = 230,
        NoticeMsg = 231,
        //232
        //233
        Cooldown = 234,
        //235
        
        /*CMobPool::OnPacket*/
        MobEnterField = 236,
        MobLeaveField = 237,
        MobChangeController = 238,
        /*CMobPool::OnMobPacket*/
        MobMove = 239,
        MobCtrlAck = 240,
        //241
        MobStatSet = 242,
        MobStatReset = 243,
        MobSuspendReset = 244,
        MobAffected = 245,
        MobDamaged = 246,
        MobSpecialEffectBySkill = 247,
        //248
        MobCrcKeyChanged = 249,
        MobHPIndicator = 250,
        MobCatchEffect = 251,
        MobEffectByItem = 252,
        MobSpeaking = 253,
        MobIncMobChargeCount = 254,
        MobAttackedByMob = 255,
        //256

        /*CNpcPool::OnPacket*/
        NpcEnterField = 257,
        NpcLeaveField = 258,
        NpcChangeController = 259,
        /*CNpcPool::OnNpcPacket*/
        NpcMove = 260,
        NpcUpdateLimitedInfo = 261,
        NpcSetSpecialAction = 262,
        /*CNpcPool::OnNpcTemplatePacket*/
        NpcSetNpcScript = 263,

        //264

        /*CEmployeePool::OnPacket*/
        EmployeeEnterField = 265,
        EmployeeLeaveField = 266,
        EmployeeMiniRoomBalloon = 267,

        /*CDropPool::OnPacket*/
        DropEnterField = 268,
        DropLeaveField = 269,

        /*CMessageBoxPool::OnPacket*/
        MessageBoxCreateFailed = 270,
        MessageBoxEnterField = 271,
        MessageBoxLeaveField = 272,

        /*CAffectedAreaPool::OnPacket*/
        AffectedAreaCreated = 273,
        AffectedAreaRemoved = 274,

        /*CTownPortalPool::OnPacket*/
        TownPortalCreated = 275,
        TownPortalRemoved = 276,

        /*CReactorPool::OnPacket*/
        ReactorChangeState = 277,
        ReactorMove = 278, // NOTE: May not be implemented in v83 client.
        ReactorEnterField = 279,
        ReactorLeaveField = 280,

        SnowballState = 281,
        HitSnowball = 282,
        SnowballMejssage = 283,
        LeftKb = 284,
        CoconutHit = 285,
        CoconutScore = 286,
        GuildBossHealerMove = 287,
        GuildBossPulleyStateChange = 288,
        MonsterCarnivalEnter = 289,
        MonsterCarnivalPersonalCP = 290,
        MonsterCarnivalTeamCP = 291,
        MonsterCarnivalRequestResult1 = 292,
        MonsterCarnivalRequestResult0 = 293,
        MonsterCarnivalProcessForDeath = 294,
        MonsterCarnivalShowMemberOutMsg = 295,
        MonsterCarnivalShowGameResult = 296,
        AriantAreaUserScore = 297,
        //298
        SheepRanchInfo = 299,
        SheepRanchClothes = 300,
        AriantScore = 301,
        HorntailCave = 302,
        ZakumShrine = 303,

        /*CScriptMan::OnPacket*/
        ScriptMessage = 304,

        /*CShopDlg::OnPacket*/
        OpenNpcShop = 305,
        ConfirmShopTransaction = 306,

        /*CAdminShopDlg::OnPacket*/
        AdminShopMessage = 307,
        AdminShop = 308,
        Storage = 309,

        /*CStoreBankDlg::OnPacket*/
        StoreBankDlgMessage = 310, // TODO: Correct naming.
        StoreBankDlgSet = 311, // TODO: Correct naming.

        RPSGame = 312,
        Messenger = 313,
        PlayerInteraction = 314,
        Tournament = 315,
        TournamentMatchTable = 316,
        TournamentSetPrize = 317,
        TournamentUEW = 318,
        TournamentCharacters = 319,
        WeddingProgress = 320,
        WeddingCeremonyEnd = 321,
        Parcel = 322,
        ChangeParamResult = 323,
        QuestCashResult = 324,
        CashShopOperation = 325,
        // 326
        //327
        //328
        //329
        //330
        //331
        //332
        //333
        //334

        /*CFuncKeyMappedMan::OnPacket*/
        FuncKeyMappedInit = 335,
        FuncKeyMappedPetConsumeItemInit = 336,
        FuncKeyMappedPetConsumeMPItemInit = 337,

        //338
        //339
        //340

        /*CMapleTVMan::OnPacket*/
        MapleTVSetMessage = 341,
        MapleTVClearMessage = 342,
        MapleTVSendMessageResult = 343,

        //344
        //345
        //346
        MTSOperation2 = 347,
        MTSOperation = 348,
        //349
        //350
        //351
        //352
        //353
        ViciousHammer = 354
    }
}
