﻿namespace BaseWebApplication.Models
{
    public abstract class BaseIdentityVM<TKey>
    {
        public abstract TKey ID { get; set; }

        public string? encryptedID { get; set; }
    }
}
