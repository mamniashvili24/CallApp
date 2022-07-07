using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallApp.Domain.Respons.Models.Impementation
{
    public class MessageModel
    {
        public string PhoneNumber { get; set; }
        public string To { get; set; }
        public string Content { get; set; }
    }
}
