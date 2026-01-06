
namespace HUDPositioner
{
	public class HUDPositionerMelon : MelonMod
	{
		public static bool changedHudScale = false;


        public override void OnInitializeMelon()
		{
			Settings.instance.AddToModSettings("HUD Positioner");
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
	        if (HUDPositionerUtilities.IsScenePlayable(sceneName))
	        {
		        ApplyPositionSettings();
	        }
        }


        public static void ApplyPositionSettings()
        {
	        if (HUDPositionerUtilities.IsMenu())
	        {
		        return;
	        }
	        if (InterfaceManager.m_Instance == null)
	        {
		        return;
	        }
	        Panel_HUD panel = InterfaceManager.GetPanel<Panel_HUD>();
	        if (panel == null)
	        {
		        return;
	        }
	        foreach(UIAnchor a in panel.GetComponentsInChildren<UIAnchor>(true))
	        {
		        //Melon<HUDPositionerMelon>.Logger.Msg(a.gameObject.name);
		        switch (a.gameObject.name)
		        {
			        case "StatusBars_Small":
				        a.side = HUDPositionerUtilities.GetAnchorSideBySetting(Settings.instance.statusbaranchormode);
				        a.relativeOffset = HUDPositionerUtilities.GetFinalStatusBarOffset(0,Settings.instance.statusbaranchormode);
				        a.ApplyUpdatedPosition();
				        break;
			        case "StatusBars_Regular":
				        a.side = HUDPositionerUtilities.GetAnchorSideBySetting(Settings.instance.statusbaranchormode);
				        a.relativeOffset = HUDPositionerUtilities.GetFinalStatusBarOffset(1,Settings.instance.statusbaranchormode);
				        a.ApplyUpdatedPosition();
				        break;
			        case "StatusBars_Large":
				        a.side = HUDPositionerUtilities.GetAnchorSideBySetting(Settings.instance.statusbaranchormode);
				        a.relativeOffset = HUDPositionerUtilities.GetFinalStatusBarOffset(2,Settings.instance.statusbaranchormode);
				        a.ApplyUpdatedPosition();
				        break;
			        case "BottomRightAnchor":
				        a.side = HUDPositionerUtilities.GetAnchorSideBySetting(Settings.instance.bottomrightanchormode);
				        a.relativeOffset = HUDPositionerUtilities.GetFinalBottomRightAnchorOffset();
				        a.ApplyUpdatedPosition();
				        break;
			        case "PlayerDamageEventTable":
				        a.relativeOffset = HUDPositionerUtilities.GetFinalAfflictionTableAnchorOffset();
				        a.ApplyUpdatedPosition();
				        break;
			        case "SafehouseCustomization":
				        //Inactive at the beginning for some reason.
				        a.gameObject.SetActive(true);
				        a.Start();
				        a.side = HUDPositionerUtilities.GetAnchorSideBySetting(Settings.instance.safehouseanchormode,true);
				        a.relativeOffset = HUDPositionerUtilities.GetFinalSafehouseAnchorOffset();
				        a.ApplyUpdatedPosition();
				        break;
			        case "LocationDiscoveredObjects":
				        a.relativeOffset = HUDPositionerUtilities.GetFinalLocationAnchorOffset();
				        a.ApplyUpdatedPosition();
				        break;
		        }
	        }


        }

    }
}