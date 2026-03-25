using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using TMPro;

public class LanguageDropdown : MonoBehaviour
{
  private TMP_Dropdown dropdown;
     private string identifier;
     void Start()
     {
        dropdown = GetComponent<TMP_Dropdown>();
        dropdown.value = PlayerPrefs.GetInt("language");
        SetLanguage(identifier);
     }
     
     void Update()
     {
         if (dropdown.value == 0)
         { identifier = "en"; }
         else if (dropdown.value == 1)
         { identifier = "es"; }
         else if (dropdown.value == 2)
         { identifier = "fr"; }
         else if (dropdown.value == 3)
         { identifier = "it"; }
         else if (dropdown.value == 4)
         { identifier = "de"; }
        else if (dropdown.value == 5)
         { identifier = "ru"; } 
         else if (dropdown.value == 6) 
         { identifier = "pt-BR"; }
         else if (dropdown.value == 7) 
         { identifier = "cs"; }
         else if (dropdown.value == 8) 
         { identifier = "sk"; }
         else if (dropdown.value == 9) 
         { identifier = "bn"; }
         else if (dropdown.value == 10) 
         { identifier = "nl"; }
         SetLanguage(identifier);
         
     }
     void SetLanguage(string identifier)
     { 
         LocalizationSettings.InitializationOperation.WaitForCompletion();
         PlayerPrefs.SetInt("language", dropdown.value);
         LoadLocale(identifier);
     }

      public void LoadLocale(string languageIdentifier)
         {
             LocalizationSettings settings = LocalizationSettings.Instance;
             LocaleIdentifier localeCode = new LocaleIdentifier(languageIdentifier);
             for(int i = 0; i < LocalizationSettings.AvailableLocales.Locales.Count; i++)
             {
                 Locale aLocale = LocalizationSettings.AvailableLocales.Locales[i];
                 LocaleIdentifier anIdentifier = aLocale.Identifier;
                 if(anIdentifier == localeCode)
                 {
                     LocalizationSettings.SelectedLocale = aLocale;
                 }
             }
         }
}
