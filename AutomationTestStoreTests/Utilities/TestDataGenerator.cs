using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestStoreFramework.Utilities
{
    public static class TestDataGenerator
    {
        public static string GenerateEmail()
        {
            return $"qa{DateTime.Now.Ticks}@mailinator.com";
        }

        public static string GenerateLoginName()
        {
            return $"user{DateTime.Now.Ticks}";
        }
    }
}
