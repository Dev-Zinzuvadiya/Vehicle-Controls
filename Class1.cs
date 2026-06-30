using GTA;
using GTA.UI;
using GTA.Math;
using GTA.Native;
using GTA.NaturalMotion;
using Control = GTA.Control;
using System;
using System.Drawing;
using System.Windows.Forms;


public class Vehicle_Controls : Script
{
    // <----- REQUIRED FIELDS FOR INI -----> //
    private ScriptSettings _config;
    private Keys _engineToggle = Keys.Space;
    private bool _AutoIndicators = true;
    private bool _brakeTemperature = true;
    private bool _brakeNotifications = true;




    public Vehicle_Controls()
    {
        Tick += OnTick;
        KeyUp += OnKeyUp;
        KeyDown += OnKeyDown;
        Aborted += OnAbort;
        Interval = 25;

        INI_CONFIG();
    }



    //  =>> RUN EVERY FUNCTIONS AND CODE ON EVERY TICK  <<= //
    // =======================================================
    private void OnTick(object sender, EventArgs e)
    {
    }



    //  =>> EVENT AND FUNCTIONS RUN AFTER KEY RELEASED  <<= //
    // =======================================================
    private void OnKeyUp(object sender, KeyEventArgs e)
    {
    }



    //  =>> EVENT AND CODE RUN WHEN KEY PRESSED  <<= //
    // =======================================================
    private void OnKeyDown(object sender, KeyEventArgs e)
    {
    }



    //  =>> RESET EVERY FIELDS AFTER SCRIPT RELOADING  <<= //
    // =======================================================
    private void OnAbort(object sender, EventArgs e)
    {
    }



    //  =>>  CHANGEABLE SCRIPT FEATURES FROM .INI  <<= //
    // =======================================================
    private void INI_CONFIG()
    {
        _config = ScriptSettings.Load("scripts/Vehicle Controls.ini");

        // --- KEYS --- //
        _engineToggle = _config.GetValue("Keys", "EngineToggle", Keys.Space);

        // --- FEATURES --- //
        _AutoIndicators = _config.GetValue("Features", "AutoIndicators", true);
        _brakeTemperature = _config.GetValue("Features", "BrakeTemperature", true);
        _brakeNotifications = _config.GetValue("Features", "BrakeNotifications", true);

        _config.Save();
    }
}
