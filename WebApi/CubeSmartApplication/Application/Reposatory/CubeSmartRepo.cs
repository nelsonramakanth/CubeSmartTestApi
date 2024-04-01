using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Reposatory
{
    public static class CubeSmartRepo
    {
        public static string CubeData = string.Empty;
        public static object _lock = new object();

        public static string Insert(string data)
        {
            if (String.IsNullOrEmpty(CubeData))
            {
                lock (_lock)
                {
                    CubeData = data;
                    return CubeData;
                }
            }
            return CubeData;
        }

        public static string Update(string data)
        {
            if (String.IsNullOrEmpty(data))
            {
                throw new Exception("NO Data Provided");
            }

            if (CubeData != null)
            {
                lock (_lock)
                {
                    CubeData = CubeData + " " + data;
                    return CubeData;
                }
            }
            return CubeData;
        }

        public static string Get()
        {
            return CubeData;
        }
    }
}