using ModSettings;

namespace HUDPositioner
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Status Bar Positioning")]
        [Name("Status Bar Anchor")]
        [Description("Determines where on screen the Status Bar should be attached to.")]
        [Choice("Bottom Left", "Bottom Center","Bottom Right")]
        public int statusbaranchormode = 0;

        [Name("Status Bar Offset Right")]
        [Description("Determines how much the Status Bar should be offset to the right. Negative values will make it move towards the left.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int statusbaroffsetright = 0;
        
        [Name("Status Bar Offset Up")]
        [Description("Determines how much the Status Bar should be offset to the top. Negative values will make it move towards the bottom.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int statusbaroffsettop = 0;

        [Section("Sprint Bar Positioning")]
        [Name("Sprint Bar Anchor")]
        [Description("Determines where on screen the Sprint Bar should be attached to.")]
        [Choice("Bottom Left", "Bottom Center", "Bottom Right")]
        public int bottomrightanchormode = 2;
        
        [Name("Sprint Bar Offset Right")]
        [Description("Determines how much the Status Bar should be offset to the right. Negative values will make it move towards the left.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int bottomrightoffsetright = 0;
        
        [Name("Sprint Bar Offset Up")]
        [Description("Determines how much the Status Bar should be offset to the top. Negative values will make it move towards the bottom.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int bottomrightoffsetup = 0;
        
        [Section("Affliction Table Positioning")]
        
        [Name("Affliction Table Offset Right")]
        [Description("Determines how much the Affliction Table should be offset to the right. Negative values will make it move towards the left.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int afflictiontableoffsetright = 0;
        
        [Name("Affliction Table Offset Up")]
        [Description("Determines how much the Affliction Table should be offset to the top. Negative values will make it move towards the bottom.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int afflictiontableoffsetup = 0;
        
        [Section("Safehouse Icon Positioning")]
        [Name("Safehouse Icon Anchor")]
        [Description("Determines where on screen the Safehouse Icon should be attached to.")]
        [Choice("Top Left", "Top Center", "Top Right")]
        public int safehouseanchormode = 0;
        
        [Name("Safehouse Icon Offset Right")]
        [Description("Determines how much the Safehouse Icon should be offset to the right. Negative values will make it move towards the left.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int safehouseoffsetright = 0;
        
        [Name("Safehouse Icon Offset Up")]
        [Description("Determines how much the Safehouse Icon should be offset to the top. Negative values will make it move towards the bottom.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int safehouseoffsetup = 0;
        
        [Section("Location Text Positioning")]
        [Name("Location Text Offset Right")]
        [Description("Determines how much the Location Text should be offset to the right. Negative values will make it move towards the left.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int locoffsetright = 0;
        
        [Name("Location Text Offset Up")]
        [Description("Determines how much the Location Text should be offset to the top. Negative values will make it move towards the bottom.\n[Keep in mind that an offset too big may position it out of screen view.]")]
        [Slider(-50f, 50f, 1)]
        public int locoffsetup = 0;
        
        [Section("Reset Settings")]
        [Name("Reset To Default")]
        [Description("Resets all settings to Default.")]
        public bool ResetSettings = false;


        protected override void OnConfirm()
        {
            ApplyReset();
            instance.ResetSettings = false;
            base.OnConfirm();
            base.RefreshGUI();
            HUDPositionerMelon.ApplyPositionSettings();
        }

        public static void ApplyReset()
        {
            if (instance.ResetSettings == true)
            {
                instance.afflictiontableoffsetright = 0;
                instance.afflictiontableoffsetup = 0;
                instance.statusbaroffsetright = 0;
                instance.statusbaroffsettop = 0;
                instance.bottomrightanchormode = 2;
                instance.bottomrightoffsetright = 0;
                instance.bottomrightoffsetup = 0;
                instance.statusbaranchormode = 0;
                instance.safehouseanchormode = 0; 
                instance.safehouseoffsetright = 0;
                instance.safehouseoffsetup = 0;
                instance.locoffsetright = 0;
                instance.locoffsetup = 0;
                instance.ResetSettings = false;
            }
        }
    }


}
