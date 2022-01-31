using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;
using HarmonyLib;
using BepInEx;

namespace TBMLogCommandLineOptions
{
    [BepInPlugin("jp.stevenson.timberbnmod.log_commandline_options", "log commandline options", "0.1")]
    public class Class1 : BaseUnityPlugin
    {
        public void Awake()
        {
            new Harmony("jp.stevenson.timberbnmod.log_commandline_options").PatchAll();
            Debug.Log("log commandline options : Loaded.");

        }
    }
}
