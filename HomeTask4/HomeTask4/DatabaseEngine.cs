using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class DatabaseEngine
    {
        class DatabaseValue<T>
        {
            public T value { get; set; }
            public string tableName { get; set; }
        }

        public void WriteValue<T>(T value, string password)
        {
            var dbValue = new DatabaseValue<T>()
            {
                value = value,           
            };
        }
    }
}
