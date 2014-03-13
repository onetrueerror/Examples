using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MinimalConfiguration
{
    public class FakeRepository
    {
        public void Save()
        {
            throw new DataException("Failed to save data");
        }
    }
}