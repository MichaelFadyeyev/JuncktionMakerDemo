using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuncktionMakerDemo.Localizations
{
    public class LocalizationManager
    {
        string name;
        public string Name => name;

        string menuOptions;
        public string MenuOptions => menuOptions;

        string menuLanguage;
        public string MenuLanguage => menuLanguage;

        string menuAbout;
        public string MenuAbout => menuAbout;

        string linkType;
        public string LinkType => linkType;

        string[] modes;
        public string [] Modes => modes;

        string source;
        public string Source => source;

        string target;
        public string Target => target;

        string create;
        public string Create => create;

        string clear;
        public string Clear => clear;

        string error_001; // Different drives for hard link are pointed 
        public string Error_001 => error_001;

        string error_002; //  
        public string Error_002 => error_002;

        string error_003; //  
        public string Error_003 => error_003;

        string error_004; //  
        public string Error_004 => error_004;

        public LocalizationManager() { }
        
        public void SetLocalization(string lang)
        {
            name = lang;
            menuOptions = "Options";
            menuLanguage = "Language";
            menuAbout = "About";
            linkType = "Link Type:";
            modes = new string[]
            {
                "Junction",
                "Hard Link",
                "Soft Link (directory)",
                "Soft Link (file)"
            };
            source = "Source";
            target = "Target";
            create = "Create";
            clear = "Clear";
            error_001 = "Different drives for hard link are pointed";
            error_002 = "";
            error_003 = "";
            error_004 = "";
;        }
    }


}
