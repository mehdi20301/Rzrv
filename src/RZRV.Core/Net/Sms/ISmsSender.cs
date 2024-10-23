﻿using System.Threading.Tasks;

namespace RZRV.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}