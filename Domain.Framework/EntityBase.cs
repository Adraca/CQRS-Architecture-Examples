namespace Domain.Framework
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public override bool Equals(object entity)
        {
            return entity != null
               && entity is EntityBase
               && this == (EntityBase)entity;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public static bool operator ==(EntityBase entity1, EntityBase entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
            {
                return true;
            }

            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }

            if (entity1.Id == entity2.Id)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(EntityBase entity1, EntityBase entity2)
        {
            return (!(entity1 == entity2));
        }
    }
}
