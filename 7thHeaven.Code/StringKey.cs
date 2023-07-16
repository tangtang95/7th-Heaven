﻿namespace _7thHeaven.Code
{
    /// <summary>
    /// enum is equivalent to the Keys located in SeventhHeavenUI/Resources/StringResources.xaml
    /// and is used to reference strings.
    /// </summary>
    public enum StringKey
    {
        Play,
        PlayWithMods,
        StartedClickHereToViewAppLog,
        HintLabel,
        CheckingForUpdates,
        ModRequiresModsIsMissingWarning,
        UnsupportedModVersionsWarning,
        ThisModRequiresYouActivateFollowingMods,
        ModRequiresYouDeactivateTheFollowingMods,
        CannotActivateModBecauseItIsIncompatibleWithOtherMod,
        CannotActivateModBecauseDependentIsIncompatible,
        SelectAll,
        Unknown,
        UpdateAvailable,
        UpdateDownloading,
        NoUpdates,
        UpdatesIgnored,
        AutoUpdate,
        FollowingErrorsFoundInConfiguration,
        ErrorsFoundInGeneralSettingsViewAppLog,
        AppUpdateIsAvailableMessage,
        NewVersionAvailable,
        ThisModContainsDataThatCouldHarm,
        CannotOpenHelp,
        SubscriptionIsAlreadyAdded,
        AddedToSubscriptions,
        IrosLinkMayBeFormatedIncorrectly,
        FailedToSetBackgroundImageFromTheme,
        AllowModToRun,
        ThisModAlsoRequiresYouDownloadTheFollowing,
        ThisModRequiresTheFollowingButCouldNotBeFoundInCatalog,
        PauseResumeSelectedDownload,
        PauseSelectedDownload,
        ResumeSelectedDownload,
        NoResultsFound,
        CheckingSubscription,
        CheckingCatalog,
        UpdatedCatalogFrom,
        FailedToLoadSubscription,
        CatalogDownloadFailed,
        Resuming,
        Paused,
        Canceled,
        Warning,
        IsAlreadyDownloading,
        IsAlreadyUpdating,
        IsAlreadyDownloadedAndInstalled,
        Requirements,
        Failed,
        NoLinksFor,
        FailedToParseLinkFor,
        ExternalDownload,
        OpeningExternalUrlInBrowserFor,
        ErrorDownloading,
        WasCanceled,
        Error,
        ExternalUrlDownloadMessage1,
        ExternalUrlDownloadMessage2,
        Starting,
        Pending,
        SwitchingToBackupUrl,
        Downloading,
        Installing,
        PathToFlevelRequired,
        MissingPath,
        PathToOutputFolderRequired,
        SelectTheSectionsToExtract,
        FlevelFileDoesNotExistAtGivenPath,
        OutputFolderDoesNotExist,
        Complete,
        FailedToExtractTheErrorHasBeenLogged,
        ExtractComplete,
        ConfigureMod,
        ThisOptionCannotBeChangedDueToCompatibility,
        TheFollowingValuesHaveBeenRemovedDueToCompatibility,
        FailedToPlayPreviewAudio,
        DownloadingPreviewImage,
        InsertAndClickImport,
        GameLauncherSettingsUpdated,
        FailedToSaveLaunchSettings,
        ErrorCopyingFf7InputCfg,
        NoFf7InputCfgFoundAt,
        AlreadyExistsAt,
        ChoosingAnyOtherOptionBesidesCustom7HGameDriver,
        ReunionWarningMessage,
        YouShouldLeaveThisSettingOn,
        ProgramToRunNotFound,
        ImportMissingMoviesWarningMessage,
        LookingFor,
        InsertToContinue,
        PleaseInsertToContinueCopying,
        InsertDisc,
        FoundDiscAt,
        Overwriting,
        Copying,
        FailedToFindAt,
        AnErrorOccurredCopyingMovies,
        SuccessfullyCopiedMovies,
        FinishedCopyingMoviesSomeFailed,
        SaveControlConfiguration,
        SaveControlsPreset,
        ImportCurrentControlsFromGameAndSaveAs,
        SaveError,
        ControlNameIsEmpty,
        ControlNameContainsInvalidChars,
        ControlsWithThatNameAlreadyExist,
        SuccessfullyCreatedCustomControls,
        FailedToCreateCustomControls,
        SuccessfullyDeletedCustomControls,
        FailedToDeleteCustomControls,
        EnterNameForCatalog,
        GeneralSettingsHaveBeenUpdated,
        SettingsNotValid,
        MissingFf7ExePath,
        MissingLibraryPath,
        MissingTexturesPath,
        MissingMoviePath,
        FailedToRegisterIroModFilesWith7thHeaven,
        FailedToUnregisterIroModFilesWith7thHeaven,
        FailedToUnregisterIrosLinksWith7thHeaven,
        FailedToRegisterIrosLinksWith7thHeaven,
        FailedToCreate7thHeavenContextMenuEntries,
        FailedToRemove7thHeavenContextMenuEntries,
        CatalogNameWillAutoResolveOnSave,
        ResolvingCatalogName,
        UrlMustBeInIrosFormat,
        ResolvingCatalogNameFor,
        SelectAnIroFileToImport,
        SelectAFolderThatContainsModFiles,
        SelectAFolderThatContainsIroModFilesAndFolders,
        ImportingModsPleaseWait,
        ValidationError,
        ImportError,
        EnterPathToAnIroFile,
        IroFileDoesNotExist,
        SuccessfullyImported,
        CanNotImportMod,
        FailedToImportModTheErrorHasBeenLogged,
        EnterPathToFolderContainingModFiles,
        DirectoryDoesNotExist,
        EnterPathToFolderContainingIroFilesOrModFolders,
        GeneratingLinks,
        FailedToGenerateLinks,
        EnterMegaFolderIdToGenerateLinks,
        NoLinksFoundInFolder,
        MissingRequirements,
        UnsupportedVersion,
        MissingRequiredActiveMods,
        DeactivateModsWarning,
        Uninstalled,
        CanNotReOrderModItHasBeenRemoved,
        CanNotConfigureModItHasBeenRemoved,
        CanNotConfigureModFailedToReadModXml,
        ThereAreNoOptionsToConfigureForThisMod,
        NoOptions,
        NewVersionOfModAvailable,
        CouldNotLoadModXml,
        CouldNotSaveModXml,
        SuccessfullySavedTo,
        ActiveProfileFileDoesNotExist,
        EnterProfileName,
        SaveActiveProfile,
        SuccessfullySavedAsNewProfile,
        FailToSaveAsNewProfile,
        ProfileDoesNotExist,
        HasItBeenDeletedAlready,
        SuccessfullyDeletedProfile,
        FailedToDeleteProfile,
        EnterProfileNameForTheCopy,
        CopyProfile,
        SuccessfullyCopiedProfile,
        FailedToCopyProfile,
        FailedToOpenProfileDetails,
        NewProfile,
        ProfileNameIsEmpty,
        ProfileError,
        WarningProfileXmlDoesNotExistCanNotSwitch,
        LoadedProfile,
        FailedToSwitchToProfile,
        MissingRequiredInput,
        PathToSourceFolderIsRequired,
        PathToOutputIroFileIsRequired,
        SelectCompressionOption,
        InvalidPackIroOptions,
        AnErrorOccuredWhilePacking,
        PackingComplete,
        PathToOriginalIroIsRequired,
        PathToNewIroFileIsRequired,
        PathToIropFileIsRequired,
        AnErrorOccuredWhilePatching,
        PatchingComplete,
        ThemeSaved,
        ThemeSavedAs,
        FailedToSaveTheme,
        FailedToLoadTheme,
        ThemeLoadedClickSavveToSaveThis,
        SelectBackgroundImageFile,
        PathToSourceIroFileIsRequired,
        InvalidUnpackIroOptions,
        AnErrorOccuredWhileUnpacking,
        UnpackingComplete,
        CouldNotLoadModXmlFromIroFile,
        CouldNotLoadCatalogXml,
        FailedToReadRequiredSpecXmlFile,
        WillDeleteEverythingUnder,
        PathToCacheFolderDoesNotExist,
        TextureCacheCleared,
        FailedToClearTextureCache,
        GameDriverSettingsSaved,
        CouldNotWriteTo7HGameDriverCfg,
        UnknownErrorWhileSaving,
        GameDriverSettingsResetToDefaults,
        SelectProgramToRemove,
        SelectProgramToEdit,
        SelectProgramToMove,
        SelectProgramToRunSuchAs,
        LaunchingFinalFantasyVII,
        UnknownErrorWhenLaunchingGame,
        GameLaunchProcessCanceled,
        FailedToLaunchFf7ViewLogForDetails,
        SuccessfullyLaunchedFf7,
        ThisExeIsUsedForSteamReleaseFailedToCopyExe,
        ThisExeIsUsedForSteamReleaseCopiedSelectedForYou,
        ErrorIncorrectExe,
        Selected,
        CopiedAndSelected,
        ThisExeIsUsedForConfiguringFf7Settings,
        SelectFf7Exe,
        SelectMoviesFolder,
        SelectTexturesFolder,
        Select7thHeavenLibraryFolder,
        SelectSubscriptionToEdit,
        SelectSubscriptionToRemove,
        SelectSubscriptionToMove,
        SelectFolderToRemove,
        SelectFolderToMove,
        SelectIroFile,
        AreYouSureYouWantToPlayDebugWarning,
        AreYouSureYouWantToExitPendingDownloads,
        CannotExitWhileImporting,
        ConfirmExit,
        AreYouSureYouWantToDeleteSelectedProfile,
        SelectProfileToContinue,
        NoProfileSelected,
        English,
        French,
        German,
        Spanish,
        CheckingFf7IsNotRunning,
        Ff7IsAlreadyRunning,
        Ff7IsAlreadyRunningDoYouWantToForceClose,
        ForceClosingAllInstancesFf7,
        Aborting,
        FailedToCloseProcess,
        CheckingFf7ExeExistsAt,
        FileNotFoundAborting,
        Ff7ExeNotFoundYouMayNeedToConfigure,
        VerifyingInstalledGameIsCompatible,
        ErrorCodeYarr,
        VerifyingGameIsNotInstalledInProtectedFolder,
        VerifyingEnglishGameFilesExist,
        ExtractingLGPFiles,
        RenamingLanguageSpecificFiles,
        CouldNotFindFileToRename,
        WaitingForFF7WindowToBeVisible,
        CouldNotFindFileToCopy,
        AnErrorOccurredStartingULGP,
        UpdatingPathsInSysSettings,
        ForceMinimizingProgram,
        FailedToStartAdditionalProgram,
        EncodingNewLGPFiles,
        DeletingTemporaryFiles,
        BeginningToPollForGamePadInput,
        FoundLanguageInstalledCreatingEnglishGameFiles,
        Ff7IsCurrentlyInstalledInASystemFolder,
        CanNotContinueDueToFf7nstalledInProtectedFolder,
        CannotContinue,
        CopyingGameFilesTo,
        FailedToCopyFf7To,
        VerifyingGameIsMaxInstall,
        YourFf7InstallationFolderIsMissingCriticalFiles,
        CreatingMissingRequiredDirectories,
        VerifyingAdditionalFilesForBattleAndKernelFoldersExist,
        FailedToVerifyCopyMissingAdditionalFiles,
        VerifyingAllMovieFilesExist,
        CouldNotFindAllMovieFilesAt,
        AllFilesFoundAt,
        UpdatingMoviePathSetting,
        AttemptingToCopyMovieFiles,
        MovieFilesAreMissing,
        InOrderToSeeInGameMoviesYouWillNeedMessage,
        VerifyingMusicFilesExist,
        CouldNotFindAllMusicFilesAt,
        AttemptingToCopyMusicFiles,
        OggMusicFilesAreMissing,
        InOrderToHearHighQualityMusicYouWillNeedMessage,
        VerifyingLatestGameDriverIsInstalled,
        SomethingWentWrongTryingToDetectGameDriver,
        VerifyingGameDriverShadersFoldersExist,
        VerifyingFf7Exe,
        Ff7ExeDetectedToBeDifferent,
        FailedToCopyFf7Exe,
        FailedToCreateBackupOfFf7Exe,
        Ff7ConfigExeDetectedToBeMissingOrDifferent,
        FailedToCopyFf7ConfigExe,
        FailedToCreateBackupOfFf7ConfigExe,
        CheckingAProfileIsActive,
        ActiveProfileNotFound,
        CreateAProfileFirstAndTryAgain,
        CheckingModCompatibilityRequirements,
        FailedModCompatibilityCheck,
        CheckingModConstraintsForCompatibility,
        FailedModConstraintCheck,
        CheckingModLoadOrderRequirements,
        FailedModLoadOrderCheck,
        LookingForGameDisc,
        FoundGameDiscAt,
        FailedToFindGameDisc,
        OsDoesNotSupportAutoMounting,
        AutoMountingVirtualGameDisc,
        FailedToAutoMountVirtualDiscAt,
        LookingForGameDiscAfterMounting,
        FailedToFindGameDiscAfterAutoMounting,
        UserRequestedToPlayWithNoModsLaunchingGameAsVanilla,
        NoModsActivatedLaunchingGameAsVanilla,
        SelectedRendererIsNotSetToCustomLaunchingGameAsVanilla,
        CreatingRuntimeProfile,
        FailedToCreateRuntimeProfileForActiveMods,
        VariableDumpSetToTrueStartingTurboLog,
        CopyingEasyHookToFf7PathIfNotFoundOrOlder,
        CopyingFf7InputCfgToFf7Path,
        DebugLoggingSetToTrueDetailedLoggingWillBeWrittenTo,
        CheckingIfReunionModIsInstalled,
        Found,
        DisablingReunionMod,
        ReenablingReunionMod,
        LaunchingAdditionalProgramsToRunIfAny,
        WritingTemporaryRuntimeProfileFileTo,
        AttemptingToInjectWithEasyHook,
        ReceivedErrors,
        ReachedTimeoutWaitingForInjection,
        ReceivedUnknownError,
        FailedToInjectAfterMaxAmountOfTries,
        ErrorFailedToStartGame,
        FailedToInjectWithEasyHookMessage,
        SettingCompatibilityFixAndTryingAgain,
        StillFailedToInjectWithEasyHookAborting,
        FailedToInjectWithEasyHookAfterSettingFlags,
        UserChoseNotToSetCompatibilityFix,
        GettingFf7Proc,
        FailedToGetFf7Proc,
        DebugLoggingSetToTrueWiringUpLogFile,
        FailedToStartProcessForDebugLog,
        StartingProgramsForMods,
        StartingPluginsForMods,
        SettingUpFf7ExeToStopPluginsAndModPrograms,
        StoppingOtherProgramsForMods,
        AutoUnmountingGameDisc,
        WaitingForFf7ExeToRespond,
        ExceptionOccurredWhileTryingToStart,
        PluginAdded,
        StartingPlugin,
        FailedToGetListOfRuntimeMods,
        AddingPathsToMonitor,
        DetectedToBeOlderVersion,
        Copied,
        SkippedCopying,
        AnExceptionOccurredTryingToStartFf7At,
        ThereWasAnErrorVerifyingModConstraintSeeTheFollowingDetails,
        TheFollowingSettingsHaveBeenChangedToMakeTheseModsCompatible,
        ModRequiresYouToActivateAsWell,
        ModRequiresYouToActivateButYouDoNotHaveCompatibleVersionInstalled,
        UnsupportedModVersion,
        IncompatibleMod,
        ModIsNotCompatibleWithTheVersionYouHaveInstalled,
        ModIsNotCompatibleWithYouWillNeedToDisableIt,
        ModIsNotCompatibleAnotherModVariableUsed,
        TheFollowingModsWillNotWorkProperlyInTheCurrentOrder,
        LoadOrderIncompatible,
        ModIsMeantToComeBelowModInTheLoadOrder,
        ModIsMeantToComeAboveModInTheLoadOrder,
        CouldNotFindDdrawDllAt,
        CouldNotFindReunionDllBakAt,
        Renamed,
        ApplyingChangedValuesToRegistry,
        ApplyingCompatibilityFlagsInRegistry,
        CompatibilityFlagsFoundDeleting,
        HighDpiFixSetToTrueApplyingCompatibilityFlag,
        UsingControlConfigurationFile,
        InputCfgFileNotFoundAt,
        FailedToCopyCfgFile,
        StartingProgram,
        Started,
        WaitingForProgramToInitializeAndShow,
        TimeoutReachedWaitingForProgramToShow,
        ProgramAlreadyRunning,
        NotFoundScanningDiscsForFiles,
        FoundFileOnAtCopyingFile,
        FailedToCopyErrorHasBeenLogged,
        FailedToFindOnAnyDisc,
        FileNotFound,
        CannotCopySourceFileBecauseItIsMissingAt,
        CopyingFileFrom,
        CannotCheckIfLatestDriverIsInstalledDueToMissingFile,
        GameDriverDllFileIsUpToDate,
        BackingUpExistingGameDriverTo,
        BackingUpExistingGameDriverCfgTo,
        GameDriverCfgFileMissingCopyingDefaultFrom,
        CannotCreateDefaultCfgDueToMissingFile,
        BackingUpExistingShadersFolderTo,
        CopyingContentsOf,
        DirectoryMissingCreating,
        OldGameConverterRegistryKeysFoundBackingUp,
        MissingShadersNolightFolderCreatingDirectory,
        MissingShadersComplexMultiShaderFolderCreatingDirectory,
        MissingShadersFolderCreatingDirectory,
        MissingShadersFilesCopyingFrom,
        CheckingForUpdatesUsingChannel,
        FailedToCheckForUpdatesAt,
        MakeSureToCopyToTheRootFolder,
        Info,
        Name,
        Author,
        Released,
        Category,
        Size,
        Inst,
        Active,
        Japanese,
        Graphics,
        Cheats,
        Rendering,
        Advanced,
        FailedToCopyDirectory,
        FailedToMoveDirectory,
        FailedToDeleteFiles,
        FailedToGetPreviewImage,
        ErrorOccurredDownloadingInstalling,
        Installed,
        Updated,
        ErrorUpdating,
        FailedToGetModInfoDueToMissingVariable,
        TheFollowingModsWereNotFoundInstalledAndHaveBeenRemoved,
        ErrorLoadingSettingsPleaseConfigure7H,
        ErrorLoadingLibraryFile,
        FailedToImportMod,
        AutoImportedMod,
        CouldNotImportIroFileIsCorrupt,
        ModCouldNotBeFoundHasItBeenDeleted,
        CouldNotLoadProfile,
        FailedToPackIntoIro,
        PackingIntoIro,
        UnpackingIroIntoSubfolder,
        FailedToUnpackIro,
        SelectModToDownloadFirst,
        NoDownloadSelected,
        SelectAModFirst,
        FailedToSaveCatalogXml,
        ModNotActiveOnlyActivatedModsCanBeConfigured,
        UninstallWarning,
        AreYouSureYouWantToDelete,
        Greek,
        ModSettingNoCompatibleOptionFoundTheFollowingModsRestrictIt,
        ModChangedSettingTo,
        SaveCatalogXml,
        SelectCatalogXmlToLoad,
        SelectModXmlOrIroFileToLoad,
        SelectImageToUse,
        SaveModXml,
        SelectModXmlToLoad,
        SaveAsIroTitle,
        SelectTheFolderThatContainsAllTheModFiles,
        SaveAsIropTitle,
        SelectFolderToOutputUnpackedFiles,
        SelectFLevelLgpFile,
        SelectCustomThemeXmlFile,
        SaveCustomThemeXmlFile,
        AppHint1,
        AppHint2,
        AppHint3,
        AppHint4,
        AppHint5,
        AppHint6,
        AppHint7,
        AppHint8,
        AppHint9,
        AppHint10,
        AppHint11,
        AppHint12,
        AppHint13,
        AppHint14,
        AppHint15,
        AppHint16,
        AppHint17,
        AppHint18,
        AppHint19,
        AppHint20,
        AppHint21,
        AppHint22,
        AppHint23,
        AppHint24,
        AppHint25,
        AppHint26,
        AppHint27,
        AppHint28,
        AppHint29,
        AppHint30,
        AppHint31,
        AppHint32,
        AppHint33,
        AppHint34,
        AppHint35,
        AppHint36,
        AppHint37,
        AppHint38,
        AppHint39,
        AppHint40,
        AppHint41,
        AppHint42,
        AppHint43,
        ModManagerForFinalFantasy7,
        Miscellaneous,
        Animations,
        BattleModels,
        BattleTextures,
        FieldModels,
        FieldTextures,
        Gameplay,
        Media,
        Minigames,
        SpellTextures,
        UserInterface,
        WorldModels,
        WorldTextures,
        Cancelling,
        Volume,
        Esc,
        D1,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        D9,
        D0,
        Minus,
        Equal,
        Backspace,
        Tab,
        LeftBracket,
        RightBracket,
        Return,
        LeftCtrl,
        Semicolon,
        Apostrophe,
        Backquote,
        LeftShift,
        Backslash,
        Comma,
        Period,
        Slash,
        RightShift,
        NumpadMultiply,
        LeftAlt,
        Space,
        Caps,
        Numlock,
        Scrolllock,
        Numpad7,
        Numpad8,
        Numpad9,
        Numpad0,
        NumpadSubtract,
        Numpad5,
        Numpad6,
        NumpadAdd,
        Numpad1,
        Numpad2,
        Numpad3,
        NumpadDecimal,
        NumpadEnter,
        RightCtrl,
        NumpadDivide,
        PrtScn,
        RightAlt,
        PauseBreak,
        Home,
        Up,
        PageUp,
        Left,
        Right,
        End,
        Down,
        PageDown,
        Insert,
        Delete,
        LeftWinKey,
        RightWinKey,
        Apps,
        MouseB1,
        MouseB2,
        MouseB3,
        Button1,
        Button2,
        Button3,
        Button4,
        Button5,
        Button6,
        Button7,
        Button8,
        Button9,
        Button10,
        BrazilianPortuguese,
        LeftTrigger,
        RightTrigger,
        DPadUp,
        DPadDown,
        DPadLeft,
        DPadRight,
        Italian,
        StartingPS4ControllerService,
        ServiceAlreadyRunning,
        AllMovieFilesAlreadyImported,
        MountDiscWithPowershell,
        MountDiscWithWinCDEmu,
        LoadingDevices,
        Button11,
        Button12,
        Button13,
        Button14,
        DoNotMount,
        CanaryWarningTitle,
        CanaryWarningMessage,
        PleaseUpdateFFNx,
        CheckForSystemDEPStatus,
        DEPDetected,
        DoYouWantToDisableDEP,
        SystemDEPDisabledPleaseReboot,
        CannotContinueWithDEPEnabled,
        SomethingWentWrongWhileDisablingDEP
    }
}
