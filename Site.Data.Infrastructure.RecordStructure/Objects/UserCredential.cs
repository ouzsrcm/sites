using System;
using System.Collections.Generic;
using System.Text;

namespace Site.Data.Infrastructure.RecordStructure.Objects
{
    public class UserCredential<TKey> : RecordBase<TKey>
    {

        public int UserId { get; set; }

    }
}
