using LectureSchedulingAndAnalysingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    interface ISessionService
    {
        Task<Session> getAll();

    }
}
