using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace RP0.ProcAvionics
{
    class ModuleProcAvionics : ModuleAvionics, IPartMassModifier, IPartCostModifier
    {
        #region KSPField

        // Type of Avionics Unit
        [KSPField(isPersistant = true)]
        public string avionicsType = "";

        // Tech Required to unlock this level
        [KSPField(isPersistant = true)]
        public string techRequired = "";

        // This is the level of the Avionics
        [KSPField(isPersistant = true)]
        public float avionicsLevel = 0f;

        // Amount of mass that can be controlled by 1 unit of Avionics Electronics
        [KSPField(isPersistant = true)]
        public float tonnageControlPerUnit = 0f;

        // Minimum controllable mass
        [KSPField(isPersistant = true)]
        public float minimumTonnage = 0f;

        // How much EC is used while active
        [KSPField(isPersistant = true)]
        public float enabledProckW = 0f;

        // How much EC is used while hibernating
        [KSPField(isPersistant = true)]
        public float disabledProckW = 0f;

        // Can the Avionics unit be put into hibernation
        [KSPField(isPersistant = true)]
        public bool canHibernate = false;

        // What is the SAS level capability of the avionics
        [KSPField(isPersistant = true)]
        public float procSASlevel = 0f;

        // Allow science storage
        [KSPField(isPersistant = true)]
        public bool storeScienceData = false;

        #endregion

        #region Config

        public void LoadBoosterConfigs(ConfigNode node)
        {
            ConfigNode[] configs = GameDatabase.Instance.GetConfigNodes("PROCAVIONICS");

            if (configs == null || configs.Length == 0)
            {
                Log("No config to load");
                return;
            }
        }
        


        #endregion





        public static void Log(string s)
        {
            MonoBehaviour.print(string.Format("[ProcAvionics] {0}", s));
        }

    }
}
