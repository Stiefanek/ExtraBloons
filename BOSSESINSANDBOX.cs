using MelonLoader;
using BOSSESINSANDBOX;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Unity;
using Harmony;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

[assembly: MelonInfo(typeof(ExtraBloons), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]



namespace BOSSESINSANDBOX
{
    public class ExtraBloons : MelonMod
    {
        public virtual void OnApplicationStart() => MelonLogger.Msg("ExtraBloons Loaded");

        [HarmonyPatch(typeof(Il2CppAssets.Scripts.Unity.UI_New.InGame.BloonMenu.BloonMenu), "CreateBloonButtons")]
        public class MapLoader_Patch
        {
            [HarmonyPrefix]
            public static bool Prefix(List<BloonModel> sortedBloons)
            {
                foreach (BloonModel bloon in (Il2CppArrayBase<BloonModel>)Game.instance.model.bloons)
                {
                    if (bloon.baseId == "Bloonarius")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "Vortex")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "Lych")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "Phayze")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "MiniLych")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "MiniLychElite")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "Dreadbloon")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "Golden")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "GoldenLead")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonStandard1")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonStandard2")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonStandard3")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonStandard4")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonStandard5")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonElite1")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonElite2")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonElite3")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonElite4")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonElite5")
                        sortedBloons.Add(bloon);
                    if (bloon.baseId == "DreadRockBloonElite5")
                        sortedBloons.Add(bloon);
                }
                return true;
            }
        }
    }
}
