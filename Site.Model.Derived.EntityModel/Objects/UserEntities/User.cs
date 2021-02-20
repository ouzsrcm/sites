﻿namespace Site.Model.Derived.EntityModel.Objects.UserEntities
{
    public class User<TKey> : BaseEntityModel<TKey>, IEntityModel<TKey>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string Phone { get; set; }
        public bool IsValidated { get; set; }
    }
}