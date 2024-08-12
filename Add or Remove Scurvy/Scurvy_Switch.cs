using MelonLoader;
using System;
using Il2Cpp;
using HarmonyLib;
using Il2CppTLD;

namespace Add_or_Remove_Scurvy;
internal sealed class Scurvy_Switch : MelonMod
{
  public override void OnInitializeMelon()
  {

  }

  public override void OnUpdate()
  {
    string? sceneName = GameManager.m_ActiveScene;

    if(InputManager.GetKeyDown(InputManager.m_CurrentContext, UnityEngine.KeyCode.F5) && !GameManager.IsMainMenuActive() && sceneName != null)
    {
      GameManager.GetScurvyComponent().enabled = true;
      GameManager.SaveGameAndDisplayHUDMessage();
      Console.Write("Scurvy Turned ");
      Console.ForegroundColor = System.ConsoleColor.Green;
      Console.WriteLine("ON");
      Console.ForegroundColor = System.ConsoleColor.White;
    }

    if(InputManager.GetKeyDown(InputManager.m_CurrentContext, UnityEngine.KeyCode.F6) && !GameManager.IsMainMenuActive() && sceneName != null)
    {
      GameManager.GetScurvyComponent().enabled = false;
      GameManager.GetScurvyComponent().Cure();
      GameManager.SaveGameAndDisplayHUDMessage();
      Console.ForegroundColor = System.ConsoleColor.Red;
      Console.WriteLine("OFF");
      Console.ForegroundColor = System.ConsoleColor.White;
    }
  }
}
