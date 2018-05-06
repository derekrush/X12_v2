using System;
using X12.Framework.Configuration;

namespace X12.Framework.Domain
{
    public class X12Entity : IX12Entity
    {
        public IX12EntityConfiguration Configuration { get; set; }

        public object Value { get; set; }

        public X12Entity(IX12EntityConfiguration config = null, object value = null)
        {
            Configuration = config;
            Value = value;
        }
    }

    public class X12Entity<T> : X12Entity, IX12Entity<T>
    {
        public new T Value
        {
            get => base.Value != null ? (T)base.Value : default(T);
            set
            {
                base.Value = value;
            }
        }

        public X12Entity(IX12EntityConfiguration config = null, T value = default(T))
            : base(config, value) { }
    }
}
