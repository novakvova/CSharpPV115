using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_SendMessage
{
    public class Message
    {
        /// <summary>
        /// Тема листа
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Тіло листа
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Кому відправляти листа
        /// </summary>
        public string To { get; set; }
    }
}
