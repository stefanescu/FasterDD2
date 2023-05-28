using MelonLoader;
using UnityEngine;


namespace Zoomies
{
    public class FasterDD2 : MelonMod
    {
        public static FasterDD2 instance;
        private static int speedIndex;
        private static float[] allSpeeds = new float[] { 1f, 1.5f, 2f, 2.5f, 3f };

        private static Rect labelPos = new Rect ( 50, 30, 1000, 200 );
        private static Rect speedDownPos = new Rect ( 15, 30, 20, 15 );
        private static Rect speedUpPos = new Rect ( 80, 30, 20, 15 );
        private GUIStyle labelStyle;

        public override void OnEarlyInitializeMelon()
        {
            instance = this;
            speedIndex = 0;

            labelStyle = new GUIStyle { fontSize = 12 };
            labelStyle.normal.textColor = Color.red;

            Melon<FasterDD2>.Logger.Msg("FasterDD2");
            MelonEvents.OnGUI.Subscribe(DrawUI, 100);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            ApplySpeed();
        }

        public void DrawUI()
        {
            GUI.Label(labelPos, allSpeeds[speedIndex].ToString() + "x", labelStyle);

            if (GUI.Button(speedDownPos, "-"))
                SpeedDown();
            if (GUI.Button(speedUpPos, "+"))
                SpeedUp();

        }

        public static void SpeedUp()
        {
            if (speedIndex == allSpeeds.Length - 1)
                return;
            
            speedIndex++;
            ApplySpeed();

        }
        public static void SpeedDown()
        {
            if (speedIndex == 0)
                return;

            speedIndex--;
            ApplySpeed();
            //currentSpeed = (currentSpeed - 1) % allSpeeds.Count;
        }

        public static void ApplySpeed()
        {
            Melon<FasterDD2>.Logger.Msg("Speed " + allSpeeds[speedIndex] +"x");
            Time.timeScale = allSpeeds[speedIndex];
        }

        public override void OnDeinitializeMelon()
        {
            MelonEvents.OnGUI.Unsubscribe(DrawUI);
        }
    }
}

