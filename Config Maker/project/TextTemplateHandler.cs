namespace AC_Config_Maker
{
    internal class TextTemplateHandler
    {
        public static string SCREEN_ELEMENT_TAG = "screen_element_";
        public static string SWING_TXT = SCREEN_ELEMENT_TAG + "swing ";
        public static string FAN_SPEED_TXT = SCREEN_ELEMENT_TAG + "fan_speed ";
        public static string TEMP_UP_TXT = SCREEN_ELEMENT_TAG + "temp_up ";
        public static string TEMP_DOWN_TXT = SCREEN_ELEMENT_TAG + "temp_down ";
        public static string MODE_TXT = SCREEN_ELEMENT_TAG + "mode ";
        public static string POWER_1_TXT = SCREEN_ELEMENT_TAG + "power_C25F3_1 ";
        public static string POWER_2_TXT = "power_C25F3_2 ";

        //modes
        public static string MODES = "modes";
        public static string COLD = "cold";
        public static string HOT = "hot";
        public static string wind = "wind";


        public static string MAX_FAN_POWER = "max_fan_power";
        public static string DEGREE_TYPE = "degree_type";

        //no display params
        public static string NO_DISPLAY_POWER_TXT = "power ";
        public static string NO_DISPLAY_MODE_TXT = "mode ";
        public static string NO_DISPLAY_TEMP_UP_TXT = "temp_up ";
        public static string NO_DISPLAY_TEMP_DOWN_TXT = "temp_down ";
        public static string NO_DISPLAY_FAN_SPEED_TXT = "fan_speed ";
        public static string NO_DISPLAY_SWING_TXT = "swing ";


    }
}