using template.Application.Common.Interfaces;
using System;

namespace template.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
