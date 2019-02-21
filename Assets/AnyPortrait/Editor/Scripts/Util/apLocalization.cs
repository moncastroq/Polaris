﻿/*
*	Copyright (c) 2017-2019. RainyRizzle. All rights reserved
*	Contact to : https://www.rainyrizzle.com/ , contactrainyrizzle@gmail.com
*
*	This file is part of [AnyPortrait].
*
*	AnyPortrait can not be copied and/or distributed without
*	the express perission of [Seungjik Lee].
*
*	Unless this file is downloaded from the Unity Asset Store or RainyRizzle homepage, 
*	this file and its users are illegal.
*	In that case, the act may be subject to legal penalties.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

using AnyPortrait;

namespace AnyPortrait
{



	public enum TEXT
	{
		None = 0,
		Cancel = 1,
		Close = 2,
		Okay = 3,
		Remove = 4,
		Detach_Title = 5,
		Detach_Body = 6,
		Detach_Ok = 7,
		ThumbCreateFailed_Title = 8,
		ThumbCreateFailed_Body_NoFile = 9,
		GIFFailed_Title = 10,
		GIFFailed_Body_Reject = 11,
		PSDBakeError_Title_WrongDst = 12,
		PSDBakeError_Body_WrongDst = 13,
		PSDBakeError_Title_Load = 14,
		PSDBakeError_Body_LoadPath = 15,
		PSDBakeError_Body_LoadSize = 16,
		PSDBakeError_Body_ErrorCode = 17,
		AddTextureFailed_Title = 18,
		AddTextureFailed_Body = 19,
		MeshCreationFailed_Title = 20,
		MeshCreationFailed_Body = 21,
		MeshAddFailed_Title = 22,
		MeshAddFailed_Body = 23,
		AnimCreateFailed_Title = 24,
		AnimCreateFailed_Body = 25,
		AnimDuplicatedFailed_Title = 26,
		AnimDuplicatedFailed_Body = 27,
		AnimTimelineAddFailed_Title = 28,
		AnimTimelineAddFailed_Body = 29,
		AnimTimelineLayerAddFailed_Title = 30,
		AnimTimelineLayerAddFailed_Body = 31,
		AnimKeyframeAddFailed_Title = 32,
		AnimKeyframeAddFailed_Body_Already = 33,
		AnimKeyframeAddFailed_Body_Error = 34,
		MeshGroupAddFailed_Title = 35,
		MeshGroupAddFailed_Body = 36,
		BoneAddFailed_Title = 37,
		BoneAddFailed_Body = 38,
		MeshAttachFailed_Title = 39,
		MeshAttachFailed_Body = 40,
		MeshGroupAttachFailed_Title = 41,
		MeshGroupAttachFailed_Body = 42,
		ModifierAddFailed_Title = 43,
		ModifierAddFailed_Body = 44,
		ControlParamNameError_Title = 45,
		ControlParamNameError_Body_Wrong = 46,
		ControlParamNameError_Body_Used = 47,
		IKOption_Title = 48,
		IKOption_Body_Chained = 49,
		IKOption_Body_Head = 50,
		IKOption_Body_Single = 51,
		PhysicPreset_Regist_Title = 52,
		PhysicPreset_Regist_Body = 53,
		PhysicPreset_Regist_Okay = 54,
		PhysicPreset_Remove_Title = 55,
		PhysicPreset_Remove_Body = 56,
		ResetPSDImport_Title = 57,
		ResetPSDImport_Body = 58,
		ResetPSDImport_Okay = 59,
		ClosePSDImport_Title = 60,
		ClosePSDImport_Body = 61,
		MeshEditChanged_Title = 62,
		MeshEditChanged_Body = 63,
		MeshEditChanged_Okay = 64,
		ControlParamDefaultAll_Title = 65,
		ControlParamDefaultAll_Body = 66,
		ControlParamDefaultAll_Okay = 67,
		RemoveRecordKey_Title = 68,
		RemoveRecordKey_Body = 69,
		AdaptFFDTransformEdit_Title = 70,
		AdaptFFDTransformEdit_Body = 71,
		AdaptFFDTransformEdit_Okay = 72,
		AdaptFFDTransformEdit_No = 73,
		RemoveImage_Title = 74,
		RemoveImage_Body = 75,
		RemoveAnimClip_Title = 76,
		RemoveAnimClip_Body = 77,
		AnimClipMeshGroupChanged_Title = 78,
		AnimClipMeshGroupChanged_Body = 79,
		RemoveControlParam_Title = 80,
		RemoveControlParam_Body = 81,
		ResetMeshVertices_Title = 82,
		ResetMeshVertices_Body = 83,
		ResetMeshVertices_Okay = 84,
		RemoveMesh_Title = 85,
		RemoveMesh_Body = 86,
		RemoveMeshVertices_Title = 87,
		RemoveMeshVertices_Body = 88,
		RemoveMeshVertices_Okay = 89,
		RemoveMeshGroup_Title = 90,
		RemoveMeshGroup_Body = 91,
		RemoveBonesAll_Title = 92,
		RemoveBonesAll_Body = 93,
		RemoveKeyframes_Title = 94,
		RemoveKeyframes_Body = 95,
		DetachChildBone_Title = 96,
		DetachChildBone_Body = 97,
		RemoveModifier_Title = 98,
		RemoveModifier_Body = 99,
		RemoveFromKeys_Title = 100,
		RemoveFromKeys_Body = 101,
		RemoveFromRigging_Title = 102,
		RemoveFromRigging_Body = 103,
		RemoveFromPhysics_Title = 104,
		RemoveFromPhysics_Body = 105,
		AddAllObjects2Timeline_Title = 106,
		AddAllObjects2Timeline_Body = 107,
		RemoveTimeline_Title = 108,
		RemoveTimeline_Body = 109,
		RemoveTimelineLayer_Title = 110,
		RemoveTimelineLayer_Body = 111,
		DemoLimitation_Title = 112,
		DemoLimitation_Body = 113,
		DemoLimitation_Body_AddParam = 114,
		DemoLimitation_Body_AddAnimation = 115,
		BackupError_Title = 116,
		BackupError_Body = 117,
		RemoveKeyframe1_Title = 118,
		RemoveKeyframe1_Body = 119,
		AddKeyframeToAllLayer_Title = 120,
		AddKeyframeToAllLayer_Body = 121,
		BakeWarning_Title = 122,
		BakeWarning_Body = 123,
		Retarget_EnableAll_Title = 124,
		Retarget_EnableAll_Body = 125,
		Retarget_DisableAll_Title = 126,
		Retarget_DisableAll_Body = 127,
		Retarget_EnablePart_Body = 128,
		Retarget_DisablePart_Body = 129,
		Retarget_AutoMapping_Title = 130,
		Retarget_AutoMapping_Body = 131,
		Retarget_AutoMappingPart_Body = 132,
		Retarget_AutoMapping = 133,
		Retarget_ImportAnim_Title = 134,
		Retarget_ImportAnimMerge_Body = 135,
		Retarget_ImportAnimReplace_Body = 136,
		Import = 137,
		Export = 138,
		Retarget_ImportAnimComplete_Title = 139,
		Retarget_ImportAnimComplete_Body = 140,
		Retarget_RemoveSinglePose_Title = 141,
		Retarget_RemoveSinglePose_Body = 142,
		Retarget_SinglePoseImportFailed_Title = 143,
		Retarget_SinglePoseImportFailed_Body_NoFile = 144,
		Retarget_SinglePoseImportFailed_Body_Error = 145,
		ControlParamPreset_Regist_Title = 146,
		ControlParamPreset_Regist_Body = 147,
		ControlParamPreset_Regist_Okay = 148,
		ControlParamPreset_Remove_Title = 149,
		ControlParamPreset_Remove_Body = 150,
		ControlParamPreset_NameOverwrite_Title = 151,
		ControlParamPreset_NameOverwrite_Body = 152,
		OptPortrait_LoadError_Title = 153,
		OptPortrait_LoadError_Body = 154,
		OptBakeError_Title = 155,
		OptBakeError_NotOptTarget_Body = 156,
		OptBakeError_SrcMatchError_Body = 157,
		DLG_SelectTimelineTypeToAdd = 158,
		DLG_TimelineTypes = 159,
		DLG_Select = 160,
		DLG_Close = 161,
		DLG_ControlParameters = 162,
		DLG_Modifier = 163,
		DLG_Mesh = 164,
		DLG_Meshes = 165,
		DLG_MeshGroup = 166,
		DLG_MeshGroups = 167,
		DLG_Add = 168,
		DLG_Cancel = 169,
		DLG_SelectModifier = 170,
		DLG_Modifiers = 171,
		DLG_ModInfo_NotSelectableInDemo = 172,
		DLG_ModInfo_Morph = 173,
		DLG_ModInfo_AnimatedMorph = 174,
		DLG_ModInfo_Rigging = 175,
		DLG_ModInfo_Physic = 176,
		DLG_ModInfo_TF = 177,
		DLG_ModInfo_AnimatedTF = 178,
		DLG_AnimationEvents = 179,
		DLG_Range = 180,
		DLG_IsLoopAnimation = 181,
		DLG_AddEvent = 182,
		DLG_Sort = 183,
		DLG_EventName = 184,
		DLG_CallMethod = 185,
		DLG_TargetFrame = 186,
		DLG_StartFrame = 187,
		DLG_EndFrame = 188,
		DLG_Parameters = 189,
		DLG_AddParameter = 190,
		DLG_RemoveEvent = 191,
		DLG_NotSelected = 192,
		DLG_Portrait = 193,
		DLG_BakeSetting = 194,
		DLG_BakeScale = 195,
		DLG_ZPerDepth = 196,
		DLG_Bake = 197,
		DLG_OptimizedBaking = 198,
		DLG_Target = 199,
		DLG_OptimizedBakeTo = 200,
		DLG_OptimizedBakeMakeNew = 201,
		DLG_Setting = 202,
		DLG_Position = 203,
		DLG_CaptureSize = 204,
		DLG_Width = 205,
		DLG_Height = 206,
		DLG_ImageSize = 207,
		DLG_BGColor = 208,
		DLG_FixedAspectRatio = 209,
		DLG_NotFixedAspectRatio = 210,
		DLG_ThumbnailCapture = 211,
		DLG_FilePath = 212,
		DLG_Change = 213,
		DLG_MakeThumbnail = 214,
		DLG_ScreenshotCapture = 215,
		DLG_TakeAScreenshot = 216,
		DLG_GIFAnimation = 217,
		DLG_NotAnimation = 218,
		DLG_QualityHigh = 219,
		DLG_QualityMedium = 220,
		DLG_QualityLow = 221,
		DLG_LoopCount = 222,
		DLG_TakeAGIFAnimation = 223,
		DLG_AnimationClips = 224,
		DLG_SelectedControlParamSetting = 225,
		DLG_Default = 226,
		DLG_RegistToPreset = 227,
		DLG_Presets = 228,
		DLG_Category = 229,
		DLG_ValueType = 230,
		DLG_Min = 231,
		DLG_Max = 232,
		DLG_Axis1 = 233,
		DLG_Axis2 = 234,
		DLG_ValueRange = 235,
		DLG_Label = 236,
		DLG_SnapSize = 237,
		DLG_RemovePreset = 238,
		DLG_Apply = 239,
		DLG_SetSuctomFFDGridSize = 240,
		DLG_StartEdit = 241,
		DLG_NewPortraitName = 242,
		DLG_MakePortrait = 243,
		DLG_SelectedPhysicsSetting = 244,
		DLG_Name = 245,
		DLG_Icon = 246,
		DLG_Editor = 247,
		DLG_About = 248,
		DLG_PortraitSetting = 249,
		DLG_Setting_FPS = 250,
		DLG_Setting_IsImportant = 251,
		DLG_Setting_ManualBackUp = 252,
		DLG_EditorSetting = 253,
		DLG_Setting_Language = 254,
		DLG_Setting_ShowFPS = 255,
		DLG_Setting_ShowStatistics = 256,
		DLG_Setting_AutoBackupSetting = 257,
		DLG_Setting_AutoBackup = 258,
		DLG_Setting_BackupTime = 259,
		DLG_Setting_BackupPath = 260,
		DLG_Setting_PoseSnapshotSetting = 261,
		DLG_Setting_BackgroundColors = 262,
		DLG_Setting_Background = 263,
		DLG_Setting_GridCenter = 264,
		DLG_Setting_Grid = 265,
		DLG_Setting_AtlasBorder = 266,
		DLG_Setting_MeshGUIColors = 267,
		DLG_Setting_MeshEdge = 268,
		DLG_Setting_MeshHiddenEdge = 269,
		DLG_Setting_Outline = 270,
		DLG_Setting_TransformBorder = 271,
		DLG_Setting_Vertex = 272,
		DLG_Setting_SelectedVertex = 273,
		DLG_Setting_GizmoColors = 274,
		DLG_Setting_FFDLine = 275,
		DLG_Setting_FFDInnerLine = 276,
		DLG_Setting_OnionSkinColor = 277,
		DLG_Setting_OnionSkinColor2X = 278,
		DLG_Setting_RestoreDefaultSetting = 279,
		DLG_ExportBoneStructure = 280,
		DLG_NoBonesToExport = 281,
		DLG_1BoneToExport = 282,
		DLG_NBonesToExport = 283,
		DLG_Export = 284,
		DLG_ImportBoneStructure = 285,
		DLG_NoFileIsImported = 286,
		DLG_LoadFile = 287,
		DLG_Import = 288,
		DLG_NoImport = 289,
		DLG_NoIK = 290,
		DLG_Shape = 291,
		DLG_NoShape = 292,
		DLG_EnableAllBones = 293,
		DLG_DisableAllBones = 294,
		DLG_EnableAllIK = 295,
		DLG_DisableAllIK = 296,
		DLG_EnableAllShape = 297,
		DLG_DisableAllShape = 298,
		DLG_ImportScale = 299,
		DLG_ImportToMeshGroup = 300,
		DLG_ExportPose = 301,
		DLG_PoseName = 302,
		DLG_Description = 303,
		DLG_SelectAll = 304,
		DLG_DeselectAll = 305,
		DLG_ImportPose = 306,
		DLG_ImportPoseToMirror = 307,
		DLG_Refresh = 308,
		DLG_SameGroup = 309,
		DLG_SamePortrait = 310,
		DLG_AllPoses = 311,
		DLG_Selected = 312,
		DLG_NoPoseSelected = 313,
		DLG_NumberBones = 314,
		DLG_NoBones = 315,
		DLG_Warningproperly = 316,
		DLG_RemovePose = 317,
		DLG_PoseFolderNotExist = 318,
		DLG_ExportAnimationClip = 319,
		DLG_NoTimelinesToExport = 320,
		DLG_1TimelinesToExport = 321,
		DLG_NTimelinesToExport = 322,
		DLG_ImportAnimationClip = 323,
		DLG_MeshesMeshGroups = 324,
		DLG_Bones = 325,
		DLG_Timelines = 326,
		DLG_AnimEvents = 327,
		DLG_LoadedData = 328,
		DLG_TargetObjects = 329,
		DLG_AutoMapping = 330,
		DLG_Enable = 331,
		DLG_Disable = 332,
		DLG_AutoMappingAll = 333,
		DLG_SaveMapping = 334,
		DLG_LoadMapping = 335,
		DLG_EnableAll = 336,
		DLG_DisableAll = 337,
		DLG_ImportMerge = 338,
		DLG_ImportReplace = 339,
		DLG_SelectControlParemeter = 340,
		DLG_Search = 341,
		DLG_SelectMeshGroupToLink = 342,
		DLG_SetTexture = 343,
		DLG_Set = 344,
		DLG_SelectImage = 345,
		DLG_DemoVersion = 346,
		DLG_CheckLimitations = 347,
		DLG_StartPage_Hompage = 348,
		DLG_StartPage_AlawysOn = 349,
		DLG_ModLockSettings = 350,
		DLG_ModLockMode = 351,
		DLG_ModUnlockMode = 352,
		DLG_ModLockDescription = 353,
		DLG_ModUnlockDescription = 354,
		DLG_ModLockCalculateUnregisteredObj = 355,
		DLG_ModLockRenderCalculatedColors = 356,
		DLG_ModLockPreviewCalculatedBones = 357,
		DLG_ModLockShowModifierList = 358,
		DLG_ModLockPreviewColor = 359,
		DLG_ModLockBonePreviewColor = 360,
		DLG_ModLockRestoreSettings = 361,
		DLG_RemoveItemChangedWarning = 362,
		RemoveBone_Title = 363,
		RemoveBone_Body = 364,
		RemoveBone_RemoveAllChildren = 365,
		DLG_CaptureIsPhysics = 366,
		DLG_PrefabDisconn_Title = 367,
		DLG_PrefabDisconn_Body = 368,
		DLG_RigBakeError_Title = 369,
		DLG_RIGBakeError_Body = 370,
		DLG_BasicSettings = 371,
		DLG_Colors = 372,
		DLG_Bone = 373,
		DLG_SingleMarker = 374,
		DLG_PreviousFrames = 375,
		DLG_NextFrames = 376,
		DLG_RestoretoDefaultColors = 377,
		DLG_Thickness01 = 378,
		DLG_Order = 379,
		DLG_PositionOffset = 380,
		DLG_IKCalculation = 381,
		DLG_AnimationSettings = 382,
		DLG_AnimationFrameRendering = 383,
		DLG_SingleFrame = 384,
		DLG_MultipleFrames = 385,
		DLG_PreviousRange = 386,
		DLG_NextRange = 387,
		DLG_FramePerRender = 388,
		DLG_RestoretoDefaultSettings = 389,
		DLG_MirrorBoneWarning_Title = 390,
		DLG_MirrorBoneWarning_Body_Aleady = 391,
		DLG_MirrorBoneWarning_Body_Children = 392,
		DLG_MirrorBoneWarning_Btn1_WithAllChildBones = 393,
		DLG_MirrorBoneWarning_Btn2_OnlySelectedBone = 394,
		SortingLayer = 395,
		SortingOrder = 396,
		IsMecanimAnimation = 397,
		AnimationClipExportPath = 398,
		DLG_PSD_Load = 399,
		DLG_PSD_Layers = 400,
		DLG_PSD_Atlas = 401,
		DLG_PSD_LoadPSDFile = 402,
		DLG_PSD_ReloadPSDFile = 403,
		DLG_PSD_PSDFileInformation = 404,
		DLG_PSD_PSDFilePath = 405,
		DLG_PSD_ImageSize = 406,
		DLG_PSD_ImageLayers = 407,
		DLG_PSD_Reset = 408,
		DLG_PSD_Deselect = 409,
		DLG_PSD_Layer = 410,
		DLG_PSD_Rect = 411,
		DLG_PSD_Position = 412,
		DLG_PSD_Size = 413,
		DLG_PSD_Level = 414,
		DLG_PSD_Parent = 415,
		DLG_PSD_Clipping = 416,
		DLG_PSD_BakeTarget = 417,
		DLG_PSD_ImageName = 418,
		DLG_PSD_FilePath = 419,
		DLG_PSD_AssetName = 420,
		DLG_PSD_SavePath = 421,
		DLG_PSD_Assets = 422,
		DLG_PSD_AtlasBakingOption = 423,
		DLG_PSD_MaximumAtlas = 424,
		DLG_PSD_Padding = 425,
		DLG_PSD_FixBorderProblem = 426,
		DLG_PSD_MeshGroupScaleOption = 427,
		DLG_PSD_ResizeRatio = 428,
		DLG_PSD_Warning = 429,
		DLG_PSD_Bake = 430,
		DLG_PSD_SettingsAreChanged = 431,
		DLG_PSD_ExpectedScale = 432,
		DLG_PSD_ExpectedAtlas = 433,
		DLG_PSD_BakeResult = 434,
		DLG_PSD_ScalePercent = 435,
		DLG_PSD_BackgroundColor = 436,
		DLG_PSD_Next = 437,
		DLG_PSD_Back = 438,
		DLG_PSD_Complete = 439,
		DLG_PSD_PSDSet = 440,
		DLG_PSD_BasicSetting = 441,
		DLG_PSD_Mapping = 442,
		DLG_PSD_Adjust = 443,
		DLG_PSD_PSDOutlineColor = 444,
		DLG_PSD_MeshOutlineColor = 445,
		DLG_PSD_SelectPSDSet = 446,
		DLG_PSD_NoFile = 447,
		DLG_PSD_NoPath = 448,
		DLG_PSD_InvalidFile = 449,
		DLG_PSD_InvalidPath = 450,
		DLG_PSD_Select = 451,
		DLG_PSD_Selected = 452,
		DLG_PSD_AddNewPSDImportSet = 453,
		DLG_PSD_SelectedPSDSet = 454,
		DLG_PSD_NotSelected = 455,
		DLG_PSD_NoPSDFile = 456,
		DLG_PSD_PSDFileName = 457,
		DLG_PSD_AssetPath = 458,
		DLG_PSD_Scale = 459,
		DLG_PSD_ThereAreNoBakeData = 460,
		DLG_PSD_BakeSettings = 461,
		DLG_PSD_PSDFileProperties = 462,
		DLG_PSD_RemovePSDImportSet = 463,
		DLG_PSD_RemovePSDSet_Title = 464,
		DLG_PSD_RemovePSDSet_Body = 465,
		DLG_PSD_PSDImportSetSettings = 466,
		DLG_PSD_TargetMeshGroup = 467,
		DLG_PSD_NoMeshGroup = 468,
		DLG_PSD_BakedImages = 469,
		DLG_PSD_AddImage = 470,
		DLG_PSD_AddImagesAuto = 471,
		DLG_PSD_Images = 472,
		DLG_PSD_DetachImage_Title = 473,
		DLG_PSD_DetachImage_Body = 474,
		DLG_PSD_Detach = 475,
		DLG_PSD_AtlasBakeSettingsForReimpot = 476,
		DLG_PSD_BakeScale = 477,
		DLG_PSD_RenderingType = 478,
		DLG_PSD_Offset = 479,
		DLG_PSD_PSDLayers = 480,
		DLG_PSD_NotBakeable = 481,
		DLG_PSD_AutoMapping = 482,
		DLG_PSD_EnableAll = 483,
		DLG_PSD_DisableAll = 484,
		DLG_PSD_RenderingNOrder = 485,
		DLG_PSD_PositionOffset = 486,
		DLG_PSD_PrevAtlasScale = 487,
		CheckLatestVersionOption = 488,
		DLG_ResizeArea_Title = 489,
		DLG_ResizeArea_Body = 490,
		DLG_Rescan_Title = 491,
		DLG_Rescan_Body = 492,
		DLG_ReplaceAppendVertices_Title = 493,
		DLG_ReplaceAppendVertices_Body = 494,
		DLG_Replace = 495,
		DLG_Append = 496,
		DLG_Billboard = 497,
		DLG_ExportMP4 = 498,
		DLG_ExportGIXMaxQualityWarining_Title = 499,
		DLG_ExportGIXMaxQualityWarining_Body = 500,
		DLG_AmbientToBlack = 501,
		DLG_NewVersion_Title = 502,
		DLG_NewVersion_Body = 503,
		DLG_NewVersion_OpenAssetStore = 504,
		DLG_NewVersion_Ignore = 505,
		DLG_NoComputeShaderOnCapture_Title = 506,
		DLG_NoComputeShaderOnCapture_Body = 507,
		DLG_NoComputeShaderOnCapture_IgnoreAndCapture = 508,
		DLG_NoComputeShaderOnCapture_OpenBuildSettings = 509,
		ExtraOpt_ExtraPropertyOn = 510,
		ExtraOpt_ExtraPropertyOff = 511,
		ExtraOpt_TargetFrame = 512,
		ExtraOpt_WeightSettings = 513,
		ExtraOpt_Offset = 514,
		ExtraOpt_OffsetPrevKeyframe = 515,
		ExtraOpt_OffsetNextKeyframe = 516,
		ExtraOpt_Tab_Depth = 517,
		ExtraOpt_Tab_Image = 518,
		ExtraOpt_ChangingDepth = 519,
		ExtraOpt_DepthOptOn = 520,
		ExtraOpt_DepthOptOff = 521,
		ExtraOpt_DeltaDepth = 522,
		ExtraOpt_ChangingImage = 523,
		ExtraOpt_ImageOptOn = 524,
		ExtraOpt_ImageOptOff = 525,
		ExtraOpt_SlotOriginal = 526,
		ExtraOpt_SlotChanged = 527,
		ExtraOpt_SelectImage = 528,
		ExtraOpt_ResetImage = 529,
	}






	public enum UIWORD
	{
		None = 0,
		RootUnit = 1,
		Image = 2,
		Mesh = 3,
		MeshGroup = 4,
		AnimationClip = 5,
		ControlParameter = 6,
		RootUnits = 7,
		Images = 8,
		Meshes = 9,
		MeshGroups = 10,
		AnimationClips = 11,
		ControlParameters = 12,
		Hierarchy = 13,
		Controller = 14,
		MakeNewPortrait = 15,
		RefreshToLoad = 16,
		LoadBackupFile = 17,
		Select = 18,
		AutoPlayEnabled = 19,
		AutoPlayDisabled = 20,
		UnregistRootUnit = 21,
		SelectImage = 22,
		RefreshImageProperty = 23,
		RemoveImage = 24,
		Setting = 25,
		MakeMesh = 26,
		Pivot = 27,
		Modify = 28,
		Name = 29,
		ImageAsset = 30,
		Width = 31,
		Height = 32,
		Size = 33,
		ChangeImage = 34,
		ResetVertices = 35,
		RemoveMesh = 36,
		AddVertexLinkEdge = 37,
		AddVertex = 38,
		LinkEdge = 39,
		Polygon = 40,
		MakePolygons = 41,
		AutoLinkEdge = 42,
		RemoveAllVertices = 43,
		AddOrMoveVertexWithEdges = 44,
		MoveView = 45,
		RemoveVertexorEdge = 46,
		SnapToVertex = 47,
		LCutEdge_RDeleteVertex = 48,
		AddOrMoveVertex = 49,
		RemoveVertex = 50,
		LinkVertices_TurnEdge = 51,
		RemoveEdge = 52,
		CutEdge = 53,
		SelectPolygon = 54,
		RemovePolygon = 55,
		MovePivot = 56,
		ResetPivot = 57,
		SelectVertex = 58,
		Position = 59,
		Rotation = 60,
		Scaling = 61,
		Depth = 62,
		Color = 63,
		Visible = 64,
		Z_Depth = 65,
		Z_DepthRendering = 66,
		Bake = 67,
		Coordinate = 68,
		Bone = 69,
		Bones = 70,
		Modifier = 71,
		EditDefaultTransform = 72,
		EditingDefaultTransform = 73,
		SetRootUnit = 74,
		RemoveMeshGroup = 75,
		StartEditingBones = 76,
		EditingBones = 77,
		SelectBones = 78,
		AddBones = 79,
		LinkBones = 80,
		Deselect = 81,
		SelectAndLinkBones = 82,
		ExportImportBones = 83,
		RemoveAllBones = 84,
		AddModifier = 85,
		ModifierStack = 86,
		Socket = 87,
		SocketEnabled = 88,
		SocketDisabled = 89,
		ShaderSetting = 90,
		UseCustomShader = 91,
		CustomShader = 92,
		ParentMaskMesh = 93,
		MaskTextureSize = 94,
		ClippedChildMesh = 95,
		MaskMesh = 96,
		ClippedIndex = 97,
		Release = 98,
		ClipToBelowMesh = 99,
		Detach = 100,
		RootTransform = 101,
		LayerUp = 102,
		LayerDown = 103,
		Layer = 104,
		Blend = 105,
		ColorOptionOn = 106,
		ColorOptionOff = 107,
		Weight = 108,
		RemoveModifier = 109,
		SetOfKeys = 110,
		Copy = 111,
		Paste = 112,
		ResetValue = 113,
		ExportImportPose = 114,
		Export = 115,
		Import = 116,
		RemoveFromKeys = 117,
		NotAbleToBeAdded = 118,
		AddToKeys = 119,
		BasePoseTransformation = 120,
		IKSetting = 121,
		IKInfo_Single = 122,
		IKInfo_Head = 123,
		IKInfo_Chain = 124,
		IKInfo_Disabled = 125,
		IKHeader = 126,
		IKNextChainToTarget = 127,
		IKTarget = 128,
		ChangeIKTarget = 129,
		IKAngleConstraint = 130,
		ConstraintOn = 131,
		ConstraintOff = 132,
		Range = 133,
		Min = 134,
		Max = 135,
		Preferred = 136,
		ParentBone = 137,
		Change = 138,
		ChildrenBones = 139,
		AttachChildBone = 140,
		Shape = 141,
		Taper = 142,
		RemoveBone = 143,
		TargetMeshTransform = 144,
		TargetMeshGroupTransform = 145,
		TargetBone = 146,
		NotAddedtoEdit = 147,
		Selected = 148,
		NoVertexisSelected = 149,
		NumVertsareSelected = 150,
		SingleVertexSelected = 151,
		SetImportant = 152,
		ImportantVertex = 153,
		SetWeight = 154,
		ScaleWeight = 155,
		Grow = 156,
		Shrink = 157,
		Blend_Weight = 158,
		ViscosityGroupID = 159,
		PhysicalMaterial = 160,
		BasicSetting = 161,
		Mass = 162,
		Damping = 163,
		AirDrag = 164,
		SetMoveRange = 165,
		MoveRange = 166,
		MoveRangeUnlimited = 167,
		Stretchiness = 168,
		K_Value = 169,
		SetStretchRange = 170,
		LengthenRatio = 171,
		LengthenRatioUnlimited = 172,
		Inertia = 173,
		Restoring = 174,
		Viscosity = 175,
		Gravity = 176,
		InputType = 177,
		NoControlParam = 178,
		Set = 179,
		Wind = 180,
		WindRandomRangeSize = 181,
		Method = 182,
		AddImage = 183,
		ImportPSDFile = 184,
		AddMesh = 185,
		AddMeshGroup = 186,
		AddAnimationClip = 187,
		AddControlParameter = 188,
		NoMeshIsSelected = 189,
		RemoveFromRigging = 190,
		AddToRigging = 191,
		AutoNormalize = 192,
		Normalize = 193,
		Prune = 194,
		AutoRig = 195,
		AddToPhysics = 196,
		RemoveFromPhysics = 197,
		Vertex = 198,
		PhysicsPresets = 199,
		Target = 200,
		NoMeshGroup = 201,
		AnimationSettings = 202,
		StartFrame = 203,
		EndFrame = 204,
		LoopOn = 205,
		LoopOff = 206,
		AnimationEvents = 207,
		ExportImport = 208,
		AllObjectToLayers = 209,
		RemoveTimeline = 210,
		AddTimelineLayerToEdit = 211,
		RemoveTimelineLayer = 212,
		TimelineLayers = 213,
		EditingAnim = 214,
		StartEdit = 215,
		NoEditable = 216,
		AddKey = 217,
		AddKeyframesToAllLayers = 218,
		Frame = 219,
		UnhideLayers = 220,
		AutoScroll = 221,
		Timeline = 222,
		TimelineLayer = 223,
		Timelines = 224,
		NotSelected = 225,
		Transform = 226,
		Curve = 227,
		ControlParameterValue = 228,
		MorphModifierValue = 229,
		TransformModifierValue = 230,
		Color2X = 231,
		IsVisible = 232,
		ColorPropertyIsDisabled = 233,
		Prev = 234,
		Next = 235,
		Current = 236,
		KeyframeIsNotLinked = 237,
		ResetSmoothSetting = 238,
		CopyCurveToAllKeyframes = 239,
		PoseExportImportLabel = 240,
		RemoveKeyframe = 241,
		NumKeyframesSelected = 242,
		RemoveKeyframes = 243,
		RemoveNumKeyframes = 244,
		LayerGUIColor = 245,
		Keyframe = 246,
		Keyframes = 247,
		SelectMeshGroup = 248,
		TargetMeshGroup = 249,
		Duplicate = 250,
		AddTimeline = 251,
		RemoveAnimation = 252,
		ReservedParameter = 253,
		NameUnique = 254,
		ValueType = 255,
		Category = 256,
		IconPreset = 257,
		Param_IntegerType = 258,
		Param_FloatType = 259,
		Param_Vector2Type = 260,
		Param_DefaultValue = 261,
		Param_Axis1 = 262,
		Param_Axis2 = 263,
		RangeValueLabel = 264,
		SnapSize = 265,
		Presets = 266,
		RemoveParameter = 267,
		ModBinding = 268,
		ModStartBinding = 269,
		ModEditing = 270,
		ModStartEditing = 271,
		ModNotEditable = 272,
		ModNoParam = 273,
		ModNoKey = 274,
		ModNoSelected = 275,
		ModSubObject = 276,
		MeshTransform = 277,
		MeshGroupTransform = 278,
		ModSelectKeyFirst = 279,
		RigBoneColor = 280,
		RigPoseTest = 281,
		RigResetPose = 282,
		PxDirection = 283,
		PxPower = 284,
		PxWindOn = 285,
		PxWindOff = 286,
		SetDefaultAll = 287,
		SelectPortraitFromScene = 288,
		Portrait = 289,
		Radius = 290,
		Intensity = 291,
		ShowFrame = 292,
		Capture = 293,
		Helper = 294,
		ColorSpace = 295,
		Compression = 296,
		UseMipmap = 297,
		CaptureTabThumbnail = 298,
		CaptureTabScreenshot = 299,
		CaptureTabGIFAnim = 300,
		CaptureTabSpritesheet = 301,
		ImageSizePerFrame = 302,
		SizeofSpritesheet = 303,
		SpriteSizeCompression = 304,
		SpriteMargin = 305,
		SpriteGIFWait = 306,
		SpriteSheet = 307,
		ExpectedNumSprites = 308,
		InvalidSpriteSizeSettings = 309,
		ExportMetaFile = 310,
		CaptureScreenPosZoom = 311,
		CaptureMoveToCenter = 312,
		CaptureZoom = 313,
		CaptureExportSpriteSheets = 314,
		CaptureExportSeqFiles = 315,
		CaptureSelectAll = 316,
		CaptureDeselectAll = 317,
		IKConSettings = 318,
		IKConDefaultWeight = 319,
		IKConEffectorBone = 320,
		IKConModWeight = 321,
		MirrorBone = 322,
		Axis = 323,
		Offset = 324,
		MakeNewMirrorBone = 325,
		AutoKey = 326,
		TwoSidesRendering = 327,
		MakeMeshTab_Add = 328,
		MakeMeshTab_Edit = 329,
		MakeMeshTab_Auto = 330,
		MirrorTool = 331,
		MirrorEnabled = 332,
		MirrorDisabled = 333,
		RulerSettings = 334,
		RulerPosition = 335,
		MoveToCenter = 336,
		SnapToRuler = 337,
		RemoveSymmetry = 338,
		CopySymmetry = 339,
		AlignTools = 340,
		AreaSizeSettings = 341,
		AreaOptionEnabled = 342,
		AreaOptionDisabled = 343,
		AreaSize = 344,
		TextureRWEnabled = 345,
		TextureRWDisabled = 346,
		WarningTextureRWDisabled = 347,
		WarningAreaSmall = 348,
		WarningAreaDisabled = 349,
		AlphaCutout = 350,
		WrapperShapeOptions = 351,
		ScanImage = 352,
		OutlineGroups = 353,
		OutlineEnabled = 354,
		OutlineDisabled = 355,
		ResizeAreaToSelectedGroup = 356,
		Division = 357,
		PointCount = 358,
		LockAxis = 359,
		PrevewMesh = 360,
		Relax = 361,
		GenerateMesh = 362,
		WarningTextureRWNeedToDisabledForOpt = 363,
		TextureRW = 364,
		CastShadows = 365,
		ReceiveShadows = 366,
		ShadowSetting = 367,
		OverrideShadow = 368,
		UseCommonShadowSetting = 369,
		Quality = 370,
		Extra = 371,
		ExtraOptionON = 372,
		ExtraOptionOFF = 373,
	}





	/// <summary>
	/// 텍스트를 설정에 맞게 번역하는 클래스
	/// Editor의 멤버로 존재하며, Editor에서 Language 옵션을 넣어준다.
	/// </summary>
	public class apLocalization
	{
		// Member
		//------------------------------------------------
		//텍스트를 받는다.
		


		private bool _isLoaded = false;
		public bool IsLoaded { get { return _isLoaded; } }
		private apEditor.LANGUAGE _language = apEditor.LANGUAGE.English;
		public apEditor.LANGUAGE Language { get { return _language; } }

		
		//이전 : 모든 Language가 포함된다.
		///// <summary>
		///// Dialog에 들어가는 데이터
		///// </summary>
		//private class TextSet
		//{
		//	public TEXT _textType = TEXT.None;
		//	public Dictionary<apEditor.LANGUAGE, string> _textSet = new Dictionary<apEditor.LANGUAGE, string>();

		//	public TextSet(TEXT textType)
		//	{
		//		_textType = textType;
		//	}

		//	public void SetText(apEditor.LANGUAGE language, string text)
		//	{
		//		text = text.Replace("\t", "");
		//		text = text.Replace("[]", "\r\n");
		//		text = text.Replace("[c]", ",");
		//		text = text.Replace("[u]", "\"");


		//		//Debug.Log("언어팩 : " + language + " : " + text);
		//		_textSet.Add(language, text);
		//	}
		//}

		///// <summary>
		///// Dialog에 들어가는 텍스트 데이터
		///// </summary>
		//private Dictionary<TEXT, TextSet> _textSets = new Dictionary<TEXT, TextSet>();


		//private class UIWordSet
		//{
		//	public UIWORD _uiWordType = UIWORD.None;
		//	public Dictionary<apEditor.LANGUAGE, string> _wordSet = new Dictionary<apEditor.LANGUAGE, string>();

		//	public UIWordSet(UIWORD uiWordType)
		//	{
		//		_uiWordType = uiWordType;
		//	}

		//	public void SetUIWord(apEditor.LANGUAGE language, string text)
		//	{
		//		text = text.Replace("\t", "");
		//		text = text.Replace("[]", "\r\n");
		//		text = text.Replace("[c]", ",");
		//		text = text.Replace("[u]", "\"");

		//		_wordSet.Add(language, text);
		//	}
		//}

		///// <summary>
		///// UI에 들어가는 텍스트 데이터
		///// </summary>
		//private Dictionary<UIWORD, UIWordSet> _uiWordSets = new Dictionary<UIWORD, UIWordSet>();

		//변경 : 선택된 Language만 포함된다.
		private Dictionary<TEXT, string> _texts = new Dictionary<TEXT, string>();
		private Dictionary<UIWORD, string> _uiWords = new Dictionary<UIWORD, string>();

		


		// Function
		//------------------------------------------------
		public apLocalization()
		{
			_isLoaded = false;
			//_textSets.Clear();
			//_uiWordSets.Clear();

			_texts.Clear();
			_uiWords.Clear();
		}

		/// <summary>
		/// 다시 로드해야하는지 체크한다.
		/// "한번도 로드를 안했거나" / "선택한 언어가 아니라면" True 리턴
		/// </summary>
		/// <param name="language"></param>
		/// <returns></returns>
		public bool CheckToReloadLanguage(apEditor.LANGUAGE language)
		{
			return (!_isLoaded || _language != language);
		}


		public void SetTextAsset(apEditor.LANGUAGE language, TextAsset textAsset_Dialog, TextAsset textAsset_UI)
		{
			if (_isLoaded && _language == language)
			{
				return;
			}
			int iText = GetLanguageIndex(language);
			if(iText < 0)
			{
				Debug.LogError("알 수 없는 언어 : " + language);
				//영어로 변경
				iText = GetLanguageIndex(apEditor.LANGUAGE.English);
			}
			_language = language;
			_isLoaded = true;

			//_textSets.Clear();
			//_uiWordSets.Clear();

			_texts.Clear();
			_uiWords.Clear();

			string[] strParseLines = textAsset_Dialog.text.Split(new string[] { "\n" }, StringSplitOptions.None);

			string strCurParseLine = null;

			for (int i = 1; i < strParseLines.Length; i++)
			{
				//첫줄(index 0)은 빼고 읽는다.
				strCurParseLine = strParseLines[i].Replace("\r", "");
				string[] strSubParseLine = strCurParseLine.Split(new string[] { "," }, StringSplitOptions.None);
				//Parse 순서
				//0 : TEXT 타입 (string) - 파싱 안한다.
				//1 : TEXT 타입 (int)
				//2 : English (영어)
				//3 : Korean (한국어)
				//4 : French (프랑스어)
				//5 : German (독일어)
				//6 : Spanish (스페인어)
				//7 : Italian (이탈리아어)
				//8 : Danish (덴마크어)
				//9 : Japanese (일본어)
				//10 : Chinese_Traditional (중국어-번체)
				//11 : Chinese_Simplified (중국어-간체)
				if (strSubParseLine.Length < 13)
				{
					//Debug.LogError("인식할 수 없는 Text (" + i + " : " + strCurParseLine + ")");
					continue;
				}
				try
				{
					TEXT textType = (TEXT)(int.Parse(strSubParseLine[1]));
					
					//이전 코드
					//TextSet newTextSet = new TextSet(textType);

					//newTextSet.SetText(apEditor.LANGUAGE.English, strSubParseLine[2]);
					//newTextSet.SetText(apEditor.LANGUAGE.Korean, strSubParseLine[3]);
					//newTextSet.SetText(apEditor.LANGUAGE.French, strSubParseLine[4]);
					//newTextSet.SetText(apEditor.LANGUAGE.German, strSubParseLine[5]);
					//newTextSet.SetText(apEditor.LANGUAGE.Spanish, strSubParseLine[6]);
					//newTextSet.SetText(apEditor.LANGUAGE.Italian, strSubParseLine[7]);
					//newTextSet.SetText(apEditor.LANGUAGE.Danish, strSubParseLine[8]);
					//newTextSet.SetText(apEditor.LANGUAGE.Japanese, strSubParseLine[9]);
					//newTextSet.SetText(apEditor.LANGUAGE.Chinese_Traditional, strSubParseLine[10]);
					//newTextSet.SetText(apEditor.LANGUAGE.Chinese_Simplified, strSubParseLine[11]);
					//newTextSet.SetText(apEditor.LANGUAGE.Polish, strSubParseLine[12]);

					//_textSets.Add(textType, newTextSet);

					//변경된 코드
					_texts.Add(textType, ConvertText(strSubParseLine[iText]));
				}
				catch (Exception)
				{
					Debug.LogError("Parsing 실패 (" + i + " : " + strCurParseLine + ")");
				}


			}


			//UI 단어도 열자
			strParseLines = textAsset_UI.text.Split(new string[] { "\n" }, StringSplitOptions.None);

			for (int i = 1; i < strParseLines.Length; i++)
			{
				//첫줄(index 0)은 빼고 읽는다.
				strCurParseLine = strParseLines[i].Replace("\r", "");
				string[] strSubParseLine = strCurParseLine.Split(new string[] { "," }, StringSplitOptions.None);
				//Parse 순서
				//0 : TEXT 타입 (string) - 파싱 안한다.
				//1 : TEXT 타입 (int)
				//2 : English (영어)
				//3 : Korean (한국어)
				//4 : French (프랑스어)
				//5 : German (독일어)
				//6 : Spanish (스페인어)
				//7 : Italian (이탈리아어)
				//8 : Danish (덴마크어)
				//9 : Japanese (일본어)
				//10 : Chinese_Traditional (중국어-번체)
				//11 : Chinese_Simplified (중국어-간체)
				if (strSubParseLine.Length < 13)
				{
					//Debug.LogError("인식할 수 없는 Text (" + i + " : " + strCurParseLine + ")");
					continue;
				}
				try
				{
					UIWORD uiWordType = (UIWORD)(int.Parse(strSubParseLine[1]));

					//이전 코드
					//UIWordSet newUIWordSet = new UIWordSet(uiWordType);

					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.English, strSubParseLine[2]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.Korean, strSubParseLine[3]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.French, strSubParseLine[4]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.German, strSubParseLine[5]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.Spanish, strSubParseLine[6]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.Italian, strSubParseLine[7]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.Danish, strSubParseLine[8]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.Japanese, strSubParseLine[9]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.Chinese_Traditional, strSubParseLine[10]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.Chinese_Simplified, strSubParseLine[11]);
					//newUIWordSet.SetUIWord(apEditor.LANGUAGE.Polish, strSubParseLine[12]);

					//_uiWordSets.Add(uiWordType, newUIWordSet);

					//변경된 코드
					_uiWords.Add(uiWordType, ConvertText(strSubParseLine[iText]));
				}
				catch (Exception)
				{
					Debug.LogError("Parsing 실패 (" + i + " : " + strCurParseLine + ")");
				}


			}


			_isLoaded = true;
		}
		//public void SetLanguage(apEditor.LANGUAGE language)
		//{
		//	_language = language;
		//}

		public string GetText(TEXT textType)
		{
			//return (_textSets[textType])._textSet[_language];
			return _texts[textType];
		}

		public string GetUIWord(UIWORD uiWordType)
		{
			//return (_uiWordSets[uiWordType])._wordSet[_language];
			return _uiWords[uiWordType];
		}


		private string ConvertText(string srcText)
		{
			srcText = srcText.Replace("\t", "");
			srcText = srcText.Replace("[]", "\r\n");
			srcText = srcText.Replace("[c]", ",");
			srcText = srcText.Replace("[u]", "\"");
			return srcText;
		}

		private int GetLanguageIndex(apEditor.LANGUAGE language)
		{
			switch (language)
			{
				case apEditor.LANGUAGE.English:					return 2;
				case apEditor.LANGUAGE.Korean:					return 3;
				case apEditor.LANGUAGE.French:					return 4;
				case apEditor.LANGUAGE.German:					return 5;
				case apEditor.LANGUAGE.Spanish:					return 6;
				case apEditor.LANGUAGE.Italian:					return 7;
				case apEditor.LANGUAGE.Danish:					return 8;
				case apEditor.LANGUAGE.Japanese:				return 9;
				case apEditor.LANGUAGE.Chinese_Traditional:		return 10;
				case apEditor.LANGUAGE.Chinese_Simplified:		return 11;
				case apEditor.LANGUAGE.Polish:					return 12;
					
			}
			return -1;
		}
	}

}