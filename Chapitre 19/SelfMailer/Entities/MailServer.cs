//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelfMailer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MailServer
    {
        public MailServer()
        {
            this.Sender = new HashSet<Sender>();
            this.Password = new Password();
        }
    
        public int ID { get; set; }
        public string Host { get; set; }
        public string Username { get; set; }
    
        public Password Password { get; set; }
    
        public virtual ICollection<Sender> Sender { get; set; }
    }
}