﻿namespace ClientInterfaces.Configuration
{
    public interface IConfigurationManager
    {
        void Initialize(string configFile);
        void SetPlayerName(string name);
        void SetServerAddress(string address);
        void SetFullscreen(bool fullscreen);
        void SetResolution(uint width, uint height);
        string GetPlayerName();
        string GetResourcePath();
        string GetResourcePassword();
        bool GetFullscreen();
        bool GetVsync();
        void SetVsync(bool state);
        uint GetDisplayWidth();
        uint GetDisplayHeight();
        uint GetDisplayRefresh();
        void SetDisplayRefresh(uint rate);
        string GetServerAddress();
        bool GetMessageLogging();
        bool GetSimulateLatency();
        float GetSimulatedLoss();
        float GetSimulatedMinimumLatency();
        float GetSimulatedRandomLatency();
        int GetRate();
        int GetUpdateRate();
        int GetCommandRate();
        float GetInterpolation();
    }
}