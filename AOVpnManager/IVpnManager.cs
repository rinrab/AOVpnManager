﻿using System;

namespace AOVpnManager
{
    public interface IVpnManager : IDisposable
    {
        void CreateVpnConnection(string connectionName, string profile);
        void DeleteVpnConnection(string connectionName);
        VpnConnectionInfo GetVpnConnection(string connectionName);
        void UpdateVpnConnection(string connectionName, string profile);
    }
}