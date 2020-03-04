using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PMSApplication.Data.Entity
{
    public class Message
    {
        [Key]
        public int idMessage { get; set; }


        public string dateEnvoi { get; set; }

        public int? isArchive { get; set; }

        public int? lu { get; set; }

        public string messageCible { get; set; }
        public string messageType { get; set; }

        [DataType(DataType.MultilineText)]
        public string body { get; set; }


        //public user sender { get; set; }

        //public int idUserSender { get; set; }

    }
}
