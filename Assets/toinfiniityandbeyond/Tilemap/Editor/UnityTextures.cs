﻿using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


//Unity 4.1.5
public class UnityTextures : EditorWindow
{

	[MenuItem ("Window/UnityTextures")]
	static void Init ()
	{
		UnityTextures window = (UnityTextures)EditorWindow.GetWindow (typeof (UnityTextures), false, "UnityTextures");
		window.Show ();
	}


	private Vector2 scrollPosition;
	private GUIContent m_btnCntent = new GUIContent ();
	List<string> pathList = new List<string> ();


	void OnGUI ()
	{

		EditorGUILayout.BeginHorizontal ();
		EditorGUILayout.LabelField ("", GUILayout.Width (50));
		EditorGUILayout.LabelField ("path", GUILayout.Width (m_pathWidth));
		EditorGUILayout.LabelField ("width", GUILayout.Width (m_textureWidth));
		EditorGUILayout.LabelField ("height", GUILayout.Width (m_textureHeight));
		EditorGUILayout.EndHorizontal ();


		if (pathList == null || pathList.Count == 0)
		{
			pathList = new List<string> ();
			pathList = GetIconLists (pathList);
		}


		scrollPosition = GUILayout.BeginScrollView (scrollPosition, false, false);

		foreach (string path in pathList)
		{
			if (string.IsNullOrEmpty (path)) continue;
			EditorGUILayout.BeginHorizontal ();
			GUIItem (path);
			EditorGUILayout.EndHorizontal ();
		}


		GUILayout.EndScrollView ();
	}


	int m_pathWidth = 350;
	int m_textureWidth = 60;
	int m_textureHeight = 60;


	void GUIItem (string path)
	{
		Texture tex = EditorGUIUtility.Load (path) as Texture2D;

		if (tex == null)
		{
			EditorGUILayout.LabelField ("null:", GUILayout.Width (30));
			EditorGUILayout.TextField (path);
			return;
		}


		m_btnCntent.text = "";
		m_btnCntent.tooltip = "";
		m_btnCntent.image = tex;
		if (GUILayout.Button (m_btnCntent, GUILayout.Width (50))) { }

		EditorGUILayout.TextField (path, GUILayout.Width (m_pathWidth));
		EditorGUILayout.LabelField (tex.width.ToString (), GUILayout.Width (m_textureWidth));
		EditorGUILayout.LabelField (tex.height.ToString (), GUILayout.Width (m_textureHeight));
	}

	List<string> GetIconLists (List<string> pathList)
	{
		pathList.Add ("icons/_Help.png");
		pathList.Add ("icons/_Popup.png");
		pathList.Add ("icons/aboutwindow.mainheader.png");
		pathList.Add ("icons/ageialogo.png");
		pathList.Add ("icons/Animation.AddEvent.png");
		pathList.Add ("icons/Animation.AddKeyframe.png");
		pathList.Add ("icons/Animation.EventMarker.png");
		pathList.Add ("icons/Animation.NextKey.png");
		pathList.Add ("icons/Animation.Play.png");
		pathList.Add ("icons/Animation.PrevKey.png");
		pathList.Add ("icons/Animation.Record.png");
		pathList.Add ("icons/animationanimated.png");
		pathList.Add ("icons/animationkeyframe.png");
		pathList.Add ("icons/animationnocurve.png");
		pathList.Add ("icons/animationvisibilitytoggleoff.png");
		pathList.Add ("icons/animationvisibilitytoggleon.png");
		pathList.Add ("icons/AreaLight Gizmo.png");
		pathList.Add ("icons/AS Badge Delete.png");
		pathList.Add ("icons/AS Badge Move.png");
		pathList.Add ("icons/AS Badge New.png");
		pathList.Add ("icons/Asset Store.png");
		pathList.Add ("icons/AssetServer.Delete.png");
		pathList.Add ("icons/AudioSource Gizmo.png");
		pathList.Add ("icons/AvatarCompass.png");
		pathList.Add ("icons/AvatarCompass.png");
		pathList.Add ("icons/AvatarController.Layer.png");
		pathList.Add ("icons/AvatarController.LayerHover.png");
		pathList.Add ("icons/AvatarController.LayerSelected.png");
		pathList.Add ("icons/AvatarPivot.png");
		pathList.Add ("icons/AvatarPivot.png");
		pathList.Add ("icons/beginButton.png");
		pathList.Add ("icons/beginButton-On.png");
		pathList.Add ("icons/blendKey.png");
		pathList.Add ("icons/blendKeyOverlay.png");
		pathList.Add ("icons/blendKeySelected.png");
		pathList.Add ("icons/blendSampler.png");
		pathList.Add ("icons/blueGroove.png");
		pathList.Add ("icons/BuildSettings.Android.png");
		pathList.Add ("icons/BuildSettings.Android.Small.png");
		pathList.Add ("icons/BuildSettings.Broadcom.png");
		pathList.Add ("icons/BuildSettings.FlashPlayer.png");
		pathList.Add ("icons/BuildSettings.FlashPlayer.Small.png");
		pathList.Add ("icons/BuildSettings.iPhone.png");
		pathList.Add ("icons/BuildSettings.iPhone.Small.png");
		pathList.Add ("icons/BuildSettings.NaCl.png");
		pathList.Add ("icons/BuildSettings.NaCl.Small.png");
		pathList.Add ("icons/BuildSettings.PS3.png");
		pathList.Add ("icons/BuildSettings.PS3.Small.png");
		pathList.Add ("icons/BuildSettings.SelectedIcon.png");
		pathList.Add ("icons/BuildSettings.Standalone.png");
		pathList.Add ("icons/BuildSettings.Standalone.Small.png");
		pathList.Add ("icons/BuildSettings.StandaloneBroadcom.Small.png");
		pathList.Add ("icons/BuildSettings.StandaloneGLES20Emu.Small.png");
		pathList.Add ("icons/BuildSettings.StandaloneGLESEmu.Small.png");
		pathList.Add ("icons/BuildSettings.Web.png");
		pathList.Add ("icons/BuildSettings.Web.Small.png");
		pathList.Add ("icons/BuildSettings.Wii.png");
		pathList.Add ("icons/BuildSettings.Wii.Small.png");
		pathList.Add ("icons/BuildSettings.WP8.png");
		pathList.Add ("icons/BuildSettings.WP8.Small.png");
		pathList.Add ("icons/BuildSettings.Xbox360.png");
		pathList.Add ("icons/BuildSettings.Xbox360.Small.png");
		pathList.Add ("icons/Camera Gizmo.png");
		pathList.Add ("icons/CheckerFloor.png");
		pathList.Add ("icons/CheckerFloor.png");
		pathList.Add ("icons/Clipboard.png");
		pathList.Add ("icons/ClothInspector.PaintTool.png");
		pathList.Add ("icons/ClothInspector.PaintValue.png");
		pathList.Add ("icons/ClothInspector.SelectTool.png");
		pathList.Add ("icons/ClothInspector.SettingsTool.png");
		pathList.Add ("icons/ClothInspector.ViewValue.png");
		pathList.Add ("icons/ColorPicker.ColorCycle.png");
		pathList.Add ("icons/ColorPicker.CycleColor.png");
		pathList.Add ("icons/ColorPicker.CycleSlider.png");
		pathList.Add ("icons/ColorPicker.SliderCycle.png");
		pathList.Add ("icons/console.erroricon.png");
		pathList.Add ("icons/console.erroricon.sml.png");
		pathList.Add ("icons/console.infoicon.png");
		pathList.Add ("icons/console.infoicon.sml.png");
		pathList.Add ("icons/console.warnicon.png");
		pathList.Add ("icons/console.warnicon.sml.png");
		pathList.Add ("icons/curvekeyframe.png");
		pathList.Add ("icons/curvekeyframeselected.png");
		pathList.Add ("icons/curvekeyframeselectedoverlay.png");
		pathList.Add ("icons/curvekeyframesemiselectedoverlay.png");
		pathList.Add ("icons/d__Popup.png");
		pathList.Add ("icons/d_aboutwindow.mainheader.png");
		pathList.Add ("icons/d_ageialogo.png");
		pathList.Add ("icons/d_Animation.AddEvent.png");
		pathList.Add ("icons/d_Animation.AddKeyframe.png");
		pathList.Add ("icons/d_Animation.EventMarker.png");
		pathList.Add ("icons/d_Animation.NextKey.png");
		pathList.Add ("icons/d_Animation.Play.png");
		pathList.Add ("icons/d_Animation.PrevKey.png");
		pathList.Add ("icons/d_Animation.Record.png");
		pathList.Add ("icons/d_animationanimated.png");
		pathList.Add ("icons/d_animationkeyframe.png");
		pathList.Add ("icons/d_animationnocurve.png");
		pathList.Add ("icons/d_animationvisibilitytoggleoff.png");
		pathList.Add ("icons/d_animationvisibilitytoggleon.png");
		pathList.Add ("icons/d_AS Badge Delete.png");
		pathList.Add ("icons/d_AS Badge Move.png");
		pathList.Add ("icons/d_AS Badge New.png");
		pathList.Add ("icons/d_Asset Store.png");
		pathList.Add ("icons/d_AssetServer.Delete.png");
		pathList.Add ("icons/d_AvatarBlendBackground.png");
		pathList.Add ("icons/d_AvatarBlendLeft.png");
		pathList.Add ("icons/d_AvatarBlendLeftA.png");
		pathList.Add ("icons/d_AvatarBlendRight.png");
		pathList.Add ("icons/d_AvatarBlendRightA.png");
		pathList.Add ("icons/d_AvatarCompass.png");
		pathList.Add ("icons/d_AvatarPivot.png");
		pathList.Add ("icons/d_beginButton.png");
		pathList.Add ("icons/d_beginButton-On.png");
		pathList.Add ("icons/d_blueGroove.png");
		pathList.Add ("icons/d_BuildSettings.Android.png");
		pathList.Add ("icons/d_BuildSettings.Android.Small.png");
		pathList.Add ("icons/d_BuildSettings.Broadcom.png");
		pathList.Add ("icons/d_BuildSettings.FlashPlayer.png");
		pathList.Add ("icons/d_BuildSettings.FlashPlayer.Small.png");
		pathList.Add ("icons/d_BuildSettings.iPhone.png");
		pathList.Add ("icons/d_BuildSettings.iPhone.Small.png");
		pathList.Add ("icons/d_BuildSettings.PS3.png");
		pathList.Add ("icons/d_BuildSettings.PS3.Small.png");
		pathList.Add ("icons/d_BuildSettings.SelectedIcon.png");
		pathList.Add ("icons/d_BuildSettings.Standalone.png");
		pathList.Add ("icons/d_BuildSettings.Standalone.Small.png");
		pathList.Add ("icons/d_BuildSettings.Web.png");
		pathList.Add ("icons/d_BuildSettings.Web.Small.png");
		pathList.Add ("icons/d_BuildSettings.Wii.png");
		pathList.Add ("icons/d_BuildSettings.Wii.Small.png");
		pathList.Add ("icons/d_BuildSettings.Xbox360.png");
		pathList.Add ("icons/d_BuildSettings.Xbox360.Small.png");
		pathList.Add ("icons/d_CheckerFloor.png");
		pathList.Add ("icons/d_ColorPicker.CycleColor.png");
		pathList.Add ("icons/d_ColorPicker.CycleSlider.png");
		pathList.Add ("icons/d_console.erroricon.png");
		pathList.Add ("icons/d_console.erroricon.sml.png");
		pathList.Add ("icons/d_console.infoicon.png");
		pathList.Add ("icons/d_console.infoicon.sml.png");
		pathList.Add ("icons/d_console.warnicon.png");
		pathList.Add ("icons/d_console.warnicon.sml.png");
		pathList.Add ("icons/d_curvekeyframe.png");
		pathList.Add ("icons/d_curvekeyframeselected.png");
		pathList.Add ("icons/d_curvekeyframeselectedoverlay.png");
		pathList.Add ("icons/d_curvekeyframesemiselectedoverlay.png");
		pathList.Add ("icons/d_editicon.sml.png");
		pathList.Add ("icons/d_endButton.png");
		pathList.Add ("icons/d_endButton-On.png");
		pathList.Add ("icons/d_eyeDropper.Large.png");
		pathList.Add ("icons/d_eyeDropper.sml.png");
		pathList.Add ("icons/d_Favorite.png");
		pathList.Add ("icons/d_FilterByLabel.png");
		pathList.Add ("icons/d_FilterByType.png");
		pathList.Add ("icons/d_GEAR.png");
		pathList.Add ("icons/d_Groove.png");
		pathList.Add ("icons/d_HorizontalSplit.png");
		pathList.Add ("icons/d_icon dropdown.png");
		pathList.Add ("icons/d_IN-AddComponentLeft.png");
		pathList.Add ("icons/d_IN-AddComponentRight.png");
		pathList.Add ("icons/d_InspectorLock.png");
		pathList.Add ("icons/d_leftBracket.png");
		pathList.Add ("icons/d_Mirror.png");
		pathList.Add ("icons/d_model large.png");
		pathList.Add ("icons/d_monologo.png");
		pathList.Add ("icons/d_MoveTool on.png");
		pathList.Add ("icons/d_MoveTool.png");
		pathList.Add ("icons/d_Navigation.png");
		pathList.Add ("icons/d_Occlusion.png");
		pathList.Add ("icons/d_P4_AddedLocal.png");
		pathList.Add ("icons/d_P4_AddedRemote.png");
		pathList.Add ("icons/d_P4_CheckOutLocal.png");
		pathList.Add ("icons/d_P4_CheckOutRemote.png");
		pathList.Add ("icons/d_P4_Conflicted.png");
		pathList.Add ("icons/d_P4_DeletedLocal.png");
		pathList.Add ("icons/d_P4_DeletedRemote.png");
		pathList.Add ("icons/d_P4_Local.png");
		pathList.Add ("icons/d_P4_LockedLocal.png");
		pathList.Add ("icons/d_P4_LockedRemote.png");
		pathList.Add ("icons/d_P4_OutOfSync.png");
		pathList.Add ("icons/d_Particle Effect.png");
		pathList.Add ("icons/d_PauseButton Anim.png");
		pathList.Add ("icons/d_PauseButton On.png");
		pathList.Add ("icons/d_PauseButton.png");
		pathList.Add ("icons/d_PlayButton Anim.png");
		pathList.Add ("icons/d_PlayButton On.png");
		pathList.Add ("icons/d_PlayButton.png");
		pathList.Add ("icons/d_PlayButtonProfile Anim.png");
		pathList.Add ("icons/d_PlayButtonProfile On.png");
		pathList.Add ("icons/d_PlayButtonProfile.png");
		pathList.Add ("icons/d_playLoopOff.png");
		pathList.Add ("icons/d_playLoopOn.png");
		pathList.Add ("icons/d_preAudioAutoPlayOff.png");
		pathList.Add ("icons/d_preAudioAutoPlayOn.png");
		pathList.Add ("icons/d_preAudioLoopOff.png");
		pathList.Add ("icons/d_preAudioLoopOn.png");
		pathList.Add ("icons/d_preAudioPlayOff.png");
		pathList.Add ("icons/d_preAudioPlayOn.png");
		pathList.Add ("icons/d_PreMatCube.png");
		pathList.Add ("icons/d_PreMatCylinder.png");
		pathList.Add ("icons/d_PreMatLight0.png");
		pathList.Add ("icons/d_PreMatLight1.png");
		pathList.Add ("icons/d_PreMatSphere.png");
		pathList.Add ("icons/d_PreMatTorus.png");
		pathList.Add ("icons/d_PreTextureAlpha.png");
		pathList.Add ("icons/d_PreTextureMipMapHigh.png");
		pathList.Add ("icons/d_PreTextureMipMapLow.png");
		pathList.Add ("icons/d_PreTextureRGB.png");
		pathList.Add ("icons/d_Profiler.Audio.png");
		pathList.Add ("icons/d_Profiler.CPU.png");
		pathList.Add ("icons/d_Profiler.FirstFrame.png");
		pathList.Add ("icons/d_Profiler.LastFrame.png");
		pathList.Add ("icons/d_Profiler.Memory.png");
		pathList.Add ("icons/d_Profiler.Network.png");
		pathList.Add ("icons/d_Profiler.NextFrame.png");
		pathList.Add ("icons/d_Profiler.PrevFrame.png");
		pathList.Add ("icons/d_Profiler.Record.png");
		pathList.Add ("icons/d_Profiler.Rendering.png");
		pathList.Add ("icons/d_Project.png");
		pathList.Add ("icons/d_redGroove.png");
		pathList.Add ("icons/d_Refresh.png");
		pathList.Add ("icons/d_rightBracket.png");
		pathList.Add ("icons/d_RotateTool On.png");
		pathList.Add ("icons/d_RotateTool.png");
		pathList.Add ("icons/d_ScaleTool On.png");
		pathList.Add ("icons/d_ScaleTool.png");
		pathList.Add ("icons/d_SceneViewAlpha.png");
		pathList.Add ("icons/d_SceneViewAudio.png");
		pathList.Add ("icons/d_SceneViewFx.png");
		pathList.Add ("icons/d_SceneViewLighting.png");
		pathList.Add ("icons/d_SceneViewOrtho.png");
		pathList.Add ("icons/d_SceneViewRGB.png");
		pathList.Add ("icons/d_SettingsIcon.png");
		pathList.Add ("icons/d_SocialNetworks.FacebookShare.png");
		pathList.Add ("icons/d_SocialNetworks.LinkedInShare.png");
		pathList.Add ("icons/d_SocialNetworks.Tweet.png");
		pathList.Add ("icons/d_SocialNetworks.UDNOpen.png");
		pathList.Add ("icons/d_SpeedScale.png");
		pathList.Add ("icons/d_StepButton Anim.png");
		pathList.Add ("icons/d_StepButton On.png");
		pathList.Add ("icons/d_StepButton.png");
		pathList.Add ("icons/d_StepLeftButton.png");
		pathList.Add ("icons/d_StepLeftButton-On.png");
		pathList.Add ("icons/d_SVN_AddedLocal.png");
		pathList.Add ("icons/d_SVN_Conflicted.png");
		pathList.Add ("icons/d_SVN_DeletedLocal.png");
		pathList.Add ("icons/d_SVN_Local.png");
		pathList.Add ("icons/d_SVN_LockedLocal.png");
		pathList.Add ("icons/d_SVN_OutOfSync.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolLower On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolLowerAlt.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolPlants On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolPlants.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolPlantsAlt On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolPlantsAlt.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolRaise On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolRaise.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSetheight On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSetheight.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSetheightAlt On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSetheightAlt.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSettings On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSettings.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSmoothHeight On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSmoothHeight.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSplat On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSplat.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSplatAlt On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolSplatAlt.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolTrees On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolTrees.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolTreesAlt On.png");
		pathList.Add ("icons/d_TerrainInspector.TerrainToolTreesAlt.png");
		pathList.Add ("icons/d_Toolbar Minus.png");
		pathList.Add ("icons/d_Toolbar Plus More.png");
		pathList.Add ("icons/d_Toolbar Plus.png");
		pathList.Add ("icons/d_ToolHandleCenter.png");
		pathList.Add ("icons/d_ToolHandleGlobal.png");
		pathList.Add ("icons/d_ToolHandleLocal.png");
		pathList.Add ("icons/d_ToolHandlePivot.png");
		pathList.Add ("icons/d_tranp.png");
		pathList.Add ("icons/d_tree_icon.png");
		pathList.Add ("icons/d_tree_icon_branch.png");
		pathList.Add ("icons/d_tree_icon_branch_frond.png");
		pathList.Add ("icons/d_tree_icon_frond.png");
		pathList.Add ("icons/d_tree_icon_leaf.png");
		pathList.Add ("icons/d_TreeEditor.AddBranches.png");
		pathList.Add ("icons/d_TreeEditor.AddLeaves.png");
		pathList.Add ("icons/d_TreeEditor.Branch On.png");
		pathList.Add ("icons/d_TreeEditor.Branch.png");
		pathList.Add ("icons/d_TreeEditor.BranchFreeHand On.png");
		pathList.Add ("icons/d_TreeEditor.BranchFreeHand.png");
		pathList.Add ("icons/d_TreeEditor.BranchRotate On.png");
		pathList.Add ("icons/d_TreeEditor.BranchRotate.png");
		pathList.Add ("icons/d_TreeEditor.BranchScale On.png");
		pathList.Add ("icons/d_TreeEditor.BranchScale.png");
		pathList.Add ("icons/d_TreeEditor.BranchTranslate On.png");
		pathList.Add ("icons/d_TreeEditor.BranchTranslate.png");
		pathList.Add ("icons/d_TreeEditor.Distribution On.png");
		pathList.Add ("icons/d_TreeEditor.Distribution.png");
		pathList.Add ("icons/d_TreeEditor.Duplicate.png");
		pathList.Add ("icons/d_TreeEditor.Geometry On.png");
		pathList.Add ("icons/d_TreeEditor.Geometry.png");
		pathList.Add ("icons/d_TreeEditor.Leaf On.png");
		pathList.Add ("icons/d_TreeEditor.Leaf.png");
		pathList.Add ("icons/d_TreeEditor.LeafFreeHand On.png");
		pathList.Add ("icons/d_TreeEditor.LeafFreeHand.png");
		pathList.Add ("icons/d_TreeEditor.LeafRotate On.png");
		pathList.Add ("icons/d_TreeEditor.LeafRotate.png");
		pathList.Add ("icons/d_TreeEditor.LeafScale On.png");
		pathList.Add ("icons/d_TreeEditor.LeafScale.png");
		pathList.Add ("icons/d_TreeEditor.LeafTranslate On.png");
		pathList.Add ("icons/d_TreeEditor.LeafTranslate.png");
		pathList.Add ("icons/d_TreeEditor.Material On.png");
		pathList.Add ("icons/d_TreeEditor.Material.png");
		pathList.Add ("icons/d_TreeEditor.Refresh.png");
		pathList.Add ("icons/d_TreeEditor.Trash.png");
		pathList.Add ("icons/d_TreeEditor.Wind On.png");
		pathList.Add ("icons/d_TreeEditor.Wind.png");
		pathList.Add ("icons/d_UnityEditor.AnimationWindow.png");
		pathList.Add ("icons/d_UnityEditor.ConsoleWindow.png");
		pathList.Add ("icons/d_UnityEditor.DebugInspectorWindow.png");
		pathList.Add ("icons/d_UnityEditor.GameView.png");
		pathList.Add ("icons/d_UnityEditor.HierarchyWindow.png");
		pathList.Add ("icons/d_UnityEditor.InspectorWindow.png");
		pathList.Add ("icons/d_UnityEditor.ProfilerWindow.png");
		pathList.Add ("icons/d_UnityEditor.SceneView.png");
		pathList.Add ("icons/d_UnityEditor.ServerView.png");
		pathList.Add ("icons/d_UnityLogo.png");
		pathList.Add ("icons/d_VerticalSplit.png");
		pathList.Add ("icons/d_ViewToolMove On.png");
		pathList.Add ("icons/d_ViewToolMove.png");
		pathList.Add ("icons/d_ViewToolOrbit On.png");
		pathList.Add ("icons/d_ViewToolOrbit.png");
		pathList.Add ("icons/d_ViewToolZoom On.png");
		pathList.Add ("icons/d_ViewToolZoom.png");
		pathList.Add ("icons/d_VUMeterTextureHorizontal.png");
		pathList.Add ("icons/d_VUMeterTextureVertical.png");
		pathList.Add ("icons/d_WaitSpin00.png");
		pathList.Add ("icons/d_WaitSpin01.png");
		pathList.Add ("icons/d_WaitSpin02.png");
		pathList.Add ("icons/d_WaitSpin03.png");
		pathList.Add ("icons/d_WaitSpin04.png");
		pathList.Add ("icons/d_WaitSpin05.png");
		pathList.Add ("icons/d_WaitSpin06.png");
		pathList.Add ("icons/d_WaitSpin07.png");
		pathList.Add ("icons/d_WaitSpin08.png");
		pathList.Add ("icons/d_WaitSpin09.png");
		pathList.Add ("icons/d_WaitSpin10.png");
		pathList.Add ("icons/d_WaitSpin11.png");
		pathList.Add ("icons/d_WelcomeScreen.AssetStoreLogo.png");
		pathList.Add ("icons/d_WelcomeScreen.MainHeader.png");
		pathList.Add ("icons/d_WelcomeScreen.UnityAnswersLogo.png");
		pathList.Add ("icons/d_WelcomeScreen.UnityBasicsLogo.png");
		pathList.Add ("icons/d_WelcomeScreen.UnityForumLogo.png");
		pathList.Add ("icons/d_WelcomeScreen.VideoTutLogo.png");
		pathList.Add ("icons/d_winbtn_graph.png");
		pathList.Add ("icons/d_winbtn_graph_close_h.png");
		pathList.Add ("icons/d_winbtn_graph_max_h.png");
		pathList.Add ("icons/d_winbtn_graph_min_h.png");
		pathList.Add ("icons/d_winbtn_mac_close.png");
		pathList.Add ("icons/d_winbtn_mac_close_a.png");
		pathList.Add ("icons/d_winbtn_mac_close_h.png");
		pathList.Add ("icons/d_winbtn_mac_inact.png");
		pathList.Add ("icons/d_winbtn_mac_max.png");
		pathList.Add ("icons/d_winbtn_mac_max_a.png");
		pathList.Add ("icons/d_winbtn_mac_max_h.png");
		pathList.Add ("icons/d_winbtn_mac_min.png");
		pathList.Add ("icons/d_winbtn_mac_min_a.png");
		pathList.Add ("icons/d_winbtn_mac_min_h.png");
		pathList.Add ("icons/d_winbtn_win_close.png");
		pathList.Add ("icons/d_winbtn_win_close_a.png");
		pathList.Add ("icons/d_winbtn_win_close_h.png");
		pathList.Add ("icons/d_winbtn_win_max.png");
		pathList.Add ("icons/d_winbtn_win_max_a.png");
		pathList.Add ("icons/d_winbtn_win_max_h.png");
		pathList.Add ("icons/d_winbtn_win_min.png");
		pathList.Add ("icons/d_winbtn_win_min_a.png");
		pathList.Add ("icons/d_winbtn_win_min_h.png");
		pathList.Add ("icons/d_winbtn_win_rest.png");
		pathList.Add ("icons/d_winbtn_win_rest_a.png");
		pathList.Add ("icons/d_winbtn_win_rest_h.png");
		pathList.Add ("icons/DirectionalLight Gizmo.png");
		pathList.Add ("icons/editicon.sml.png");
		pathList.Add ("icons/endButton.png");
		pathList.Add ("icons/endButton-On.png");
		pathList.Add ("icons/eyeDropper.Large.png");
		pathList.Add ("icons/eyeDropper.sml.png");
		pathList.Add ("icons/Favorite.png");
		pathList.Add ("icons/FilterByLabel.png");
		pathList.Add ("icons/FilterByType.png");
		pathList.Add ("icons/GEAR.png");
		pathList.Add ("icons/Groove.png");
		pathList.Add ("icons/HorizontalSplit.png");
		pathList.Add ("icons/icon dropdown.png");
		pathList.Add ("icons/IN-AddComponentLeft.png");
		pathList.Add ("icons/IN-AddComponentRight.png");
		pathList.Add ("icons/InspectorLock.png");
		pathList.Add ("icons/leftBracket.png");
		pathList.Add ("icons/LensFlare Gizmo.png");
		pathList.Add ("icons/Light Gizmo.png");
		pathList.Add ("icons/Lightmapping.png");
		pathList.Add ("icons/loop.png");
		pathList.Add ("icons/Main Light Gizmo.png");
		pathList.Add ("icons/Mirror.png");
		pathList.Add ("icons/monologo.png");
		pathList.Add ("icons/MoveTool on.png");
		pathList.Add ("icons/MoveTool.png");
		pathList.Add ("icons/Navigation.png");
		pathList.Add ("icons/Occlusion.png");
		pathList.Add ("icons/P4_AddedLocal.png");
		pathList.Add ("icons/P4_AddedRemote.png");
		pathList.Add ("icons/P4_CheckOutLocal.png");
		pathList.Add ("icons/P4_CheckOutRemote.png");
		pathList.Add ("icons/P4_Conflicted.png");
		pathList.Add ("icons/P4_DeletedLocal.png");
		pathList.Add ("icons/P4_DeletedRemote.png");
		pathList.Add ("icons/P4_Local.png");
		pathList.Add ("icons/P4_LockedLocal.png");
		pathList.Add ("icons/P4_LockedRemote.png");
		pathList.Add ("icons/P4_OutOfSync.png");
		pathList.Add ("icons/Particle Effect.png");
		pathList.Add ("icons/ParticleSystem Gizmo.png");
		pathList.Add ("icons/PauseButton Anim.png");
		pathList.Add ("icons/PauseButton On.png");
		pathList.Add ("icons/PauseButton.png");
		pathList.Add ("icons/PlayButton Anim.png");
		pathList.Add ("icons/PlayButton On.png");
		pathList.Add ("icons/PlayButton.png");
		pathList.Add ("icons/PlayButtonProfile Anim.png");
		pathList.Add ("icons/PlayButtonProfile On.png");
		pathList.Add ("icons/PlayButtonProfile.png");
		pathList.Add ("icons/playLoopOff.png");
		pathList.Add ("icons/playLoopOn.png");
		pathList.Add ("icons/playSpeed.png");
		pathList.Add ("icons/PointLight Gizmo.png");
		pathList.Add ("icons/preAudioAutoPlayOff.png");
		pathList.Add ("icons/preAudioAutoPlayOn.png");
		pathList.Add ("icons/preAudioLoopOff.png");
		pathList.Add ("icons/preAudioLoopOn.png");
		pathList.Add ("icons/preAudioPlayOff.png");
		pathList.Add ("icons/preAudioPlayOn.png");
		pathList.Add ("icons/PreMatCube.png");
		pathList.Add ("icons/PreMatCylinder.png");
		pathList.Add ("icons/PreMatLight0.png");
		pathList.Add ("icons/PreMatLight1.png");
		pathList.Add ("icons/PreMatSphere.png");
		pathList.Add ("icons/PreMatTorus.png");
		pathList.Add ("icons/PreTextureAlpha.png");
		pathList.Add ("icons/PreTextureMipMapHigh.png");
		pathList.Add ("icons/PreTextureMipMapLow.png");
		pathList.Add ("icons/PreTextureRGB.png");
		pathList.Add ("icons/Profiler.Audio.png");
		pathList.Add ("icons/Profiler.CPU.png");
		pathList.Add ("icons/Profiler.FirstFrame.png");
		pathList.Add ("icons/Profiler.LastFrame.png");
		pathList.Add ("icons/Profiler.Memory.png");
		pathList.Add ("icons/Profiler.Network.png");
		pathList.Add ("icons/Profiler.NextFrame.png");
		pathList.Add ("icons/Profiler.PrevFrame.png");
		pathList.Add ("icons/Profiler.Record.png");
		pathList.Add ("icons/Profiler.Rendering.png");
		pathList.Add ("icons/Project.png");
		pathList.Add ("icons/Projector Gizmo.png");
		pathList.Add ("icons/redGroove.png");
		pathList.Add ("icons/Refresh.png");
		pathList.Add ("icons/rightBracket.png");
		pathList.Add ("icons/RotateTool On.png");
		pathList.Add ("icons/RotateTool.png");
		pathList.Add ("icons/ScaleTool On.png");
		pathList.Add ("icons/ScaleTool.png");
		pathList.Add ("icons/SceneViewAlpha.png");
		pathList.Add ("icons/SceneViewAudio.png");
		pathList.Add ("icons/SceneViewFx.png");
		pathList.Add ("icons/SceneViewLighting.png");
		pathList.Add ("icons/SceneViewOrtho.png");
		pathList.Add ("icons/SceneViewRGB.png");
		pathList.Add ("icons/SettingsIcon.png");
		pathList.Add ("icons/SocialNetworks.FacebookShare.png");
		pathList.Add ("icons/SocialNetworks.LinkedInShare.png");
		pathList.Add ("icons/SocialNetworks.Tweet.png");
		pathList.Add ("icons/SocialNetworks.UDNLogo.png");
		pathList.Add ("icons/SocialNetworks.UDNOpen.png");
		pathList.Add ("icons/SpeedScale.png");
		pathList.Add ("icons/SpeedScale.png");
		pathList.Add ("icons/SpotLight Gizmo.png");
		pathList.Add ("icons/StateMachineEditor.ArrowTip.png");
		pathList.Add ("icons/StateMachineEditor.ArrowTipSelected.png");
		pathList.Add ("icons/StateMachineEditor.Background.png");
		pathList.Add ("icons/StateMachineEditor.State.png");
		pathList.Add ("icons/StateMachineEditor.StateHover.png");
		pathList.Add ("icons/StateMachineEditor.StateSelected.png");
		pathList.Add ("icons/StateMachineEditor.StateSub.png");
		pathList.Add ("icons/StateMachineEditor.StateSubHover.png");
		pathList.Add ("icons/StateMachineEditor.StateSubSelected.png");
		pathList.Add ("icons/StateMachineEditor.UpButton.png");
		pathList.Add ("icons/StateMachineEditor.UpButtonHover.png");
		pathList.Add ("icons/StepButton Anim.png");
		pathList.Add ("icons/StepButton On.png");
		pathList.Add ("icons/StepButton.png");
		pathList.Add ("icons/StepLeftButton.png");
		pathList.Add ("icons/StepLeftButton-On.png");
		pathList.Add ("icons/sticky_arrow.png");
		pathList.Add ("icons/sticky_p4.png");
		pathList.Add ("icons/sticky_skin.png");
		pathList.Add ("icons/sv_icon_dot0_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot0_sml.png");
		pathList.Add ("icons/sv_icon_dot1_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot1_sml.png");
		pathList.Add ("icons/sv_icon_dot10_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot10_sml.png");
		pathList.Add ("icons/sv_icon_dot11_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot11_sml.png");
		pathList.Add ("icons/sv_icon_dot12_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot12_sml.png");
		pathList.Add ("icons/sv_icon_dot13_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot13_sml.png");
		pathList.Add ("icons/sv_icon_dot14_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot14_sml.png");
		pathList.Add ("icons/sv_icon_dot15_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot15_sml.png");
		pathList.Add ("icons/sv_icon_dot2_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot2_sml.png");
		pathList.Add ("icons/sv_icon_dot3_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot3_sml.png");
		pathList.Add ("icons/sv_icon_dot4_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot4_sml.png");
		pathList.Add ("icons/sv_icon_dot5_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot5_sml.png");
		pathList.Add ("icons/sv_icon_dot6_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot6_sml.png");
		pathList.Add ("icons/sv_icon_dot7_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot7_sml.png");
		pathList.Add ("icons/sv_icon_dot8_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot8_sml.png");
		pathList.Add ("icons/sv_icon_dot9_pix16_gizmo.png");
		pathList.Add ("icons/sv_icon_dot9_sml.png");
		pathList.Add ("icons/sv_icon_name0.png");
		pathList.Add ("icons/sv_icon_name1.png");
		pathList.Add ("icons/sv_icon_name2.png");
		pathList.Add ("icons/sv_icon_name3.png");
		pathList.Add ("icons/sv_icon_name4.png");
		pathList.Add ("icons/sv_icon_name5.png");
		pathList.Add ("icons/sv_icon_name6.png");
		pathList.Add ("icons/sv_icon_name7.png");
		pathList.Add ("icons/sv_icon_none.png");
		pathList.Add ("icons/sv_label_0.png");
		pathList.Add ("icons/sv_label_1.png");
		pathList.Add ("icons/sv_label_2.png");
		pathList.Add ("icons/sv_label_3.png");
		pathList.Add ("icons/sv_label_4.png");
		pathList.Add ("icons/sv_label_5.png");
		pathList.Add ("icons/sv_label_6.png");
		pathList.Add ("icons/sv_label_7.png");
		pathList.Add ("icons/SVN_AddedLocal.png");
		pathList.Add ("icons/SVN_Conflicted.png");
		pathList.Add ("icons/SVN_DeletedLocal.png");
		pathList.Add ("icons/SVN_Local.png");
		pathList.Add ("icons/SVN_LockedLocal.png");
		pathList.Add ("icons/SVN_OutOfSync.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolLower On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolLower.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolLowerAlt.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolPlants On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolPlants.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolPlantsAlt On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolPlantsAlt.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolRaise On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolRaise.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSetheight On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSetheight.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSetheightAlt On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSetheightAlt.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSettings On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSettings.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSmoothHeight On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSmoothHeight.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSplat On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSplat.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSplatAlt On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolSplatAlt.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolTrees On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolTrees.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolTreesAlt On.png");
		pathList.Add ("icons/TerrainInspector.TerrainToolTreesAlt.png");
		pathList.Add ("icons/Toolbar Minus.png");
		pathList.Add ("icons/Toolbar Plus More.png");
		pathList.Add ("icons/Toolbar Plus.png");
		pathList.Add ("icons/ToolHandleCenter.png");
		pathList.Add ("icons/ToolHandleGlobal.png");
		pathList.Add ("icons/ToolHandleLocal.png");
		pathList.Add ("icons/ToolHandlePivot.png");
		pathList.Add ("icons/tranp.png");
		pathList.Add ("icons/tree_icon.png");
		pathList.Add ("icons/tree_icon_branch.png");
		pathList.Add ("icons/tree_icon_branch_frond.png");
		pathList.Add ("icons/tree_icon_frond.png");
		pathList.Add ("icons/tree_icon_leaf.png");
		pathList.Add ("icons/TreeEditor.AddBranches.png");
		pathList.Add ("icons/TreeEditor.AddLeaves.png");
		pathList.Add ("icons/TreeEditor.Branch On.png");
		pathList.Add ("icons/TreeEditor.Branch.png");
		pathList.Add ("icons/TreeEditor.BranchFreeHand On.png");
		pathList.Add ("icons/TreeEditor.BranchFreeHand.png");
		pathList.Add ("icons/TreeEditor.BranchRotate On.png");
		pathList.Add ("icons/TreeEditor.BranchRotate.png");
		pathList.Add ("icons/TreeEditor.BranchScale On.png");
		pathList.Add ("icons/TreeEditor.BranchScale.png");
		pathList.Add ("icons/TreeEditor.BranchTranslate On.png");
		pathList.Add ("icons/TreeEditor.BranchTranslate.png");
		pathList.Add ("icons/TreeEditor.Distribution On.png");
		pathList.Add ("icons/TreeEditor.Distribution.png");
		pathList.Add ("icons/TreeEditor.Duplicate.png");
		pathList.Add ("icons/TreeEditor.Geometry On.png");
		pathList.Add ("icons/TreeEditor.Geometry.png");
		pathList.Add ("icons/TreeEditor.Leaf On.png");
		pathList.Add ("icons/TreeEditor.Leaf.png");
		pathList.Add ("icons/TreeEditor.LeafFreeHand On.png");
		pathList.Add ("icons/TreeEditor.LeafFreeHand.png");
		pathList.Add ("icons/TreeEditor.LeafRotate On.png");
		pathList.Add ("icons/TreeEditor.LeafRotate.png");
		pathList.Add ("icons/TreeEditor.LeafScale On.png");
		pathList.Add ("icons/TreeEditor.LeafScale.png");
		pathList.Add ("icons/TreeEditor.LeafTranslate On.png");
		pathList.Add ("icons/TreeEditor.LeafTranslate.png");
		pathList.Add ("icons/TreeEditor.Material On.png");
		pathList.Add ("icons/TreeEditor.Material.png");
		pathList.Add ("icons/TreeEditor.Refresh.png");
		pathList.Add ("icons/TreeEditor.Trash.png");
		pathList.Add ("icons/TreeEditor.Wind On.png");
		pathList.Add ("icons/TreeEditor.Wind.png");
		pathList.Add ("icons/UnityEditor.AnimationWindow.png");
		pathList.Add ("icons/UnityEditor.ASMainWindow.png");
		pathList.Add ("icons/UnityEditor.ConsoleWindow.png");
		pathList.Add ("icons/UnityEditor.DebugInspectorWindow.png");
		pathList.Add ("icons/UnityEditor.GameView.png");
		pathList.Add ("icons/UnityEditor.Graphs.AnimatorControllerTool.png");
		pathList.Add ("icons/UnityEditor.HierarchyWindow.png");
		pathList.Add ("icons/UnityEditor.InspectorWindow.png");
		pathList.Add ("icons/UnityEditor.ProfilerWindow.png");
		pathList.Add ("icons/UnityEditor.SceneView.png");
		pathList.Add ("icons/UnityEditor.ServerView.png");
		pathList.Add ("icons/UnityLogo.png");
		pathList.Add ("icons/UnityLogoLarge.png");
		pathList.Add ("icons/UpArrow.png");
		pathList.Add ("icons/vcs_add.png");
		pathList.Add ("icons/vcs_branch.png");
		pathList.Add ("icons/vcs_change.png");
		pathList.Add ("icons/vcs_check.png");
		pathList.Add ("icons/vcs_delete.png");
		pathList.Add ("icons/vcs_document.png");
		pathList.Add ("icons/vcs_edit.png");
		pathList.Add ("icons/vcs_integrate.png");
		pathList.Add ("icons/vcs_local.png");
		pathList.Add ("icons/vcs_lock.png");
		pathList.Add ("icons/vcs_refresh.png");
		pathList.Add ("icons/vcs_sync.png");
		pathList.Add ("icons/vcs_unresolved.png");
		pathList.Add ("icons/vcs_update.png");
		pathList.Add ("icons/VerticalSplit.png");
		pathList.Add ("icons/ViewToolMove On.png");
		pathList.Add ("icons/ViewToolMove.png");
		pathList.Add ("icons/ViewToolOrbit On.png");
		pathList.Add ("icons/ViewToolOrbit.png");
		pathList.Add ("icons/ViewToolZoom On.png");
		pathList.Add ("icons/ViewToolZoom.png");
		pathList.Add ("icons/VUMeterTextureHorizontal.png");
		pathList.Add ("icons/VUMeterTextureVertical.png");
		pathList.Add ("icons/WaitSpin00.png");
		pathList.Add ("icons/WaitSpin01.png");
		pathList.Add ("icons/WaitSpin02.png");
		pathList.Add ("icons/WaitSpin03.png");
		pathList.Add ("icons/WaitSpin04.png");
		pathList.Add ("icons/WaitSpin05.png");
		pathList.Add ("icons/WaitSpin06.png");
		pathList.Add ("icons/WaitSpin07.png");
		pathList.Add ("icons/WaitSpin08.png");
		pathList.Add ("icons/WaitSpin09.png");
		pathList.Add ("icons/WaitSpin10.png");
		pathList.Add ("icons/WaitSpin11.png");
		pathList.Add ("icons/WelcomeScreen.AssetStoreLogo.png");
		pathList.Add ("icons/WelcomeScreen.MainHeader.png");
		pathList.Add ("icons/WelcomeScreen.UnityAnswersLogo.png");
		pathList.Add ("icons/WelcomeScreen.UnityBasicsLogo.png");
		pathList.Add ("icons/WelcomeScreen.UnityForumLogo.png");
		pathList.Add ("icons/WelcomeScreen.VideoTutLogo.png");
		pathList.Add ("icons/winbtn_graph.png");
		pathList.Add ("icons/winbtn_graph_close_h.png");
		pathList.Add ("icons/winbtn_graph_max_h.png");
		pathList.Add ("icons/winbtn_graph_min_h.png");
		pathList.Add ("icons/winbtn_mac_close.png");
		pathList.Add ("icons/winbtn_mac_close_a.png");
		pathList.Add ("icons/winbtn_mac_close_h.png");
		pathList.Add ("icons/winbtn_mac_inact.png");
		pathList.Add ("icons/winbtn_mac_max.png");
		pathList.Add ("icons/winbtn_mac_max_a.png");
		pathList.Add ("icons/winbtn_mac_max_h.png");
		pathList.Add ("icons/winbtn_mac_min.png");
		pathList.Add ("icons/winbtn_mac_min_a.png");
		pathList.Add ("icons/winbtn_mac_min_h.png");
		pathList.Add ("icons/winbtn_win_close.png");
		pathList.Add ("icons/winbtn_win_close_a.png");
		pathList.Add ("icons/winbtn_win_close_h.png");
		pathList.Add ("icons/winbtn_win_max.png");
		pathList.Add ("icons/winbtn_win_max_a.png");
		pathList.Add ("icons/winbtn_win_max_h.png");
		pathList.Add ("icons/winbtn_win_min.png");
		pathList.Add ("icons/winbtn_win_min_a.png");
		pathList.Add ("icons/winbtn_win_min_h.png");
		pathList.Add ("icons/winbtn_win_rest.png");
		pathList.Add ("icons/winbtn_win_rest_a.png");
		pathList.Add ("icons/winbtn_win_rest_h.png");
		pathList.Add ("icons/WindZone Gizmo.png");
		return pathList;
	}

}
