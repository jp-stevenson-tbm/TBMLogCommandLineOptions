using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using UnityEngine;
using HarmonyLib;
using Timberborn.FeatureToggleSystem;

namespace TBMLogCommandLineOptions
{
    [HarmonyPatch(typeof(FeatureToggleService), "InitializeToggles")]
    class patch_FeatureToggleService
    {
        /*
         * オプション一覧をログ出力する。
         * オプションはtimberborn.exeのコマンドライン引数で指定する。
         * 例）Golemsの場合、-feature-Golems
         * ※大文字小文字を区別する。
         */
        public static bool Prefix()
        {
            Debug.Log("commandline option state:");

            // private staticメソッドの取得
            MethodInfo _GetToggleFields = typeof(FeatureToggleService).GetMethod("GetToggleFields", BindingFlags.NonPublic | BindingFlags.Static);
            if (_GetToggleFields == null)
            {
                Debug.LogError("failed to get GetToggleFields().");
                return true;
            }
            MethodInfo _GetToggleState = typeof(FeatureToggleService).GetMethod("GetToggleState", BindingFlags.NonPublic | BindingFlags.Static);
            if (_GetToggleState == null)
            {
                Debug.LogError("failed to get GetToggleState().");
                return true;
            }

            IEnumerable<FieldInfo> fields = (IEnumerable<FieldInfo>)_GetToggleFields.Invoke(null, null);
            if (fields == null)
            {
                Debug.LogError("failed to get fields.");
                return true;
            }

            foreach (FieldInfo fieldInfo in fields)
            {
                string name = fieldInfo.Name;
                bool toggleState = (bool)_GetToggleState.Invoke(null, new object[] { name });
                if (toggleState)
                {
                    Debug.Log("    Feature " + name + ": on");
                }
                else
                {
                    Debug.Log("    Feature " + name + ": off");
                }
            }

            return true;
        }
    }
}
