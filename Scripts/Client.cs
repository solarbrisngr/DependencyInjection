﻿using UnityEngine;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        // Bike controlled by the player
        public Bike m_PlayerBike;

        // Bike controlled by an android (AI)
        public Bike m_AndroidBike;
        
        // Bike controlled by an android (AI)
        public Bike m_DapperBike;
        
        // Bike controlled by an android (AI)
        public Bike m_SnoopyBike;

        void Awake()
        {
            // Set up a bike with a human driver and jet engine
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();

            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            m_PlayerBike.StartEngine();

            // Set up a bike with a AI driver and a nitro engine
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndroidDriver();

            m_AndroidBike.SetEngine(nitroEngine);
            m_AndroidBike.SetDriver(androidDriver);
            m_AndroidBike.StartEngine();

            // Bike with Electric Engine and Charlie Brown's dog as your driver
            IEngine ElectricEngine = new ElectricEngine();
            IDriver SnoopyDriver = new SnoopyDriver();

            m_AndroidBike.SetEngine(ElectricEngine);
            m_AndroidBike.SetDriver(SnoopyDriver);
            m_AndroidBike.StartEngine();

            //Bike with combustion engine and a Disney Dapper Dan as your driver
            IEngine CombustionEngine = new NitroEngine();
            IDriver DapperDanDriver = new AndroidDriver();

            m_AndroidBike.SetEngine(CombustionEngine);
            m_AndroidBike.SetDriver(DapperDanDriver);
            m_AndroidBike.StartEngine();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_PlayerBike.TurnLeft();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                m_PlayerBike.TurnRight();
            }
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
            GUI.Label(new Rect(10, 30, 500, 20), "Look in the Debug Console to the status of your inputs");
        }
    }
}
