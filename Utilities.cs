
namespace HUDPositioner
{
    internal static class HUDPositionerUtilities
    {
        
        internal static bool IsMenu()
        {
            if (GameManager.m_ActiveScene.Contains("MainMenu") || InterfaceManager.IsMainMenuEnabled())
            {
                return true;
            }
            return false;

        }
        
        public static bool IsScenePlayable(string scene)
        {
            return !(string.IsNullOrEmpty(scene) || scene.Contains("MainMenu") || scene == "Boot" || scene == "Empty" || scene.Contains("_SANDBOX") || scene.Contains("_DLC01") || scene.Contains("_WILDLIFE"));
        }

        public static Vector2 GetFinalStatusBarOffset(int hudSize, int anchorType)
        {
            Vector2 finalOffset = new Vector2(0.05f,0.09f);
            switch (hudSize)
            {
                case 0: //small
                    switch (anchorType)
                    {
                        case 0: //left
                            finalOffset = new Vector2(0.05f, 0.09f);
                            break;
                        case 1: //middle
                            finalOffset = new Vector2(-0.029f, 0.09f);
                            break;
                        case 2: //right
                            finalOffset = new Vector2(-0.115f, 0.09f);
                            break;
                    }

                    break;
                case 1: // normal
                    switch (anchorType)
                    {
                        case 0: //left
                            finalOffset = new (0.05f, 0.09f);
                            break;
                        case 1: // middle
                            finalOffset =  new Vector2(-0.059f, 0.09f);
                            break;
                        case 2: //right
                            finalOffset = new Vector2(-0.15f, 0.09f);
                            break;
                    }

                    break;
                case 2: // big
                    switch (anchorType)
                    {
                        case 0: //left
                            finalOffset =  new Vector2(0.05f, 0.09f);
                            break;
                        case 1: // middle
                            finalOffset =  new Vector2(-0.079f, 0.09f);
                            break;
                        case 2: //right
                            finalOffset = new Vector2(-0.225f, 0.09f);
                            break;
                    }

                    break;
                    
            }

            return finalOffset + new Vector2(Settings.instance.statusbaroffsetright/100f, Settings.instance.statusbaroffsettop/100f);
        }

        public static UIAnchor.Side GetAnchorSideBySetting(int Setting, bool Top = false)
        {
            UIAnchor.Side Side = UIAnchor.Side.BottomLeft;
            if (Top)
            {
                switch (Setting)
                {
                    case 0:
                        Side = UIAnchor.Side.TopLeft;
                        break;
                    case 1:
                        Side = UIAnchor.Side.Top;
                        break;
                    case 2:
                        Side = UIAnchor.Side.TopRight;
                        break;
                }
            }
            else
            {
                switch (Setting)
                {
                    case 0:
                        Side = UIAnchor.Side.BottomLeft;
                        break;
                    case 1:
                        Side = UIAnchor.Side.Bottom;
                        break;
                    case 2:
                        Side = UIAnchor.Side.BottomRight;
                        break;
                }
            }


            return Side;
        }

        public static Vector2 GetFinalBottomRightAnchorOffset()
        {
            Vector2 finalOffset = new Vector2(0f, 0f);
            switch (Settings.instance.bottomrightanchormode)
            {
                case 0: // left
                    finalOffset = new(0.165f, 0f);
                    break;
                case 1: // middle
                    finalOffset = new(0.0935f, 0f);
                    break;
                case 2: // right
                    finalOffset = new(0f, 0f);
                    break;
            }
            return finalOffset + new Vector2(Settings.instance.bottomrightoffsetright / 100f, Settings.instance.bottomrightoffsetup / 100f);
        }

        public static Vector2 GetFinalAfflictionTableAnchorOffset()
        {
            Vector2 finalOffset = new Vector2(-0.035f, 0.3f);
            return finalOffset + new Vector2(Settings.instance.afflictiontableoffsetright / 100f, Settings.instance.afflictiontableoffsetup / 100f);
        }
        
        public static Vector2 GetFinalSafehouseAnchorOffset()
        {
            Vector2 finalOffset = new Vector2(0f, 0f);
            switch (Settings.instance.safehouseanchormode)
            {
                case 0: // left
                    finalOffset = new(0f, 0f);
                    break;
                case 1: // middle
                    finalOffset = new(-0.052f, 0f);
                    break;
                case 2: // right
                    finalOffset = new(-0.01f, 0f);
                    break;
            }
            return finalOffset + new Vector2(Settings.instance.safehouseoffsetright / 100f, Settings.instance.safehouseoffsetup / 100f);
        }

        public static Vector2 GetFinalLocationAnchorOffset()
        {
            Vector2 finalOffset = new Vector2(0.03f, -0.13f);
            return finalOffset + new Vector2(Settings.instance.locoffsetright / 100f, Settings.instance.locoffsetup / 100f);
        }

    }
}