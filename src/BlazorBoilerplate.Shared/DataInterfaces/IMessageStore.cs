﻿using System.Threading.Tasks;
using BlazorBoilerplate.Shared.DataModels;
using BlazorBoilerplate.Shared.Dto.Sample;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IMessageStore
    {
        Task<Message> AddMessage(MessageDto messageDto);
    }
}