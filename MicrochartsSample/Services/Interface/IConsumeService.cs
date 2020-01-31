using MicrochartsSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicrochartsSample.Services
{
    public interface IConsumeService
    {
        List<Consume> GetConsumes();
    }
}
