namespace R.ARC.Core.Entity
{
    public class BaseExtendedEntity<T> : BaseEntity where T : class, new()
    {
        public T ExtendedData { get; set; } = new T();
    }
}
