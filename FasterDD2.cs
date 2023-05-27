using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;


namespace Fasterdd2
{
    public class FasterDD2 : MelonMod
    {
        public static FasterDD2 instance;
        private static int currentSpeed;
        private static float[] allSpeeds = new float[] { 1F, 1.5F, 2F, 2.5F, 3F };
        private GUIStyle labelStyle;


        public override void OnEarlyInitializeMelon()
        {
            instance = this;
            currentSpeed = 0;

            labelStyle = new GUIStyle { fontSize = 12 };
            labelStyle.normal.textColor = Color.red;

            Melon<FasterDD2>.Logger.Msg("SpeedMod");
            MelonEvents.OnGUI.Subscribe(DrawSpeedText, 100);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            ApplySpeed();
        }

        public  void DrawSpeedText()
        {
            //GUI.Label(new Rect(45, 28, 1000, 200), "<b><color=red><size=12> 3x </size></color></b>");
            GUI.Label(new Rect(50, 30, 1000, 200), allSpeeds[currentSpeed].ToString() + "x", labelStyle);

            if (GUI.Button(new Rect(15, 30, 20, 15), "-"))
                SpeedDown();
            if (GUI.Button(new Rect(80, 30, 20, 15), "+"))
                SpeedUp();

        }

        public static void SpeedUp()
        {
            if (currentSpeed == allSpeeds.Length - 1)
                return;
            
            currentSpeed++;
            ApplySpeed();

        }
        public static void SpeedDown()
        {
            if (currentSpeed == 0)
                return;

            currentSpeed--;
            ApplySpeed();
            //currentSpeed = (currentSpeed - 1) % allSpeeds.Count;
        }

        public static void ApplySpeed()
        {
            Melon<FasterDD2>.Logger.Msg("Speed " + allSpeeds[currentSpeed] +"x");
            Time.timeScale = allSpeeds[currentSpeed];
        }

        public override void OnDeinitializeMelon()
        {
            MelonEvents.OnGUI.Unsubscribe(DrawSpeedText);
        }
    }
}

