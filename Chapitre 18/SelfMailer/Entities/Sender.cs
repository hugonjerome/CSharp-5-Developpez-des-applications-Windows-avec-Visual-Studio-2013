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
    
    public partial class Sender
    {
        public Sender()
        {
            this.MailServer = new HashSet<MailServer>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<MailServer> MailServer { get; set; }
    }
}
