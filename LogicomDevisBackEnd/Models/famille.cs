//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogicomDevisBackEnd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class famille
    {
        public string code { get; set; }
        public string libelle { get; set; }
        public string achat { get; set; }
        public string vente { get; set; }
        public Nullable<double> dispo { get; set; }
        public string sav { get; set; }
        public string immeuble { get; set; }
        public Nullable<int> position { get; set; }
        public string codepv { get; set; }
        public string libpv { get; set; }
        public string favoris { get; set; }
    }
}
