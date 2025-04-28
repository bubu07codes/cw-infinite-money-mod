using HarmonyLib;
using UnityEngine;

namespace InfiniteMoneyMod
{
    [ContentWarningPlugin("Infinite Money Mod", "1.0.0", true)]
    public class InfiniteMoneyPlugin : MonoBehaviour
    {
        static InfiniteMoneyPlugin()
        {
            new Harmony("InfiniteMoneyMod").PatchAll();
            GameObject obj = new GameObject("InfiniteMoneyRunner");
            obj.AddComponent<InfiniteMoneyRunner>();
            GameObject.DontDestroyOnLoad(obj);

            Debug.Log("Infinite Money Mod By BUBU07 has been loaded!");
        }
    }

    public class InfiniteMoneyRunner : MonoBehaviour
    {
        bool moneyAdded;

        void Update()
        {
            if (moneyAdded) return;

            if (SurfaceNetworkHandler.Instance != null)
            {
                SurfaceNetworkHandler.RoomStats.AddMoney(99999999);
                Debug.Log("Added SO MUCH MONEY!");
                moneyAdded = true;
            }
        }
    }
}
