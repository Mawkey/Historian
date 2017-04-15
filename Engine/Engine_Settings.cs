using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Engine
{
    static public class Engine_Settings
    {

        /// <summary>
        /// Returns a setting of type: String.
        /// </summary>
        /// <param name="settingName"></param>
        /// <returns></returns>
        static public string LoadString(string settingName)
        {
            return Properties.Settings.Default[settingName].ToString();
        }

        static public Boolean IsStringListEmpty()
        {
            var mySetting = Properties.Settings.Default.stringList;

            if (mySetting.Count == 0 || mySetting == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public List<String> LoadStringList()
        {
            var list = Properties.Settings.Default.stringList.Cast<string>().ToList();

            return list;
        }

        static public string[] LoadStringArray()
        {
            var array = Properties.Settings.Default.stringList.Cast<string>().ToArray();

            return array;
        }

        /// <summary>
        /// Loads a setting of type: String into another string.
        /// </summary>
        /// <param name="settingName"></param>
        /// <param name="loadTo"></param>
        static public string LoadString(string settingName, string loadTo)
        {
            loadTo = Properties.Settings.Default[settingName].ToString();

            return loadTo;
        }

        static public void SaveStringList(StringCollection list)
        {
            Properties.Settings.Default.stringList = list;
        }

        static public void SaveString(string settingName, string save)
        {
            Properties.Settings.Default[settingName] = save;
        }

        static public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
    }
}
