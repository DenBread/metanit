using System;
using System.Collections.Generic;
using System.Text;

namespace OtherCode
{

    /// <summary>
    /// Сласс индикатор
    /// </summary>
    class Clients
    {
        private string[] names = new string[10];

        public string this[int index]
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }
    }
}
