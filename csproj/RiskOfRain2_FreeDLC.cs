using BepInEx;
using RoR2;
using System;

namespace RiskOfRain2_FreeDLC {
    [BepInPlugin(MODUID, MODNAME, MODVERSION)]
    public class RiskOfRain2_FreeDLC : BaseUnityPlugin
	{
        public const string MODUID = "com.Snoresville.RiskOfRain2_FreeDLC";
        public const string MODNAME = "Risk of Rain 2 - Free DLC";
        public const string MODVERSION = "0.0.1";

        void Start() {
            On.RoR2.RuleDef.FromExpansion += RuleDef_FromExpansion;
        }

        void OnDisable() {
            On.RoR2.RuleDef.FromExpansion -= RuleDef_FromExpansion;
        }

        private static RuleDef RuleDef_FromExpansion(On.RoR2.RuleDef.orig_FromExpansion orig, RoR2.ExpansionManagement.ExpansionDef expansionDef) {
            expansionDef.requiredEntitlement = null;
            return orig(expansionDef);
        }
    }
}
